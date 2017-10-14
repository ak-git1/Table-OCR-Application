using NLog;

namespace TableOcrExtractor.Logic.Helpers
{
    /// <summary>
    /// Log helper
    /// </summary>
    public static class LogHelper
    {
        #region Properies

        /// <summary>
        /// Logger
        /// </summary>
        public static Logger Logger => LogManager.GetCurrentClassLogger();

        #endregion

        #region Public methods

        /// <summary>
        /// Applying changes, logger clearing
        /// </summary>
        public static void Flush()
        {
            LogManager.Flush();
        }


        #endregion
    }
}
