using System;

namespace PythonChallengeInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //Problem0();
            //Problem1();

            FileHandling file = new FileHandling();
            file.basic(); 


            Console.ReadKey();
        }

        // Okay, so here we go...
        /* Problem 0, image of a 2^38
         *
         * Learned about Pow, it's double - https://stackoverflow.com/questions/3034604/is-there-an-exponent-operator-in-c
         */
        static void Problem0()
        {
            double Result, Number1, Number2;

            Number1 = 2;
            Number2 = 38;

            Result = Math.Pow(Number1, Number2);
            Console.WriteLine(Result);
        }

        /*
         * Problem 1 - http://www.pythonchallenge.com/pc/def/map.html
         * Now to learn how to swap letters...
         * 
         * So we can add a number to a char and "shift" it forward. Interesting...
         * That means, for our cypher, we can go letter by letter and add the shift, then add the output to an exit string...
         * ASCII usage ftw - https://upload.wikimedia.org/wikipedia/commons/thumb/d/dd/ASCII-Table.svg/1200px-ASCII-Table.svg.png
         */
        static void Problem1()
        {

            //char test = 'a';
            //char output = (char) (test + 2);
            //Console.WriteLine(output);

            //string cypher = "g fmnc wms bgblr rpylqjyrc gr zw fylb. rfyrq ufyr amknsrcpq ypc dmp. bmgle gr gl zw fylb gq glcddgagclr ylb rfyr'q ufw rfgq rcvr gq qm jmle. sqgle qrpgle.kyicrpylq() gq pcamkkclbcb. lmu ynnjw ml rfc spj. ";
            string cypher = "map";
            int shift = 2;
            foreach (char letter in cypher)
            {
                if (letter < 97)
                {
                    Console.Write((char)(letter));
                } else if (letter > 120)
                {
                    Console.Write((char)(97 + (2 - shift)));
                } else
                {
                    Console.Write((char)(letter + shift));

                }
            }
        }

    }
}
