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
    /// Логика взаимодействия для ChosseTimePage.xaml
    /// </summary>
    public partial class ChosseTimePage : Page
    {
        int DoctorId;
        public ChosseTimePage(int id)
        {
            InitializeComponent();
            DoctorId = id;
        }

        private void Submit(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вы записаны");
            MainWindow.PageManager.Navigate(new PatientPage());
        }
    }
}
