using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymophism
{
    class Shoe
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Model: {Model}");
        }

    }

    class RunningShoe : Shoe
    {
        public double Size { get; set; }

        public override void DisplayInfo()
        {
            Console.WriteLine("Running Shoe Information");
            base.DisplayInfo();
            Console.WriteLine($"Size: {Size}\n");
        }
    }

    class BasketShoe : Shoe
    {
        public string Colorway { get; set; }

        public override void DisplayInfo()
        {
            Console.WriteLine("BasketBall Shoe Information");
            base.DisplayInfo();
            Console.WriteLine($"Color: {Colorway}");
        }
    }
}
