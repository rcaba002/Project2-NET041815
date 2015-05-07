using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a string of any kind: ");
            string userInput = Console.ReadLine();

            char[] array = userInput.ToLower().ToCharArray();
            char[] alphabet = new char[26] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            int x = 0;

            for (int i = 0; x < array.Length; i++)
            {
                if (i == 26)
                {
                    x++;
                    i = -1;
                    continue;
                }
                if (array[x] == alphabet[i])
                {
                    if (array[x] == 'z')
                        Console.Write("a");
                    else
                    {
                        Console.Write(alphabet[i + 1]);
                        x++;
                        i = -1;
                    }
                }
            }

            Console.ReadLine();
        }
    }
}