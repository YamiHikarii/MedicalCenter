using System;
using System.Collections.Generic;
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

namespace Kovalevskaya.Pages
{
    /// <summary>
    /// Логика взаимодействия для DoctorChooserPage.xaml
    /// </summary>
    public partial class DoctorChooserPage : Page
    {
        public DoctorChooserPage()
        {
            InitializeComponent();
        }

        private void ChooseTime(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            int id = Int32.Parse(button.ContentStringFormat);
            MainWindow.PageManager.Navigate(new ChosseTimePage(id));
        }
    }
}
