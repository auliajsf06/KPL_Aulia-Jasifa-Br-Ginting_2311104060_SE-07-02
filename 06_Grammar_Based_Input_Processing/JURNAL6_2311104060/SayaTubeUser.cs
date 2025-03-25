using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JURNAL6_2311104060
{
    class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        public string Username { get; private set; }

        public SayaTubeUser(string username)
        {
            Debug.Assert(username != null && username.Length <= 100, "Username tidak valid.");

            Random rand = new Random();
            this.id = rand.Next(10000, 99999);
            this.Username = username;
            this.uploadedVideos = new List<SayaTubeVideo>();
        }

        public void AddVideo(SayaTubeVideo video)
        {
            Debug.Assert(video != null, "Video tidak boleh null.");
            Debug.Assert(video.GetPlayCount() < int.MaxValue, "PlayCount video melebihi batas maksimal integer.");

            uploadedVideos.Add(video);
        }

        public int GetTotalVideoPlayCount()
        {
            int total = 0;
            foreach (var video in uploadedVideos)
            {
                total += video.GetPlayCount();
            }
            return total;
        }

        public void PrintAllVideoPlaycount()
        {
            Console.WriteLine($"User: {this.Username}");
            for (int i = 0; i < Math.Min(uploadedVideos.Count, 8); i++)
            {
                Console.WriteLine($"Video {i + 1} judul: {uploadedVideos[i].GetTitle()}");
            }
        }
    }
}
