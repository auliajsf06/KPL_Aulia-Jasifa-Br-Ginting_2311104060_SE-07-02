using System;
using AljabarLibrarys;

class Program
{
    static void Main(string[] args)
    {
        // Tes AkarPersamaanKuadrat
        double[] persamaanKuadrat = { 1, -3, -10 };
        var akar = Aljabar.AkarPersamaanKuadrat(persamaanKuadrat);
        Console.WriteLine("Akar-akar dari x² - 3x - 10 = 0:");
        foreach (var a in akar)
        {
            Console.WriteLine(a);
        }

        // Tes HasilKuadrat
        double[] persamaanPangkat1 = { 2, -3 };
        var hasilKuadrat = Aljabar.HasilKuadrat(persamaanPangkat1);
        Console.WriteLine("Hasil kuadrat dari (2x - 3)²:");
        foreach (var h in hasilKuadrat)
        {
            Console.WriteLine(h);
        }
    }
}
