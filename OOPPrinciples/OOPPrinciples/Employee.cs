using OOPPrinciples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciples
{
    internal abstract class Employee
    {
        public string employeeName;
        public Employee(string employeeName)
        {
            this.employeeName = employeeName;
        }

        public abstract decimal CalculateSalary();

    }
    class FullTimeEmployee : Employee
    {
        private decimal _monthlySalary;

        public FullTimeEmployee(string name, decimal monthlySalary) : base(name)
        {
            _monthlySalary = monthlySalary;
        }

        public override decimal CalculateSalary()
        {
            return _monthlySalary;
        }
    }

    class PartTimeEmployee : Employee
    {
        public decimal HourlyRate { get; set; }
        public int HoursWorked { get; set; }

        public PartTimeEmployee(string name, decimal hourlyRate, int hoursWorked) : base(name)
        {
            HourlyRate = hourlyRate;
            HoursWorked = hoursWorked;
        }

        public override decimal CalculateSalary()
        {
            return HourlyRate * HoursWorked;
        }
    }

}
