using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace Lottos
{
    class Szamok
    {
        static private List<int> SajatSzamok = new List<int>();
        static private List<int> NyeroSzamok = new List<int>();
        static Random rnd = new Random();

     static   public void Sajatokszamok(int elso, int masodik, int harmadik, int negyedik, int otodik)
        {
            SajatSzamok.Clear();
            SajatSzamok.Add(elso+1);
            SajatSzamok.Add(masodik+1);
            SajatSzamok.Add(harmadik+1);
            SajatSzamok.Add(negyedik+1);
            SajatSzamok.Add(otodik+1);

        }
       static public List<int> Nyeroszamok()
        {
            List<int> sz = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                sz.Add(rnd.Next(1,91));
            }
            sz.Sort();
            return sz;
        }
        static public void Kiir()
        {
            foreach (var x in SajatSzamok)
            {
                MessageBox.Show(x.ToString());
            }
        }
    }
}
