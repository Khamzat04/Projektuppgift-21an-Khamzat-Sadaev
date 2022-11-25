using System;
namespace Projekt.Khamzat_21._an
{
    class Program
    {
        static void Main()

        {

            // Byter Färgen på allt till grön. bara det som skrivs.
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            // Starta spelet BlackJack
            int Spela = 1;
            // Visar senaste vinnaren 
            int Senaste = 2;
            // visar spelets regler 
            int Regler = 3;
            // Avslutar programmet
            int Avsluta = 4;

         

            Console.WriteLine("Välj ett ett alternativ ");
            Console.WriteLine("(1) Spela BlackJack.");
            Console.WriteLine("(2) Visa senaste vinnaren.");
            Console.WriteLine("(3) Spelets Regler.");
            Console.WriteLine("(4) Avsluta Allt.");

            string välj = Console.ReadLine();

            switch (välj)
            {
                // BlackJack
                case "1":

                    Console.WriteLine("");

                    break;

                    //senaste vinnare
                case "2":

                    Console.WriteLine("");

                    break;

                //visar spelets regler
                case "3":

                    Console.WriteLine("Spelets idé är att med två eller flera kort försöka uppnå det sammanlagda värdet 21, ");
                    Console.WriteLine("eller komma så nära som möjligt utan att överskrida 21.");
                    Console.WriteLine("Alltså du kan också Sluta ta kort men dator ska fortsätta ");
                    Console.WriteLine("om du har närmast till 21 Så vinner du Spelet");

                    break;

                // Avslutar programmet
                case "4":

                    Console.WriteLine("Tack För din tid (Hejdå)");

                    break;



    }   }   }


}