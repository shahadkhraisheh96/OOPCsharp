using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciples
{
    internal abstract class Appliance
    {
        public string Brand { get; set; }

        protected Appliance(string brand)
        {
            Brand = brand;
        }

        public abstract void TurnOn();
        public abstract void TurnOff();
    }

    class WashingMachine : Appliance
    {
        public WashingMachine(string brand) : base(brand) { }

        public override void TurnOn()
        {
            Console.WriteLine($"{Brand} Washing Machine: Locking door... Starting wash cycle.");
        }

        public override void TurnOff()
        {
            Console.WriteLine($"{Brand} Washing Machine: Cycle complete. Unlocking door.");
        }
    }

    class AirConditioner : Appliance
    {
        public AirConditioner(string brand) : base(brand) { }

        public override void TurnOn()
        {
            Console.WriteLine($"{Brand} AC: Compressor active. Cooling mode engaged.");
        }

        public override void TurnOff()
        {
            Console.WriteLine($"{Brand} AC: Fan slowing down. Shutdown complete.");
        }

    }
}
