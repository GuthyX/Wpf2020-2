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
using System.Windows.Shapes;

namespace Lottos
{
    /// <summary>
    /// Interaction logic for SajatSzamok.xaml
    /// </summary>
    public partial class SajatSzamok : Window
    {
        public SajatSzamok()
        {
            InitializeComponent();
            Feltoltes(Cb1);
            Feltoltes(Cb2);
            Feltoltes(Cb3);
            Feltoltes(Cb4);
            Feltoltes(Cb5);
        }
        private void Feltoltes(ComboBox c)
        {
            for (int i = 1; i < 91; i++)
            {
                c.Items.Add(i);
            }
        }
        private void btnMentes_Click(object sender, RoutedEventArgs e)
        {
            Szamok.Sajatokszamok(Cb1.SelectedIndex, Cb2.SelectedIndex, Cb3.SelectedIndex, Cb4.SelectedIndex, Cb5.SelectedIndex);
            MessageBox.Show("Sikeres Mentés");
        }

        private void btnVissza_Click(object sender, RoutedEventArgs e)
        {
            Window1 w = new Window1();
            this.Close();
            w.Show();
        }
    }
}
