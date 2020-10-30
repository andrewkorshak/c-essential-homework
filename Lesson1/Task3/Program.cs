using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {         
        static void Main(string[] args)
        {
            string content = "Здесь находится контент";

            Book book = new Book("Автор1", "Автор2", content);

            book.Show();

            Console.ReadKey();

        }
    }
}
