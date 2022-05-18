using System;
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
using Sessia_2_PM_03.Classes;

namespace Sessia_2_PM_03
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new AbonentsPage());
            Manager.MainFrame = MainFrame;
           
        }

        

        private void ManagementAbonentsButton_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new ManagementAbonentsPage());
        }

        private void ActivsButton_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new ActivsPage());
        }

        private void BillingButton_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new BillingPage());
        }

        private void SupportUsers_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new SupportUsersPage());
        }

        private void CRM_Button_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new CRM_page());
        }

        private void abonents_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AbonentsPage());
        }
    }
}
