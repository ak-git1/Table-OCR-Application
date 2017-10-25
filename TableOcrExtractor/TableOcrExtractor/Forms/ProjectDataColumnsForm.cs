using System.Collections.Generic;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace TableOcrExtractor.Forms
{
    /// <summary>
    /// Project data columns form
    /// </summary>
    /// <seealso cref="TableOcrExtractor.Forms.LocalizedForm" />
    public partial class ProjectDataColumnsForm : LocalizedForm
    {
        #region Properties

        /// <summary>
        /// Data columns
        /// </summary>
        public List<string> DataColumns
        {
            get
            {
                List<string> list = new List<string>();
                foreach (ListViewDataItem item in DataColumnsListView.Items)
                    list.Add(item.Text);
                return list;
            }
            set
            {
                DataColumnsListView.Items.Clear();
                foreach (string s in value)
                    DataColumnsListView.Items.Add(s);
            }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectDataColumnsForm"/> class.
        /// </summary>
        public ProjectDataColumnsForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Event handlers

        private void SaveBtn_Click(object sender, System.EventArgs e)
        {
            Close();
            DialogResult = DialogResult.OK;
        }

        private void CancelBtn_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void AddBtn_Click(object sender, System.EventArgs e)
        {
            DataColumnsListView.Items.Add($"Data column {DataColumnsListView.Items.Count + 1}");
        }

        private void RemoveBtn_Click(object sender, System.EventArgs e)
        {
            if (DataColumnsListView.SelectedItem != null)
                DataColumnsListView.Items.Remove(DataColumnsListView.SelectedItem);
        }

        #endregion
    }
}