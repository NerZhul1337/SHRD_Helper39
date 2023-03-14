using SHRD_Helper.Helpers;
using System.Windows;
using System.Windows.Controls;

namespace SHRD_Helper.Pages
{
    /// <summary>
    /// Логика взаимодействия для TimedShutdownPage.xaml
    /// </summary>
    public partial class TimedShutdownPage : Page
    {
        public TimedShutdownPage()
        {
            InitializeComponent();
        }

        private void btnMainPage_Click(object sender, RoutedEventArgs e)
        {
            AppHelper.mainFrame.GoBack();
        }
    }
}
