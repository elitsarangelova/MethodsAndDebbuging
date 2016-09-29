using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyEvenByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sumEvens = GetSumOfEvenDigits(n);
            int sumOdds = GetSumOfOddDigits(n);
            int result = Math.Abs(sumEvens * sumOdds);
            Console.WriteLine(result);

        }
        static int GetMultipleEvensAndOdds(int n)
        {
           
            int result = Math.Abs(sumEvens * sumOdds);
            return result;
        }
       
        static int GetSumOfOddDigits(int n)
        {
            int sumOdds = 0;
            while (n>0)
            {
                int lastDigit = n % 10;
                if (lastDigit%2!=0)
                {
                   Math.Abs(sumOdds += lastDigit);
                }
                n /= 10;
            }
            return sumOdds;
        }
        static int GetSumOfEvenDigits(int n)
        {
            int sumEvens = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 != 0)
                {
                    Math.Abs(sumEvens+=lastDigit);
                }
                n /= 10;
            }
            return sumEvens;
        }
    }

}
