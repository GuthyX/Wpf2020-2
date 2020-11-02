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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void btnVissza_Click(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow();
            this.Close();
            m.Show();
        }

        private void btnSajatSzamok_Click(object sender, RoutedEventArgs e)
        {
            SajatSzamok s = new SajatSzamok();
            this.Close();
            s.Show();
        }
      
        private void btnSorsolas_Click(object sender, RoutedEventArgs e)
        {
            List<int> sz = Szamok.Nyeroszamok();
            TbElsoSzam.Text = sz[0].ToString();
            TbMasodikSzam.Text = sz[1].ToString();
            TbHarmadikSzam.Text = sz[2].ToString();
            TbNegyedikSzam.Text = sz[3].ToString();
            TbOtodikSzam.Text = sz[4].ToString();
        }
    }
}
