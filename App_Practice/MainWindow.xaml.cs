using System;
using App_Practice;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace App_Practice
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Practice12_Click(object sender, RoutedEventArgs e)
        {
            var work12 = new App_Practice.Practice12Window();
            work12.Show();
            this.Hide();
        }

        private void Practice13_Click(object sender, RoutedEventArgs e)
        {
            var work13 = new App_Practice.Practice13Window();
            work13.Show();
            this.Hide();
        }

        private void Practice14_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Практическая работа №14 еще не реализована", "Информация",
                          MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
