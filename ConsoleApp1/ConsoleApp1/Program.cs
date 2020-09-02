// Cale Reinking
using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\Charlene\Downloads\Pride and Prejudice by Jane Austen.txt";
            //Either do double back slashes or add the @ symbol so it can read it 

            // string contentsoffile = File.ReadAllText(filePath);
            //MAke sure it says using system.IO at top by using light bulb
            var lines = File.ReadAllLines(filePath);

            //Output the first 5 lines of the book with a loop
            // for (int i = 0; i < lines.Length; i++)
            // {
            //    if (i % 5 == 0 && i != 0)
            //  {
            //    Console.ReadKey();
            //}
            // Console.WriteLine(lines[i]);
            // }

            //Console.WriteLine(lines);
            for (int i = 0; i < lines.Length; i++)
            {
                string currentLine = lines[i];
                if (currentLine.Contains("Chapter"))
                {
                    Console.ReadKey();
                }
                Console.WriteLine(currentLine);
            }



        }
    }
}
