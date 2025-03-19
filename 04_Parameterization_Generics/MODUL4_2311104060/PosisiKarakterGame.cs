using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JURNAL4_2311104040
{
    public enum PosisiState
    {
        Berdiri,
        Jongkok,
        Tengkurap,
        Terbang
    }

    class PosisiKarakterGame
    {
        public PosisiState StateSaatIni { get; private set; } = PosisiState.Berdiri;

        public void TombolW()
        {
            if (StateSaatIni == PosisiState.Berdiri)
            {
                StateSaatIni = PosisiState.Terbang;
                Console.WriteLine("Posisi take off");
            }
        }

        public void TombolS()
        {
            if (StateSaatIni == PosisiState.Berdiri)
            {
                StateSaatIni = PosisiState.Jongkok;
                Console.WriteLine("Posisi standby");
            }
            else if (StateSaatIni == PosisiState.Terbang)
            {
                StateSaatIni = PosisiState.Jongkok;
                Console.WriteLine("Posisi landing");
            }
        }

        public void TombolX()
        {
            if (StateSaatIni == PosisiState.Jongkok)
            {
                StateSaatIni = PosisiState.Tengkurap;
                Console.WriteLine("Posisi istirahat");
            }
        }

        public void TombolUp()
        {
            if (StateSaatIni == PosisiState.Tengkurap)
            {
                StateSaatIni = PosisiState.Berdiri;
                Console.WriteLine("Kembali ke posisi berdiri");
            }
        }
    }
}
