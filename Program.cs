using System;
namespace cody_practice_v2
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            bool running = true;

            while (running) // menuen kører indtil man vælger exit
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("=== MENU ===");
                Console.ResetColor();
                Console.WriteLine("1. Kayak Øvelse");
                Console.WriteLine("2. Matematik Øvelser");
                Console.WriteLine("3. Ny Øvelse");
                Console.WriteLine("4. incrementDecrement");
                Console.WriteLine("0. Afslut");
                Console.Write("Vælg en mulighed: ");

                string choice = Console.ReadLine();
                Console.Clear(); // ryd skærmen for pænhed

                switch (choice)
                {
                    case "1":
                        KayakExercise();
                        break;
                    case "2":
                        MathExercises();
                        break;
                    case "3":
                        NewExercise();
                        break;
                    case "4":
                        incrementDecrement();
                        break;
                    case "0":
                        running = false; // luk programmet
                        break;
                    default:
                        Console.WriteLine("Ugyldigt valg, prøv igen.");
                        break;
                }

                Console.WriteLine("\nTryk på en tast for at vende tilbage til menuen...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        // === Sektion 1 ===
        static void KayakExercise()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Kayak øvelse med variabler");
            Console.ResetColor();
            int numberofkayaks = 30;
            string kayakBrand1 = "Nelo";
            string kayakBrand2 = "Plastex";

            Console.WriteLine(kayakBrand1 + numberofkayaks);
            Console.WriteLine(kayakBrand2);
        }

        // === Sektion 2 ===
        static void MathExercises()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Matematik øvelser");
            Console.ResetColor();

            Console.WriteLine("2 + 2 = " + (2 + 2));
            Console.WriteLine("10 - 5 = " + (10 - 5));
            Console.WriteLine("9 * 3 = " + (9 * 3));
            Console.WriteLine("100.10 / 10 = " + (100.10 / 10));
        }

        // === Sektion 3 ===
        static void NewExercise()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Ny Øvelse");
            Console.ResetColor();

            // Du kan tilføje mere kode her senere
        }

        static void incrementDecrement()
        {
            int a = 5;
            a++;
            a = a * 2;
            a--;
            
            Console.WriteLine(a);
            
        }
    }
}
