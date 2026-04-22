using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethod
{
    public class Converter
    {
        public static double CelsiusYoFahrenheit(double celsius)
        {
            return (celsius * 1.8) + 32;
        }
        public static double KilometersToMiles(double kilometers)
        {
            return kilometers * 0.621371;
        }
    }
}
