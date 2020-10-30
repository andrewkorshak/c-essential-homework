using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure figure = new Figure(new Point("A", 2, 2), new Point("B", 4, 2), new Point("C", 3, 6), new Point("D", 10,20), new Point("E", 50, 70));
            Console.WriteLine("{0}", figure.Type);
            Console.Write("P = ");
            figure.PerimeterCalculator();
            Console.ReadKey();
        }
    }
}
