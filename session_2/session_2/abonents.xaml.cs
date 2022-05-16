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
using session_2.classes;



namespace session_2
{
    /// <summary>
    /// Логика взаимодействия для abonents.xaml
    /// </summary>
    public partial class abonents : Page
    {
        public abonents()
        {
            InitializeComponent();
            GridAbonents.ItemsSource = session2Entities.GetContext().abonents.ToList();
        }
        
    }
}
