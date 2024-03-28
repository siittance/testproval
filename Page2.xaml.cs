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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Testiki
{
    /// <summary>
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        json Json = new json();
        public List<model> govno { get; set; }
        public Page2()
        {
            InitializeComponent();
            govno = new List<model>();
            List<model> govna = Json.Deserialization<List<model>>("soxr.json");
            govna = govno;
            GridData.ItemsSource = govno;
        }

        private void testsoxr(object sender, RoutedEventArgs e)
        {
            Json.Sirialize(govno, "soxr.json");
        }
    }
}
