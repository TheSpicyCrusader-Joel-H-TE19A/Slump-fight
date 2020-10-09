using System;

namespace Fighters
{
    class Program
    {
        static void Main(string[] args)
        {
            Random Fighter1DMG = new Random();
            Random Fighter2DMG = new Random();

            string Fighter1 = "Jotaro";
            string Fighter2 = "DIO";

            int Fighter1HP = 200;
            int Fighter2HP = 200;

            Console.WriteLine($"{Fighter1}'s HP: {Fighter1HP}");
            Console.WriteLine($"{Fighter2}'s HP: {Fighter2HP}");
            Console.WriteLine("START!!!");
            Console.ReadLine();

            while (Fighter1HP > 0 && Fighter2HP > 0)
            {
                int DMG1 = Fighter1DMG.Next(1, 50);
                int DMG2 = Fighter2DMG.Next(1, 50);

                Fighter1HP = Fighter1HP - DMG2;
                Console.WriteLine($"{Fighter2} hit {Fighter1} for {DMG2} damage.");

                Fighter2HP = Fighter2HP - DMG1;
                Console.WriteLine($"{Fighter1} hit {Fighter2} for {DMG1} damage.");

                if (Fighter1HP < 0) Fighter1HP = 0;
                if (Fighter2HP < 0) Fighter2HP = 0;

                Console.WriteLine(Fighter1 + " HP: " + Fighter1HP);
                Console.WriteLine(Fighter2 + " HP: " + Fighter2HP);
                Console.ReadLine();
            }

            if (Fighter1HP > Fighter2HP)
            {
                Console.WriteLine("Fighter 1: " + Fighter1 + " WINS!");
                Console.ReadLine();
            }
            else if (Fighter2HP > Fighter1HP)
            {
                Console.WriteLine("Fighter 2: " + Fighter2 + " WINS!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Both fighters fought valiantly to the death! Its a draw!");
                Console.ReadLine();
            }


        }
    }
}
