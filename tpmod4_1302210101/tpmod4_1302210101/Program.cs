// See https://aka.ms/new-console-template for more information


using tpmod4_1302210101;
using static tpmod4_1302210101.DoorMachine;

internal class program { 
    public static void Main(string[] args)
    {
        KodePos kode = new KodePos();
        KodePos.Kelurahan kjng = KodePos.Kelurahan.Kujangsari;
        Console.WriteLine("Kelurahan " + kjng + " dengan kode pos " + kode.getKodePos(kjng));


        DoorMachine door = new DoorMachine();
        door.current = State.Terkunci;

        string[] screenName = { "Terkunci", "Terbuka" };
        while (door.current != State.Terbuka)
        {
            Console.WriteLine(screenName[(int)door.current]);
            Console.Write("Enter Command: ");

            string command = Console.ReadLine();
            switch (door.current)
            {
                case State.Terkunci:
                    if (command == "KunciPintu")
                        door.current = State.Terkunci;
                    else if (command == "BukaPintu")
                        door.current = State.Terbuka;
                    break;
                case State.Terbuka:
                    if (command == "BukaPintu")
                        door.current = State.Terbuka;
                    else if (command == "KunciPintu")
                        door.current = State.Terkunci;
                    break;
            }
        }
        Console.WriteLine("Pintu " + screenName[(int)door.current]);
        Console.WriteLine("EXIT PROGRAM");

    }
}


