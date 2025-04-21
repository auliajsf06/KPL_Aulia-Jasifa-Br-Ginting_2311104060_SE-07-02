using System;
using TPModul8_2311104060;

class Program
{
    static void Main(string[] args)
    {
        CovidConfig config = new CovidConfig();

        Console.Write($"Berapa suhu badan anda saat ini? (dalam satuan {config.satuan_suhu}): ");
        double suhu = double.Parse(Console.ReadLine());

        Console.Write("Berapa hari yang lalu (perkiraan) anda terakhir memiliki gejala demam? ");
        int hariDemam = int.Parse(Console.ReadLine());

        bool isSuhuNormal = false;

        if (config.satuan_suhu.ToLower() == "celcius")
        {
            isSuhuNormal = (suhu >= 36.5 && suhu <= 37.5);
        }
        else if (config.satuan_suhu.ToLower() == "fahrenheit")
        {
            isSuhuNormal = (suhu >= 97.7 && suhu <= 99.5);
        }

        bool isDemamBaru = hariDemam < int.Parse(config.batas_hari_demam);

        if (isSuhuNormal && isDemamBaru)
        {
            Console.WriteLine(config.pesan_diterima);
        }
        else
        {
            Console.WriteLine(config.pesan_ditolak);
        }

        Console.Write("\nApakah Anda ingin mengubah satuan suhu? (y/n): ");
        string ubah = Console.ReadLine();
        if (ubah.ToLower() == "y")
        {
            config.UbahSatuan();
            Console.WriteLine($"Satuan suhu sekarang menjadi: {config.satuan_suhu}");
        }
    }
}
