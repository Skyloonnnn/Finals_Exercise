using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymophism
{
    class Program
    {
        static void Main(string[] args)
        {
            Shoe running = new RunningShoe
            {
                Brand = "New Balance",
                Model = "FuelCell Rebel v5",
                Size = 9.5
            };

            Shoe basketball = new BasketShoe
            {
                Brand = "Nike",
                Model = "Nike Book 1",
                Colorway = "White"
            };

            running.DisplayInfo();
            basketball.DisplayInfo();

            Console.ReadKey();
        }
    }
}
