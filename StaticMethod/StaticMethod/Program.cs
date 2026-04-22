using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethod
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit = Converter.CelsiusYoFahrenheit(25);
            double miles = Converter.KilometersToMiles(10);


            Console.WriteLine("25°C is " + fahrenheit + "°F");
            Console.WriteLine("10km is " + miles + " miles");

            
            VisitorCounter v1= new VisitorCounter();
            VisitorCounter v2 = new VisitorCounter();
            VisitorCounter v3 = new VisitorCounter();
            Console.WriteLine("the visitor couner = " + v2.display());


        }
    }
}
