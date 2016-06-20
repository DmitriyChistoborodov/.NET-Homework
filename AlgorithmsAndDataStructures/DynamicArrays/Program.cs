using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = new[] { "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten" };

            // Реализовать динамический массив на основе статического. 
            var ArrayDynamicList = new ArrayDynamicList<string>(words);
            ArrayDynamicList.OutputConsole();

            // Реализовать динамический массив на основе двусвязного списка (LinkedList<T>).
            var LinkedDynamicList = new LinkedDynamicList<string>(words);
            LinkedDynamicList.Add("Eleven");
            LinkedDynamicList.OutputConsole();

            Console.ReadKey();
        }
    }
}
