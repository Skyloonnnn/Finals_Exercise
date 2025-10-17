using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Bag schoolbag = new SchoolBag("Nike", "Black", 1300, 3);
            Bag travelbag = new TravelBag("Puma", "White", 2500, 5);

            schoolbag.DisplayDetails();
            schoolbag.CalculateDiscount(25);
            schoolbag.Carry();

            travelbag.DisplayDetails();
            travelbag.CalculateDiscount(30);
            schoolbag.Carry();

            Console.ReadKey();
        }
    }
}
