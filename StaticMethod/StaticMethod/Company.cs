using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethod
{
    public class Company
    {
        public static string companyName = "orange";

        public string employeeName;
        public Company(string employeeName)
        {
            this.employeeName = employeeName;
        }

        public void displayInfo()
        {
            Console.WriteLine($"Company Name {companyName} have Employee {employeeName}");
        }


    }
}
