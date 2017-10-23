using System;
using System.Drawing;
using System.Windows.Forms;
using TableOcrExtractor.Controls.Enums;
using TableOcrExtractor.Controls.Model;

namespace TableOcrExtractor.Controls
{
    /// <summary>
    /// Image Viewer control with additional operations
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class ImageViewer : UserControl
    {
        #region Variables and constants

        /// <summary>
        /// The minimum zoom value
        /// </summary>
        private const int MinZoomValue = 10;

        /// <summary>
        /// The maximum zoom value
        /// </summary>
        private const int MaxZoomValue = 1000;

        /// <summary>
        /// The drawing is in progress
        /// </summary>
        private bool _isDrawingInProgress;

        /// <summary>
        /// Current drawing mode
        /// </summary>
        private DrawingMode _currentDrawingMode = DrawingMode.None;

        /// <summary>
        /// The drawn rectangle area brush
        /// </summary>
        private readonly Brush _rectangleAreaBrush = new SolidBrush(Color.FromArgb(70, 72, 145, 220));

        /// <summary>
        /// The drawing start point
        /// </summary>
        private Point _drawingStartPoint;

        /// <summary>
        /// The drawing end point
        /// </summary>
        private Point _drawingEndPoint;

        /// <summary>
        /// Rectangle area
        /// </summary>
        private Rectangle _rectangleArea;

        #endregion

        #region Properties

        /// <summary>
        /// Current drawing mode
        /// </summary>
        public DrawingMode CurrentDrawingMode
        {
            get => _currentDrawingMode;
            set
            {
                if (value == DrawingMode.None)
                    _isDrawingInProgress = false;
                _currentDrawingMode = value;
            }
        }

        /// <summary>
        /// Image
        /// </summary>
        public Image Image
        {
            get => PictureBox.Image;
            set => PictureBox.Image = value;
        }

        /// <summary>
        /// Current zoom percent
        /// </summary>
        public double ZoomPercent => PictureBox.Properties.ZoomPercent;

        /// <summary>
        /// Zoom step
        /// </summary>
        public double ZoomStep { get; set; } = 2.5;

        /// <summary>
        /// Drawing objects
        /// </summary>
        public DrawingObjects DrawingObjects { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageViewer"/> class.
        /// </summary>
        public ImageViewer()
        {
            DrawingObjects = new DrawingObjects();

            InitializeComponent();
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Zooms in the image
        /// </summary>
        public void ZoomIn()
        {
            if (Image != null)
                if (PictureBox.Properties.ZoomPercent < MaxZoomValue)
                    PictureBox.Properties.ZoomPercent += ZoomStep;
        }

        /// <summary>
        /// Zooms out the image
        /// </summary>
        public void ZoomOut()
        {
            if (Image != null)
                if (PictureBox.Properties.ZoomPercent > MinZoomValue)
                    PictureBox.Properties.ZoomPercent -= ZoomStep;
        }

        /// <summary>
        /// Fits the image.
        /// </summary>
        public void FitImage()
        {
            if (Image != null)
            {
                int zoomValue = Math.Min(100, Math.Min((PictureBox.Width - 2) * 100 / Image.Width, (PictureBox.Height - 2) * 100 / Image.Height));
                PictureBox.Properties.ZoomPercent = zoomValue;
            }
        }

        #endregion

        #region Private methods

        /// <summary>
        /// Creates the rectangle by two points.
        /// </summary>
        /// <param name="startPoint">The start point.</param>
        /// <param name="endPoint">The end point.</param>
        /// <returns></returns>
        private Rectangle CreateRectangleByTwoPoints(Point startPoint, Point endPoint)
        {
            return new Rectangle
            {
                Location = new Point(Math.Min(startPoint.X, endPoint.X), Math.Min(startPoint.Y, endPoint.Y)),
                Size = new Size(Math.Abs(startPoint.X - endPoint.X), Math.Abs(startPoint.Y - endPoint.Y))
            };
        }

        /// <summary>
        /// Converts to viewport coordinates rectangle.
        /// </summary>
        /// <param name="rect">Rectangle</param>
        /// <returns></returns>
        private Rectangle ConvertToViewportRectangle(Rectangle rect)
        {
            int xMin = rect.X;
            int xMax = rect.X + rect.Width;
            int yMin = rect.Y;
            int yMax = rect.Y + rect.Height;

            Point leftBottomCorner = PictureBox.ImageToViewport(new Point(xMin, yMin));
            Point rightTopCorner = PictureBox.ImageToViewport(new Point(xMax, yMax));

            return new Rectangle
            {
                Location = PictureBox.ImageToViewport(rect.Location),
                Size = new Size(Math.Abs(leftBottomCorner.X - rightTopCorner.X), Math.Abs(leftBottomCorner.Y - rightTopCorner.Y))
            };
        }

        #endregion

        #region Event handlers

        /// <summary>
        /// Handles the MouseDown event of the PictureBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (CurrentDrawingMode != DrawingMode.None)
            {
                _drawingStartPoint = e.Location;
                _isDrawingInProgress = true;
                Invalidate();
            }            
        }

        /// <summary>
        /// Handles the MouseMove event of the PictureBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (Image == null || e.Button != MouseButtons.Left)
                return;

            switch (CurrentDrawingMode)
            {
                case DrawingMode.Rectangle:
                    _drawingEndPoint = e.Location;
                    _rectangleArea = CreateRectangleByTwoPoints(_drawingStartPoint, _drawingEndPoint);
                    PictureBox.Invalidate();
                    break;

                default:
                    break;
            }            
        }

        /// <summary>
        /// Handles the MouseUp event of the PictureBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                switch (CurrentDrawingMode)
                {
                    case DrawingMode.Rectangle:
                        _isDrawingInProgress = false;
                        _rectangleArea = Rectangle.Empty;
                        DrawingObjects.RectangleArea = CreateRectangleByTwoPoints(PictureBox.ViewportToImage(_drawingStartPoint), PictureBox.ViewportToImage(_drawingEndPoint));
                        break;
                }
            }            
        }

        /// <summary>
        /// Handles the Paint event of the PictureBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (Image != null)
            {
                if (_isDrawingInProgress)
                {
                    if (_rectangleArea != Rectangle.Empty && _rectangleArea.Width > 0 && _rectangleArea.Height > 0)
                        e.Graphics.FillRectangle(_rectangleAreaBrush, _rectangleArea);
                }
                else
                {
                    if (DrawingObjects.RectangleArea != Rectangle.Empty && DrawingObjects.RectangleArea.Width > 0 && DrawingObjects.RectangleArea.Height > 0)
                        e.Graphics.FillRectangle(_rectangleAreaBrush, ConvertToViewportRectangle(DrawingObjects.RectangleArea));
                }
            }
        }

        #endregion
    }
}
