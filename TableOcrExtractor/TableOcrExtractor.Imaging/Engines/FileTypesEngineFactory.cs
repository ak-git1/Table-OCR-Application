using System;
using TableOcrExtractor.Imaging.Enums;
using TableOcrExtractor.Imaging.Helpers;
using TableOcrExtractor.Imaging.Interfaces;

namespace TableOcrExtractor.Imaging.Engines
{
    /// <summary>
    /// Фабрика обработчиков файлов
    /// </summary>
    public static class FileTypesEngineFactory
    {
        #region Public methods

        /// <summary>
        /// Gets file types engine.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <returns></returns>
        /// <exception cref="Exception">Unsupported format</exception>
        public static IFileTypeEngine GetFileTypesEngine(string filePath)
        {
            IFileTypeEngine engine = null;

            FileType fileType = FilesHelper.GetFileType(filePath);
            switch (fileType)
            {
                case FileType.Bmp:
                case FileType.Gif:
                case FileType.Jpeg:
                case FileType.Png:
                    engine = new SinglePageImageEngine();
                    break;

                case FileType.Tiff:
                    engine = new TiffEngine();
                    break;

                case FileType.Pdf:
                    engine = new PdfEngine();
                    break;

                case FileType.Unsupported:
                    throw new Exception("Unsupported format");
            }

            return engine;
        }

        #endregion
    }
}
