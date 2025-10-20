using System;
using cody_practice_v2.Exercise_s; // 👈 this line connects to your other classes

namespace cody_practice_v2
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("=== MENU ===");
                Console.ResetColor();
                Console.WriteLine("1. Kayak Exercise");
                Console.WriteLine("2. Math Exercise");
                Console.WriteLine("3. New Exercise");
                Console.WriteLine("4. Increment / Decrement Exercise");
                Console.WriteLine("0. quit");
                Console.Write("chose an option: ");

                string choice = Console.ReadLine();
                Console.Clear();

                switch (choice)
                {
                    case "1":
                        KayakExercise.Run(); // 👈 You’ll add this class next
                        break;
                    case "2":
                        MathExercises.Run(); // 👈 Calls your MathExercises class
                        break;
                    case "3":
                        NewExercise();
                        break;
                    case "4":
                        IncrementDecrement.Run(); // 👈 Calls IncrementDecrement class
                        break;
                    case "0":
                        running = false;
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

        // === Midlertidig NewExercise (kan også flyttes ud senere) ===
        static void NewExercise()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Ny Øvelse");
            Console.ResetColor();

            int a = 5;
            a += 3;
            Console.WriteLine(a);

            int b = 100;
            b -= 10;
            Console.WriteLine(b);
        }
    }
}
