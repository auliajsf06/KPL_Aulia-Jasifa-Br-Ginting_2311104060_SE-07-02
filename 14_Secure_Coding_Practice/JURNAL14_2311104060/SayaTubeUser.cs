using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JURNAL14_2311104060
{
    class SayaTubeUser
    {
        // Fields
        private int _id;
        private List<SayaTubeVideo> _uploadedVideos;
        public string Username { get; private set; }

        // Constructor
        public SayaTubeUser(string username)
        {
            Debug.Assert(username != null && username.Length <= 100, "Username tidak valid.");

            Random rand = new Random();
            _id = rand.Next(10000, 99999);
            Username = username;
            _uploadedVideos = new List<SayaTubeVideo>();
        }

        // Method to add a video
        public void AddVideo(SayaTubeVideo video)
        {
            Debug.Assert(video != null, "Video tidak boleh null.");
            Debug.Assert(video.GetPlayCount() < int.MaxValue, "PlayCount video melebihi batas maksimal integer.");

            _uploadedVideos.Add(video);
        }

        // Method to get total play count of all videos
        public int GetTotalVideoPlayCount()
        {
            int total = 0;
            foreach (var video in _uploadedVideos)
            {
                total += video.GetPlayCount();
            }
            return total;
        }

        // Method to print all video play counts
        public void PrintAllVideoPlayCount()
        {
            Console.WriteLine($":User  {Username}");
            for (int i = 0; i < Math.Min(_uploadedVideos.Count, 8); i++)
            {
                Console.WriteLine($"Video {i + 1} judul: {_uploadedVideos[i].GetTitle()}");
            }
        }
    }

}

