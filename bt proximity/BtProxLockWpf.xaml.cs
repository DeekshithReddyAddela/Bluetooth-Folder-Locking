using System.Resources;
using System.Reflection;

namespace btprox
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class BtProxDialog
    {
        public BtProxDialog()
        {
            InitializeComponent();
            InitializeLanguageControls();
        }

        public void InitializeLanguageControls()
        {
            /* resource manager used to pull data */
            var rmg = new ResourceManager(
                "btprox.LanguageResources",
                Assembly.GetExecutingAssembly());

            m_labelUsedDevice.Content = rmg.GetString("labelUsedDevice");
            m_labelDeviceName.Content = rmg.GetString("labelUnknown");
        }
    }
}
