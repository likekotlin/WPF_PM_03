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

namespace session_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        public MainWindow()
    {
        InitializeComponent();
    }
    private void Button_Click(object sender, RoutedEventArgs e)
    {
        Nomer.Clear();
        pass.Clear();
        cod.Clear();
        MessageBox.Show("Очищены все поля!");
    }

    class Generation
    {
        public string Code()
        {
            int[] arr = new int[8];
            Random rm = new Random();
            string cod = "";

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rm.Next(33, 125);
                cod += (char)arr[i];
            }
            return cod;
        }
    }
    private void obnovit_Click(object sender, RoutedEventArgs e)
    {
        Generation P = new Generation();
        var cod = P.Code();
        MessageBox.Show(cod, "Генерaця кода");
        Clipboard.SetText(cod);
    }

    private void nomer_Up(object sender, KeyEventArgs e)
    {
        if (e.Key == Key.Enter)
        {
            TextBox txtBox = e.Source as TextBox;
            if (txtBox != null)
            {
                pass.IsEnabled = IsEnabled;
                cod.IsEnabled = IsEnabled;
                Vhod.IsEnabled = IsEnabled;
            }
        }
    }


    private void pass_up(object sender, KeyEventArgs e)
    {
        if (e.Key == Key.Enter)
        {
            TextBox txtBox = e.Source as TextBox;
            if (txtBox != null)
            {
                Generation P = new Generation();
                var cod = P.Code();
                MessageBox.Show(cod, "Генерaция кода");
                Clipboard.SetText(cod);
            }
        }
    }
}
}
