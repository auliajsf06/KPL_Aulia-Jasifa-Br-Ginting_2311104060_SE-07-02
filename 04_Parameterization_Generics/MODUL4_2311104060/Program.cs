using JURNAL4_2311104040;

class Program
{
    static void Main(string[] args)
    {
        // Membuat objek KodeBuah
        KodeBuah kodeBuah = new KodeBuah();

        // Menampilkan header tabel
        Console.WriteLine("Nama Buah\tKode Buah");

        // Array nama buah untuk diuji
        string[] namabuah = { "Apel", "Aprikot", "Alpukat", "Pisang", "Paprika", "Blackberry", "Ceri", "Kelapa", "Jagung" };

        // Menampilkan kode untuk setiap buah
        foreach (string buah in namabuah)
        {
            Console.WriteLine($"{buah}\t\t{kodeBuah.getKodeBuah(buah)}");
        }

        Console.ReadKey();
    }
}