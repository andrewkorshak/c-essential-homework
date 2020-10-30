using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Adress instance1 = new Adress();
            instance1.Index = "07400";
            instance1.Country = "Ukraine";
            instance1.City = "Brovary";
            instance1.Street = "My street";
            instance1.House = "44";
            instance1.Apartment = "22";

            Console.WriteLine(instance1.Index);
            Console.WriteLine(instance1.Country);
            Console.WriteLine(instance1.City);
            Console.WriteLine(instance1.Street);
            Console.WriteLine(instance1.House);
            Console.WriteLine(instance1.Apartment);
            Console.ReadKey();
        }
    }
}
