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
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        json Json = new json();
       public List<model> govna = new List<model>();
        int i = 1;
        int kol = 0;
        public Page3()
        {
            govna = Json.Deserialization<List<model>>("soxr.json");
            InitializeComponent();
            Namee.Text = govna[0].Name;
            Opisanie.Text = govna[0].Description;
            Otvet1.Content = govna[0].Answer1;
            Otvet2.Content = govna[0].Answer2;
            Otvet3.Content = govna[0].Answer3;
        }
        private void Listanie()
        {
            Namee.Text = govna[i].Name;
            Opisanie.Text = govna[i].Description;
            Otvet1.Content = govna[i].Answer1;
            Otvet2.Content = govna[i].Answer2;
            Otvet3.Content = govna[i].Answer3;
        }
        private void Otvet()
        {
            if (i == govna.Count - 1)
            {
                Otvet1.IsEnabled = false;
                Otvet2.IsEnabled = false;
                Otvet3.IsEnabled = false;
            }
        }

        private void answer1(object sender, RoutedEventArgs e)
        {

            if (Otvet1.Tag.ToString() == govna[0].PravdaOtvet.ToString())
            {
                kol++;
                MessageBox.Show("Ответ верный");
            }
            else
            {
                MessageBox.Show("Ответ неверный");
            }
            i++;
            if (i < govna.Count)
            {
                Listanie();
            }
            else
            {
                Kol.Text = $"Кол-во правильных: {kol}";
                Otvet();
            }
        }

        private void answer2(object sender, RoutedEventArgs e)
        {
            if (Otvet2.Tag.ToString() == govna[0].PravdaOtvet.ToString())
            {
                kol++;
                MessageBox.Show("Ответ верный");
            }
            else
            {
                MessageBox.Show("Ответ неверный");
            }
            i++;
            if (i < govna.Count)
            {
                Listanie();
            }
            else
            {
                Kol.Text = $"Кол-во правильных: {kol}";
                Otvet();
            }
        }

        private void answer3(object sender, RoutedEventArgs e)
        {
            if (Otvet3.Tag.ToString() == govna[0].PravdaOtvet.ToString())
            {
                kol++;
                MessageBox.Show("Ответ верный");
            }
            else
            {
                MessageBox.Show("Ответ неверный");
            }
            i++;
            if (i < govna.Count)
            {
                Listanie();
            }
            else
            {
                Kol.Text = $"Кол-во правильных: {kol}";
                Otvet();
            }
        }
    }
}
