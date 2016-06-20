using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class Program
    {
        static void Output<T>(T[] items)
        {
            Console.WriteLine();
            foreach (var item in items)
            {
                Console.Write(item + " ");
            }
        }

        static void Main(string[] args)
        {
            var items = new[] { 0, 3, 6, 4, 2, 5, 7, 9, 8 };
            Output(items);

            items.MyBubbleSort();
            Output(items);

            Console.ReadKey();
        }
    }
}
