using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //Init
            var words = new[] { "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten" };
            var linkedList = new CustomLinkedList<string>(words);

            // Напишите программу, которая удаляет все узлы связанного списка, 
            // находящиеся в позициях с номерами кратными пяти.
            linkedList.RemoveMultiplesOf(5);
            linkedList.OutputConsole("RemoveMultiplesOf:");

            // Задайте двухвсязный список размерностью десять элементов, добавьте три 
            // произвольных элемента после пятого, использовав для этого метод AddAfter(). 
            linkedList.AddAfterRange(linkedList.First.Next.Next.Next.Next, "node1", "node2", "node3");
            linkedList.OutputConsole("AddAfterRange:");

            // Добавьте по элементу в начало и в конец списка, использовав для этого методы AddFirst(), AddLast().
            linkedList.AddFirstAndLast("first", "last");
            linkedList.OutputConsole("AddFirstAndLast:");

            // Использовав метод Remove() удалите из списка все элементы. 
            linkedList.RemoveAll();
            linkedList.OutputConsole("RemoveAll:");

            Console.ReadKey();
        }
    }
}
