using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Elar.Framework.Core.Extensions;
using Elar.Framework.Core.Helpers;
using TableOcrExtractor.Controls.Enums;
using TableOcrExtractor.Controls.Model;
using TableOcrExtractor.Forms;
using TableOcrExtractor.Logic.Enums;
using TableOcrExtractor.Logic.Helpers;
using TableOcrExtractor.Logic.Models;
using TableOcrExtractor.Properties;
using Telerik.WinControls.UI;

namespace TableOcrExtractor
{
    /// <summary>
    /// Main program window
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class MainForm : LocalizedForm
    {
        #region Variables

        /// <summary>
        /// Current project
        /// </summary>
        private Project _project;

        /// <summary>
        /// Selected gallery image Uid
        /// </summary>
        private Guid? _selectedGalleryImageUid;

        /// <summary>
        /// The copy of drawing objects
        /// </summary>
        private DrawingObjects _copyOfDrawingObjects;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {            
            InitializeComponent();            
        }

        #endregion

        #region Private methods

        /// <summary>
        /// Initializes the controls.
        /// </summary>
        private void InitializeControls()
        {
            SetLanguage((Language)Properties.Settings.Default.CurrentCultureInfo);
            OpenProjectFileDialog.Filter = Project.ProjectFileExtensionsFilter;
            InitilalizeProjectDependentControls(false);
        }

        /// <summary>
        /// Initilalizes the controls on project load.
        /// </summary>
        /// <param name="projectLoaded">Project is loaded</param>
        private void InitilalizeProjectDependentControls(bool projectLoaded)
        {
            ProjectMenuItem.Enabled = 
            AddImagesBtn.Enabled =
            RemoveImagesBtn.Enabled = projectLoaded;

            InitializeImageControls(projectLoaded);

            ProjectNameLabelElement.Text = projectLoaded ? string.Format(Resources.ProjectName_Caption, _project.Name) : Resources.ProjectName_NoProjectLoaded;
            
        }

        /// <summary>
        /// Initializes the image controls.
        /// </summary>
        /// <param name="enabled">Controls enabled</param>
        private void InitializeImageControls(bool enabled)
        {
            ZoomInBtn.Enabled =
            ZoomOutBtn.Enabled =
            ZoomFitBtn.Enabled =
            DrawingModeNoneBtn.Enabled =
            DrawingModeRectangleBtn.Enabled =
            DrawingModeVerticalLinesBtn.Enabled =
            DrawingModeHorizontalLinesBtn.Enabled =
            CopyDrawingObjectsBtn.Enabled =
            PasteDrawingObjectsBtn.Enabled = enabled;
        }

        /// <summary>
        /// Sets the application locale.
        /// </summary>
        private void SetLanguage(Language language)
        {
            EnglishLanguageMenuItem.IsChecked =
                RussianLanguageMenuItem.IsChecked = false;

            switch (language)
            {
                case Language.En:
                    EnglishLanguageMenuItem.IsChecked = true;
                    break;

                case Language.Ru:
                    RussianLanguageMenuItem.IsChecked = true;
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }

            CurrentLanguage = language;
        }

        /// <summary>
        /// Loads the project.
        /// </summary>
        /// <param name="projectFileName">Name of the project file.</param>
        private void LoadProject(string projectFileName)
        {
            _project = Project.Load(projectFileName);
            InitilalizeProjectDependentControls(true);
            FillGallery();
        }

        /// <summary>
        /// Fills the gallery.
        /// </summary>
        private void FillGallery()
        {
            _copyOfDrawingObjects = null;

            BindingList<GalleryImage> dataSource = new BindingList<GalleryImage>();

            if (_project.Gallery.Images.Count > 0)
            {
                foreach (GalleryImage galleryImage in _project.Gallery.Images)
                    dataSource.Add(galleryImage);
            }
            else
            {
                InitializeImageControls(false);
                _selectedGalleryImageUid = null;
                ImageViewer.Image = null;
            }

            GalleryListView.DataSource = dataSource;
        }

        /// <summary>
        /// Fills the gallery image.
        /// </summary>
        private void FillGalleryImage()
        {
            if (_selectedGalleryImageUid.HasValue)
            {
                GalleryImage image = _project.Gallery.Images.WhereEx(i => i.Uid == _selectedGalleryImageUid.Value).FirstOrDefault();
                if (image != null)
                {
                    InitializeImageControls(true);
                    ImageViewer.Image = Image.FromFile(image.ImageFilePath);
                    ImageViewer.FitImage();
                    ImageViewer.DrawingObjects = image.DrawingObjects.Clone();

                    if (image.RecognitionCompleted && image.DrawingObjects.MaxNumberOfVerticalLines == image.RecognizedData.Columns.Count - 1)
                    {
                        DataGrid.Columns.Clear();
                        DataGrid.DataSource = image.RecognizedData;
                    }
                    else
                    {
                        InitializeDataGrid();
                    }
                }                        
            }
        }

        /// <summary>
        /// Initializes the OCR data grid
        /// </summary>
        private void InitializeDataGrid()
        {
            DataGrid.DataSource = null;
            DataGrid.Columns.Clear();
            foreach (string columnName in _project.DataColumns)
                DataGrid.Columns.Add(columnName, columnName);
        }

        #endregion

        #region Event handlers

        /// <summary>
        /// Handles the Load event of the MainForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            InitializeControls();
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            Text = $"{Text} Version: {fvi.FileVersion}";
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_project != null)
            {
                DialogResult result = MessageBox.Show(Resources.MainFormClosing_Message, Resources.MainFormClosing_Caption, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
                switch (result)
                {
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;

                    case DialogResult.Yes:
                        _project.Save();
                        break;
                }
            }
        }

