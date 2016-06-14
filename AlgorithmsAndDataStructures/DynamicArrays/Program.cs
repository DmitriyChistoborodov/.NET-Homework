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

            // Реализовать динамический массив на основе двусвязного списка (LinkedList<T>). 
            var customArrayList = new CustomArrayList<string>(new LinkedList<string>(words));
            customArrayList.OutputConsole();

            // Реализовать динамический массив на основе статического. 
            customArrayList = new CustomArrayList<string>(words);
            customArrayList.Add("Eleven");
            customArrayList.OutputConsole();

            Console.ReadKey();
        }
    }
}
