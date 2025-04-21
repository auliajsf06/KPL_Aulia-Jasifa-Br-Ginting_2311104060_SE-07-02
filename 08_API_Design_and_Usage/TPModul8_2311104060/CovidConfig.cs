using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace TPModul8_2311104060
{
    public class CovidConfig
    {
        public string satuan_suhu { get; set; }
        public string batas_hari_demam { get; set; }
        public string pesan_ditolak { get; set; }
        public string pesan_diterima { get; set; }

        private const string filePath = "covid_config.json";

        public CovidConfig()
        {
            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath);
                var config = JsonSerializer.Deserialize<CovidConfig>(jsonString);

                satuan_suhu = config?.satuan_suhu ?? "celcius";
                batas_hari_demam = config?.batas_hari_demam ?? "14";
                pesan_ditolak = config?.pesan_ditolak ?? "Anda tidak diperbolehkan masuk ke dalam gedung ini";
                pesan_diterima = config?.pesan_diterima ?? "Anda dipersilahkan untuk masuk ke dalam gedung ini";
            }
            else
            {
                satuan_suhu = "celcius";
                batas_hari_demam = "14";
                pesan_ditolak = "Anda tidak diperbolehkan masuk ke dalam gedung ini";
                pesan_diterima = "Anda dipersilahkan untuk masuk ke dalam gedung ini";
            }
        }

        public void UbahSatuan()
        {
            if (satuan_suhu.ToLower() == "celcius")
            {
                satuan_suhu = "fahrenheit";
            }
            else
            {
                satuan_suhu = "celcius";
            }
            SaveConfig();
        }

        private void SaveConfig()
        {
            var jsonString = JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, jsonString);
        }
    }
}
