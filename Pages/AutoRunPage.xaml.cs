using SHRD_Helper.Helpers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace SHRD_Helper.Pages
{
    /// <summary>
    /// Логика взаимодействия для AutoRun.xaml
    /// </summary>
    public partial class AutoRun : Page
    {
        Thickness marg = new Thickness(5, 5, 5, 5);

        public AutoRun()
        {
            InitializeComponent();
           // if (System.IO.File.Exists("file.txt"))
           // {
            //   string xaml = System.IO.File.ReadAllText("file.txt");
            //   object content = System.Windows.Markup.XamlReader.Parse(xaml);
            //   this.Content = content;
           // }
        }

        //protected override void btnLaunch(System.ComponentModel.CancelEventArgs e)
        //{
         //   base.btnLaunch(e);
         //  string xaml = System.Windows.Markup.XamlWriter.Save(this.Content);
         //   System.IO.File.WriteAllText("file.txt", xaml);
        //}

        private void bntLaunch_Click(object sender, RoutedEventArgs e)
        {
            var apps = new List<string>();

            foreach(TextBox tbox in spApps.Children)
            {
                apps.Add(tbox.Text);
            }

            try
            {
                foreach(string appname in apps)
                {
                   Process.Start(appname);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Приложение {tbox1.Text} не найдено! \n {ex.Message}", "Ошибка");
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            int i = 0;

            foreach (TextBox tbox in spApps.Children)
            {
                i++;
            }

            //Нужно найти способ сохраниния данных полей и запись этих данных в создаваемые поля
            //Так же нужно найти способ сохранения созданных полей чтобы при перезапуске они отображались

            if (i < 10)
            {
                TextBox addingTbox = new TextBox();
                addingTbox.Width = 500;
                addingTbox.Margin = marg;
                addingTbox.Name = "tbox" + i.ToString();

                spApps.Children.Add(addingTbox);
            }
            else
            {
                MessageBox.Show("Максимальное количество открываемых приложений - 10", "Предупреждение");
            }
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            TextBox last = null;
            foreach (TextBox tbox in spApps.Children)
            {
                last = tbox;
            }
            spApps.Children.Remove(last);
        }

        private void btnMainPage_Click(object sender, RoutedEventArgs e)
        {
            AppHelper.mainFrame.GoBack();
        }
    }
}
