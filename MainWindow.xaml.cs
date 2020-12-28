using Class1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
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

namespace WpfApp1
{
       public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                exponentiation exp = new exponentiation(tb1.Text, tb2.Text);
                otvet.Content = exp.ogo();
            }
            catch
            {
                otvet.Content = "Error";
            }
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            tb1.Clear();
            tb2.Clear();
            exponentiation Clear = new exponentiation(tb1.Text, tb2.Text);
            otvet.Content = Clear.Clear();
        }
    }
}