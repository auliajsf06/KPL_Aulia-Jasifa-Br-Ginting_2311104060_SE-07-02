using JURNAL8_2311104060;

using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Program dimulai...");

        string configPath = "bank_transfer_config.json";
        BankTransferConfig config;

        if (!File.Exists(configPath))
        {
            Console.WriteLine("File konfigurasi tidak ditemukan, membuat default config...");
            config = new BankTransferConfig();
            string json = JsonSerializer.Serialize(config, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(configPath, json);
        }
        else
        {
            Console.WriteLine("Membaca file konfigurasi...");
            string json = File.ReadAllText(configPath);
            config = JsonSerializer.Deserialize<BankTransferConfig>(json);
        }

        string language = config.lang;
        Console.WriteLine(language == "en" ? "Please insert the amount of money to transfer:" : "Masukkan jumlah uang yang akan di-transfer:");
        int amount = int.Parse(Console.ReadLine());

        int fee = amount <= config.transfer.threshold ? config.transfer.low_fee : config.transfer.high_fee;
        int total = amount + fee;

        if (language == "en")
        {
            Console.WriteLine($"Transfer fee = {fee}");
            Console.WriteLine($"Total amount = {total}");
            Console.WriteLine("Select transfer method:");
        }
        else
        {
            Console.WriteLine($"Biaya transfer = {fee}");
            Console.WriteLine($"Total biaya = {total}");
            Console.WriteLine("Pilih metode transfer:");
        }

        for (int i = 0; i < config.methods.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {config.methods[i]}");
        }

        Console.ReadLine(); // untuk memilih metode transfer (tidak diproses lebih lanjut di soal)
        string confirmText = language == "en" ? config.confirmation.en : config.confirmation.id;

        Console.WriteLine(language == "en" ? $"Please type \"{confirmText}\" to confirm the transaction:" : $"Ketik \"{confirmText}\" untuk mengkonfirmasi transaksi:");
        string userConfirm = Console.ReadLine();

        if (userConfirm.ToLower() == confirmText.ToLower())
        {
            Console.WriteLine(language == "en" ? "The transfer is completed" : "Proses transfer berhasil");
        }
        else
        {
            Console.WriteLine(language == "en" ? "Transfer is cancelled" : "Transfer dibatalkan");
        }

        Console.WriteLine("Program selesai. Tekan tombol apa saja untuk keluar...");
        Console.ReadKey();
    }
}
