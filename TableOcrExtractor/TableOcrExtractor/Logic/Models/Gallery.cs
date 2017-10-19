using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using TableOcrExtractor.Logic.Enums;
using TableOcrExtractor.Logic.Helpers;
using TableOcrExtractor.Imaging.Converters;
using TableOcrExtractor.Imaging.Engines;
using TableOcrExtractor.Imaging.Interfaces;
using TableOcrExtractor.Settings;

namespace TableOcrExtractor.Logic.Models
{
    /// <summary>
    /// Images gallery
    /// </summary>
    [Serializable]
    internal class Gallery
    {
        #region Variables and constants

        /// <summary>
        /// The image name mask
        /// </summary>
        private const string ImageNameMask = "0000000";

        #endregion

        #region Properties

        /// <summary>
        /// Gallery folder path
        /// </summary>
        [XmlElement]
        public string GalleryFolderPath { get; set; }

        /// <summary>
        /// Gallery
        /// </summary>
        [XmlElement]
        public List<GalleryImage> Images { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Gallery"/> class.
        /// </summary>
        /// <param name="galleryFolderPath">The gallery folder path.</param>
        public Gallery(string galleryFolderPath)
        {
            GalleryFolderPath = galleryFolderPath;
            Images = new List<GalleryImage>();            
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Adds files to gallery
        /// </summary>
        /// <param name="files">The files</param>
        public List<ActionResult> AddFiles(string[] files)
        {
            List<ActionResult> results = new List<ActionResult>();

            foreach (string file in files)
                results.Add(AddFile(file));

            return results;
        }

        #endregion

        #region Private methods

        /// <summary>
        /// Adds file to gallery
        /// </summary>
        /// <param name="filePath">File path</param>
        private ActionResult AddFile(string filePath)
        {
            if (Images == null)
                Images = new List<GalleryImage>();

            try
            {
                IFileTypeEngine engine = FileTypesEngineFactory.GetFileTypesEngine(filePath);
                int totalPages = engine.GetTotalPages(filePath);
                int orderNumber = Images.Any() ? Images.Max(x => x.OrderNumber) + 1 : 1;

                for (int i = 1; i <= totalPages; i++)
                {
                    Guid imageGuid = Guid.NewGuid();
                    string imagePath = Path.Combine(GalleryFolderPath, $"{imageGuid}.jpg");
                    string thumbnailPath = Path.Combine(GalleryFolderPath, $"{imageGuid}_thumb.jpg");

                    engine.SavePageToJpeg(filePath, imagePath, i);
                    new ImagesConverter(imagePath).CreateThumbnail(thumbnailPath, CommonSettings.ThumbnailWidth, CommonSettings.ThumbnailHeight);

                    GalleryImage galleryImage = new GalleryImage
                    {
                        OrderNumber = orderNumber,
                        DisplayedName = orderNumber.ToString(ImageNameMask),
                        ImagePath = imagePath,
                        ThumbnailPath = thumbnailPath
                    };

                    Images.Add(galleryImage);
                }

                return new ActionResult();
            }
            catch (Exception e)
            {
                LogHelper.Logger.Error(e, $"Unable to add {filePath} to gallery");
                return new ActionResult(ActionResultType.Error, $"Error while trying to add {filePath} to gallery");
            }
        }

        #endregion
    }
}
