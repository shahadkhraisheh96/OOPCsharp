using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathUtilities
{
    static class MathUtilities
    {
        
        public static double squareNumber(int num)
        {
            return Math.Pow(2, num);
        }
        public static double squareRoot(double num)
        {
            return Math.Sqrt(num);
        }
        public static double MaximumNumber(double num1, double num2)
        {
            {
                return Math.Max(num1, num2);
            }

        }
    }
        internal class Program
        {

            static void Main(string[] args)
            {

            double max = MathUtilities.MaximumNumber(2, 55);
            double squareNumber = MathUtilities.squareNumber(3);
            double squareRoot=MathUtilities.squareRoot(squareNumber);
            
            Console.WriteLine($"the square Root of {squareNumber} is {squareRoot}");
            Console.WriteLine($"the square Number of 3 = {squareNumber}");
            Console.WriteLine($"the Maximum of 2 and 55 is {max}");

            }
        }
    }
