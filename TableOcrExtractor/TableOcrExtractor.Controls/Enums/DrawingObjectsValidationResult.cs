﻿namespace TableOcrExtractor.Controls.Enums
{
    /// <summary>
    /// Validation results for drawing objects
    /// </summary>
    public enum DrawingObjectsValidationResult
    {
        /// <summary>
        /// Ok
        /// </summary>
        Ok = 0,

        /// <summary>
        /// The rectangle not set
        /// </summary>
        RectangleNotSet = 1,

        /// <summary>
        /// Wrong number of vertical lines
        /// </summary>
        WrongNumberOfVerticalLines = 2
    }
}
