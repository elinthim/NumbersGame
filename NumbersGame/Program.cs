using System;

namespace NumbersGame
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            int number = random.Next(1, 10);
            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");
            int maxallowedtries = 5;
            int numberoftries = 0;
            bool gameloop = false;
            int checkguess = 0 - 10;
            while (!gameloop)
            //while (checkguess != number)

            {
                checkguess = Convert.ToInt32(Console.ReadLine());
                if (checkguess > number)
                {
                    Console.WriteLine("Tyvärr du gissade för högt!");
                }
                else if (checkguess < number)

                {
                    Console.WriteLine("Tyvärr du gissade för lågt!");
                }
                else
                {
                    Console.WriteLine("Woho! Du gjorde det!");
                    gameloop = true;
                }
                maxallowedtries++;
            }
            while (numberoftries != maxallowedtries) ;// loopen fortsätter så länge antalet gissningar inte är lika med maxantal gissningar

            if (numberoftries == maxallowedtries && checkguess != number) // om antal gissningar är lika med maxantal gissningar men nummer är inte lika med slumptal.
            {
                Console.WriteLine("Tyvärr du lyckades inte gissa talet på fem försök!");
                Console.ReadLine();
                //if (allowedtries == numberoftries) ;
            }
            //Console.ReadKey();
        }
    }
}
