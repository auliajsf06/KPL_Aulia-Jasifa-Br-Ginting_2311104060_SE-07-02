using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JURNAL4_2311104040
{
    class KodeBuah
    {
        private Dictionary<string, string> tabelKodeBuah;

        // Constructor
        public KodeBuah()
        {
            // Inisialisasi dictionary
            tabelKodeBuah = new Dictionary<string, string>
        {
            {"Apel", "A00"},
            {"Aprikot", "B00"},
            {"Alpukat", "C00"},
            {"Pisang", "D00"},
            {"Paprika", "E00"},
            {"Blackberry", "F00"},
            {"Ceri", "H00"},
            {"Kelapa", "I00"},
            {"Jagung", "J00"}
        };
        }

        // Method untuk mendapatkan kode buah
        public string getKodeBuah(string namaBuah)
        {
            // Cek apakah nama buah ada dalam dictionary
            if (tabelKodeBuah.ContainsKey(namaBuah))
            {
                return tabelKodeBuah[namaBuah];
            }
            else
            {
                return "Kode buah tidak ditemukan";
            }
        }
    }
}