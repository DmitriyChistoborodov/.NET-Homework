using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmsAndDataStructures.Lesson1;

namespace AlgorithmsAndDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Lesson1Task1

            var words = new[] { "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten" };
            var linkedList = new LinkedList<string>(words);

            linkedList.RemoveMultiplesOf(5);

            Console.WriteLine("Напишите программу, которая удаляет все узлы связанного списка, находящиеся в позициях с номерами кратными пяти.");
            foreach (var item in linkedList)
                Console.WriteLine(item);

            #endregion

            Console.ReadKey();
        }
    }
}
