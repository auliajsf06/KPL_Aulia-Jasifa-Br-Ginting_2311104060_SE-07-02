using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace JURNAL8_2311104060
{
    public class BankTransferConfig
    {
        public string lang { get; set; } = "en";
        public Transfer transfer { get; set; } = new Transfer();
        public List<string> methods { get; set; } = new List<string> { "RTO (real-time)", "SKN", "RTGS", "BI FAST" };
        public Confirmation confirmation { get; set; } = new Confirmation();

        public static BankTransferConfig LoadConfig(string path)
        {
            if (!File.Exists(path))
            {
                BankTransferConfig config = new BankTransferConfig();
                File.WriteAllText(path, JsonSerializer.Serialize(config, new JsonSerializerOptions { WriteIndented = true }));
                return config;
            }
            string json = File.ReadAllText(path);
            return JsonSerializer.Deserialize<BankTransferConfig>(json);
        }
    }

    public class Transfer
    {
        public int threshold { get; set; } = 25000000;
        public int low_fee { get; set; } = 6500;
        public int high_fee { get; set; } = 15000;
    }

    public class Confirmation
    {
        public string en { get; set; } = "yes";
        public string id { get; set; } = "ya";
    }

}
