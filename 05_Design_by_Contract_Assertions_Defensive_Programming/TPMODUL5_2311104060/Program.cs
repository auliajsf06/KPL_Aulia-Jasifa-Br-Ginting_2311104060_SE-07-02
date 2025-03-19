using TPModul5_2311104060;
using TPMODUL5_2311104060;

class Program
{
    static void Main(string[] args)
    {
        HaloGeneric halo = new HaloGeneric();
        halo.SapaUser("Praktikan");

        // Contoh pemanggilan dengan NIM
        DataGeneric<string> dataGeneric = new DataGeneric<string>("2311104060");
        dataGeneric.PrintData();
    }
}

