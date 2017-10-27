using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Xml.Serialization;
using TableOcrExtractor.Controls.Model;
using TableOcrExtractor.Imaging.Helpers;

namespace TableOcrExtractor.Logic.Models
{
    /// <summary>
    /// Gallery image
    /// </summary>
    [Serializable]
    internal class GalleryImage
    {
        #region Properties

        /// <summary>
        /// Uid
        /// </summary>
        [XmlElement]
        public Guid Uid { get; set; }

        /// <summary>
        /// Order number of the image
        /// </summary>
        [XmlElement]
        public int OrderNumber { get; set; }

        /// <summary>
        /// Displayed name
        /// </summary>
        [XmlElement]
        public string DisplayedName { get; set; }

        /// <summary>
        /// The image folder path.
        /// </summary>
        public string ImageFolderPath { get; set; }

        /// <summary>
        /// Thumbnail file name
        /// </summary>
        [XmlElement]
        public string ThumbnailFileName { get; set; }

        /// <summary>
        /// Thumbnail file path
        /// </summary>
        [XmlIgnore]
        public string ThumbnailFilePath => Path.Combine(ImageFolderPath, ThumbnailFileName);

        /// <summary>
        /// Image file name
        /// </summary>
        [XmlElement]
        public string ImageFileName { get; set; }

        /// <summary>
        /// Image file path
        /// </summary>
        [XmlIgnore]
        public string ImageFilePath => Path.Combine(ImageFolderPath, ImageFileName);

        /// <summary>
        /// Drawing objects on the image for OCR 
        /// </summary>
        [XmlIgnore]
        public DrawingObjects DrawingObjects { get; set; }

        /// <summary>
        /// Recognition completed
        /// </summary>
        [XmlIgnore]
        public bool RecognitionCompleted { get; set; }

        /// <summary>
        /// Recognized data
        /// </summary>
        [XmlIgnore]
        public DataTable RecognizedData { get; set; }

        #endregion

        #region Public methods

        /// <summary>
        /// Performs OCR recognition
        /// </summary>
        /// <param name="dataColumns">Data columns.</param>
        public void PerformOcr(List<string> dataColumns)
        {
            using (Bitmap bitmap = new Bitmap(Image.FromFile(ImageFilePath)))
            {
                RecognizedData = new DataTable();
                foreach (string dataColumn in dataColumns)
                    RecognizedData.Columns.Add(dataColumn);

                Rectangle[,] areas = GetRecognitionAreas();
                for (int i = 0; i < areas.GetLength(0); i++)
                for (int j = 0; j < areas.GetLength(1); j++)
                {
                    Rectangle area = areas[i, j];
                    using (Bitmap croppedBitmap = BitmapHelper.Crop(bitmap, area))
                    {
                        
                    }
                }
            }  
        }

        #endregion

        #region Private methods

        /// <summary>
        /// Gets the recognition areas.
        /// </summary>
        /// <returns></returns>
        private Rectangle[,] GetRecognitionAreas()
        {
            int columnsNumber = DrawingObjects.VerticalLinesCoordinates.Count + 1;
            int rowsNumber = DrawingObjects.HorizontalLinesCoordinates.Count + 1;
            Rectangle[,] areas = new Rectangle[columnsNumber, rowsNumber];

            for (int i = 0; i < columnsNumber; i++)
            {
                int x = i == 0 ? DrawingObjects.RectangleArea.X : DrawingObjects.VerticalLinesCoordinates[i - 1];
                int w = 0;
                if (columnsNumber == 1)
                    w = DrawingObjects.RectangleArea.Width;
                else if (i == columnsNumber - 1)
                    w = DrawingObjects.RectangleArea.Right - x;
                    else
                        w = DrawingObjects.VerticalLinesCoordinates[i] - x; 

                for (int j = 0; j < rowsNumber; j++)
                {
                    int y = j == 0 ? DrawingObjects.RectangleArea.Y : DrawingObjects.HorizontalLinesCoordinates[j - 1];
                    int h = 0;
                    if (rowsNumber == 1)
                        h = DrawingObjects.RectangleArea.Width;
                    else if (j == rowsNumber - 1)
                        h = DrawingObjects.RectangleArea.Bottom - y;
                    else
                        h = DrawingObjects.HorizontalLinesCoordinates[j] - y;

                    areas[i, j]  = new Rectangle(x, y, w, h);
                }
            }            

            return areas;
        }

        #endregion
    }
}
