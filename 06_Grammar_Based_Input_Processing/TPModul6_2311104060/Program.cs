using TPModul6_2311104060;

class Program
{
    static void Main(string[] args)
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - [NAMA_PRAKTIKAN]");
        video.IncreasePlayCount(1000000);
        video.PrintVideoDetails();
    }
}