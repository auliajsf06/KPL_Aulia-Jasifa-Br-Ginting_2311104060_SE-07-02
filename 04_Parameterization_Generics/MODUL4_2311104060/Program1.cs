using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JURNAL4_2311104040
{
    class Program1
    {
        static void Main(string[] args)
        {
            PosisiKarakterGame karakter = new PosisiKarakterGame();

            Console.WriteLine("State awal: " + karakter.StateSaatIni);

            karakter.TombolW();
            karakter.TombolS();
            karakter.TombolX();
            karakter.TombolUp();
            karakter.TombolW();
        }
    }
}