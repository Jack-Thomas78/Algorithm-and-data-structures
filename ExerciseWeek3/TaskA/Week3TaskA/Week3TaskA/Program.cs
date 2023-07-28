using System;
using System.IO;

namespace Week3TaskA
{
    class Program
    {

        static void readFile(string fileName)
        {
            BSTree<string> wordTree = new BSTree<string>();

            const int MAX_FILE_LINES = 50000;
            string[] AllLines = new string[MAX_FILE_LINES];

            //reads from bin/DEBUG subdirectory of project directory
            AllLines = File.ReadAllLines(fileName);


            foreach (string line in AllLines)
            {
                //split words using space , . ?
                string[] words = line.Split(' ', ',', '.', '?', ';', ':', '!');
                foreach (string word in words)
                {
                    if (word != "")
                    {
                        Console.WriteLine(word.ToLower());
                        wordTree.AddItem(word.ToLower());
                    }
                        
                }
                    
            }
            Console.WriteLine("Number of Words = "+ wordTree.Count());
            Console.WriteLine("Height of tree = "+ wordTree.Height());
        }

        static void Main(string[] args)
        {
            
            readFile("textFile.txt");
            
        }
    }
}
