using SHRD_Helper.Helpers;
using SHRD_Helper.Pages;
using System.Windows;

namespace SHRD_Helper
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AppHelper.mainFrame = _mainFrame;
            AppHelper.mainFrame.Navigate(new MainPage());
        }
    }
}
