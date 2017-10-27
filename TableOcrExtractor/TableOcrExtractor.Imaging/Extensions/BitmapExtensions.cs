using System.Drawing;
using Elar.Framework.Core.Helpers;

namespace TableOcrExtractor.Imaging.Extensions
{
    /// <summary>
    /// Extensions for bitmap
    /// </summary>
    public static class BitmapExtensions
    {
        /// <summary>
        /// Clones bitmap
        /// </summary>
        /// <param name="bitmap">Bitmap.</param>
        /// <param name="pixelFormat">Pixel format.</param>
        /// <returns></returns>
        public static Bitmap CloneSmart(this Bitmap bitmap, System.Drawing.Imaging.PixelFormat pixelFormat)
        {
            Bitmap resultBitmap;
            GarbageCollectorHelper.Collect();

            using (Bitmap b = new Bitmap(bitmap))
            {
                b.SetResolution(bitmap.HorizontalResolution, bitmap.VerticalResolution);
                resultBitmap = b.Clone(new Rectangle(Point.Empty, new Size(b.Width, b.Height)), pixelFormat);
            }

            return resultBitmap;
        }
    }
}