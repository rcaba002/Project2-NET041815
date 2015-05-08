using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphabetizedList
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = File.ReadLines("names.txt").Skip(440).Take(1).First();

            //get rid of unnecessary characters and spaces
            line = line.Replace("<td id=\"LC1\" class=\"blob-code blob-code-inner js-file-line\">&quot;", "");
            line = line.Replace("&quot;", "");
            line = line.Replace("        ", "");
            line = line.Replace("</td>", "");

            string[] words = line.Split(',');

            Array.Sort(words);

            Console.WriteLine("Creating new file (p4aNames.txt)...");

            foreach (string word in words)
            {
                string text = Environment.NewLine + word;
                System.IO.File.AppendAllText(@"C:\Work\Claim\Project2-NET041815\answers\p4aNames.txt", text);
            }

            Console.Write("Complete. Press any key... ");
            Console.ReadKey();

            Dictionary<char, int> dictionary = new Dictionary<char, int>();
            dictionary.Add('A', 1);
            dictionary.Add('B', 2);
            dictionary.Add('C', 3);
            dictionary.Add('D', 4);
            dictionary.Add('E', 5);
            dictionary.Add('F', 6);
            dictionary.Add('G', 7);
            dictionary.Add('H', 8);
            dictionary.Add('I', 9);
            dictionary.Add('J', 10);
            dictionary.Add('K', 11);
            dictionary.Add('L', 12);
            dictionary.Add('M', 13);
            dictionary.Add('N', 14);
            dictionary.Add('O', 15);
            dictionary.Add('P', 16);
            dictionary.Add('Q', 17);
            dictionary.Add('R', 18);
            dictionary.Add('S', 19);
            dictionary.Add('T', 20);
            dictionary.Add('U', 21);
            dictionary.Add('V', 22);
            dictionary.Add('W', 23);
            dictionary.Add('X', 24);
            dictionary.Add('Y', 25);
            dictionary.Add('Z', 26);

            int alphaValue = 0;
            int alphaValueTotal = 0;
            int alphaPosition = 1;
            int nameScore = 0;
            int totalNameScores = 0;

            StreamReader myReader = new StreamReader("p4aNames.txt");
            string newLine = "";

            Console.WriteLine("Creating new file (p4bNames.txt)...");

            while (newLine != null)
            {
                newLine = myReader.ReadLine();
                if (newLine != null)
                {
                    foreach (char letter in newLine)
                    {
                        if (dictionary.TryGetValue(letter, out alphaValue))
                        {
                            alphaValueTotal = alphaValueTotal + alphaValue;
                        }
                    }

                    nameScore = alphaValueTotal * alphaPosition;
                    totalNameScores = totalNameScores + nameScore;

                    string text = Environment.NewLine + nameScore;
                    System.IO.File.AppendAllText(@"C:\Work\Claim\Project2-NET041815\answers\p4bNames.txt", text);

                    alphaValueTotal = 0;
                    alphaPosition++;
                }
            }

            myReader.Close();

            Console.Write("Complete. Press any key... ");
            Console.ReadKey();

            Console.WriteLine("Total of all name scores in file: {0:N0}", totalNameScores);
            Console.Write("Press any key to exit... ");

            Console.ReadLine();
        }
    }
}