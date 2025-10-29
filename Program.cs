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
                Console.WriteLine("5. Array + Simple Exercise");
                Console.WriteLine("0. Quit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();
                Console.Clear();

                switch (choice)
                {
                    case "1":
                        KayakExercise.Run();
                        break;
                    case "2":
                        MathExercises.Run();
                        break;
                    case "3":
                        NewExercise();
                        break;
                    case "4":
                        IncrementDecrement.Run();
                        break;
                    case "5":
                        ArrayExercise.Run(); // 👈 Moved the other Program code here
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

    // 👇 Moved the “array + Simple” logic into its own class
    class ArrayExercise
    {
        public static void Run()
        {
            int[] arr = new int[] { 4, 6, 2, 33, 5 };
            int svar = A(arr);
            Console.WriteLine(svar);

            Simple person = new Simple();
            person.ShowInfo();
        }

        static int A(int[] arr)
        {
            int pos = arr.Length - 1;
            return arr[pos];
        }
    }

    class Simple
    {
        int age = 23;
        string name = "Philip Bryde";
        string occupation = "*Athlete*";

        public void ShowInfo()
        {
            Console.WriteLine($"{name} {age} {occupation}");
        }
    }
}
