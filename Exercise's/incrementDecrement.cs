using System;

namespace cody_practice_v2.Exercise_s

{
    public class IncrementDecrement 
    {
        public static void Run()
        {
         int a = 5;
         a++;
         a = a* 2;
         a--;

         Console.WriteLine(a);

         //short cut til increment/decrement 
         int b = 10;
         b += 10;
         Console.WriteLine(b);

         //bool true false greater or equal to coody example 
         int c = 10;
         int d = 10;
         bool result = c <= d;
         Console.WriteLine(c <=d);

         //coody lesson bool to see if n1 is greater then n2     
         var n1 = 8;
         var n2 = 9;
         bool n3 = n1 > n2;
         Console.WriteLine(n3);
        }

    }
}