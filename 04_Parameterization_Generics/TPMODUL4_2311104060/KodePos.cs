using System;
using System.Collections.Generic;

// Table-Driven Implementation
public class KodePos
{
    // Dictionary to store postal codes
    private Dictionary<string, string> postalCodes = new Dictionary<string, string>
    {
        { "Batununggal", "40266" },
        { "Kujangsari", "40287" },
        { "Mengger", "40267" },
        { "Wates", "40256" },
        { "Cijaura", "40287" },
        { "Jatisari", "40286" },
        { "Margasari", "40286" },
        { "Sekejati", "40286" },
        { "Kebonwaru", "40272" },
        { "Malaer", "40274" },
        { "Samoja", "40273" }
    };

    // Method to retrieve postal code based on village name
    public string GetKodePos(string kelurahan)
    {
        if (postalCodes.TryGetValue(kelurahan, out string kodePos))
        {
            return kodePos;
        }
        return "Kode pos tidak ditemukan";
    }
}