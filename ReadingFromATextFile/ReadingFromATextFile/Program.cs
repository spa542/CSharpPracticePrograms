using System;
using System.IO;

namespace ReadingFromATextFile
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Reading from a text file
            string text = System.IO.File.ReadAllText(@"C:\Users\Test\Documents\C#PracticePrograms\textFilePractice.txt");

            Console.WriteLine("TextFile contains following text: {0}", text);

            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Test\Documents\C#PracticePrograms\textFIlePractice.txt");

            Console.WriteLine("Contents of textFilePractice.txt");
            foreach(string line in lines)
            {
                Console.WriteLine("\t" + line);
            }
            */
            string[] lines = { "First line", "Second line", "Third line" };
            File.WriteAllLines(@"C:\Users\Test\Documents\C#PracticePrograms\textFilePractice.txt", lines);

            Console.WriteLine("Please give the file a name");
            string fileName = Console.ReadLine();
            Console.WriteLine("Please enter the text for the file");
            string input = Console.ReadLine();
            File.WriteAllText(@"C:\Users\Test\Documents\C#PracticePrograms\" + fileName + ".txt", input);

            using (StreamWriter file = new StreamWriter(@"C:\Users\Test\Documents\C#PracticePrograms\myText.txt"))
            {
                foreach(string line in lines)
                {
                    if (line.Contains("Third"))
                    {
                        file.WriteLine(line);
                    }
                }
            }

            using(StreamWriter file = new StreamWriter(@"C:\Users\Test\Documents\C#PracticePrograms\myText2.txt", true))
            {
                file.WriteLine("Additional Line");
            }
            Console.Read();
        }
    }
}
