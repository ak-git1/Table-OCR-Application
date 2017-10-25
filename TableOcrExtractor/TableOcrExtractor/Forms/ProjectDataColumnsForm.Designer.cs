namespace TableOcrExtractor.Forms
{
    partial class ProjectDataColumnsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectDataColumnsForm));
            this.CancelBtn = new Telerik.WinControls.UI.RadButton();
            this.SaveBtn = new Telerik.WinControls.UI.RadButton();
            this.DataColumnsEnterLbl = new Telerik.WinControls.UI.RadLabel();
            this.DataColumnsListView = new Telerik.WinControls.UI.RadListView();
            this.AddBtn = new Telerik.WinControls.UI.RadButton();
            this.RemoveBtn = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.CancelBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaveBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataColumnsEnterLbl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataColumnsListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemoveBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelBtn
            // 
            resources.ApplyResources(this.CancelBtn, "CancelBtn");
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SaveBtn
            // 
            resources.ApplyResources(this.SaveBtn, "SaveBtn");
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // DataColumnsEnterLbl
            // 
            resources.ApplyResources(this.DataColumnsEnterLbl, "DataColumnsEnterLbl");
            this.DataColumnsEnterLbl.Name = "DataColumnsEnterLbl";
            // 
            // DataColumnsListView
            // 
            resources.ApplyResources(this.DataColumnsListView, "DataColumnsListView");
            this.DataColumnsListView.Name = "DataColumnsListView";
            // 
            // AddBtn
            // 
            resources.ApplyResources(this.AddBtn, "AddBtn");
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // RemoveBtn
            // 
            resources.ApplyResources(this.RemoveBtn, "RemoveBtn");
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // ProjectDataColumnsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.DataColumnsListView);
            this.Controls.Add(this.DataColumnsEnterLbl);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ProjectDataColumnsForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.ThemeName = "Windows7";
            ((System.ComponentModel.ISupportInitialize)(this.CancelBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaveBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataColumnsEnterLbl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataColumnsListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemoveBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton CancelBtn;
        private Telerik.WinControls.UI.RadButton SaveBtn;
        private Telerik.WinControls.UI.RadLabel DataColumnsEnterLbl;
        private Telerik.WinControls.UI.RadListView DataColumnsListView;
        private Telerik.WinControls.UI.RadButton AddBtn;
        private Telerik.WinControls.UI.RadButton RemoveBtn;
    }
}