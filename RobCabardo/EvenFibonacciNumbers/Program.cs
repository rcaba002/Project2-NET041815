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
            int sum = getSumOfEvenFibNums();

            //The sum of the even numbers within the fibonacci
            //sequence (not exceeding 4,000,000) equeals 4,613,732
            Console.WriteLine("Sum of all even-valued terms in Fibonacci Sequence = {0:n0}", sum);
            Console.ReadLine();
        }

        static int getSumOfEvenFibNums()
        {
            int firstNum = 1;
            int secondNum = 2;
            int total = 0;
            int sum = 2;

            while (total < 4000000)
            {
                total = secondNum + firstNum;
                firstNum = secondNum;
                secondNum = total;

                if (total % 2 == 0 && total < 4000000)
                    sum = sum + total;
            }

            return sum;
        }
    }
}
