using System;
using JURNAL14_2311104060;

class Program
{
    static void Main(string[] args)
    {
        // Create a new user
        SayaTubeUser user = new SayaTubeUser("Nama_Praktikan");

        // Add videos to the user
        for (int i = 1; i <= 10; i++)
        {
            SayaTubeVideo video = new SayaTubeVideo($"Review Film {i} oleh Nama_Praktikan");
            video.IncreasePlayCount(1000);
            user.AddVideo(video);
        }

        // Print all video play counts and total play count
        user.PrintAllVideoPlayCount();
        Console.WriteLine($"Total Play Count: {user.GetTotalVideoPlayCount()}");
    }
}

