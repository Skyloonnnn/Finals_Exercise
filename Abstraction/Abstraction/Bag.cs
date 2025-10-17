using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    abstract class Bag // abstract class
    {
        // properties of bag 
        public string Brand { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }

        //parameterized construtor
        public Bag(string brand, string color, double price)
        {
            Brand = brand;
            Color = color;
            Price = price;
        }

        //abstract method
        public abstract void DisplayDetails();
        public abstract void CalculateDiscount(double percent);

        //concrete method
        public void Carry()
        {
            Console.WriteLine($"{Brand} bag is being carried.\n");
        }
    }

    class SchoolBag : Bag // derived class
    {
        //property for schoolbag
        public int NumberOfCompartments { get; set; }

        //parameterized constructor
        public SchoolBag(string brand, string color, double price, int compartments) : base (brand, color, price)
        {
            NumberOfCompartments = compartments;
        }

        //  implementation of abstract method
        public override void DisplayDetails()
        {
            Console.WriteLine("SchoolBag Details\n");
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Compartments: {NumberOfCompartments}\n");
        }

        // implementation of abstract method
        public override void CalculateDiscount(double percent)
        {
            double discount = Price * (percent / 100);
            Price -= discount;
            Console.WriteLine($"Discount Applied: {percent}%");
            Console.WriteLine($"New Price: {Price}\n");
        }
    }

    class TravelBag : Bag //Derived class
    {
        //Properties of TravelBag
        public double Capacity { get; set; } // in liters

        public TravelBag(string brand, string color, double price, double capacity)
            : base(brand, color, price)
        {
            Capacity = capacity;
        }

        // implementation of abstract method
        public override void DisplayDetails()
        {
            Console.WriteLine("Travel Bag Details\n");
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Capacity: {Capacity} liters\n");
        }

        // implementation of abstract method
        public override void CalculateDiscount(double percent)
        {
            double discount = Price * (percent / 100);
            Price -= discount;
            Console.WriteLine($"Discount Applied: {percent}%");
            Console.WriteLine($"New Price: {Price}\n");
        }
    }
}
