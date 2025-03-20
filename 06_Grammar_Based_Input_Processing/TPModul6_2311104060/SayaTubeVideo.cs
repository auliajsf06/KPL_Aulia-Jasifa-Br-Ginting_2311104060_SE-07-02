using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPModul6_2311104060
{
    class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            // Design by Contract: Validasi title tidak null dan maksimal 100 karakter
            Debug.Assert(!string.IsNullOrEmpty(title), "Judul video tidak boleh null atau kosong.");
            Debug.Assert(title.Length <= 100, "Judul video tidak boleh lebih dari 100 karakter.");

            this.title = title;
            Random random = new Random();
            this.id = random.Next(10000, 99999); // 5 digit angka random
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            // Design by Contract: Validasi nilai count maksimal 10.000.000 dan tidak negatif
            Debug.Assert(count > 0 && count <= 10000000, "Penambahan play count harus antara 1 hingga 10.000.000.");

            // Menggunakan checked untuk mencegah overflow
            try
            {
                checked
                {
                    this.playCount += count;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: Play count melebihi batas maksimum integer.");
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("ID Video: " + this.id);
            Console.WriteLine("Judul Video: " + this.title);
            Console.WriteLine("Play Count: " + this.playCount);
        }
    }
}
