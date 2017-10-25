using System;
using System.IO;
using System.Xml.Serialization;
using TableOcrExtractor.Controls.Model;

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

        #endregion

        #region Public methods



        #endregion
    }
}
