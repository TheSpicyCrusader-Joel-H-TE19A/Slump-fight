using System;

namespace Fighters
{
    class Program
    {
        static void Main(string[] args)
        {
            Random Fighter1DMG = new Random();
            Random Fighter2DMG = new Random();


            string Fighter1 = "Bruno";
            string Fighter2 = "Secco";

            int Fighter1HP = 150;
            int Fighter2HP = 150;

            int DMG1 = Fighter1DMG.Next(1, 31);
            int DMG2 = Fighter2DMG.Next(1, 31);

            while (Fighter1HP != 0 || Fighter2HP != 0)
            {
                Console.WriteLine(Fighter1HP - DMG2);
                Console.WriteLine(Fighter2HP - DMG1);
                Console.ReadLine();


            }

            if (Fighter1HP == 0)
            {
                Console.WriteLine("Fighter 2: " + Fighter2 + "WINS!");
                Console.ReadLine();
            }

            if (Fighter2HP == 0)
            {
                Console.WriteLine("Fighter 1: " + Fighter1 + "WINS!");
                Console.ReadLine();
            }

            if (Fighter1HP == 0 && Fighter2HP == 0)
            {
                Console.WriteLine("ITS A DRAW!!!");
                Console.ReadLine();
            }


        }
    }
}
