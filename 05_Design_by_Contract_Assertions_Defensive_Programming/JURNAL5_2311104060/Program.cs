using Jurnal5_2311104060;

class Program
{
    static void Main(string[] args)
    {
        Penjumlahan penjumlahan = new Penjumlahan();

        // Contoh input berdasarkan aturan 2-digit NIM
        float hasil = penjumlahan.JumlahTigaAngka(23f, 11f, 10f); 
        Console.WriteLine($"Hasil penjumlahan: {hasil}");

        SimpleDataBase<int> database = new SimpleDataBase<int>();

        // Contoh data dua digit NIM
        database.AddNewData(12);
        database.AddNewData(34);
        database.AddNewData(56);

        database.PrintAllData();
    }
}
