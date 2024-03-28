using System.Windows;

namespace Testiki
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Redak redak = new Redak();
        public static string parol { get; set; }
        public MainWindow()
        {
                InitializeComponent();

        }

        private void Redak(object sender, RoutedEventArgs e)
        {
            parol = Parol.Text;
            Parol.IsEnabled = true;
            if (parol == "kop")
            {
                redak.Show();
                Close();
            }
        }

        private void Start(object sender, RoutedEventArgs e)
        {
            redak.Show();
            Close();
            redak.textr.IsEnabled = false;
        }
    }
}