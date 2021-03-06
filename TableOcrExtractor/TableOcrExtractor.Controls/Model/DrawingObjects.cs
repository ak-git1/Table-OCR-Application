﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Xml.Serialization;
using TableOcrExtractor.Controls.Enums;

namespace TableOcrExtractor.Controls.Model
{
    /// <summary>
    /// Drawing objects
    /// </summary>
    [Serializable]
    public class DrawingObjects
    {
        #region Properties

        #region Rectangle

        /// <summary>
        /// Rectangle area
        /// </summary>
        [XmlElement]
        public Rectangle RectangleArea { get; set; }

        #endregion

        #region Vertical lines

        /// <summary>
        /// Maximun number of vertical lines
        /// </summary>
        public int MaxNumberOfVerticalLines { get; set; } = 1;

        /// <summary>
        /// Vertical lines coordinates on the X-axis
        /// </summary>
        [XmlElement]
        public List<int> VerticalLinesCoordinates { get; set; } = new List<int>();

        #endregion

        #region Horizontal lines

        /// <summary>
        /// Horizontal lines coordinates on the Y-axis
        /// </summary>
        [XmlElement]
        public List<int> HorizontalLinesCoordinates { get; set; } = new List<int>();

        #endregion

        #endregion

        #region Public methods

        /// <summary>
        /// Validates the object
        /// </summary>
        /// <returns></returns>
        public DrawingObjectsValidationResult Validate()
        {
            if (RectangleArea == Rectangle.Empty)
                return DrawingObjectsValidationResult.RectangleNotSet;

            if (VerticalLinesCoordinates.Count != MaxNumberOfVerticalLines)
                return DrawingObjectsValidationResult.WrongNumberOfVerticalLines;

            return DrawingObjectsValidationResult.Ok;
        }

        /// <summary>
        /// Clears the object
        /// </summary>
        public void Clear()
        {
            RectangleArea = Rectangle.Empty;
            VerticalLinesCoordinates = new List<int>();
            HorizontalLinesCoordinates = new List<int>();
        }

        /// <summary>
        /// Clones this instance.
        /// </summary>
        public DrawingObjects Clone()
        {
            return new DrawingObjects
            {
                RectangleArea = RectangleArea,
                MaxNumberOfVerticalLines = MaxNumberOfVerticalLines,
                VerticalLinesCoordinates = new List<int>(VerticalLinesCoordinates),
                HorizontalLinesCoordinates = new List<int>(HorizontalLinesCoordinates)
            };
        }

        /// <summary>
        /// Clean lines data by removing doubles and lines outside the rectangle area
        /// </summary>
        /// <returns></returns>
        public void RemoveWrongLines()
        {
            if (RectangleArea != Rectangle.Empty)
            {
                if (VerticalLinesCoordinates.Count > 0)
                    VerticalLinesCoordinates = VerticalLinesCoordinates.Distinct().Where(x => x <= RectangleArea.Right && x >= RectangleArea.Left).ToList();

                if (HorizontalLinesCoordinates.Count > 0)
                    HorizontalLinesCoordinates = HorizontalLinesCoordinates.Distinct().Where(y => y >= RectangleArea.Top && y <= RectangleArea.Bottom).ToList();
            }            
        }

        #endregion
    }
}
