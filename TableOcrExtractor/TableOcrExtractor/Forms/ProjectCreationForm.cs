using System.Windows.Forms;
using Elar.Framework.Core.Extensions;
using TableOcrExtractor.Logic.Enums;
using TableOcrExtractor.Logic.Helpers;
using TableOcrExtractor.Logic.Models;
using TableOcrExtractor.Properties;

namespace TableOcrExtractor.Forms
{
    /// <summary>
    /// Project creation form
    /// </summary>
    /// <seealso cref="TableOcrExtractor.Forms.LocalizedForm" />
    public partial class ProjectCreationForm : LocalizedForm
    {
        #region Properties

        /// <summary>
        /// Project file path
        /// </summary>
        public string ProjectPath { get; private set; }

        /// <summary>
        /// Project name
        /// </summary>
        public string ProjectName { get; private set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectCreationForm"/> class.
        /// </summary>
        public ProjectCreationForm()
        {
            InitializeComponent();
            ProjectCreationFileDialog.Filter = Project.ProjectFileExtensionsFilter;
        }

        #endregion

        #region Private methods

        /// <summary>
        /// Validates data on the form
        /// </summary>
        /// <returns></returns>
        private ActionResultType ValidateData()
        {
            return ProjectFileTxt.Text.NotEmpty() && ProjectNameTxt.Text.NotEmpty()
                ? ActionResultType.Ok
                : ActionResultType.Error;
        }

        #endregion

        #region Event handlers

        /// <summary>
        /// Handles the Click event of the SelectFileBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void SelectFileBtn_Click(object sender, System.EventArgs e)
        {
            if (ProjectCreationFileDialog.ShowDialog() == DialogResult.OK)
                ProjectFileTxt.Text = ProjectCreationFileDialog.FileName;
        }

        /// <summary>
        /// Handles the Click event of the CreateBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        private void CreateBtn_Click(object sender, System.EventArgs e)
        {
            if (ValidateData() == ActionResultType.Ok)
            {
                ProjectName = ProjectNameTxt.Text;
                ProjectPath = ProjectFileTxt.Text;                
                Close();
                DialogResult = DialogResult.OK;
            }
            else
                FormsHelper.ShowWarning(Resources.ProjectValidationMessage_Text, Resources.ProjectValidationMessage_Caption);
        }

        /// <summary>
        /// Handles the Click event of the CancelBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        private void CancelBtn_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        #endregion
    }
}
