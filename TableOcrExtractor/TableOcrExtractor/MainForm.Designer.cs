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
            this.GalleryCommandBar = new Telerik.WinControls.UI.RadCommandBar();
            this.commandBarRowElement1 = new Telerik.WinControls.UI.CommandBarRowElement();
            this.commandBarStripElement1 = new Telerik.WinControls.UI.CommandBarStripElement();
            this.AddImagesBtn = new Telerik.WinControls.UI.CommandBarButton();
            this.commandBarRowElement3 = new Telerik.WinControls.UI.CommandBarRowElement();
            this.ImageAndDataGridSplitPanel = new Telerik.WinControls.UI.SplitPanel();
            this.ImageSplitContainer = new Telerik.WinControls.UI.RadSplitContainer();
            this.ImageSplitPanel = new Telerik.WinControls.UI.SplitPanel();
            this.ImageCommandBar = new Telerik.WinControls.UI.RadCommandBar();
            this.commandBarRowElement2 = new Telerik.WinControls.UI.CommandBarRowElement();
            this.commandBarStripElement2 = new Telerik.WinControls.UI.CommandBarStripElement();
            this.commandBarButton1 = new Telerik.WinControls.UI.CommandBarButton();
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
            ((System.ComponentModel.ISupportInitialize)(this.GalleryCommandBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageAndDataGridSplitPanel)).BeginInit();
            this.ImageAndDataGridSplitPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageSplitContainer)).BeginInit();
            this.ImageSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageSplitPanel)).BeginInit();
            this.ImageSplitPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageCommandBar)).BeginInit();
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
            this.GallerySplitPanel.Controls.Add(this.GalleryCommandBar);
            resources.ApplyResources(this.GallerySplitPanel, "GallerySplitPanel");
            this.GallerySplitPanel.Name = "GallerySplitPanel";
            // 
            // 
            // 
            this.GallerySplitPanel.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.GallerySplitPanel.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(-0.2661064F, 0F);
            this.GallerySplitPanel.SizeInfo.SplitterCorrection = new System.Drawing.Size(-190, 0);
            this.GallerySplitPanel.TabStop = false;
            // 
            // GalleryListView
            // 
            resources.ApplyResources(this.GalleryListView, "GalleryListView");
            this.GalleryListView.Name = "GalleryListView";
            // 
            // GalleryCommandBar
            // 
            resources.ApplyResources(this.GalleryCommandBar, "GalleryCommandBar");
            this.GalleryCommandBar.Name = "GalleryCommandBar";
            this.GalleryCommandBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.GalleryCommandBar.Rows.AddRange(new Telerik.WinControls.UI.CommandBarRowElement[] {
            this.commandBarRowElement1,
            this.commandBarRowElement3});
            // 
            // commandBarRowElement1
            // 
            resources.ApplyResources(this.commandBarRowElement1, "commandBarRowElement1");
            this.commandBarRowElement1.AutoSize = true;
            this.commandBarRowElement1.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarRowElement1.MinSize = new System.Drawing.Size(25, 25);
            this.commandBarRowElement1.Strips.AddRange(new Telerik.WinControls.UI.CommandBarStripElement[] {
            this.commandBarStripElement1});
            this.commandBarRowElement1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarRowElement1.UseCompatibleTextRendering = false;
            // 
            // commandBarStripElement1
            // 
            resources.ApplyResources(this.commandBarStripElement1, "commandBarStripElement1");
            this.commandBarStripElement1.AutoSize = true;
            this.commandBarStripElement1.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarStripElement1.GradientAngle = 450F;
            // 
            // 
            // 
            this.commandBarStripElement1.Grip.Alignment = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.Alignment")));
            this.commandBarStripElement1.Grip.AngleTransform = ((float)(resources.GetObject("resource.AngleTransform")));
            this.commandBarStripElement1.Grip.FlipText = ((bool)(resources.GetObject("resource.FlipText")));
            this.commandBarStripElement1.Grip.Margin = ((System.Windows.Forms.Padding)(resources.GetObject("resource.Margin")));
            this.commandBarStripElement1.Grip.Padding = ((System.Windows.Forms.Padding)(resources.GetObject("resource.Padding")));
            this.commandBarStripElement1.Grip.RightToLeft = ((bool)(resources.GetObject("resource.RightToLeft")));
            this.commandBarStripElement1.Grip.Text = resources.GetString("resource.Text");
            this.commandBarStripElement1.Grip.TextOrientation = ((System.Windows.Forms.Orientation)(resources.GetObject("resource.TextOrientation")));
            this.commandBarStripElement1.Grip.TextWrap = ((bool)(resources.GetObject("resource.TextWrap")));
            this.commandBarStripElement1.Items.AddRange(new Telerik.WinControls.UI.RadCommandBarBaseItem[] {
            this.AddImagesBtn});
            this.commandBarStripElement1.Name = "commandBarStripElement1";
            // 
            // 
            // 
            this.commandBarStripElement1.OverflowButton.Alignment = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.Alignment1")));
            this.commandBarStripElement1.OverflowButton.AngleTransform = ((float)(resources.GetObject("resource.AngleTransform1")));
            this.commandBarStripElement1.OverflowButton.Enabled = false;
            this.commandBarStripElement1.OverflowButton.FlipText = ((bool)(resources.GetObject("resource.FlipText1")));
            this.commandBarStripElement1.OverflowButton.Margin = ((System.Windows.Forms.Padding)(resources.GetObject("resource.Margin1")));
            this.commandBarStripElement1.OverflowButton.Padding = ((System.Windows.Forms.Padding)(resources.GetObject("resource.Padding1")));
            this.commandBarStripElement1.OverflowButton.RightToLeft = ((bool)(resources.GetObject("resource.RightToLeft1")));
            this.commandBarStripElement1.OverflowButton.Text = resources.GetString("resource.Text1");
            this.commandBarStripElement1.OverflowButton.TextOrientation = ((System.Windows.Forms.Orientation)(resources.GetObject("resource.TextOrientation1")));
            this.commandBarStripElement1.OverflowButton.TextWrap = ((bool)(resources.GetObject("resource.TextWrap1")));
            this.commandBarStripElement1.OverflowButton.Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            this.commandBarStripElement1.StretchVertically = false;
            this.commandBarStripElement1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarStripElement1.UseCompatibleTextRendering = false;
            ((Telerik.WinControls.UI.RadCommandBarGrip)(this.commandBarStripElement1.GetChildAt(0))).TextWrap = ((bool)(resources.GetObject("resource.TextWrap2")));
            ((Telerik.WinControls.UI.RadCommandBarGrip)(this.commandBarStripElement1.GetChildAt(0))).TextOrientation = ((System.Windows.Forms.Orientation)(resources.GetObject("resource.TextOrientation2")));
            ((Telerik.WinControls.UI.RadCommandBarGrip)(this.commandBarStripElement1.GetChildAt(0))).FlipText = ((bool)(resources.GetObject("resource.FlipText2")));
            ((Telerik.WinControls.UI.RadCommandBarGrip)(this.commandBarStripElement1.GetChildAt(0))).Text = resources.GetString("resource.Text2");
            ((Telerik.WinControls.UI.RadCommandBarGrip)(this.commandBarStripElement1.GetChildAt(0))).Padding = ((System.Windows.Forms.Padding)(resources.GetObject("resource.Padding2")));
            ((Telerik.WinControls.UI.RadCommandBarGrip)(this.commandBarStripElement1.GetChildAt(0))).Margin = ((System.Windows.Forms.Padding)(resources.GetObject("resource.Margin2")));
            ((Telerik.WinControls.UI.RadCommandBarGrip)(this.commandBarStripElement1.GetChildAt(0))).Alignment = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.Alignment2")));
            ((Telerik.WinControls.UI.RadCommandBarGrip)(this.commandBarStripElement1.GetChildAt(0))).RightToLeft = ((bool)(resources.GetObject("resource.RightToLeft2")));
            ((Telerik.WinControls.UI.RadCommandBarGrip)(this.commandBarStripElement1.GetChildAt(0))).AngleTransform = ((float)(resources.GetObject("resource.AngleTransform2")));
            ((Telerik.WinControls.UI.RadCommandBarOverflowButton)(this.commandBarStripElement1.GetChildAt(2))).TextWrap = ((bool)(resources.GetObject("resource.TextWrap3")));
            ((Telerik.WinControls.UI.RadCommandBarOverflowButton)(this.commandBarStripElement1.GetChildAt(2))).TextOrientation = ((System.Windows.Forms.Orientation)(resources.GetObject("resource.TextOrientation3")));
            ((Telerik.WinControls.UI.RadCommandBarOverflowButton)(this.commandBarStripElement1.GetChildAt(2))).FlipText = ((bool)(resources.GetObject("resource.FlipText3")));
            ((Telerik.WinControls.UI.RadCommandBarOverflowButton)(this.commandBarStripElement1.GetChildAt(2))).Text = resources.GetString("resource.Text3");
            ((Telerik.WinControls.UI.RadCommandBarOverflowButton)(this.commandBarStripElement1.GetChildAt(2))).Padding = ((System.Windows.Forms.Padding)(resources.GetObject("resource.Padding3")));
            ((Telerik.WinControls.UI.RadCommandBarOverflowButton)(this.commandBarStripElement1.GetChildAt(2))).Margin = ((System.Windows.Forms.Padding)(resources.GetObject("resource.Margin3")));
            ((Telerik.WinControls.UI.RadCommandBarOverflowButton)(this.commandBarStripElement1.GetChildAt(2))).Alignment = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.Alignment3")));
            ((Telerik.WinControls.UI.RadCommandBarOverflowButton)(this.commandBarStripElement1.GetChildAt(2))).Enabled = false;
            ((Telerik.WinControls.UI.RadCommandBarOverflowButton)(this.commandBarStripElement1.GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            ((Telerik.WinControls.UI.RadCommandBarOverflowButton)(this.commandBarStripElement1.GetChildAt(2))).RightToLeft = ((bool)(resources.GetObject("resource.RightToLeft3")));
            ((Telerik.WinControls.UI.RadCommandBarOverflowButton)(this.commandBarStripElement1.GetChildAt(2))).AngleTransform = ((float)(resources.GetObject("resource.AngleTransform3")));
            // 
            // AddImagesBtn
            // 
            resources.ApplyResources(this.AddImagesBtn, "AddImagesBtn");
            this.AddImagesBtn.AutoSize = false;
            this.AddImagesBtn.Bounds = new System.Drawing.Rectangle(0, 0, 24, 24);
            this.AddImagesBtn.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.AddImagesBtn.Image = global::TableOcrExtractor.Properties.Resources.add;
            this.AddImagesBtn.ImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddImagesBtn.Name = "AddImagesBtn";
            this.AddImagesBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.AddImagesBtn.UseCompatibleTextRendering = false;
            this.AddImagesBtn.Click += new System.EventHandler(this.AddImagesBtn_Click);
            // 
            // commandBarRowElement3
            // 
            this.commandBarRowElement3.MinSize = new System.Drawing.Size(25, 25);
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
            this.ImageAndDataGridSplitPanel.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(0.2661064F, 0F);
            this.ImageAndDataGridSplitPanel.SizeInfo.SplitterCorrection = new System.Drawing.Size(190, 0);
            this.ImageAndDataGridSplitPanel.TabStop = false;
            // 
            // ImageSplitContainer
            // 
            this.ImageSplitContainer.Controls.Add(this.ImageSplitPanel);
            this.ImageSplitContainer.Controls.Add(this.DataGridSplitPanel);
            resources.ApplyResources(this.ImageSplitContainer, "ImageSplitContainer");
            this.ImageSplitContainer.Name = "ImageSplitContainer";
            // 
            // 
            // 
            this.ImageSplitContainer.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.ImageSplitContainer.TabStop = false;
            // 
            // ImageSplitPanel
            // 
            this.ImageSplitPanel.Controls.Add(this.ImageCommandBar);
            resources.ApplyResources(this.ImageSplitPanel, "ImageSplitPanel");
            this.ImageSplitPanel.Name = "ImageSplitPanel";
            // 
            // 
            // 
            this.ImageSplitPanel.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.ImageSplitPanel.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(0F, 0.1467533F);
            this.ImageSplitPanel.SizeInfo.SplitterCorrection = new System.Drawing.Size(0, 57);
            this.ImageSplitPanel.TabStop = false;
            // 
            // ImageCommandBar
            // 
            resources.ApplyResources(this.ImageCommandBar, "ImageCommandBar");
            this.ImageCommandBar.Name = "ImageCommandBar";
            this.ImageCommandBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.ImageCommandBar.Rows.AddRange(new Telerik.WinControls.UI.CommandBarRowElement[] {
            this.commandBarRowElement2});
            // 
            // commandBarRowElement2
            // 
            resources.ApplyResources(this.commandBarRowElement2, "commandBarRowElement2");
            this.commandBarRowElement2.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarRowElement2.MinSize = new System.Drawing.Size(25, 25);
            this.commandBarRowElement2.Strips.AddRange(new Telerik.WinControls.UI.CommandBarStripElement[] {
            this.commandBarStripElement2});
            this.commandBarRowElement2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarRowElement2.UseCompatibleTextRendering = false;
            // 
            // commandBarStripElement2
            // 
            resources.ApplyResources(this.commandBarStripElement2, "commandBarStripElement2");
            this.commandBarStripElement2.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarStripElement2.GradientAngle = 450F;
            // 
            // 
            // 
            this.commandBarStripElement2.Grip.Alignment = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.Alignment4")));
            this.commandBarStripElement2.Grip.AngleTransform = ((float)(resources.GetObject("resource.AngleTransform4")));
            this.commandBarStripElement2.Grip.FlipText = ((bool)(resources.GetObject("resource.FlipText4")));
            this.commandBarStripElement2.Grip.Margin = ((System.Windows.Forms.Padding)(resources.GetObject("resource.Margin4")));
            this.commandBarStripElement2.Grip.Padding = ((System.Windows.Forms.Padding)(resources.GetObject("resource.Padding4")));
            this.commandBarStripElement2.Grip.RightToLeft = ((bool)(resources.GetObject("resource.RightToLeft4")));
            this.commandBarStripElement2.Grip.Text = resources.GetString("resource.Text4");
            this.commandBarStripElement2.Grip.TextOrientation = ((System.Windows.Forms.Orientation)(resources.GetObject("resource.TextOrientation4")));
            this.commandBarStripElement2.Grip.TextWrap = ((bool)(resources.GetObject("resource.TextWrap4")));
            this.commandBarStripElement2.Items.AddRange(new Telerik.WinControls.UI.RadCommandBarBaseItem[] {
            this.commandBarButton1});
            this.commandBarStripElement2.Name = "commandBarStripElement2";
            // 
            // 
            // 
            this.commandBarStripElement2.OverflowButton.Alignment = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.Alignment5")));
            this.commandBarStripElement2.OverflowButton.AngleTransform = ((float)(resources.GetObject("resource.AngleTransform5")));
            this.commandBarStripElement2.OverflowButton.FlipText = ((bool)(resources.GetObject("resource.FlipText5")));
            this.commandBarStripElement2.OverflowButton.Margin = ((System.Windows.Forms.Padding)(resources.GetObject("resource.Margin5")));
            this.commandBarStripElement2.OverflowButton.Padding = ((System.Windows.Forms.Padding)(resources.GetObject("resource.Padding5")));
            this.commandBarStripElement2.OverflowButton.RightToLeft = ((bool)(resources.GetObject("resource.RightToLeft5")));
            this.commandBarStripElement2.OverflowButton.Text = resources.GetString("resource.Text5");
            this.commandBarStripElement2.OverflowButton.TextOrientation = ((System.Windows.Forms.Orientation)(resources.GetObject("resource.TextOrientation5")));
            this.commandBarStripElement2.OverflowButton.TextWrap = ((bool)(resources.GetObject("resource.TextWrap5")));
            this.commandBarStripElement2.OverflowButton.Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            this.commandBarStripElement2.StretchHorizontally = false;
            this.commandBarStripElement2.StretchVertically = true;
            this.commandBarStripElement2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarStripElement2.UseCompatibleTextRendering = false;
            ((Telerik.WinControls.UI.RadCommandBarGrip)(this.commandBarStripElement2.GetChildAt(0))).TextWrap = ((bool)(resources.GetObject("resource.TextWrap6")));
            ((Telerik.WinControls.UI.RadCommandBarGrip)(this.commandBarStripElement2.GetChildAt(0))).TextOrientation = ((System.Windows.Forms.Orientation)(resources.GetObject("resource.TextOrientation6")));
            ((Telerik.WinControls.UI.RadCommandBarGrip)(this.commandBarStripElement2.GetChildAt(0))).FlipText = ((bool)(resources.GetObject("resource.FlipText6")));
            ((Telerik.WinControls.UI.RadCommandBarGrip)(this.commandBarStripElement2.GetChildAt(0))).Text = resources.GetString("resource.Text6");
            ((Telerik.WinControls.UI.RadCommandBarGrip)(this.commandBarStripElement2.GetChildAt(0))).Padding = ((System.Windows.Forms.Padding)(resources.GetObject("resource.Padding6")));
            ((Telerik.WinControls.UI.RadCommandBarGrip)(this.commandBarStripElement2.GetChildAt(0))).Margin = ((System.Windows.Forms.Padding)(resources.GetObject("resource.Margin6")));
            ((Telerik.WinControls.UI.RadCommandBarGrip)(this.commandBarStripElement2.GetChildAt(0))).Alignment = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.Alignment6")));
            ((Telerik.WinControls.UI.RadCommandBarGrip)(this.commandBarStripElement2.GetChildAt(0))).RightToLeft = ((bool)(resources.GetObject("resource.RightToLeft6")));
            ((Telerik.WinControls.UI.RadCommandBarGrip)(this.commandBarStripElement2.GetChildAt(0))).AngleTransform = ((float)(resources.GetObject("resource.AngleTransform6")));
            ((Telerik.WinControls.UI.RadCommandBarOverflowButton)(this.commandBarStripElement2.GetChildAt(2))).TextWrap = ((bool)(resources.GetObject("resource.TextWrap7")));
            ((Telerik.WinControls.UI.RadCommandBarOverflowButton)(this.commandBarStripElement2.GetChildAt(2))).TextOrientation = ((System.Windows.Forms.Orientation)(resources.GetObject("resource.TextOrientation7")));
            ((Telerik.WinControls.UI.RadCommandBarOverflowButton)(this.commandBarStripElement2.GetChildAt(2))).FlipText = ((bool)(resources.GetObject("resource.FlipText7")));
            ((Telerik.WinControls.UI.RadCommandBarOverflowButton)(this.commandBarStripElement2.GetChildAt(2))).Text = resources.GetString("resource.Text7");
            ((Telerik.WinControls.UI.RadCommandBarOverflowButton)(this.commandBarStripElement2.GetChildAt(2))).Padding = ((System.Windows.Forms.Padding)(resources.GetObject("resource.Padding7")));
            ((Telerik.WinControls.UI.RadCommandBarOverflowButton)(this.commandBarStripElement2.GetChildAt(2))).Margin = ((System.Windows.Forms.Padding)(resources.GetObject("resource.Margin7")));
            ((Telerik.WinControls.UI.RadCommandBarOverflowButton)(this.commandBarStripElement2.GetChildAt(2))).Alignment = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.Alignment7")));
            ((Telerik.WinControls.UI.RadCommandBarOverflowButton)(this.commandBarStripElement2.GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            ((Telerik.WinControls.UI.RadCommandBarOverflowButton)(this.commandBarStripElement2.GetChildAt(2))).RightToLeft = ((bool)(resources.GetObject("resource.RightToLeft7")));
            ((Telerik.WinControls.UI.RadCommandBarOverflowButton)(this.commandBarStripElement2.GetChildAt(2))).AngleTransform = ((float)(resources.GetObject("resource.AngleTransform7")));
            // 
            // commandBarButton1
            // 
            this.commandBarButton1.AutoSize = false;
            this.commandBarButton1.Bounds = new System.Drawing.Rectangle(0, 0, 24, 24);
            resources.ApplyResources(this.commandBarButton1, "commandBarButton1");
            this.commandBarButton1.Image = ((System.Drawing.Image)(resources.GetObject("commandBarButton1.Image")));
            this.commandBarButton1.Name = "commandBarButton1";
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
            ((System.ComponentModel.ISupportInitialize)(this.GalleryCommandBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageAndDataGridSplitPanel)).EndInit();
            this.ImageAndDataGridSplitPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImageSplitContainer)).EndInit();
            this.ImageSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImageSplitPanel)).EndInit();
            this.ImageSplitPanel.ResumeLayout(false);
            this.ImageSplitPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageCommandBar)).EndInit();
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
        private Telerik.WinControls.UI.SplitPanel ImageSplitPanel;
        private Telerik.WinControls.UI.SplitPanel DataGridSplitPanel;
        private Telerik.WinControls.UI.RadStatusStrip StatusStrip;
        private Telerik.WinControls.UI.RadMenuSeparatorItem SeparatorItem2;
        private Telerik.WinControls.UI.RadMenuItem SaveMenuItem;
        private Telerik.WinControls.UI.RadMenuItem SaveAsMenuItem;
        private System.Windows.Forms.OpenFileDialog OpenProjectFileDialog;
        private Telerik.WinControls.UI.RadMenuItem ProjectMenuItem;
        private Telerik.WinControls.UI.RadLabelElement ProjectNameLabelElement;
        private System.Windows.Forms.OpenFileDialog ImagesImportFileDialog;
        private Telerik.WinControls.UI.RadCommandBar ImageCommandBar;
        private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElement2;
        private Telerik.WinControls.UI.CommandBarStripElement commandBarStripElement2;
        private Telerik.WinControls.UI.CommandBarButton commandBarButton1;
        private Telerik.WinControls.UI.RadCommandBar GalleryCommandBar;
        private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElement1;
        private Telerik.WinControls.UI.CommandBarStripElement commandBarStripElement1;
        private Telerik.WinControls.UI.CommandBarButton AddImagesBtn;
        private Telerik.WinControls.UI.RadListView GalleryListView;
        private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElement3;
    }
}

