using System;
using System.Drawing;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;

namespace btprox
{
    public partial class OptionsForm : Form
    {
        /// <summary>
        /// default position of options form on the screen
        /// </summary>
        private static readonly Point MDefaultPosition = new Point(50, 50);

        /// <summary>
        /// array of identifiers of currently known languages
        /// </summary>
        private static readonly string[] KnownLanguages =
        {
            "en",
            "he",
            "ru",
            "es",
            "de"
        };

        private static Form m_parent;

        public OptionsForm(Form parent)
        {
            m_parent = parent;
            InitializeComponent();
            InitializeLanguageControls();
            FillLanguages();
        }

        /// <summary>
        /// handler of save button click
        /// </summary>
        internal event EventHandler SaveHandler
        {
            add { buttonSaveOptions.Click += value; }
            remove { buttonSaveOptions.Click -= value; }
        }

        /// <summary>
        /// state of "Show Baloons" checkbox
        /// </summary>
        internal Boolean ShowBaloons
        {
            set { m_checkBoxShowBaloons.Checked = value; }
            get { return m_checkBoxShowBaloons.Checked; }
        }

        /// <summary>
        /// get/set value of numeric box with scan period
        /// </summary>
        internal int ScanPeriod
        {
            set { m_numericScanPeriod.Value = value; }
            get { return (int)m_numericScanPeriod.Value; }
        }

        /// <summary>
        /// Get or set sound enabling checkbox state
        /// </summary>
        internal bool SoundEnabled
        {
            set { m_checkboxSound.Checked = value; }
            get { return m_checkboxSound.Checked; }
        }

        /// <summary>
        /// get or set windows log usage checkbox state
        /// </summary>
        internal bool UseWindowsLog
        {
            set { m_checkboxUseWindowsLog.Checked = value; }
            get { return m_checkboxUseWindowsLog.Checked; }
        }

        /// <summary>
        /// Get the language set by this program
        /// </summary>
        internal string Language
        {
            get
            {
                if (m_comboLanguages.SelectedItem == null)
                    return "en";
                else
                {
                    /* selected language string */
                    String strLang = m_comboLanguages.SelectedItem.ToString();

                    foreach (string strCulture in KnownLanguages)
                    {
                        /* name of the language for this culture */
                        string strCultureName =
                            new CultureInfo(strCulture).NativeName;
                        if (strLang.Equals(strCultureName))
                        {
                            return strCulture;
                        }
                    }
                }
                return String.Empty;
            }
            set
            {
                var cult = new CultureInfo(value);
                foreach (object oVal in m_comboLanguages.Items)
                {
                    if (oVal.ToString().Equals(cult.NativeName))
                    {
                        m_comboLanguages.SelectedItem = oVal;
                    }
                }
            }
        }

        /// <summary>
        /// handler of cancel button
        /// </summary>
        ///
        /// <param name="sender">
        /// sender of the event
        /// </param>
        ///
        /// <param name="e">
        /// event arguments
        /// </param>
        private void ButtonOptionsCancelClick(object sender, EventArgs e)
        {
            Hide();
        }

        /// <summary>
        /// initializes all the controls with their translations
        /// </summary>
        private void InitializeLanguageControls()
        {
            var parent = (BtProxLock) m_parent;
            m_labelSeconds.Text = parent.GetMessage("optionLabelSeconds");
            m_checkBoxShowBaloons.Text = parent.GetMessage("optionsShowBaloons");
            m_labelScanPeriod.Text = parent.GetMessage("optionScanPeriod");
            m_labelLanguage.Text = parent.GetMessage("optionLanguage");
            m_checkboxUseWindowsLog.Text = parent.GetMessage("useWindowsLog");

            this.Text = "BtProx - " + parent.GetMessage("optionTitle");
            m_checkboxSound.Text = parent.GetMessage("optionSoundEnabled");
            buttonSaveOptions.Text = parent.GetMessage("saveButton");
            buttonOptionsCancel.Text = parent.GetMessage("cancelButton");

            tabPage1.Text = parent.GetMessage("optionTabtext");
        }

        /// <summary>
        /// fill in languages into the combo
        /// </summary>
        private void FillLanguages()
        {
            m_comboLanguages.Items.Clear();
            foreach (string strName in KnownLanguages)
            {
                m_comboLanguages.Items.Add(
                    new CultureInfo(strName).NativeName);
            }
        }

        /// <summary>
        /// handler of form load. places the options form in the center of the
        /// parent window
        /// </summary>
        ///
        /// <param name="sender">
        /// sender of the event
        /// </param>
        ///
        /// <param name="e">
        /// event arguments
        /// </param>
        private void OptionsFormLoad(object sender, EventArgs e)
        {
            try
            {
                var x = m_parent.Location.X + m_parent.Size.Width / 2 -
                    Size.Width / 2;

                var y = m_parent.Location.Y + m_parent.Size.Height / 2 -
                    Size.Height / 2;

                Location = new Point(x, y);
            }
            catch
            {
                Location = MDefaultPosition;
            }
        }

    }
}