        #region Menu actions

        /// <summary>
        /// Handles the Click event of the NewProjectMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void NewProjectMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ProjectCreationForm projectCreationForm = new ProjectCreationForm
                {
                    StartPosition = FormStartPosition.CenterScreen
                };
                if (projectCreationForm.ShowDialog() == DialogResult.OK)
                {
                    _project = Project.Create(projectCreationForm.ProjectPath, projectCreationForm.ProjectName);
                    InitilalizeProjectDependentControls(true);
                }
            }
            catch (Exception ex)
            {
                LogHelper.Logger.Error(ex, "Unable to create project");
                FormsHelper.ShowUnexpectedError();
            }            
        }

        /// <summary>
        /// Handles the Click event of the OpenProjectMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OpenProjectMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (OpenProjectFileDialog.ShowDialog() == DialogResult.OK)
                    LoadProject(OpenProjectFileDialog.FileName);
            }
            catch (Exception ex)
            {
                LogHelper.Logger.Error(ex, "Unable to create project");
                FormsHelper.ShowUnexpectedError();
            }
            
        }

        /// <summary>
        /// Handles the Click event of the SaveMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void SaveMenuItem_Click(object sender, EventArgs e)
        {
            _project?.Save();
        }

        /// <summary>
        /// Handles the Click event of the SaveAsMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void SaveAsMenuItem_Click(object sender, EventArgs e)
        {
            // TODO
        }

        /// <summary>
        /// Handles the Click event of the EnglishLanguageMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void EnglishLanguageMenuItem_Click(object sender, EventArgs e)
        {
            SetLanguage(Language.En);
        }

        /// <summary>
        /// Handles the Click event of the RussianLanguageMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void RussianLanguageMenuItem_Click(object sender, EventArgs e)
        {
            SetLanguage(Language.Ru);
        }

        /// <summary>
        /// Handles the Click event of the ExitMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ProjectDataColumnsMenuItem_Click(object sender, EventArgs e)
        {
            ProjectDataColumnsForm projectDataColumnsForm = new ProjectDataColumnsForm
            {
                StartPosition = FormStartPosition.CenterScreen,
                DataColumns = _project.DataColumns
            };
            if (projectDataColumnsForm.ShowDialog() == DialogResult.OK)
            {
                _project.UpdateDataColumns(projectDataColumnsForm.DataColumns);
                if (ImageViewer.Image != null)
                    ImageViewer.DrawingObjects.MaxNumberOfVerticalLines = projectDataColumnsForm.DataColumns.Count - 1;

                FillGalleryImage();
            }
        }

        /// <summary>
        /// Handles the Click event of the StartOcrMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void StartOcrMenuItem_Click(object sender, EventArgs e)
        {
            ActionResult result = _project.ValidateOcr();
            if (result.Result == ActionResultType.Error)
            {
                FormsHelper.ShowError(result.Message);
            }
            else
            {
                result = _project.PerformOcr();
                if (result.Result == ActionResultType.Ok)
                {
                    FormsHelper.ShowMessage(Resources.OcrCompletedMessage_Text, Resources.OcrCompletedMessage_Caption);
                    FillGalleryImage();
                }
                else
                    FormsHelper.ShowUnexpectedError();
            }
        }

        /// <summary>
        /// Handles the Click event of the ExportDataMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        private void ExportDataMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ActionResult result = _project.CheckRecognitionResultExportAllowed();
                if (result.Result == ActionResultType.Error)
                {
                    FormsHelper.ShowError(result.Message);
                }
                else
                {
                    ExportDataFileDialog.FileName = $"{_project.Name}.json";
                    if (ExportDataFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        _project.ExportJson(ExportDataFileDialog.FileName);
                        Process.Start(Path.GetDirectoryName(ExportDataFileDialog.FileName));
                    }
                }
            }
            catch (Exception exception)
            {
                LogHelper.Logger.Error(exception, "Unable to export project recognized data");
            }
        }

        private void ProjectSettingsMenuItem_Click(object sender, EventArgs e)
        {
            // TODO
        }

        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            new AboutForm().Show();
        }

        #endregion

        #region Gallery actions

        /// <summary>
        /// Handles the Click event of the AddImagesBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void AddImagesBtn_Click(object sender, EventArgs e)
        {
            if (ImagesImportFileDialog.ShowDialog() == DialogResult.OK)
            {
                _project.Gallery.AddFiles(ImagesImportFileDialog.FileNames, _project.DataColumns.Count - 1);
                FillGallery();
            }
        }

        /// <summary>
        /// Handles the Click event of the RemoveImagesBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void RemoveImagesBtn_Click(object sender, EventArgs e)
        {
            foreach (ListViewDataItem item in GalleryListView.SelectedItems)
                _project.Gallery.Images.Remove((GalleryImage)item.DataBoundItem);
            FillGallery();
        }

        /// <summary>
        /// Handles the ItemDataBound event of the GalleryListView control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="ListViewItemEventArgs"/> instance containing the event data.</param>
        private void GalleryListView_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            e.Item.Image = Image.FromFile(((GalleryImage) e.Item.DataBoundItem).ThumbnailFilePath);
            e.Item.TextImageRelation = TextImageRelation.ImageAboveText;
            e.Item.ImageAlignment = ContentAlignment.MiddleCenter;
            e.Item.TextAlignment = ContentAlignment.MiddleCenter;
        }

        /// <summary>
        /// Handles the SelectedItemChanged event of the GalleryListView control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void GalleryListView_SelectedItemChanged(object sender, EventArgs e)
        {
            ListViewItemEventArgs eventArgs = e as ListViewItemEventArgs;
            if (eventArgs?.Item != null)
            {
                GalleryImage image = (GalleryImage)eventArgs.Item.DataBoundItem;
                if (_selectedGalleryImageUid != image.Uid)
                {
                    _selectedGalleryImageUid = image.Uid;
                    FillGalleryImage();
                }
            }
        }

        #endregion

        #region Image area actions

        /// <summary>
        /// Handles the Click event of the ZoomInBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ZoomInBtn_Click(object sender, EventArgs e)
        {
            ImageViewer.ZoomIn();
        }

        /// <summary>
        /// Handles the Click event of the ZoomOutBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ZoomOutBtn_Click(object sender, EventArgs e)
        {
            ImageViewer.ZoomOut();
        }

        /// <summary>
        /// Handles the Click event of the ZoomFitBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ZoomFitBtn_Click(object sender, EventArgs e)
        {
            ImageViewer.FitImage();
        }

        /// <summary>
        /// Handles the Click event of the DrawingModeNoneBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void DrawingModeNoneBtn_Click(object sender, EventArgs e)
        {
            ImageViewer.CurrentDrawingMode = DrawingMode.None;
        }

        /// <summary>
        /// Handles the Click event of the DrawingModeRectangleBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void DrawingModeRectangleBtn_Click(object sender, EventArgs e)
        {
            ImageViewer.CurrentDrawingMode = DrawingMode.Rectangle;
        }

        /// <summary>
        /// Handles the Click event of the DrawingModeVerticalLinesBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void DrawingModeVerticalLinesBtn_Click(object sender, EventArgs e)
        {
            ImageViewer.CurrentDrawingMode = DrawingMode.VerticalLine;
        }

        /// <summary>
        /// Handles the Click event of the DrawingModeHorizontalLinesBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void DrawingModeHorizontalLinesBtn_Click(object sender, EventArgs e)
        {
            ImageViewer.CurrentDrawingMode = DrawingMode.HorizontalLine;
        }

        /// <summary>
        /// Handles the Paint event of the ImageViewer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void ImageViewer_Redrawn(object sender, EventArgs e)
        {
            if (_selectedGalleryImageUid.HasValue)
            {
                GalleryImage image = _project.Gallery.Images.WhereEx(x => x.Uid == _selectedGalleryImageUid.Value).FirstOrDefault();
                if (image != null)
                    image.DrawingObjects = ImageViewer.DrawingObjects.Clone();
            }
        }

        private void CopyDrawingObjectsBtn_Click(object sender, EventArgs e)
        {
            if (_selectedGalleryImageUid.HasValue)
               _copyOfDrawingObjects = ImageViewer.DrawingObjects.Clone();
        }

        private void PasteDrawingObjectsBtn_Click(object sender, EventArgs e)
        {
            if (_selectedGalleryImageUid.HasValue && _copyOfDrawingObjects != null)
            {
                GalleryImage image = _project.Gallery.Images.WhereEx(x => x.Uid == _selectedGalleryImageUid.Value).FirstOrDefault();
                if (image != null)
                {
                    image.DrawingObjects = _copyOfDrawingObjects.Clone();
                    FillGalleryImage();
                }                    
            }
                
        }

        #endregion

        #region Datagrid action

        /// <summary>
        /// Datas the grid on selection changed.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="eventArgs">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void DataGridOnSelectionChanged(object sender, EventArgs eventArgs)
        {
            ImageViewer.HighlightedRowIndex = DataGrid.SelectedRows.Count > 0 ? (int?) DataGrid.SelectedRows[0].Index : null;
        }

        #endregion

        #endregion
    }
}