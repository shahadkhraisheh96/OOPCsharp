using System.Runtime.CompilerServices;

namespace oopTask2 {

    class Car
    {
        public int Year { get; set; }
        public string Type { get; set; }
        public double Price { get; set; }
        public string Model { get; set; }
        public string PalletNo { get; set; }
        public string Color { get; set; }
        public static bool Engine = false;
        public Car(int year, string type, double price, string model, string palletNo, string color)
        {
            this.Year = year;
            this.Type = type;
            this.Price = price;
            this.Model = model;
            this.PalletNo = palletNo;
            this.Color = color;
            Engine = false;
        }
        public bool StartEngine()
        {
            Engine = true;
            return Engine;
        }
        public bool StopEngine()
        {
            Engine = false;
            return Engine;
        }
        public void Print()
        {
            Console.WriteLine($"Car Details \n" +
               $"Year: {Year}\n" +
               $"Type: {Type}\n" +
               $"Price: ${Price}\n" +
               $"Pallet No: {PalletNo}\n" +
               $"Color: {Color}");
        }

   
    public static void Main()
        {
            Car myCar = new Car(2024, "Electric Sedan", 45000.00, "Model 3", "ABC-1234", "Deep Blue");

            myCar.Print();



            myCar.StartEngine();
            myCar.StopEngine();
        }

    }
}


