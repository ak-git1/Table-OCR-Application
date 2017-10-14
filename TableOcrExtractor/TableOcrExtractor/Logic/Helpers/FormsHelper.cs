using System.Windows.Forms;

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

        #endregion
    }
}
