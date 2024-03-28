using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;

namespace Testiki
{
    /// <summary>
    /// Логика взаимодействия для Redak.xaml
    /// </summary>
    public partial class Redak : Window
    {
        public Redak()
        {
            InitializeComponent();
        }

        private void exit(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            Close();
        }

        private void Text(object sender, RoutedEventArgs e)
        {
            stranica1.Content = new Page2();
        }

        private void nachattest(object sender, RoutedEventArgs e)
        {
            json Json = new json();
            var govna = Json.Deserialization<List<model>>("soxr.json"); 
            if (govna == null)
            {
                stranica2.Content = new Page1();
            }
            else
            {
                stranica3.Content = new Page3();
            }
        }
    }
}
