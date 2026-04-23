using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAndException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the first number ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Seconde number ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Calculator calculator = new Calculator();
                int sum = calculator.Add(num1, num2);

                Console.WriteLine($"the summation of {num1} + {num2} = {sum}");
            }
            catch (Exception ex) { 
            Console.WriteLine(ex.Message);
            
            }
        }
    }
}
