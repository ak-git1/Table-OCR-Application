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
            this.ImageAndDataGridSplitPanel = new Telerik.WinControls.UI.SplitPanel();
            this.ImageSplitContainer = new Telerik.WinControls.UI.RadSplitContainer();
            this.ImageSplitPanel = new Telerik.WinControls.UI.SplitPanel();
            this.DataGridSplitPanel = new Telerik.WinControls.UI.SplitPanel();
            this.StatusStrip = new Telerik.WinControls.UI.RadStatusStrip();
            this.OpenProjectFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ProjectNameLabelElement = new Telerik.WinControls.UI.RadLabelElement();
            ((System.ComponentModel.ISupportInitialize)(this.MainMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).BeginInit();
            this.MainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GallerySplitPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageAndDataGridSplitPanel)).BeginInit();
            this.ImageAndDataGridSplitPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageSplitContainer)).BeginInit();
            this.ImageSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageSplitPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridSplitPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusStrip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.NewProjectMenuItem,
            this.OpenProjectMenuItem,
            this.SeparatorItem1,
            this.SaveMenuItem,
            this.SaveAsMenuItem,
            this.SeparatorItem2,
            this.ExitMenuItem});
            this.FileMenuItem.Name = "FileMenuItem";
            resources.ApplyResources(this.FileMenuItem, "FileMenuItem");
            // 
            // NewProjectMenuItem
            // 
            this.NewProjectMenuItem.Name = "NewProjectMenuItem";
            resources.ApplyResources(this.NewProjectMenuItem, "NewProjectMenuItem");
            this.NewProjectMenuItem.Click += new System.EventHandler(this.NewProjectMenuItem_Click);
            // 
            // OpenProjectMenuItem
            // 
            this.OpenProjectMenuItem.Name = "OpenProjectMenuItem";
            resources.ApplyResources(this.OpenProjectMenuItem, "OpenProjectMenuItem");
            this.OpenProjectMenuItem.Click += new System.EventHandler(this.OpenProjectMenuItem_Click);
            // 
            // SeparatorItem1
            // 
            this.SeparatorItem1.Name = "SeparatorItem1";
            resources.ApplyResources(this.SeparatorItem1, "SeparatorItem1");
            // 
            // SaveMenuItem
            // 
            this.SaveMenuItem.Name = "SaveMenuItem";
            resources.ApplyResources(this.SaveMenuItem, "SaveMenuItem");
            this.SaveMenuItem.Click += new System.EventHandler(this.SaveMenuItem_Click);
            // 
            // SaveAsMenuItem
            // 
            this.SaveAsMenuItem.Name = "SaveAsMenuItem";
            resources.ApplyResources(this.SaveAsMenuItem, "SaveAsMenuItem");
            this.SaveAsMenuItem.Click += new System.EventHandler(this.SaveAsMenuItem_Click);
            // 
            // SeparatorItem2
            // 
            this.SeparatorItem2.Name = "SeparatorItem2";
            resources.ApplyResources(this.SeparatorItem2, "SeparatorItem2");
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            resources.ApplyResources(this.ExitMenuItem, "ExitMenuItem");
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // AboutMenuItem
            // 
            this.AboutMenuItem.Name = "AboutMenuItem";
            resources.ApplyResources(this.AboutMenuItem, "AboutMenuItem");
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
            this.MainMenu.ThemeName = "ControlDefault";
            // 
            // ProjectMenuItem
            // 
            this.ProjectMenuItem.Name = "ProjectMenuItem";
            resources.ApplyResources(this.ProjectMenuItem, "ProjectMenuItem");
            // 
            // SettingsMenuItem
            // 
            this.SettingsMenuItem.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.LanguageMenuItem});
            this.SettingsMenuItem.Name = "SettingsMenuItem";
            resources.ApplyResources(this.SettingsMenuItem, "SettingsMenuItem");
            // 
            // LanguageMenuItem
            // 
            this.LanguageMenuItem.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.EnglishLanguageMenuItem,
            this.RussianLanguageMenuItem});
            this.LanguageMenuItem.Name = "LanguageMenuItem";
            resources.ApplyResources(this.LanguageMenuItem, "LanguageMenuItem");
            // 
            // EnglishLanguageMenuItem
            // 
            this.EnglishLanguageMenuItem.Name = "EnglishLanguageMenuItem";
            resources.ApplyResources(this.EnglishLanguageMenuItem, "EnglishLanguageMenuItem");
            this.EnglishLanguageMenuItem.Click += new System.EventHandler(this.EnglishLanguageMenuItem_Click);
            // 
            // RussianLanguageMenuItem
            // 
            this.RussianLanguageMenuItem.Name = "RussianLanguageMenuItem";
            resources.ApplyResources(this.RussianLanguageMenuItem, "RussianLanguageMenuItem");
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
            this.ProjectNameLabelElement.Name = "ProjectNameLabelElement";
            this.StatusStrip.SetSpring(this.ProjectNameLabelElement, false);
            resources.ApplyResources(this.ProjectNameLabelElement, "ProjectNameLabelElement");
            this.ProjectNameLabelElement.TextWrap = true;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.MainSplitContainer);
            this.Controls.Add(this.MainMenu);
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
            ((System.ComponentModel.ISupportInitialize)(this.ImageAndDataGridSplitPanel)).EndInit();
            this.ImageAndDataGridSplitPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImageSplitContainer)).EndInit();
            this.ImageSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImageSplitPanel)).EndInit();
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
    }
}

