﻿using System;
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
    /// Логика взаимодействия для ManagementAbonentsPage.xaml
    /// </summary>
    public partial class ManagementAbonentsPage : Page
    {
        public ManagementAbonentsPage()
        {
            InitializeComponent();
        }

        

        private void ControlSostButton_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new ControlSost());
        }
    }
}
