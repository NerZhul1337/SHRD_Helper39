using SHRD_Helper.Helpers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace SHRD_Helper.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }
        
        private void btnAutoRunPage_Click(object sender, RoutedEventArgs e)
        {
            AppHelper.mainFrame.Navigate(new AutoRun());
        }

        //private void btnTimedShutdownPage_Click(object sender, RoutedEventArgs e)
        //{
        //    AppHelper.mainFrame.Navigate(new TimedShutdownPage());
        //}
    }
}
