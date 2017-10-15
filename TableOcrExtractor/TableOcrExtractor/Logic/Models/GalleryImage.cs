using System;
using System.Xml.Serialization;

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
        /// Thumbnail file path
        /// </summary>
        [XmlElement]
        public string ThumbnailPath { get; set; }

        /// <summary>
        /// Image file path
        /// </summary>
        [XmlElement]
        public string ImagePath { get; set; }

        #endregion

        #region Public methods



        #endregion
    }
}
