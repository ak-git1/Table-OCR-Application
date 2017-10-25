using System;
using System.Collections.Generic;
using System.Drawing;
using System.Xml.Serialization;

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
        public bool Validate()
        {
            return RectangleArea != Rectangle.Empty && VerticalLinesCoordinates.Count == MaxNumberOfVerticalLines;
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

        #endregion
    }
}
