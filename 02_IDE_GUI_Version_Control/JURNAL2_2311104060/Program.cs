class Program
{
    // Method untuk mengecek apakah suatu bilangan adalah prima
    static bool IsPrima(int angka)
    {
        // Angka kurang dari 2 bukan bilangan prima
        if (angka < 2)
            return false;

        // Angka 2 adalah bilangan prima
        if (angka == 2)
            return true;

        // Angka genap selain 2 bukan bilangan prima
        if (angka % 2 == 0)
            return false;

        // Cek apakah angka dapat dibagi dengan bilangan ganjil dari 3 sampai akar dari angka
        int batas = (int)Math.Sqrt(angka);
        for (int i = 3; i <= batas; i += 2)
        {
            if (angka % i == 0)
                return false;
        }

        // Jika tidak ada pembagi, maka angka adalah bilangan prima
        return true;
    }

    static void Main(string[] args)
    {
        // Bagian A: Menerima input nama praktikan
        Console.WriteLine("Masukkan nama Anda:");
        string nama = Console.ReadLine();
        Console.WriteLine($"Selamat datang, {nama}!");

        Console.WriteLine(); // Spasi antar bagian

        // Bagian B: Array 50 elemen dengan output berdasarkan kelipatan
        Console.WriteLine("=== Bagian B: Array 50 elemen ===");

        // Membuat array bertipe int berukuran 50
        int[] array = new int[50];

        // Mengisi array dengan nilai sesuai indeksnya
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i;
        }

        // Menampilkan isi array dengan aturan kelipatan
        for (int i = 0; i < array.Length; i++)
        {
            bool kelipatan2 = (i % 2 == 0);
            bool kelipatan3 = (i % 3 == 0);

            string tambahan = "";

            if (kelipatan2 && kelipatan3)
                tambahan = " #$#$";
            else if (kelipatan2)
                tambahan = " ##";
            else if (kelipatan3)
                tambahan = " $$";

            Console.WriteLine($"{i}{tambahan}");
        }

        Console.WriteLine(); // Spasi antar bagian

        // Bagian C: Input angka dan cek bilangan prima
        Console.WriteLine("=== Bagian C: Cek Bilangan Prima ===");
        Console.WriteLine("Masukkan angka (1-10000):");

        // Mengonversi input menjadi integer
        string nilaiString = Console.ReadLine();
        int nilaiInt = Convert.ToInt32(nilaiString);

        // Memastikan nilai dalam rentang yang valid
        if (nilaiInt < 1 || nilaiInt > 10000)
        {
            Console.WriteLine("Nilai harus berada dalam rentang 1-10000.");
        }
        else
        {
            // Cek apakah bilangan prima
            bool isPrima = IsPrima(nilaiInt);

            if (isPrima)
                Console.WriteLine($"Angka {nilaiInt} merupakan bilangan prima");
            else
                Console.WriteLine($"Angka {nilaiInt} bukan merupakan bilangan prima");
        }

        Console.WriteLine("\nTekan sembarang tombol untuk keluar...");
        Console.ReadKey();
    }
}