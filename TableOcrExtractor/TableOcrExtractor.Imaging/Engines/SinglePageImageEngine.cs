using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableOcrExtractor.Imaging.Converters;
using TableOcrExtractor.Imaging.Interfaces;

namespace TableOcrExtractor.Imaging.Engines
{
    /// <summary>
    /// Engine for operations with single page image files
    /// </summary>
    /// <seealso cref="IFileTypeEngine" />
    public class SinglePageImageEngine : IFileTypeEngine
    {
        #region Public methods

        /// <summary>
        /// Gets total pages number in file
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <returns></returns>
        public int GetTotalPages(string filePath)
        {
            return 1;
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
            new ImagesConverter(sourceFilePath).ConvertToJpeg(outputPath);
        }

        #endregion
    }
}
