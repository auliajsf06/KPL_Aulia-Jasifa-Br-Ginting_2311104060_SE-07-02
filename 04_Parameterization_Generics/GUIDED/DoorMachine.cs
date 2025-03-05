public class DoorMachine
{
    // Enum to represent door states
    private enum DoorState
    {
        Terkunci,
        Terbuka
    }

    private DoorState currentState = DoorState.Terkunci;

    // Method to simulate opening the door
    public void BukaPintu()
    {
        if (currentState == DoorState.Terkunci)
        {
            currentState = DoorState.Terbuka;
            Console.WriteLine("Pintu tidak terkunci");
        }
        else
        {
            Console.WriteLine("Pintu sudah terbuka");
        }
    }

    // Method to simulate closing the door
    public void KunciPintu()
    {
        if (currentState == DoorState.Terbuka)
        {
            currentState = DoorState.Terkunci;
            Console.WriteLine("Pintu terkunci");
        }
        else
        {
            Console.WriteLine("Pintu sudah terkunci");
        }
    }
}