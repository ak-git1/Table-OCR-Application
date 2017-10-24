namespace TableOcrExtractor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.windows7Theme = new Telerik.WinControls.Themes.Windows7Theme();
            this.FileMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.NewProjectMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.OpenProjectMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.SeparatorItem1 = new Telerik.WinControls.UI.RadMenuSeparatorItem();
            this.SaveMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.SaveAsMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.SeparatorItem2 = new Telerik.WinControls.UI.RadMenuSeparatorItem();
            this.ExitMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.AboutMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.MainMenu = new Telerik.WinControls.UI.RadMenu();
            this.ProjectMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.SettingsMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.LanguageMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.EnglishLanguageMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.RussianLanguageMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.MainSplitContainer = new Telerik.WinControls.UI.RadSplitContainer();
            this.GallerySplitPanel = new Telerik.WinControls.UI.SplitPanel();
            this.GalleryListView = new Telerik.WinControls.UI.RadListView();
            this.GalleryCommandsPanel = new Telerik.WinControls.UI.RadPanel();
            this.RemoveImagesBtn = new Telerik.WinControls.UI.RadButton();
            this.AddImagesBtn = new Telerik.WinControls.UI.RadButton();
            this.ImageAndDataGridSplitPanel = new Telerik.WinControls.UI.SplitPanel();
            this.ImageSplitContainer = new Telerik.WinControls.UI.RadSplitContainer();
            this.GalleryImageSplitPanel = new Telerik.WinControls.UI.SplitPanel();
            this.ImageViewer = new TableOcrExtractor.Controls.ImageViewer();
            this.ImageCommandsPanel = new Telerik.WinControls.UI.RadPanel();
            this.radButton7 = new Telerik.WinControls.UI.RadButton();
            this.radButton6 = new Telerik.WinControls.UI.RadButton();
            this.radButton5 = new Telerik.WinControls.UI.RadButton();
            this.radButton4 = new Telerik.WinControls.UI.RadButton();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.radButton3 = new Telerik.WinControls.UI.RadButton();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.DataGridSplitPanel = new Telerik.WinControls.UI.SplitPanel();
            this.StatusStrip = new Telerik.WinControls.UI.RadStatusStrip();
            this.ProjectNameLabelElement = new Telerik.WinControls.UI.RadLabelElement();
            this.OpenProjectFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ImagesImportFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.MainMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).BeginInit();
            this.MainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GallerySplitPanel)).BeginInit();
            this.GallerySplitPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GalleryListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GalleryCommandsPanel)).BeginInit();
            this.GalleryCommandsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RemoveImagesBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddImagesBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageAndDataGridSplitPanel)).BeginInit();
            this.ImageAndDataGridSplitPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageSplitContainer)).BeginInit();
            this.ImageSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GalleryImageSplitPanel)).BeginInit();
            this.GalleryImageSplitPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageCommandsPanel)).BeginInit();
            this.ImageCommandsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridSplitPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusStrip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // FileMenuItem
            // 
            resources.ApplyResources(this.FileMenuItem, "FileMenuItem");
            this.FileMenuItem.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.NewProjectMenuItem,
            this.OpenProjectMenuItem,
            this.SeparatorItem1,
            this.SaveMenuItem,
            this.SaveAsMenuItem,
            this.SeparatorItem2,
            this.ExitMenuItem});
            this.FileMenuItem.Name = "FileMenuItem";
            // 
            // NewProjectMenuItem
            // 
            resources.ApplyResources(this.NewProjectMenuItem, "NewProjectMenuItem");
            this.NewProjectMenuItem.Name = "NewProjectMenuItem";
            this.NewProjectMenuItem.Click += new System.EventHandler(this.NewProjectMenuItem_Click);
            // 
            // OpenProjectMenuItem
            // 
            resources.ApplyResources(this.OpenProjectMenuItem, "OpenProjectMenuItem");
            this.OpenProjectMenuItem.Name = "OpenProjectMenuItem";
            this.OpenProjectMenuItem.Click += new System.EventHandler(this.OpenProjectMenuItem_Click);
            // 
            // SeparatorItem1
            // 
            resources.ApplyResources(this.SeparatorItem1, "SeparatorItem1");
            this.SeparatorItem1.Name = "SeparatorItem1";
            // 
            // SaveMenuItem
            // 
            resources.ApplyResources(this.SaveMenuItem, "SaveMenuItem");
            this.SaveMenuItem.Name = "SaveMenuItem";
            this.SaveMenuItem.Click += new System.EventHandler(this.SaveMenuItem_Click);
            // 
            // SaveAsMenuItem
            // 
            resources.ApplyResources(this.SaveAsMenuItem, "SaveAsMenuItem");
            this.SaveAsMenuItem.Name = "SaveAsMenuItem";
            this.SaveAsMenuItem.Click += new System.EventHandler(this.SaveAsMenuItem_Click);
            // 
            // SeparatorItem2
            // 
            resources.ApplyResources(this.SeparatorItem2, "SeparatorItem2");
            this.SeparatorItem2.Name = "SeparatorItem2";
            // 
            // ExitMenuItem
            // 
            resources.ApplyResources(this.ExitMenuItem, "ExitMenuItem");
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // AboutMenuItem
            // 
            resources.ApplyResources(this.AboutMenuItem, "AboutMenuItem");
            this.AboutMenuItem.Name = "AboutMenuItem";
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.FileMenuItem,
            this.ProjectMenuItem,
            this.SettingsMenuItem,
            this.AboutMenuItem});
            resources.ApplyResources(this.MainMenu, "MainMenu");
            this.MainMenu.Name = "MainMenu";
            // 
            // 
            // 
            this.MainMenu.RootElement.AutoSize = false;
            this.MainMenu.RootElement.FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentBounds;
            ((Telerik.WinControls.UI.RadMenuElement)(this.MainMenu.GetChildAt(0))).AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            // 
            // ProjectMenuItem
            // 
            resources.ApplyResources(this.ProjectMenuItem, "ProjectMenuItem");
            this.ProjectMenuItem.Name = "ProjectMenuItem";
            // 
            // SettingsMenuItem
            // 
            resources.ApplyResources(this.SettingsMenuItem, "SettingsMenuItem");
            this.SettingsMenuItem.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.LanguageMenuItem});
            this.SettingsMenuItem.Name = "SettingsMenuItem";
            // 
            // LanguageMenuItem
            // 
            resources.ApplyResources(this.LanguageMenuItem, "LanguageMenuItem");
            this.LanguageMenuItem.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.EnglishLanguageMenuItem,
            this.RussianLanguageMenuItem});
            this.LanguageMenuItem.Name = "LanguageMenuItem";
            // 
            // EnglishLanguageMenuItem
            // 
            resources.ApplyResources(this.EnglishLanguageMenuItem, "EnglishLanguageMenuItem");
            this.EnglishLanguageMenuItem.Name = "EnglishLanguageMenuItem";
            this.EnglishLanguageMenuItem.Click += new System.EventHandler(this.EnglishLanguageMenuItem_Click);
            // 
            // RussianLanguageMenuItem
            // 
            resources.ApplyResources(this.RussianLanguageMenuItem, "RussianLanguageMenuItem");
            this.RussianLanguageMenuItem.Name = "RussianLanguageMenuItem";
            this.RussianLanguageMenuItem.Click += new System.EventHandler(this.RussianLanguageMenuItem_Click);
            // 
            // MainSplitContainer
            // 
            this.MainSplitContainer.Controls.Add(this.GallerySplitPanel);
            this.MainSplitContainer.Controls.Add(this.ImageAndDataGridSplitPanel);
            resources.ApplyResources(this.MainSplitContainer, "MainSplitContainer");
            this.MainSplitContainer.Name = "MainSplitContainer";
            // 
            // 
            // 
            this.MainSplitContainer.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.MainSplitContainer.TabStop = false;
            // 
            // GallerySplitPanel
            // 
            this.GallerySplitPanel.Controls.Add(this.GalleryListView);
            this.GallerySplitPanel.Controls.Add(this.GalleryCommandsPanel);
            resources.ApplyResources(this.GallerySplitPanel, "GallerySplitPanel");
            this.GallerySplitPanel.Name = "GallerySplitPanel";
            // 
            // 
            // 
            this.GallerySplitPanel.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.GallerySplitPanel.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(-0.319838F, 0F);
            this.GallerySplitPanel.SizeInfo.SplitterCorrection = new System.Drawing.Size(-243, 0);
            this.GallerySplitPanel.TabStop = false;
            // 
            // GalleryListView
            // 
            this.GalleryListView.AllowArbitraryItemHeight = true;
            this.GalleryListView.AllowArbitraryItemWidth = true;
            this.GalleryListView.AllowColumnReorder = false;
            this.GalleryListView.AllowColumnResize = false;
            this.GalleryListView.AllowEdit = false;
            this.GalleryListView.DisplayMember = "OrderNumber";
            resources.ApplyResources(this.GalleryListView, "GalleryListView");
            this.GalleryListView.EnableAnalytics = false;
            this.GalleryListView.EnableGestures = false;
            this.GalleryListView.ItemSize = new System.Drawing.Size(150, 20);
            this.GalleryListView.Name = "GalleryListView";
            this.GalleryListView.ShowColumnHeaders = false;
            this.GalleryListView.ValueMember = "Uid";
            this.GalleryListView.SelectedItemChanged += new System.EventHandler(this.GalleryListView_SelectedItemChanged);
            this.GalleryListView.ItemDataBound += new Telerik.WinControls.UI.ListViewItemEventHandler(this.GalleryListView_ItemDataBound);
            // 
            // GalleryCommandsPanel
            // 
            this.GalleryCommandsPanel.BackColor = System.Drawing.SystemColors.MenuBar;
            this.GalleryCommandsPanel.Controls.Add(this.RemoveImagesBtn);
            this.GalleryCommandsPanel.Controls.Add(this.AddImagesBtn);
            resources.ApplyResources(this.GalleryCommandsPanel, "GalleryCommandsPanel");
            this.GalleryCommandsPanel.Name = "GalleryCommandsPanel";
            // 
            // RemoveImagesBtn
            // 
            resources.ApplyResources(this.RemoveImagesBtn, "RemoveImagesBtn");
            this.RemoveImagesBtn.Image = global::TableOcrExtractor.Properties.Resources.remove;
            this.RemoveImagesBtn.Name = "RemoveImagesBtn";
            this.RemoveImagesBtn.Click += new System.EventHandler(this.RemoveImagesBtn_Click);
            // 
            // AddImagesBtn
            // 
            resources.ApplyResources(this.AddImagesBtn, "AddImagesBtn");
            this.AddImagesBtn.Image = global::TableOcrExtractor.Properties.Resources.add;
            this.AddImagesBtn.Name = "AddImagesBtn";
            this.AddImagesBtn.Click += new System.EventHandler(this.AddImagesBtn_Click);
            // 
            // ImageAndDataGridSplitPanel
            // 
            this.ImageAndDataGridSplitPanel.Controls.Add(this.ImageSplitContainer);
            resources.ApplyResources(this.ImageAndDataGridSplitPanel, "ImageAndDataGridSplitPanel");
            this.ImageAndDataGridSplitPanel.Name = "ImageAndDataGridSplitPanel";
            // 
            // 
            // 
            this.ImageAndDataGridSplitPanel.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.ImageAndDataGridSplitPanel.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(0.319838F, 0F);
            this.ImageAndDataGridSplitPanel.SizeInfo.SplitterCorrection = new System.Drawing.Size(243, 0);
            this.ImageAndDataGridSplitPanel.TabStop = false;
            // 
            // ImageSplitContainer
            // 
            this.ImageSplitContainer.Controls.Add(this.GalleryImageSplitPanel);
            this.ImageSplitContainer.Controls.Add(this.DataGridSplitPanel);
            resources.ApplyResources(this.ImageSplitContainer, "ImageSplitContainer");
            this.ImageSplitContainer.Name = "ImageSplitContainer";
            // 
            // 
            // 
            this.ImageSplitContainer.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.ImageSplitContainer.TabStop = false;
            // 
            // GalleryImageSplitPanel
            // 
            this.GalleryImageSplitPanel.Controls.Add(this.ImageViewer);
            this.GalleryImageSplitPanel.Controls.Add(this.ImageCommandsPanel);
            resources.ApplyResources(this.GalleryImageSplitPanel, "GalleryImageSplitPanel");
            this.GalleryImageSplitPanel.Name = "GalleryImageSplitPanel";
            // 
            // 
            // 
            this.GalleryImageSplitPanel.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.GalleryImageSplitPanel.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(0F, 0.1467533F);
            this.GalleryImageSplitPanel.SizeInfo.SplitterCorrection = new System.Drawing.Size(0, 57);
            this.GalleryImageSplitPanel.TabStop = false;
            // 
            // ImageViewer
            // 
            resources.ApplyResources(this.ImageViewer, "ImageViewer");
            this.ImageViewer.CurrentDrawingMode = TableOcrExtractor.Controls.Enums.DrawingMode.None;
            this.ImageViewer.DrawingObjects = ((TableOcrExtractor.Controls.Model.DrawingObjects)(resources.GetObject("ImageViewer.DrawingObjects")));
            this.ImageViewer.Image = null;
            this.ImageViewer.Name = "ImageViewer";
            this.ImageViewer.ZoomStep = 2.5D;
            // 
            // ImageCommandsPanel
            // 
            this.ImageCommandsPanel.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ImageCommandsPanel.Controls.Add(this.radButton7);
            this.ImageCommandsPanel.Controls.Add(this.radButton6);
            this.ImageCommandsPanel.Controls.Add(this.radButton5);
            this.ImageCommandsPanel.Controls.Add(this.radButton4);
            this.ImageCommandsPanel.Controls.Add(this.radPanel1);
            this.ImageCommandsPanel.Controls.Add(this.radButton3);
            this.ImageCommandsPanel.Controls.Add(this.radButton2);
            this.ImageCommandsPanel.Controls.Add(this.radButton1);
            resources.ApplyResources(this.ImageCommandsPanel, "ImageCommandsPanel");
            this.ImageCommandsPanel.Name = "ImageCommandsPanel";
            // 
            // radButton7
            // 
            resources.ApplyResources(this.radButton7, "radButton7");
            this.radButton7.Image = global::TableOcrExtractor.Properties.Resources.add;
            this.radButton7.Name = "radButton7";
            // 
            // radButton6
            // 
            resources.ApplyResources(this.radButton6, "radButton6");
            this.radButton6.Image = global::TableOcrExtractor.Properties.Resources.add;
            this.radButton6.Name = "radButton6";
            // 
            // radButton5
            // 
            resources.ApplyResources(this.radButton5, "radButton5");
            this.radButton5.Image = global::TableOcrExtractor.Properties.Resources.add;
            this.radButton5.Name = "radButton5";
            // 
            // radButton4
            // 
            resources.ApplyResources(this.radButton4, "radButton4");
            this.radButton4.Image = global::TableOcrExtractor.Properties.Resources.add;
            this.radButton4.Name = "radButton4";
            // 
            // radPanel1
            // 
            this.radPanel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            resources.ApplyResources(this.radPanel1, "radPanel1");
            this.radPanel1.Name = "radPanel1";
            // 
            // radButton3
            // 
            resources.ApplyResources(this.radButton3, "radButton3");
            this.radButton3.Image = global::TableOcrExtractor.Properties.Resources.add;
            this.radButton3.Name = "radButton3";
            // 
            // radButton2
            // 
            resources.ApplyResources(this.radButton2, "radButton2");
            this.radButton2.Image = global::TableOcrExtractor.Properties.Resources.add;
            this.radButton2.Name = "radButton2";
            // 
            // radButton1
            // 
            resources.ApplyResources(this.radButton1, "radButton1");
            this.radButton1.Image = global::TableOcrExtractor.Properties.Resources.add;
            this.radButton1.Name = "radButton1";
            // 
            // DataGridSplitPanel
            // 
            resources.ApplyResources(this.DataGridSplitPanel, "DataGridSplitPanel");
            this.DataGridSplitPanel.Name = "DataGridSplitPanel";
            // 
            // 
            // 
            this.DataGridSplitPanel.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.DataGridSplitPanel.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(0F, -0.1467533F);
            this.DataGridSplitPanel.SizeInfo.SplitterCorrection = new System.Drawing.Size(0, -57);
            this.DataGridSplitPanel.TabStop = false;
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.ProjectNameLabelElement});
            resources.ApplyResources(this.StatusStrip, "StatusStrip");
            this.StatusStrip.Name = "StatusStrip";
            // 
            // ProjectNameLabelElement
            // 
            resources.ApplyResources(this.ProjectNameLabelElement, "ProjectNameLabelElement");
            this.ProjectNameLabelElement.Name = "ProjectNameLabelElement";
            this.StatusStrip.SetSpring(this.ProjectNameLabelElement, false);
            this.ProjectNameLabelElement.TextWrap = true;
            // 
            // ImagesImportFileDialog
            // 
            this.ImagesImportFileDialog.Multiselect = true;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainSplitContainer);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.StatusStrip);
            this.Name = "MainForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ThemeName = "Windows7";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).EndInit();
            this.MainSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GallerySplitPanel)).EndInit();
            this.GallerySplitPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GalleryListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GalleryCommandsPanel)).EndInit();
            this.GalleryCommandsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RemoveImagesBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddImagesBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageAndDataGridSplitPanel)).EndInit();
            this.ImageAndDataGridSplitPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImageSplitContainer)).EndInit();
            this.ImageSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GalleryImageSplitPanel)).EndInit();
            this.GalleryImageSplitPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImageCommandsPanel)).EndInit();
            this.ImageCommandsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radButton7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridSplitPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusStrip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.Themes.Windows7Theme windows7Theme;
        private Telerik.WinControls.UI.RadMenuItem FileMenuItem;
        private Telerik.WinControls.UI.RadMenuItem NewProjectMenuItem;
        private Telerik.WinControls.UI.RadMenuSeparatorItem SeparatorItem1;
        private Telerik.WinControls.UI.RadMenuItem ExitMenuItem;
        private Telerik.WinControls.UI.RadMenuItem AboutMenuItem;
        private Telerik.WinControls.UI.RadMenuItem OpenProjectMenuItem;
        private Telerik.WinControls.UI.RadMenu MainMenu;
        private Telerik.WinControls.UI.RadMenuItem SettingsMenuItem;
        private Telerik.WinControls.UI.RadMenuItem LanguageMenuItem;
        private Telerik.WinControls.UI.RadMenuItem EnglishLanguageMenuItem;
        private Telerik.WinControls.UI.RadMenuItem RussianLanguageMenuItem;
        private Telerik.WinControls.UI.RadSplitContainer MainSplitContainer;
        private Telerik.WinControls.UI.SplitPanel GallerySplitPanel;
        private Telerik.WinControls.UI.SplitPanel ImageAndDataGridSplitPanel;
        private Telerik.WinControls.UI.RadSplitContainer ImageSplitContainer;
        private Telerik.WinControls.UI.SplitPanel GalleryImageSplitPanel;
        private Telerik.WinControls.UI.SplitPanel DataGridSplitPanel;
        private Telerik.WinControls.UI.RadStatusStrip StatusStrip;
        private Telerik.WinControls.UI.RadMenuSeparatorItem SeparatorItem2;
        private Telerik.WinControls.UI.RadMenuItem SaveMenuItem;
        private Telerik.WinControls.UI.RadMenuItem SaveAsMenuItem;
        private System.Windows.Forms.OpenFileDialog OpenProjectFileDialog;
        private Telerik.WinControls.UI.RadMenuItem ProjectMenuItem;
        private Telerik.WinControls.UI.RadLabelElement ProjectNameLabelElement;
        private System.Windows.Forms.OpenFileDialog ImagesImportFileDialog;
        private Telerik.WinControls.UI.RadListView GalleryListView;
        private Controls.ImageViewer ImageViewer;
        private Telerik.WinControls.UI.RadPanel ImageCommandsPanel;
        private Telerik.WinControls.UI.RadPanel GalleryCommandsPanel;
        private Telerik.WinControls.UI.RadButton AddImagesBtn;
        private Telerik.WinControls.UI.RadButton RemoveImagesBtn;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadButton radButton3;
        private Telerik.WinControls.UI.RadButton radButton2;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadButton radButton7;
        private Telerik.WinControls.UI.RadButton radButton6;
        private Telerik.WinControls.UI.RadButton radButton5;
        private Telerik.WinControls.UI.RadButton radButton4;
    }
}

