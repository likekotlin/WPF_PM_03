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
    /// Логика взаимодействия для CRM_page.xaml
    /// </summary>
    public partial class CRM_page : Page
    {
        public CRM_page()
        {
            InitializeComponent();
            GridAbonents.ItemsSource = AbonentsDBEntities.GetContext().abonents.ToList();
        }

        

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddCRM_page());
        }
    }
}