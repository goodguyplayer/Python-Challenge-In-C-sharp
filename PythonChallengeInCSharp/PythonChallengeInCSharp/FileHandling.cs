using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace PythonChallengeInCSharp
{
    /*
     * Class used for handling files.
     * Basic stuff, load file, read file, write file, what have you.
     */ 
    class FileHandling
    {
        // Honestly, mostly making this one to see where the file is created.
        // https://www.w3schools.com/cs/cs_files.asp
        public void basic()
        {

            string writeText = "Hello World!";  // Create a text string
            File.WriteAllText("filename.txt", writeText);  // Create a file and write the content of writeText to it

            string readText = File.ReadAllText("filename.txt");  // Read the contents of the file
            Console.WriteLine(readText);  // Output the content
        }

        /*
         * Takes a string for filename and return it
         */ 
        public string readFile(string name)
        {
            string readText = File.ReadAllText(name);  // Read the contents of the file
            return readText;
        }

    }
}
