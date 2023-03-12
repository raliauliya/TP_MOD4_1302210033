// See https://aka.ms/new-console-template for more information

using System;

public class KodePos
{
    public enum Kelurahan 
    { 
        Batununggal, 
        Kujangsari, 
        Mengger, 
        Wates, 
        Cijaura, 
        Jatisari, 
        Sekejati, 
        Kebonwaru, 
        Maleer, 
        Samoja
    }

    public static int getKodePos(Kelurahan kelurahan)
    {
        int[] kodePos = { 40266, 40287, 40267, 40256, 40287, 40286, 40286, 400272, 40274, 40273 };
        return kodePos[(int) kelurahan];
    }

}

public class DoorMachine
{
    enum State { terkunci, terbuka };

    public static void Main()
    {
        KodePos kodePos = new KodePos();

        int getKodePos = KodePos.getKodePos(KodePos.Kelurahan.Batununggal);
        Console.WriteLine(getKodePos);
        Console.WriteLine();

        State state = State.terkunci;
        string[] screenName = { "Pintu terkunci", "Pintu tidak terkunci" };

        while(state != null)
        {
            Console.WriteLine(screenName[(int)state]);
            Console.WriteLine();
            Console.Write("Enter Command : ");

            string command = Console.ReadLine();

            switch (state)
            {
                case State.terkunci:
                    if(command == "BukaPintu")
                        state = State.terbuka;
                    else if (command == "KunciPintu")
                        state = State.terkunci;
                    else
                    {
                        state = State.terkunci;
                        Console.WriteLine("Command Salah");
                    }
                    Console.WriteLine();
                    break;

                case State.terbuka:
                    if(command == "BukaPintu")
                        state = State.terbuka;
                    else if (command == "KunciPintu")
                        state = State.terkunci;
                    else
                    {
                        state = State.terbuka;
                        Console.WriteLine("Comman Salah");
                        Console.WriteLine();
                    }

                    Console.WriteLine();
                    break;
            }
            
        }


    }
}
    