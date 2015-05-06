using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenFibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = fibonacciSequence();

            //The sum of the even numbers within the fibonacci
            //sequence (not exceeding 4,000,000) equeals 4,613,732
            Console.WriteLine("Sum of all even-valued terms in Fibonacci Sequence = {0:n0}", sum);
            Console.ReadLine();
        }

        static int fibonacciSequence()
        {
            int a = 1;
            int b = 2;
            int c = 0;
            int sum = 2;

            while (c < 4000000)
            {
                c = b + a;
                a = b;
                b = c;

                if (c % 2 == 0 && c < 4000000)
                    sum = sum + c;
            }

            return sum;
        }
    }
}
