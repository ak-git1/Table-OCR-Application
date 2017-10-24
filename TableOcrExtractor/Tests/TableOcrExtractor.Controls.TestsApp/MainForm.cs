using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TableOcrExtractor.Controls.Enums;

namespace TableOcrExtractor.Controls.TestsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            ImageViewer.Image = Image.FromFile(@"d:\Current\samples\IMG_000001.jpg");
            ImageViewer.DrawingObjects.MaxNumberOfVerticalLines = 3;
        }

        private void ZoomNormalBtn_Click(object sender, EventArgs e)
        {
            ImageViewer.FitImage();
        }

        private void ZoomInBtn_Click(object sender, EventArgs e)
        {
            ImageViewer.ZoomIn();
        }

        private void ZoomOutBtn_Click(object sender, EventArgs e)
        {
            ImageViewer.ZoomOut();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ImageViewer.CurrentDrawingMode = DrawingMode.None;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ImageViewer.CurrentDrawingMode = DrawingMode.Rectangle;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ImageViewer.CurrentDrawingMode = DrawingMode.VerticalLine;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ImageViewer.CurrentDrawingMode = DrawingMode.HorizontalLine;
        }
    }
}
