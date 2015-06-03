using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsecutiveNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[100];
            string[] primeNumbers = new string[25];
            int counter = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                numbers[i] = i;

                if (isPrime(numbers[i]))
                {
                    primeNumbers[counter] = Convert.ToString((numbers[i]));
                    counter++;
                }   
            }

            File.WriteAllLines(@"C:\Work\Claim\Project2-NET041815\answers\primearray.txt", primeNumbers);

            Consecutive.MakeConsecutive();

            Console.ReadLine();
        }

        static bool isPrime(int number)
        {
            double boundary = Math.Floor(Math.Sqrt(number));

            if (number == 1) return false;
            if (number == 2) return true;

            for (int i = 2; i <= boundary; ++i)
            {
                if (number % i == 0)  
                    return false;
            }

            return true;  
        }
    }

    class Consecutive
    {
        internal static void MakeConsecutive()
        {
            string path = @"C:\Work\Claim\Project2-NET041815\answers\primearray.txt";
        }
    }
}
