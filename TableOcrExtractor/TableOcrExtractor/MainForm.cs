using System;
using System.Windows.Forms;
using TableOcrExtractor.Forms;
using TableOcrExtractor.Logic.Enums;
using TableOcrExtractor.Logic.Models;
using TableOcrExtractor.Properties;

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
            ProjectMenuItem.Enabled = false;
        }

        /// <summary>
        /// Initilalizes the controls on project load.
        /// </summary>
        private void InitilalizeControlsOnProjectLoad()
        {
            ProjectMenuItem.Enabled = true;
            ProjectNameLabelElement.Text = string.Format(Resources.ProjectNameCaption, _project.Name);
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
            ProjectCreationForm projectCreationForm = new ProjectCreationForm
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            var s = projectCreationForm.ShowDialog();
            if (s == DialogResult.OK)
            {
                _project = Project.Create(projectCreationForm.ProjectPath, projectCreationForm.ProjectName);
                InitilalizeControlsOnProjectLoad();
            }
        }

        /// <summary>
        /// Handles the Click event of the OpenProjectMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OpenProjectMenuItem_Click(object sender, EventArgs e)
        {
            if (OpenProjectFileDialog.ShowDialog() == DialogResult.OK)
            {
                _project = Project.Load(OpenProjectFileDialog.FileName);
                InitilalizeControlsOnProjectLoad();
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

        #endregion
    }
}