using System;
using TPModul14_2311104060;

class Program
{
    static void Main(string[] args)
    {
        string namaPraktikan = "Aulia Jasifa Br Ginting"; 
        string judulVideo = $"Tutorial Design By Contract - {namaPraktikan}";

        SayaTubeVideo video = new SayaTubeVideo(judulVideo);

        video.IncreasePlayCount(1_000_000);
        video.PrintVideoDetails();
    }
}
