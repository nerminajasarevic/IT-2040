using System;

namespace Automobile
{
    class Automobile
    {
        enum autoType
        {
            Sedan,
            Truck,
            Van,
            SUV
        }

        private string make;
        private string model;
        private string vin;
        private string color;
        private int year;
        private autoType type;

        public Automobile(string carMake, string carModel, string carVin, string carColor, int carYear, autoType carType)
        {
            make = carMake;
            model = carModel;
            vin = carVin;
            color = carColor;
            year = carYear;
            type = carType;
        }

        public string getMake 
        {
            get { return make; }
        }

        public string getModel 
        {
            get { return model; }
        }

        public string getVin
        {
            get { return vin; }
        }

        public string getColor 
        {
            get { return color; }
        }

        public int getYear
        {
            get { return year; }
        }

        public autoType getType
        {
            get { return type; }
        }

        public string setColor
        {
            set { color = value;}
        }

    }

    public int getAutoAge()
    {
        int currentYear = 2022;
        int autoYear = int.Parse(getYear);

        return currentYear - autoYear;
    }

    class Program
    {
        Console.WriteLine("\nCreating the first Automobile\n---------------");
        Automobile auto1 = new Automobile("Tesla", "Model X", 2020, "12345", "blue", AutoType.Sedan);
        Console.WriteLine($"Make: {auto1.getMake()} \nModel: {auto1.getModel()}\nYear: {auto1.getYear()}\nType: {auto1.getType()} \nVIN: {auto1.getVin()}");
        Console.WriteLine($"Color: {auto1.getColor()}");
        Console.WriteLine("\nChanging the Colour\n---------------");
        auto1.setColor("black");
        Console.WriteLine($"Color: {auto1.getColor()}");

        Console.WriteLine("\nCreating the second Automobile\n---------------");
        Automobile auto2 = new Automobile("Mercedes", "G-Wagon", 2017, "24578", "silver", AutoType.SUV);
        Console.WriteLine($"Make: {auto2.getMake()}\nModel: {auto2.getModel()}\nYear: {auto2.getYear()}\nType: {auto2.getType()}\nVIN: {auto2.getVin()}");

        Console.WriteLine("\nPrinting Automobile Ages\n---------------");
        Console.WriteLine($"Auto1 Age: {auto1.getAutoAge()} years");
        Console.WriteLine($"Auto2 Age: {auto2.getAutoAge()} years");
    }
}