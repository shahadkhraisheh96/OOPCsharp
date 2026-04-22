using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal myDog = new Dog();
            Animal myCat = new Cat();

            myDog.MakeSound(); 
            myCat.MakeSound();

            Appliance laundry = new WashingMachine("Samsung");
            Appliance cooling = new AirConditioner("LG");

            laundry.TurnOn();
            laundry.TurnOff();


            cooling.TurnOn();
            cooling.TurnOff();

            BankAccount myAccount = new BankAccount();

            myAccount.Deposit(500);
            myAccount.Withdraw(200);
            myAccount.Withdraw(400); 

            Console.WriteLine($"Final Statement Balance: ${myAccount.balance}");




            Employee ft = new FullTimeEmployee("shahd", 5000m);
            Employee pt = new PartTimeEmployee("farah", 25m, 80);

            Console.WriteLine($"{ft.employeeName}'s Salary: ${ft.CalculateSalary():N2}");
            //Console.WriteLine($"{pt.employeeName}'s Salary: ${pt.CalculateSalary():N2}");
        }
    }
}
