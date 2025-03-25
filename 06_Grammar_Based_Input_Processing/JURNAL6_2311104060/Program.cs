using JURNAL6_2311104060;

class Program
{
    static void Main(string[] args)
    {
        SayaTubeUser user = new SayaTubeUser("Nama_Praktikan");
        for (int i = 1; i <= 10; i++)
        {
            SayaTubeVideo video = new SayaTubeVideo($"Review Film {i} oleh Nama_Praktikan");
            video.IncreasePlayCount(1000);
            user.AddVideo(video);
        }

        user.PrintAllVideoPlaycount();
        Console.WriteLine($"Total Play Count: {user.GetTotalVideoPlayCount()}");
    }
}
