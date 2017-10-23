﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Elar.Framework.Core.Extensions;
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
        private Project _project = null;

        /// <summary>
        /// Selected gallery image Uid
        /// </summary>
        private Guid? _selectedGalleryImageUid = null;

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
            SetLanguage((Language)TableOcrExtractor.Properties.Settings.Default.CurrentCultureInfo);
            OpenProjectFileDialog.Filter = Project.ProjectFileExtensionsFilter;
            InitilalizeProjectDependentControls(false);
        }

        /// <summary>
        /// Initilalizes the controls on project load.
        /// </summary>
        /// <param name="projectLoaded">Project is loaded</param>
        private void InitilalizeProjectDependentControls(bool projectLoaded)
        {
            ProjectMenuItem.Enabled = AddImagesBtn.Enabled = projectLoaded;
            ProjectNameLabelElement.Text = projectLoaded ? string.Format(Resources.ProjectName_Caption, _project.Name) : Resources.ProjectName_NoProjectLoaded;
            
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
            BindingList<GalleryImage> dataSource = new BindingList<GalleryImage>();
            foreach (GalleryImage galleryImage in _project.Gallery.Images)
                dataSource.Add(galleryImage);
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
                   
                }
            }
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
                _project.Gallery.AddFiles(ImagesImportFileDialog.FileNames);
                FillGallery();
            }
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
                _selectedGalleryImageUid = image.Uid;
                FillGalleryImage();
            }
        }

        #endregion

        #region Image area actions

        #endregion

        #endregion        
    }
}