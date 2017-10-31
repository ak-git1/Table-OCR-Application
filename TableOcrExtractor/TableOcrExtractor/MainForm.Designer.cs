using System;
using Telerik.WinControls.UI;

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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
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
            this.ProjectMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.StartOcrMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.ExportDataMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.SeparatorItem3 = new Telerik.WinControls.UI.RadMenuSeparatorItem();
            this.ProjectDataColumnsMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.ProjectSettingsMenuItem = new Telerik.WinControls.UI.RadMenuItem();
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
            this.PasteDrawingObjectsBtn = new Telerik.WinControls.UI.RadButton();
            this.CopyDrawingObjectsBtn = new Telerik.WinControls.UI.RadButton();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.DrawingModeHorizontalLinesBtn = new Telerik.WinControls.UI.RadButton();
            this.DrawingModeVerticalLinesBtn = new Telerik.WinControls.UI.RadButton();
            this.DrawingModeRectangleBtn = new Telerik.WinControls.UI.RadButton();
            this.DrawingModeNoneBtn = new Telerik.WinControls.UI.RadButton();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.ZoomFitBtn = new Telerik.WinControls.UI.RadButton();
            this.ZoomOutBtn = new Telerik.WinControls.UI.RadButton();
            this.ZoomInBtn = new Telerik.WinControls.UI.RadButton();
            this.DataGridSplitPanel = new Telerik.WinControls.UI.SplitPanel();
            this.DataGrid = new Telerik.WinControls.UI.RadGridView();
            this.StatusStrip = new Telerik.WinControls.UI.RadStatusStrip();
            this.ProjectNameLabelElement = new Telerik.WinControls.UI.RadLabelElement();
            this.OpenProjectFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ImagesImportFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.MainMenu = new Telerik.WinControls.UI.RadMenu();
            this.ExportDataFileDialog = new System.Windows.Forms.SaveFileDialog();
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
            ((System.ComponentModel.ISupportInitialize)(this.PasteDrawingObjectsBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CopyDrawingObjectsBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrawingModeHorizontalLinesBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrawingModeVerticalLinesBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrawingModeRectangleBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrawingModeNoneBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZoomFitBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZoomOutBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZoomInBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridSplitPanel)).BeginInit();
            this.DataGridSplitPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusStrip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainMenu)).BeginInit();
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
            this.SaveAsMenuItem.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
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
            this.AboutMenuItem.Click += new System.EventHandler(this.AboutMenuItem_Click);
            // 
            // ProjectMenuItem
            // 
            resources.ApplyResources(this.ProjectMenuItem, "ProjectMenuItem");
            this.ProjectMenuItem.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.StartOcrMenuItem,
            this.ExportDataMenuItem,
            this.SeparatorItem3,
            this.ProjectDataColumnsMenuItem,
            this.ProjectSettingsMenuItem});
            this.ProjectMenuItem.Name = "ProjectMenuItem";
            // 
            // StartOcrMenuItem
            // 
            this.StartOcrMenuItem.Name = "StartOcrMenuItem";
            resources.ApplyResources(this.StartOcrMenuItem, "StartOcrMenuItem");
            this.StartOcrMenuItem.Click += new System.EventHandler(this.StartOcrMenuItem_Click);
            // 
            // ExportDataMenuItem
            // 
            this.ExportDataMenuItem.Name = "ExportDataMenuItem";
            resources.ApplyResources(this.ExportDataMenuItem, "ExportDataMenuItem");
            this.ExportDataMenuItem.Click += new System.EventHandler(this.ExportDataMenuItem_Click);
            // 
            // SeparatorItem3
            // 
            this.SeparatorItem3.Name = "SeparatorItem3";
            resources.ApplyResources(this.SeparatorItem3, "SeparatorItem3");
            // 
            // ProjectDataColumnsMenuItem
            // 
            this.ProjectDataColumnsMenuItem.Name = "ProjectDataColumnsMenuItem";
            resources.ApplyResources(this.ProjectDataColumnsMenuItem, "ProjectDataColumnsMenuItem");
            this.ProjectDataColumnsMenuItem.Click += new System.EventHandler(this.ProjectDataColumnsMenuItem_Click);
            // 
            // ProjectSettingsMenuItem
            // 
            this.ProjectSettingsMenuItem.Name = "ProjectSettingsMenuItem";
            resources.ApplyResources(this.ProjectSettingsMenuItem, "ProjectSettingsMenuItem");
            this.ProjectSettingsMenuItem.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            this.ProjectSettingsMenuItem.Click += new System.EventHandler(this.ProjectSettingsMenuItem_Click);
            // 
            // SettingsMenuItem
            // 
            resources.ApplyResources(this.SettingsMenuItem, "SettingsMenuItem");
            this.SettingsMenuItem.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.LanguageMenuItem});
            this.SettingsMenuItem.Name = "SettingsMenuItem";
            this.SettingsMenuItem.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
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
            this.GalleryListView.AllowRemove = false;
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
            this.ImageViewer.Redrawn += new System.EventHandler(this.ImageViewer_Redrawn);
            // 
            // ImageCommandsPanel
            // 
            this.ImageCommandsPanel.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ImageCommandsPanel.Controls.Add(this.PasteDrawingObjectsBtn);
            this.ImageCommandsPanel.Controls.Add(this.CopyDrawingObjectsBtn);
            this.ImageCommandsPanel.Controls.Add(this.radPanel2);
            this.ImageCommandsPanel.Controls.Add(this.DrawingModeHorizontalLinesBtn);
            this.ImageCommandsPanel.Controls.Add(this.DrawingModeVerticalLinesBtn);
            this.ImageCommandsPanel.Controls.Add(this.DrawingModeRectangleBtn);
            this.ImageCommandsPanel.Controls.Add(this.DrawingModeNoneBtn);
            this.ImageCommandsPanel.Controls.Add(this.radPanel1);
            this.ImageCommandsPanel.Controls.Add(this.ZoomFitBtn);
            this.ImageCommandsPanel.Controls.Add(this.ZoomOutBtn);
            this.ImageCommandsPanel.Controls.Add(this.ZoomInBtn);
            resources.ApplyResources(this.ImageCommandsPanel, "ImageCommandsPanel");
            this.ImageCommandsPanel.Name = "ImageCommandsPanel";
            // 
            // PasteDrawingObjectsBtn
            // 
            resources.ApplyResources(this.PasteDrawingObjectsBtn, "PasteDrawingObjectsBtn");
            this.PasteDrawingObjectsBtn.Image = global::TableOcrExtractor.Properties.Resources.paste;
            this.PasteDrawingObjectsBtn.Name = "PasteDrawingObjectsBtn";
            this.PasteDrawingObjectsBtn.Click += new System.EventHandler(this.PasteDrawingObjectsBtn_Click);
            // 
            // CopyDrawingObjectsBtn
            // 
            resources.ApplyResources(this.CopyDrawingObjectsBtn, "CopyDrawingObjectsBtn");
            this.CopyDrawingObjectsBtn.Image = global::TableOcrExtractor.Properties.Resources.copy;
            this.CopyDrawingObjectsBtn.Name = "CopyDrawingObjectsBtn";
            this.CopyDrawingObjectsBtn.Click += new System.EventHandler(this.CopyDrawingObjectsBtn_Click);
            // 
            // radPanel2
            // 
            this.radPanel2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            resources.ApplyResources(this.radPanel2, "radPanel2");
            this.radPanel2.Name = "radPanel2";
            // 
            // DrawingModeHorizontalLinesBtn
            // 
            resources.ApplyResources(this.DrawingModeHorizontalLinesBtn, "DrawingModeHorizontalLinesBtn");
            this.DrawingModeHorizontalLinesBtn.Image = global::TableOcrExtractor.Properties.Resources.draw_horizontal_line;
            this.DrawingModeHorizontalLinesBtn.Name = "DrawingModeHorizontalLinesBtn";
            this.DrawingModeHorizontalLinesBtn.Click += new System.EventHandler(this.DrawingModeHorizontalLinesBtn_Click);
            // 
            // DrawingModeVerticalLinesBtn
            // 
            resources.ApplyResources(this.DrawingModeVerticalLinesBtn, "DrawingModeVerticalLinesBtn");
            this.DrawingModeVerticalLinesBtn.Image = global::TableOcrExtractor.Properties.Resources.draw_vertical_line;
            this.DrawingModeVerticalLinesBtn.Name = "DrawingModeVerticalLinesBtn";
            this.DrawingModeVerticalLinesBtn.Click += new System.EventHandler(this.DrawingModeVerticalLinesBtn_Click);
            // 
            // DrawingModeRectangleBtn
            // 
            resources.ApplyResources(this.DrawingModeRectangleBtn, "DrawingModeRectangleBtn");
            this.DrawingModeRectangleBtn.Image = global::TableOcrExtractor.Properties.Resources.draw_rectangle;
            this.DrawingModeRectangleBtn.Name = "DrawingModeRectangleBtn";
            this.DrawingModeRectangleBtn.Click += new System.EventHandler(this.DrawingModeRectangleBtn_Click);
            // 
            // DrawingModeNoneBtn
            // 
            resources.ApplyResources(this.DrawingModeNoneBtn, "DrawingModeNoneBtn");
            this.DrawingModeNoneBtn.Image = global::TableOcrExtractor.Properties.Resources.cancel;
            this.DrawingModeNoneBtn.Name = "DrawingModeNoneBtn";
            this.DrawingModeNoneBtn.Click += new System.EventHandler(this.DrawingModeNoneBtn_Click);
            // 
            // radPanel1
            // 
            this.radPanel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            resources.ApplyResources(this.radPanel1, "radPanel1");
            this.radPanel1.Name = "radPanel1";
            // 
            // ZoomFitBtn
            // 
            resources.ApplyResources(this.ZoomFitBtn, "ZoomFitBtn");
            this.ZoomFitBtn.Image = global::TableOcrExtractor.Properties.Resources.zoom_best_fit;
            this.ZoomFitBtn.Name = "ZoomFitBtn";
            this.ZoomFitBtn.Click += new System.EventHandler(this.ZoomFitBtn_Click);
            // 
            // ZoomOutBtn
            // 
            resources.ApplyResources(this.ZoomOutBtn, "ZoomOutBtn");
            this.ZoomOutBtn.Image = global::TableOcrExtractor.Properties.Resources.zoom_out;
            this.ZoomOutBtn.Name = "ZoomOutBtn";
            this.ZoomOutBtn.Click += new System.EventHandler(this.ZoomOutBtn_Click);
            // 
            // ZoomInBtn
            // 
            resources.ApplyResources(this.ZoomInBtn, "ZoomInBtn");
            this.ZoomInBtn.Image = global::TableOcrExtractor.Properties.Resources.zoom_in;
            this.ZoomInBtn.Name = "ZoomInBtn";
            this.ZoomInBtn.Click += new System.EventHandler(this.ZoomInBtn_Click);
            // 
            // DataGridSplitPanel
            // 
            this.DataGridSplitPanel.Controls.Add(this.DataGrid);
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
            // DataGrid
            // 
            this.DataGrid.AutoSizeRows = true;
            resources.ApplyResources(this.DataGrid, "DataGrid");
            this.DataGrid.EnableGestures = false;
            // 
            // 
            // 
            this.DataGrid.MasterTemplate.AllowAddNewRow = false;
            this.DataGrid.MasterTemplate.AllowCellContextMenu = false;
            this.DataGrid.MasterTemplate.AllowColumnReorder = false;
            this.DataGrid.MasterTemplate.AllowDeleteRow = false;
            this.DataGrid.MasterTemplate.AllowDragToGroup = false;
            this.DataGrid.MasterTemplate.AllowRowHeaderContextMenu = false;
            this.DataGrid.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.DataGrid.MasterTemplate.EnableFiltering = true;
            this.DataGrid.MasterTemplate.EnableGrouping = false;
            this.DataGrid.MasterTemplate.EnableSorting = false;
            this.DataGrid.MasterTemplate.MultiSelect = false;
            this.DataGrid.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.SelectionChanged += DataGridOnSelectionChanged;
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
            // ExportDataFileDialog
            // 
            resources.ApplyResources(this.ExportDataFileDialog, "ExportDataFileDialog");
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.PasteDrawingObjectsBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CopyDrawingObjectsBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrawingModeHorizontalLinesBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrawingModeVerticalLinesBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrawingModeRectangleBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrawingModeNoneBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZoomFitBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZoomOutBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZoomInBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridSplitPanel)).EndInit();
            this.DataGridSplitPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusStrip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainMenu)).EndInit();
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
        private Telerik.WinControls.UI.RadButton ZoomInBtn;
        private Telerik.WinControls.UI.RadButton ZoomFitBtn;
        private Telerik.WinControls.UI.RadButton ZoomOutBtn;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadButton DrawingModeHorizontalLinesBtn;
        private Telerik.WinControls.UI.RadButton DrawingModeVerticalLinesBtn;
        private Telerik.WinControls.UI.RadButton DrawingModeRectangleBtn;
        private Telerik.WinControls.UI.RadButton DrawingModeNoneBtn;
        private Telerik.WinControls.UI.RadMenuItem ProjectDataColumnsMenuItem;
        private Telerik.WinControls.UI.RadMenuItem ProjectSettingsMenuItem;
        private Telerik.WinControls.UI.RadGridView DataGrid;
        private Telerik.WinControls.UI.RadMenuSeparatorItem SeparatorItem3;
        private Telerik.WinControls.UI.RadMenuItem StartOcrMenuItem;
        private Telerik.WinControls.UI.RadMenuItem ExportDataMenuItem;
        private Telerik.WinControls.UI.RadMenu MainMenu;
        private System.Windows.Forms.SaveFileDialog ExportDataFileDialog;
        private Telerik.WinControls.UI.RadButton PasteDrawingObjectsBtn;
        private Telerik.WinControls.UI.RadButton CopyDrawingObjectsBtn;
        private Telerik.WinControls.UI.RadPanel radPanel2;
    }
}

