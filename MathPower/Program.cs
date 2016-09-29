using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            double result = Math.Pow(a, power);
            Console.WriteLine(result);

        }
        static double ReisePower(double a, double power)
        {
            double result = 0d;
            return result;
           
        }
    }
}
