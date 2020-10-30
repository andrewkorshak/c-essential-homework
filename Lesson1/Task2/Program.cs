using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите side1:");
            double side1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите side2:");
            double side2 = Convert.ToDouble(Console.ReadLine());

            Rectangle instance1 = new Rectangle(side1,side2);

            Console.WriteLine("Area = {0}, perimeter = {1}",instance1.Area, instance1.Perimeter);
            Console.ReadKey();
        }
    }
}
