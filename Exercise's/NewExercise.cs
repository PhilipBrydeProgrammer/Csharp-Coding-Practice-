using System;

namespace cody_practice_v2.Exercise_s
{
    public class NewExercise
    {
        public static void Run()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Ny Øvelse");
            Console.ResetColor();

            int a = 5;
            a += 3; 
            Console.WriteLine(a);

            int b = 100;
            b-= 10; 
            Console.WriteLine(b);

        }

    }
}