namespace TableOcrExtractor.Controls.TestsApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TableOcrExtractor.Controls.Model.DrawingObjects drawingObjects3 = new TableOcrExtractor.Controls.Model.DrawingObjects();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.ZoomNormalBtn = new System.Windows.Forms.Button();
            this.ZoomOutBtn = new System.Windows.Forms.Button();
            this.ZoomInBtn = new System.Windows.Forms.Button();
            this.ImageViewer = new TableOcrExtractor.Controls.ImageViewer();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.LoadBtn);
            this.panel1.Controls.Add(this.ZoomNormalBtn);
            this.panel1.Controls.Add(this.ZoomOutBtn);
            this.panel1.Controls.Add(this.ZoomInBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(693, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(69, 494);
            this.panel1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(4, 133);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Rectang.";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "None";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoadBtn
            // 
            this.LoadBtn.Location = new System.Drawing.Point(4, 459);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(62, 23);
            this.LoadBtn.TabIndex = 3;
            this.LoadBtn.Text = "Load";
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // ZoomNormalBtn
            // 
            this.ZoomNormalBtn.Location = new System.Drawing.Point(3, 61);
            this.ZoomNormalBtn.Name = "ZoomNormalBtn";
            this.ZoomNormalBtn.Size = new System.Drawing.Size(63, 23);
            this.ZoomNormalBtn.TabIndex = 2;
            this.ZoomNormalBtn.Text = "ZoomN";
            this.ZoomNormalBtn.UseVisualStyleBackColor = true;
            this.ZoomNormalBtn.Click += new System.EventHandler(this.ZoomNormalBtn_Click);
            // 
            // ZoomOutBtn
            // 
            this.ZoomOutBtn.Location = new System.Drawing.Point(3, 32);
            this.ZoomOutBtn.Name = "ZoomOutBtn";
            this.ZoomOutBtn.Size = new System.Drawing.Size(63, 23);
            this.ZoomOutBtn.TabIndex = 1;
            this.ZoomOutBtn.Text = "ZoomOut";
            this.ZoomOutBtn.UseVisualStyleBackColor = true;
            this.ZoomOutBtn.Click += new System.EventHandler(this.ZoomOutBtn_Click);
            // 
            // ZoomInBtn
            // 
            this.ZoomInBtn.Location = new System.Drawing.Point(3, 3);
            this.ZoomInBtn.Name = "ZoomInBtn";
            this.ZoomInBtn.Size = new System.Drawing.Size(63, 23);
            this.ZoomInBtn.TabIndex = 0;
            this.ZoomInBtn.Text = "ZoomIn";
            this.ZoomInBtn.UseVisualStyleBackColor = true;
            this.ZoomInBtn.Click += new System.EventHandler(this.ZoomInBtn_Click);
            // 
            // ImageViewer
            // 
            this.ImageViewer.AutoScroll = true;
            this.ImageViewer.CurrentDrawingMode = TableOcrExtractor.Controls.Enums.DrawingMode.None;
            this.ImageViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            drawingObjects3.MaxNumberOfVerticalLines = 1;
            drawingObjects3.RectangleArea = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.ImageViewer.DrawingObjects = drawingObjects3;
            this.ImageViewer.Image = null;
            this.ImageViewer.Location = new System.Drawing.Point(0, 0);
            this.ImageViewer.Name = "ImageViewer";
            this.ImageViewer.Size = new System.Drawing.Size(762, 494);
            this.ImageViewer.TabIndex = 0;
            this.ImageViewer.ZoomStep = 2.5D;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(4, 162);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(62, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Vertical";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(4, 191);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(62, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Horizontal";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 494);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ImageViewer);
            this.Name = "MainForm";
            this.Text = "Controls test application";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ImageViewer ImageViewer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ZoomNormalBtn;
        private System.Windows.Forms.Button ZoomOutBtn;
        private System.Windows.Forms.Button ZoomInBtn;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
    }
}

