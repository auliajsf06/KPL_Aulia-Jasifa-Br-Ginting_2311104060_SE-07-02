using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JURNAL14_2311104060
{
    class SayaTubeVideo
    {
        // Fields
        private int _id;
        private string _title;
        private int _playCount;

        // Constructor
        public SayaTubeVideo(string title)
        {
            Debug.Assert(title != null && title.Length <= 200, "Judul video tidak valid.");

            Random rand = new Random();
            _id = rand.Next(10000, 99999);
            _title = title;
            _playCount = 0;
        }

        // Method to increase play count
        public void IncreasePlayCount(int count)
        {
            Debug.Assert(count > 0 && count <= 25000000, "Penambahan play count tidak valid.");

            try
            {
                checked
                {
                    _playCount += count;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: Play count melebihi batas integer.");
            }
        }

        // Method to print video details
        public void PrintVideoDetails()
        {
            Console.WriteLine($"ID: {_id}");
            Console.WriteLine($"Title: {_title}");
            Console.WriteLine($"Play Count: {_playCount}");
        }

        // Getter for play count
        public int GetPlayCount() => _playCount;

        // Getter for title
        public string GetTitle() => _title;
    }

}
