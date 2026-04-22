using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciples
{
    public class OverloadingMethod
    {
        public double Add(double num1, double num2) { 
        
        return num1 + num2;
        }
        public double Add(double num1, double num2,double num3)
        {

            return num1 + num2 +num3;
        }
        public decimal Add(decimal num1, decimal num2, decimal num3 ,decimal num4)
        { 
            return num1 + num2 + num3+num4;
        }
    }
}
