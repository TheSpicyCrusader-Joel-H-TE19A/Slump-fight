﻿using System;

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

            while (Fighter1HP > 0 && Fighter2HP > 0) // så länge dom lever, alltså deras hp är över 0, så kommer dom fortsätta att spöa skiten ur varandra
            {
                int DMG1 = Fighter1DMG.Next(1, 50); //random dmg fighter 1 gör per runda
                int DMG2 = Fighter2DMG.Next(1, 50); //random dmg fighter 2 gör per runda

                Fighter1HP = Fighter1HP - DMG2; //Hur mycket hälsa fighter 1 har per runda, hur mycket dmg dom tar, och deras nya lägre hälsa infoör nästa runda
                Console.WriteLine($"{Fighter2} hit {Fighter1} for {DMG2} damage."); //Beskriver hur mycket dmg de tar

                Fighter2HP = Fighter2HP - DMG1; //Hur mycket hälsa fighter 2 har per runda, hur mycket dmg dom tar, och deras nya lägre hälsa infoör nästa runda
                Console.WriteLine($"{Fighter1} hit {Fighter2} for {DMG1} damage."); //Beskriver hur mycket dmg de tar

                if (Fighter1HP < 0) Fighter1HP = 0; //Om fighter 1's hp är mindre än 0 så blir det 0, för man ska inte kunna ta negativ dmg
                if (Fighter2HP < 0) Fighter2HP = 0; //Om fighter 2's hp är mindre än 0 så blir det 0, för man ska inte kunna ta negativ dmg

                Console.WriteLine(Fighter1 + " HP: " + Fighter1HP); //Visualiserar fighter 1's nya hälsa varje runda
                Console.WriteLine(Fighter2 + " HP: " + Fighter2HP); //Visualiserar fighter 2's nya hälsa varje runda
                Console.ReadLine(); //är här för att göra så att du, spectatorn, startar varja runda genom att trycka på enter knappen
            }

            if (Fighter1HP > Fighter2HP) //Om fighter 1's hp är större än fighter 2's när loopen slutar (när fighter 2's hp är 0)...
            {
                Console.WriteLine("Fighter 1: " + Fighter1 + " WINS!"); //Så vinner Fighter 1
                Console.ReadLine();
            }
            else if (Fighter2HP > Fighter1HP) //Om fighter 2's hp är större än fighter 1's hp när loopen slutar (när fighter 2's hp är 0)
            {
                Console.WriteLine("Fighter 2: " + Fighter2 + " WINS!"); //Så vinner Fighter 2
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
