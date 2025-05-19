using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringGuru.DesignPatterns.Singleton.PusatData
{
    public sealed class PusatDataSingleton
    {
        private static PusatDataSingleton _instance;
        private List<string> DataTersimpan;

        private PusatDataSingleton()
        {
            DataTersimpan = new List<string>();
        }

        public static PusatDataSingleton GetDataSingleton()
        {
            if (_instance == null)
            {
                _instance = new PusatDataSingleton();
            }
            return _instance;
        }

        public List<string> GetSemuaData()
        {
            return DataTersimpan;
        }

        public void PrintSemuaData()
        {
            if (DataTersimpan.Count == 0)
            {
                Console.WriteLine("Belum ada data yang tersimpan.");
                return;
            }

            Console.WriteLine("Data Tersimpan:");
            for (int i = 0; i < DataTersimpan.Count; i++)
            {
                Console.WriteLine($"[{i}] {DataTersimpan[i]}");
            }
        }

        public void AddSebuahData(string input)
        {
            DataTersimpan.Add(input);
            Console.WriteLine($"Data '{input}' berhasil ditambahkan.");
        }

        public void HapusSebuahData(int index)
        {
            if (index >= 0 && index < DataTersimpan.Count)
            {
                Console.WriteLine($"Data '{DataTersimpan[index]}' dihapus.");
                DataTersimpan.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("Index tidak valid.");
            }
        }
    }
}