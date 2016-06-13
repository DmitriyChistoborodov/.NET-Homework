using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures.Lesson1
{
    public static class LinkedListUtils
    {
        /// <summary>
        /// TASK: Напишите программу, которая удаляет все узлы связанного списка, находящиеся в позициях с номерами кратными пяти. 
        /// </summary>
        public static void RemoveMultiplesOf<T>(this LinkedList<T> linkedList, int number)
        {
            // Зачинаем с головы
            var current = linkedList.First;
            for (int i = 1; current != null; i++)
            {
                // Заранее узнаем следующий узел, так как при удалении текущено узла
                // следующий узел узнать уже мы не сможем
                var next = current.Next;

                // Кратен ли итератор указаному числу в аргументе
                if (i % number == 0)
                    linkedList.Remove(current); // Собственно удаляем узел

                current = next; // Переходим к следующему узлу
            }
        }
    }
}
