using System;
using GdPicture14;
using TableOcrExtractor.Imaging.Interfaces;

namespace TableOcrExtractor.Imaging.Engines
{
    /// <summary>
    /// Engine for operations with tiff files
    /// </summary>
    /// <seealso cref="IFileTypeEngine" />
    public class TiffEngine : IFileTypeEngine
    {
        #region Public methods

        /// <summary>
        /// Gets total pages number in file
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public int GetTotalPages(string filePath)
        {
            int totalPages = 0;

            using (GdPictureImaging image = new GdPictureImaging())
            {
                int imageId = image.CreateGdPictureImageFromFile(filePath);
                totalPages = image.TiffGetPageCount(imageId);
                totalPages = totalPages > 0 ? totalPages : 1;
            }

            return totalPages;
        }

        /// <summary>
        /// Save page to jpeg file
        /// </summary>
        /// <param name="sourceFilePath">The source file path.</param>
        /// <param name="outputPath">The output path.</param>
        /// <param name="pageNumber">Page number</param>
        /// <exception cref="NotImplementedException"></exception>
        public void SavePageToJpeg(string sourceFilePath, string outputPath, int pageNumber)
        {
            using (GdPictureImaging image = new GdPictureImaging())
            {
                int imageId = image.CreateGdPictureImageFromFile(sourceFilePath);
                image.SelectPage(imageId, pageNumber);
                image.SaveAsJPEG(imageId, outputPath);
                image.ReleaseGdPictureImage(imageId);
            }

            GC.Collect();            
        }

        #endregion
    }
}
