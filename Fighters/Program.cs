using System;

namespace Fighters
{
    class Program
    {
        static void Main(string[] args)
        {
            Random Fighter1DMG = new Random();
            Random Fighter2DMG = new Random();

            string Fighter1 = "BRUNO";
            string Fighter2 = "SECCO";

            int Fighter1HP = 150;
            int Fighter2HP = 150;

            while (Fighter1HP > 0 && Fighter2HP > 0)
            {
                int DMG1 = Fighter1DMG.Next(1, 31);
                int DMG2 = Fighter2DMG.Next(1, 31);

                Fighter1HP = Fighter1HP - DMG2;
                Fighter2HP = Fighter2HP - DMG1;

                if (Fighter1HP < 0) Fighter1HP = 0;
                if (Fighter2HP < 0) Fighter2HP = 0;

                Console.WriteLine(Fighter1 + " HP: " + Fighter1HP);
                Console.WriteLine(Fighter2 + " HP: " + Fighter2HP);
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
