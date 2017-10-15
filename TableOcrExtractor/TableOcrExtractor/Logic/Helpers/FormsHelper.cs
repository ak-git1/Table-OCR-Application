using System.Windows.Forms;
using TableOcrExtractor.Properties;

namespace TableOcrExtractor.Logic.Helpers
{
    /// <summary>
    /// Class for execution operation with forms
    /// </summary>
    internal static class FormsHelper
    {
        #region Public methods

        /// <summary>
        /// Shows the warning.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="caption">The caption.</param>
        public static void ShowWarning(string text, string caption)
        {
            MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// Shows unexpected error.
        /// </summary>
        public static void ShowUnexpectedError()
        {
            MessageBox.Show(Resources.UnexpectedError_Text, Resources.UnexpectedError_Caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        #endregion
    }
}
