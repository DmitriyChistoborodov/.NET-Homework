using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmsAndDataStructures.Lesson1;
using AlgorithmsAndDataStructures.Lesson2;

namespace AlgorithmsAndDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            //Init
            var words = new[] { "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten" };
            var linkedList = new LinkedList<string>(words);

            //TASK1
            linkedList.RemoveMultiplesOf(5);
            linkedList.OutputConsole("RemoveMultiplesOf:");

            //TASK2
            linkedList.AddAfterRange(linkedList.First.Next.Next.Next.Next,"node1","node2","node3");
            linkedList.OutputConsole("AddAfterRange:");

            //TASK3
            linkedList.AddFirstAndLast("first", "last");
            linkedList.OutputConsole("AddFirstAndLast:");

            //TASK4
            linkedList.RemoveAll();
            linkedList.OutputConsole("RemoveAll:");

            //TASK5
            var customArrayList = new CustomArrayList<string>(new LinkedList<string>(words));
            customArrayList.OutputConsole();

            //TASK6
            customArrayList = new CustomArrayList<string>(new[] { "Dmitriy", "Artem", "Boris", "Andrey" });
            customArrayList.Add("Georgy");
            customArrayList.Add("Alla");
            customArrayList.OutputConsole();

            Console.ReadKey();
        }
    }
}
