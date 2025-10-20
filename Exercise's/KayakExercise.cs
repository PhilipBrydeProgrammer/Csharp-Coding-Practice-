using System;

namespace cody_practice_v2.Exercise_s
{
    public class KayakExercise
    {
        // Offentlig static metode som Program.cs kan kalde
        public static void Run()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Kayak øvelse med variabler");
            Console.ResetColor();

            int numberOfKayaks = 30;
            string kayakBrand1 = "Nelo";
            string kayakBrand2 = "Plastex";

            Console.WriteLine(kayakBrand1 + numberOfKayaks);
            Console.WriteLine(kayakBrand2);
        }
    }
}