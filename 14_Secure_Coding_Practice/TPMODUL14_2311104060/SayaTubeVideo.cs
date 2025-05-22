using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPModul14_2311104060
{
    class SayaTubeVideo
    {
        // Private fields (menggunakan camelCase)
        private int id;
        private string title;
        private int playCount;

        // Constructor
        public SayaTubeVideo(string title)
        {
            // Design by Contract: Validasi judul tidak null/kosong dan maksimal 100 karakter
            Debug.Assert(!string.IsNullOrEmpty(title), "Judul video tidak boleh null atau kosong.");
            Debug.Assert(title.Length <= 100, "Judul video tidak boleh lebih dari 100 karakter.");

            this.title = title;

            // Inisialisasi id dengan angka random 5 digit
            Random random = new Random();
            id = random.Next(10000, 99999);

            // Inisialisasi play count
            playCount = 0;
        }

        // Method untuk menambah play count video
        public void IncreasePlayCount(int count)
        {
            // Design by Contract: Validasi bahwa count dalam rentang 1 sampai 10.000.000
            Debug.Assert(count > 0 && count <= 10000000, "Penambahan play count harus antara 1 hingga 10.000.000.");

            try
            {
                // Gunakan checked untuk mencegah overflow saat penambahan play count
                checked
                {
                    playCount += count;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: Play count melebihi batas maksimum integer.");
            }
        }

        // Method untuk menampilkan detail video
        public void PrintVideoDetails()
        {
            Console.WriteLine("ID Video       : " + id);
            Console.WriteLine("Judul Video    : " + title);
            Console.WriteLine("Play Count     : " + playCount);
        }
    }
}
