using System;

namespace PythonChallengeInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Problem0();
            Console.ReadKey();
        }

        // Okay, so here we go...
        /* Problem 0, image of a 2^38
         *
         */
        static void Problem0()
        {
            double Result, Number1, Number2;

            Number1 = 2;
            Number2 = 2;

            Result = Math.Pow(Number1, Number2);
            Console.WriteLine(Result);
        }

    }
}
