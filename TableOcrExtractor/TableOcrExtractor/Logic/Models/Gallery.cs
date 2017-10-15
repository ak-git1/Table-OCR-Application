using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using TableOcrExtractor.Logic.Enums;
using TableOcrExtractor.Logic.Helpers;
using TableOcrExtractor.Imaging.Converters;
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
            FileType fileType = FilesHelper.GetFileType(filePath);
            if (fileType == FileType.Unsupported)
                return new ActionResult(ActionResultType.UnsupportedAction, $"File {filePath} has unssuported format");
            else
            {
                try
                {
                    FileFormat fileFormat = FilesHelper.GetFileFormat(fileType);
                    switch (fileFormat)
                    {
                        case FileFormat.SingePage:
                            AddImage(filePath);
                            break;

                        case FileFormat.MultiPage:

                            break;
                    }

                    return new ActionResult();
                }
                catch (Exception e)
                {
                    LogHelper.Logger.Error(e, $"Unable to add {filePath} to gallery");
                    return new ActionResult(ActionResultType.Error, $"Error while trying to add {filePath} to gallery");
                }                
            }
        }

        /// <summary>
        /// Adds image to gallery
        /// </summary>
        /// <param name="path">Original image path</param>
        private void AddImage(string path)
        {            
            int orderNumber = Images.Max(x => x.OrderNumber) + 1;
            Guid imageGuid = Guid.NewGuid();
            string imagePath = Path.Combine(GalleryFolderPath, $"{imageGuid}.jpg");
            string thumbnailPath = Path.Combine(GalleryFolderPath, $"{imageGuid}_thumb.jpg");

            new ImagesConverter(path).ConvertToJpeg(imagePath);
            new ImagesConverter(path).CreateThumbnail(imagePath, CommonSettings.ThumbnailWidth, CommonSettings.ThumbnailHeight);

            GalleryImage galleryImage = new GalleryImage
            {
                OrderNumber = orderNumber,
                DisplayedName = orderNumber.ToString(ImageNameMask),
                ImagePath = imagePath,
                ThumbnailPath = thumbnailPath
            };

            Images.Add(galleryImage);
        }

        #endregion
    }
}
