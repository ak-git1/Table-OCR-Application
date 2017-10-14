using System;
using System.ComponentModel;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using Elar.Framework.Core.Helpers;
using TableOcrExtractor.Logic.Enums;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace TableOcrExtractor.Forms
{
    /// <summary>
    /// Localized form
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public class LocalizedForm : RadForm
    {
        #region Variables

        /// <summary>
        /// Occurs when current UI culture is changed
        /// </summary>
        [Browsable(true)]
        [Description("Occurs when current UI culture is changed")]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        [Category("Property Changed")]
        public event EventHandler CultureChanged;

        /// <summary>
        /// Current language
        /// </summary>
        private Language _currentLanguage;

        /// <summary>
        /// The culture information
        /// </summary>
        private CultureInfo _cultureInfo;

        /// <summary>
        /// The background worker
        /// </summary>
        private BackgroundWorker backgroundWorker;

        /// <summary>
        /// The resource manager
        /// </summary>
        private readonly ComponentResourceManager _resManager;

        #endregion

        #region Properties


        /// <summary>
        /// Сurrent language.
        /// </summary>
        [Browsable(false)]
        [Description("Current culture of this form")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Language CurrentLanguage
        {
            get => _currentLanguage;
            set
            {
                TableOcrExtractor.Properties.Settings.Default.CurrentCultureInfo = (int)value;
                TableOcrExtractor.Properties.Settings.Default.Save();

                string lang = EnumNamesHelper.GetDescription(value);
                if (_cultureInfo.Name != lang)
                {
                    CultureInfo cultureInfo = new CultureInfo(lang);
                    Thread.CurrentThread.CurrentCulture = cultureInfo;
                    ApplyResources(this, cultureInfo);

                    _cultureInfo = cultureInfo;
                    OnCultureChanged();
                }
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalizedForm"/> class.
        /// </summary>
        public LocalizedForm()
        {
            _resManager = new ComponentResourceManager(GetType());
            _cultureInfo = new CultureInfo(EnumNamesHelper.GetDescription((Language)TableOcrExtractor.Properties.Settings.Default.CurrentCultureInfo));
        }

        #endregion

        #region Private methods

        /// <summary>
        /// Applies the resources.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <param name="culture">The culture.</param>
        private void ApplyResources(Control parent, CultureInfo culture)
        {
            _resManager.ApplyResources(parent, parent.Name, culture);

            foreach (Control ctl in parent.Controls)
                ApplyResources(ctl, culture);
        }

        /// <summary>
        /// Called when culture changed.
        /// </summary>
        protected void OnCultureChanged()
        {
            var temp = CultureChanged;
            temp?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Initializes the component.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // LocalizedForm
            // 
            this.ClientSize = new System.Drawing.Size(292, 270);
            this.Name = "LocalizedForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Load += new System.EventHandler(this.LocalizedForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        #region Event handlers

        /// <summary>
        /// Handles the Load event of the LocalizedForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void LocalizedForm_Load(object sender, EventArgs e)
        {
            ThemeResolutionService.ApplicationThemeName = ThemeName;
        }

        #endregion
    }
}
