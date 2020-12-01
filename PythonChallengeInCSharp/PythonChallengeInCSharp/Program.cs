using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace PythonChallengeInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //Problem0();
            //Problem1();
            //Problem2();

            Problem3();
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

        /*
         * Problem 2 - http://www.pythonchallenge.com/pc/def/ocr.html
         * It contains a long long string of data in the sourcecode and it's asking us to find rare characters.
         * File is named "forP2.txt". So now we just need to extract the rare characters.
         * 
         * Originally, what I used to do was step one char, read the letter, find all instances, output the total on screen and pop that character out.
         * Wonder if I can do the same here...
         */
         
        static void Problem2()
        {
            // Load file
            FileHandling file = new FileHandling();
            string text = (file.readFile("forP2.txt"));
            
            // I was NOT aware that dictionaries were a thing in c#
            // https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2?view=net-5.0#definition
            Dictionary<char, int> openWith = new Dictionary<char, int>();

            // https://www.codeproject.com/Questions/177626/count-number-of-characters-in-a-string
            foreach (char letter in text)
            {
                if (!openWith.ContainsKey(letter))
                {
                    openWith.Add(letter, 1);
                } else
                {
                    openWith[letter]++;
                }
            }

            // https://stackoverflow.com/questions/141088/what-is-the-best-way-to-iterate-over-a-dictionary
            foreach (KeyValuePair<char, int> entry in openWith)
            {
                // do something with entry.Value or entry.Key
                Console.WriteLine(entry.Key + " - " + entry.Value);
            }

        }

        // http://www.pythonchallenge.com/pc/def/equality.html
        /*
         * Problem 3, here we go.
         * Long string of text, "One small letter, surrounded by EXACTLY three big bodyguards"
         * So basic regex.
         * File is named "forP3.txt".
         * 
         */
        static void Problem3()
        {
            // Load file
            FileHandling file = new FileHandling();
            string text = (file.readFile("forP3.txt"));

            string search = "[^A-Z][A-Z]{3}[a-z]{1}[A-Z]{3}[^A-Z]";

            Regex rgx = new Regex(search);

            foreach (Match match in rgx.Matches(text))
            {
                Console.WriteLine(match.Value);
            }
        }

    }
}
