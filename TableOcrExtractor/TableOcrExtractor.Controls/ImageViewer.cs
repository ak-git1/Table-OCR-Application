using System;
using System.ComponentModel;
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
        /// The line click search area
        /// </summary>
        private const int LineClickSearchArea = 5;

        /// <summary>
        /// The drawing is in progress
        /// </summary>
        private bool _isDrawingInProgress;

        /// <summary>
        /// Current drawing mode
        /// </summary>
        private DrawingMode _currentDrawingMode = DrawingMode.None;

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

        /// <summary>
        /// Selected Vertical line index
        /// </summary>
        private int? _selectedVerticalLineIndex;

        /// <summary>
        /// Selected horizontal line index
        /// </summary>
        private int? _selectedHorizontalLineIndex;

        #region Brushes and pens

        /// <summary>
        /// Rectangle area brush while drawing
        /// </summary>
        private readonly Brush _drawingRectangleAreaBrush = new SolidBrush(Color.FromArgb(70, 72, 145, 220));

        /// <summary>
        /// The drawn rectangle area border pen
        /// </summary>
        private readonly Pen _fixedRectangleAreaBorderPen = new Pen(Color.FromArgb(72, 145, 220), 3);

        /// <summary>
        /// Line pen while drwaing
        /// </summary>
        private readonly Pen _drawingLinePen = new Pen(Color.FromArgb(50, 22, 158, 76), 3);

        /// <summary>
        /// The drwan line pen
        /// </summary>
        private readonly Pen _fixedLinePen = new Pen(Color.FromArgb(22, 158, 76), 3);

        #endregion

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
            set
            {
                DrawingObjects.Clear();
                _currentDrawingMode = DrawingMode.None;
                PictureBox.Image = value;
            }
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

        #region Events

        /// <summary>
        /// Occurs when ImageViewer redrawn
        /// </summary>
        [Category("Action")]
        [Description("Occurs when ImageViewer redrawn")]
        public event EventHandler Redrawn;

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

        /// <summary>
        /// Clears the drawn objects
        /// </summary>
        public void ClearObjects()
        {
            DrawingObjects.Clear();
            PictureBox.Invalidate();
        }

        /// <summary>
        /// Clears the drawn vertical lines
        /// </summary>
        public void ClearVerticalLines()
        {
            DrawingObjects.VerticalLinesCoordinates.Clear();
            PictureBox.Invalidate();
        }

        /// <summary>
        /// Clears the drawn horizontal lines
        /// </summary>
        public void ClearHorizontalLines()
        {
            DrawingObjects.HorizontalLinesCoordinates.Clear();
            PictureBox.Invalidate();
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
        private Rectangle ConvertToViewportCoordinatesRectangle(Rectangle rect)
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

        /// <summary>
        /// Converts to image coordinates rectangle.
        /// </summary>
        /// <param name="rect">Rectangle</param>
        /// <returns></returns>
        private Rectangle ConvertToImageCoordinatesRectangle(Rectangle rect)
        {
            int xMin = rect.X;
            int xMax = rect.X + rect.Width;
            int yMin = rect.Y;
            int yMax = rect.Y + rect.Height;

            Point leftBottomCorner = PictureBox.ViewportToImage(new Point(xMin, yMin));
            Point rightTopCorner = PictureBox.ViewportToImage(new Point(xMax, yMax));

            return new Rectangle
            {
                Location = PictureBox.ViewportToImage(rect.Location),
                Size = new Size(Math.Abs(leftBottomCorner.X - rightTopCorner.X), Math.Abs(leftBottomCorner.Y - rightTopCorner.Y))
            };
        }

        /// <summary>
        /// Converts line coordinates to viewport
        /// </summary>
        /// <param name="line">The line</param>
        /// <returns></returns>
        private Line ConvertToViewportLine(Line line)
        {
            return new Line
            {
                Start = PictureBox.ViewportToImage(line.Start),
                End = PictureBox.ViewportToImage(line.End)
            };
        }

        /// <summary>
        /// Converts X coordinate to viewport coordinate
        /// </summary>
        /// <param name="x">X</param>
        /// <returns></returns>
        private int ConvertXCoordinateToViewportCoordinate(int x)
        {
            return PictureBox.ImageToViewport(new Point(x, 0)).X;
        }

        /// <summary>
        /// Converts Y coordinate to viewport coordinate
        /// </summary>
        /// <param name="y">Y</param>
        /// <returns></returns>
        private int ConvertYCoordinateToViewportCoordinate(int y)
        {
            return PictureBox.ImageToViewport(new Point(0, y)).Y;
        }

        /// <summary>
        /// Converts X coordinate to viewport coordinate
        /// </summary>
        /// <param name="x">X</param>
        /// <returns></returns>
        private int ConvertXCoordinateToImageCoordinate(int x)
        {
            return PictureBox.ViewportToImage(new Point(x, 0)).X;
        }

        /// <summary>
        /// Converts Y coordinate to viewport coordinate
        /// </summary>
        /// <param name="y">Y</param>
        /// <returns></returns>
        private int ConvertYCoordinateToImageCoordinate(int y)
        {
            return PictureBox.ViewportToImage(new Point(0, y)).Y;
        }

        /// <summary>
        /// Determines whether value in delta area.
        /// </summary>
        /// <param name="value">Value</param>
        /// <param name="center">Center.</param>
        /// <param name="delta">Delta</param>
        /// <returns></returns>
        private bool IsValueInDeltaArea(int value, int center, int delta)
        {
            return center - delta <= value && value <= center + delta;
        }

        /// <summary>
        /// Determines whether point is in vertical line area
        /// </summary>
        /// <param name="p">Point</param>
        /// <param name="lineIndex">Index of the line.</param>
        /// <returns></returns>
        private bool IsPointInVerticalLineArea(Point p, out int? lineIndex)
        {
            lineIndex = null;

            if (DrawingObjects.RectangleArea != Rectangle.Empty && ConvertToViewportCoordinatesRectangle(DrawingObjects.RectangleArea).Contains(p))
            {
                for (int i = 0; i < DrawingObjects.VerticalLinesCoordinates.Count; i++)
                {
                    if (IsValueInDeltaArea(p.X, ConvertXCoordinateToViewportCoordinate(DrawingObjects.VerticalLinesCoordinates[i]), LineClickSearchArea))
                    {
                        lineIndex = i;
                        return true;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Determines whether point is in horizontal line area
        /// </summary>
        /// <param name="p">Point</param>
        /// <param name="lineIndex">Index of the line.</param>
        /// <returns></returns>
        private bool IsPointInHorizontalLineArea(Point p, out int? lineIndex)
        {
            lineIndex = null;

            if (DrawingObjects.RectangleArea != Rectangle.Empty && ConvertToViewportCoordinatesRectangle(DrawingObjects.RectangleArea).Contains(p))
            {
                for (int i = 0; i < DrawingObjects.HorizontalLinesCoordinates.Count; i++)
                {
                    if (IsValueInDeltaArea(p.Y, ConvertYCoordinateToViewportCoordinate(DrawingObjects.HorizontalLinesCoordinates[i]), LineClickSearchArea))
                    {
                        lineIndex = i;
                        return true;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Clears the drawing helping objects like temp points, line indexes etc
        /// </summary>
        private void ClearDrawingHelpingObjects()
        {
            _drawingStartPoint = Point.Empty;
            _drawingEndPoint = Point.Empty;
            _selectedVerticalLineIndex = null;
            _selectedHorizontalLineIndex = null;
            _isDrawingInProgress = false;
        }

        #endregion

        #region Event handlers

        /// <summary>
        /// Handles redrawing
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public delegate void RedrawnEventHandler(object sender, EventArgs e);

        /// <summary>
        /// Handles the MouseDown event of the PictureBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            ClearDrawingHelpingObjects();
            _drawingStartPoint = e.Location;            

            switch (CurrentDrawingMode)
            {
                case DrawingMode.Rectangle:                    
                    _isDrawingInProgress = true;
                    DrawingObjects.Clear();
                    PictureBox.Invalidate();
                    break;

                case DrawingMode.VerticalLine:
                    if (IsPointInVerticalLineArea(_drawingStartPoint, out _selectedVerticalLineIndex))
                    {
                        _isDrawingInProgress = true;
                        PictureBox.Invalidate();
                    }
                    else if (DrawingObjects.VerticalLinesCoordinates.Count < DrawingObjects.MaxNumberOfVerticalLines)
                    {
                        _isDrawingInProgress = true;
                        PictureBox.Invalidate();
                    }
                    break;

                case DrawingMode.HorizontalLine:
                    if (IsPointInHorizontalLineArea(_drawingStartPoint, out _selectedHorizontalLineIndex))
                    {
                        _isDrawingInProgress = true;
                        PictureBox.Invalidate();
                    }
                    else
                    {
                        _isDrawingInProgress = true;
                        PictureBox.Invalidate();
                    }
                    break;
            }          
        }

        /// <summary>
        /// Handles the MouseMove event of the PictureBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (Image == null || !_isDrawingInProgress || e.Button != MouseButtons.Left)
                return;

            switch (CurrentDrawingMode)
            {
                case DrawingMode.Rectangle:
                    _drawingEndPoint = e.Location;
                    _rectangleArea = CreateRectangleByTwoPoints(_drawingStartPoint, _drawingEndPoint);
                    PictureBox.Invalidate();
                    break;

                case DrawingMode.VerticalLine:
                    _drawingEndPoint = e.Location;
                    PictureBox.Invalidate();
                    break;

                case DrawingMode.HorizontalLine:
                    _drawingEndPoint = e.Location;
                    PictureBox.Invalidate();
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
                if (_isDrawingInProgress)
                {
                    switch (CurrentDrawingMode)
                    {
                        case DrawingMode.Rectangle:
                            _rectangleArea = Rectangle.Empty;
                            DrawingObjects.RectangleArea = ConvertToImageCoordinatesRectangle(CreateRectangleByTwoPoints(_drawingStartPoint, _drawingEndPoint));
                            break;

                        case DrawingMode.VerticalLine:
                            if (_selectedVerticalLineIndex.HasValue)
                                DrawingObjects.VerticalLinesCoordinates[_selectedVerticalLineIndex.Value] = ConvertXCoordinateToImageCoordinate(_drawingEndPoint.X);
                            else
                                if (DrawingObjects.VerticalLinesCoordinates.Count < DrawingObjects.MaxNumberOfVerticalLines)
                                    DrawingObjects.VerticalLinesCoordinates.Add(ConvertXCoordinateToImageCoordinate(_drawingEndPoint.X));
                            _selectedVerticalLineIndex = null;
                            break;

                        case DrawingMode.HorizontalLine:
                            if (_selectedHorizontalLineIndex.HasValue)
                                DrawingObjects.HorizontalLinesCoordinates[_selectedHorizontalLineIndex.Value] = ConvertYCoordinateToImageCoordinate(_drawingEndPoint.Y);
                            else                                
                                DrawingObjects.HorizontalLinesCoordinates.Add(ConvertYCoordinateToImageCoordinate(_drawingEndPoint.Y));
                            _selectedHorizontalLineIndex = null;
                            break;
                    }

                    _isDrawingInProgress = false;
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
                if (_isDrawingInProgress && CurrentDrawingMode == DrawingMode.Rectangle)
                {
                    if (_rectangleArea != Rectangle.Empty && _rectangleArea.Width > 0 && _rectangleArea.Height > 0)
                        e.Graphics.FillRectangle(_drawingRectangleAreaBrush, _rectangleArea);
                }
                else
                {
                    if (DrawingObjects.RectangleArea != Rectangle.Empty && DrawingObjects.RectangleArea.Width > 0 && DrawingObjects.RectangleArea.Height > 0)
                    {
                        #region Rectangle drawing

                        Rectangle rect = ConvertToViewportCoordinatesRectangle(DrawingObjects.RectangleArea);
                        e.Graphics.DrawRectangle(_fixedRectangleAreaBorderPen, rect);

                        #endregion

                        #region Vertical lines drawing

                        for (int i = 0; i < DrawingObjects.VerticalLinesCoordinates.Count; i++)
                        {
                            if (_selectedVerticalLineIndex.HasValue && _selectedVerticalLineIndex == i)
                                continue;

                            int x = ConvertXCoordinateToViewportCoordinate(DrawingObjects.VerticalLinesCoordinates[i]);
                            e.Graphics.DrawLine(_fixedLinePen, x, rect.Bottom, x, rect.Top);
                        }

                        if (_isDrawingInProgress && CurrentDrawingMode == DrawingMode.VerticalLine)
                            e.Graphics.DrawLine(_drawingLinePen, _drawingEndPoint.X, rect.Bottom, _drawingEndPoint.X, rect.Top);

                        #endregion

                        #region Horizontal lines drawing

                        for (int i = 0; i < DrawingObjects.HorizontalLinesCoordinates.Count; i++)
                        {
                            if (_selectedHorizontalLineIndex.HasValue && _selectedHorizontalLineIndex == i)
                                continue;

                            int y = ConvertYCoordinateToViewportCoordinate(DrawingObjects.HorizontalLinesCoordinates[i]);
                            e.Graphics.DrawLine(_fixedLinePen, rect.Left, y, rect.Right, y);
                        }

                        if (_isDrawingInProgress && CurrentDrawingMode == DrawingMode.HorizontalLine)
                            e.Graphics.DrawLine(_drawingLinePen, rect.Left, _drawingEndPoint.Y, rect.Right, _drawingEndPoint.Y);

                        #endregion
                    }
                }

                Redrawn?.Invoke(this, e);
            }
        }

        private void PictureBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && _isDrawingInProgress)
            {
                if (_selectedVerticalLineIndex.HasValue)
                {
                    DrawingObjects.VerticalLinesCoordinates.RemoveAt(_selectedVerticalLineIndex.Value);
                    _selectedVerticalLineIndex = null;
                    _isDrawingInProgress = false;
                    PictureBox.Invalidate();
                }

                if (_selectedHorizontalLineIndex.HasValue)
                {
                    DrawingObjects.HorizontalLinesCoordinates.RemoveAt(_selectedHorizontalLineIndex.Value);
                    _selectedHorizontalLineIndex = null;
                    _isDrawingInProgress = false;
                    PictureBox.Invalidate();
                }
            }

            if (e.KeyCode == Keys.Escape && _isDrawingInProgress)
            {
                ClearDrawingHelpingObjects();
                PictureBox.Invalidate();
            }                
        }

        #endregion
    }    
}