using System;
using System.IO;

namespace Document
{
    class Program
    {
        static void Main(string[] args)
        {
            string loop = "y";

            while (loop == "y")
            {
                Console.WriteLine("Document\n");

                Console.WriteLine("Enter the name of the document");
                string name = Console.ReadLine();

                using(StreamWriter fileWriter = new StreamWriter($"{name}.txt"))
                {
                    Console.WriteLine("Enter the content to be written to the document");
                    string input = Console.ReadLine();
                    fileWriter.WriteLine($"{input}");

                    int wordCount = 0;
                    for(int i = 0; i <= input.Length - 1; i++)
                    {
                        if(input[i] == ' ')
                        {
                            wordCount++;
                        }
                    }
                    wordCount++;
                    
                    Console.WriteLine($"{name}.txt was successfully saved. The document contains {wordCount} words.");
                }

                Console.WriteLine("To create another file type 'y'. Type any other key to exit");
                loop = Console.ReadLine();
            }
            Environment.Exit(0);
        }
    }
}