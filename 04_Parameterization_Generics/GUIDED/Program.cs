class Program
{
    static void Main(string[] args)
    {
        // Demonstrating KodePos (Table-Driven)
        KodePos kodePos = new KodePos();
        Console.WriteLine("Kode Pos Batununggal: " + kodePos.GetKodePos("Batununggal"));
        Console.WriteLine("Kode Pos Kujangsari: " + kodePos.GetKodePos("Kujangsari"));

        // Demonstrating DoorMachine (State-Based)
        DoorMachine doorMachine = new DoorMachine();
        doorMachine.KunciPintu();   // Should print "Pintu terkunci"
        doorMachine.KunciPintu();   // Should print "Pintu sudah terkunci"
        doorMachine.BukaPintu();    // Should print "Pintu tidak terkunci"
        doorMachine.BukaPintu();    // Should print "Pintu sudah terbuka"
    }
}