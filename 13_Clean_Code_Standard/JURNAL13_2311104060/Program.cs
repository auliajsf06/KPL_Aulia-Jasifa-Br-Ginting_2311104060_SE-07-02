using RefactoringGuru.DesignPatterns.Singleton.PusatData;

class Program
{
    static void Main(string[] args)
    {
        var data1 = PusatDataSingleton.GetDataSingleton();
        var data2 = PusatDataSingleton.GetDataSingleton();

        data1.AddSebuahData("Ali");
        data1.AddSebuahData("Budi");
        data1.AddSebuahData("Citra");
        data1.AddSebuahData("Dewi");
        data1.AddSebuahData("Asisten: Kak Rizky");

        Console.WriteLine("\n--- Data pada data2 sebelum penghapusan ---");
        data2.PrintSemuaData();

        Console.WriteLine("\n--- Menghapus data asisten praktikum melalui data2 ---");
        data2.HapusSebuahData(4);

        Console.WriteLine("\n--- Data pada data1 setelah penghapusan dari data2 ---");
        data1.PrintSemuaData();

        int jumlahData1 = data1.GetSemuaData().Count;
        int jumlahData2 = data2.GetSemuaData().Count;

        Console.WriteLine($"\nJumlah data di data1: {jumlahData1}");
        Console.WriteLine($"Jumlah data di data2: {jumlahData2}");
    }
}
