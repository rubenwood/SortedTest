using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedTest
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Here is where all of the tests will go
            /// first create an instance of and object and log its properties to make sure its working
            Item apple = new Item("A99", 0.50m);
            Item bisc = new Item("B15", 0.30m);
            Item crumpet = new Item("C40", 0.60m);

            apple.addOffer(3, 1.30m);
            bisc.addOffer(2, 0.45m);

            /// make sure the Item class has been establilshed, log out some info belonging to an Item
            Console.WriteLine(apple.SKU);
            Console.WriteLine(apple.UnitPrice);

            Console.ReadKey();
        }
    }
}
