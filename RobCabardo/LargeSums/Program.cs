using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargeSums
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadLines("longnums.txt").ToArray();

            Array.Sort(lines);

            File.WriteAllLines(@"C:\Work\Claim\Project2-NET041815\answers\p5a.txt", lines);

            double Sum = 0; 
            string eachLine = ""; 

            foreach (var line in lines) 
            { 
                char[] answer = line.ToCharArray(); 
            
                for (int i = 0; i < 50; i++) 
                { 
                    eachLine += answer[i]; 
                } 

                Sum += Convert.ToDouble(eachLine); 
                eachLine = ""; 
            }

            string firstTenDigits = Convert.ToString(Sum).Substring(0, 11);

            Console.WriteLine("First 10 digits of the sum of all 100 numbers: {0}", firstTenDigits.Remove(1,1));
            Console.ReadLine();
        }
    }
}
