namespace TableOcrExtractor.Forms
{
    partial class ProjectCreationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectCreationForm));
            this.ProjectNameLabel = new Telerik.WinControls.UI.RadLabel();
            this.ProjectCreationFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.ProjectFileLabel = new Telerik.WinControls.UI.RadLabel();
            this.SelectFileBtn = new Telerik.WinControls.UI.RadButton();
            this.ProjectNameTxt = new Telerik.WinControls.UI.RadTextBox();
            this.ProjectFileTxt = new Telerik.WinControls.UI.RadTextBox();
            this.CreateBtn = new Telerik.WinControls.UI.RadButton();
            this.CancelBtn = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectNameLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectFileLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectFileBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectNameTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectFileTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreateBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // ProjectNameLabel
            // 
            resources.ApplyResources(this.ProjectNameLabel, "ProjectNameLabel");
            this.ProjectNameLabel.Name = "ProjectNameLabel";
            // 
            // ProjectFileLabel
            // 
            resources.ApplyResources(this.ProjectFileLabel, "ProjectFileLabel");
            this.ProjectFileLabel.Name = "ProjectFileLabel";
            // 
            // SelectFileBtn
            // 
            resources.ApplyResources(this.SelectFileBtn, "SelectFileBtn");
            this.SelectFileBtn.Name = "SelectFileBtn";
            this.SelectFileBtn.Click += new System.EventHandler(this.SelectFileBtn_Click);
            // 
            // ProjectNameTxt
            // 
            resources.ApplyResources(this.ProjectNameTxt, "ProjectNameTxt");
            this.ProjectNameTxt.Name = "ProjectNameTxt";
            // 
            // ProjectFileTxt
            // 
            resources.ApplyResources(this.ProjectFileTxt, "ProjectFileTxt");
            this.ProjectFileTxt.Name = "ProjectFileTxt";
            // 
            // CreateBtn
            // 
            resources.ApplyResources(this.CreateBtn, "CreateBtn");
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // CancelBtn
            // 
            resources.ApplyResources(this.CancelBtn, "CancelBtn");
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // ProjectCreationForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.ProjectFileTxt);
            this.Controls.Add(this.ProjectNameTxt);
            this.Controls.Add(this.SelectFileBtn);
            this.Controls.Add(this.ProjectFileLabel);
            this.Controls.Add(this.ProjectNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ProjectCreationForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.ThemeName = "Windows7";
            ((System.ComponentModel.ISupportInitialize)(this.ProjectNameLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectFileLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectFileBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectNameTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectFileTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreateBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel ProjectNameLabel;
        private System.Windows.Forms.SaveFileDialog ProjectCreationFileDialog;
        private Telerik.WinControls.UI.RadLabel ProjectFileLabel;
        private Telerik.WinControls.UI.RadButton SelectFileBtn;
        private Telerik.WinControls.UI.RadTextBox ProjectNameTxt;
        private Telerik.WinControls.UI.RadTextBox ProjectFileTxt;
        private Telerik.WinControls.UI.RadButton CreateBtn;
        private Telerik.WinControls.UI.RadButton CancelBtn;
    }
}
