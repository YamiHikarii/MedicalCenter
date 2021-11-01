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
    /// Логика взаимодействия для PatientPage.xaml
    /// </summary>
    public partial class PatientPage : Page
    {
        public PatientPage()
        {
            InitializeComponent();
        }

        private void WritePage(object sender, RoutedEventArgs e)
        {
            MainWindow.PageManager.Navigate(new DoctorChooserPage());
        }

        private void WritesAndTalons(object sender, RoutedEventArgs e)
        {
            MainWindow.PageManager.Navigate(new WritesPage());
        }
    }
}
