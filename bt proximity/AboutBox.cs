using System;
using System.Reflection;
using System.Windows.Forms;
using System.Resources;

namespace btprox
{
    partial class AboutBox : Form
    {
        private static Form m_parent;

        private const int m_borderWidth = 6;

        public AboutBox(Form parent)
        {
            m_parent = parent;
            InitializeComponent();
            InitializeLanguageControls();
            labelProductName.Text = AssemblyProduct;
            labelVersion.Text = String.Format("Version {0}", AssemblyVersion);
            labelCopyright.Text = AssemblyCopyright;
            labelCompanyName.Text = AssemblyCompany;
            linkWebsite.Text = "https://sourceforge.net/projects/btprox/";
        }

        private void InitializeLanguageControls()
        {
            var parent = ((BtProxLock) m_parent);
            Text = parent.GetMessage("menuItemAbout") + " BtProx";
            textBoxDescription.Text = parent.GetMessage("textAbout");
        }

        #region Assembly Attribute Accessors

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

        private void AboutBoxLoad(object sender, EventArgs e)
        {
            /* show the form in center of the main-form (if visible) */
            if (!m_parent.Visible)
            {
                return;
            }

            var p = new System.Drawing.Point
            {
                X = m_parent.Location.X + m_parent.Size.Width / 2 -
                    Size.Width / 2,

                Y = m_parent.Location.Y + m_parent.Size.Height / 2 -
                    Size.Height / 2
            };

            var maxX = Screen.PrimaryScreen.WorkingArea.Width + m_borderWidth;
            if ((p.X + Size.Width) > maxX)
            {
                p.X -= p.X + Size.Width - maxX;
            }

            if (p.X < m_borderWidth)
            {
                p.X = m_borderWidth;
            }

            var maxY = Screen.PrimaryScreen.WorkingArea.Height + m_borderWidth;
            if ((p.Y + Size.Height) > maxY)
            {
                p.Y -= p.Y + Size.Height - maxY;
            }
            if (p.Y < m_borderWidth)
            {
                p.Y = m_borderWidth;
            }

            Location = p;
        }
    }
}
