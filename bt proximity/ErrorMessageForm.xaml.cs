using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace btprox
{
    /// <summary>
    /// Interaction logic for ErrorMessageForm.xaml
    /// </summary>
    public partial class ErrorMessageForm : Window
    {
        public ErrorMessageForm(String message)
        {
            InitializeComponent();
            Dispatcher.Invoke(new Action(() =>
                m_errorMessage.Text = message ?? "no data"));
        }

        private void copyButton_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(m_errorMessage.Text);
        }
    }
}
