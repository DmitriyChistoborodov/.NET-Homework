using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures.Lesson1
{
    public static class LinkedListUtils
    {
        /// <summary>
        /// TASK: Напишите программу, которая удаляет все узлы связанного списка, 
        /// находящиеся в позициях с номерами кратными пяти. 
        /// </summary>
        /// <typeparam name="T">Место указателя типа в связном списке</typeparam>
        /// <param name="linkedList">Связной список</param>
        /// <param name="number">Кратное число</param>
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

        ///<summary>
        /// TASK: Задайте двухвсязный список размерностью десять элементов, добавьте три 
        /// произвольных элемента после пятого, использовав для этого метод AddAfter(). 
        ///</summary> 
        /// <typeparam name="T">Место указателя типа в связном списке</typeparam>
        /// <param name="linkedList">Связной список</param>
        /// <param name="after">После какого узла начинать добавлять новые узлы</param>
        /// <param name="values">узлы, которые необходимо добавить</param>
        public static void AddAfterRange<T>(
            this LinkedList<T> linkedList,
            LinkedListNode<T> after,
            params T[] values)
        {
            foreach (var value in values)
            {
                var node = new LinkedListNode<T>(value);
                linkedList.AddAfter(after, node);
                after = node;
            }
        }

        /// <summary>
        /// TASK: Добавьте по элементу в начало и в конец списка, использовав для этого методы AddFirst(), AddLast().
        /// </summary>
        /// <typeparam name="T">Место указателя типа в связном списке</typeparam>
        /// <param name="linkedList">Связной список</param>
        /// <param name="first">Узел который необходимо добавить в начало связного списка</param>
        /// <param name="last">Узел который необходимо добавить в конец связного списка</param>
        public static void AddFirstAndLast<T>(this LinkedList<T> linkedList, T first, T last)
        {
            linkedList.AddFirst(first);
            linkedList.AddLast(last);
        }

        /// <summary>
        /// TASK: Использовав метод Remove() удалите из списка все элементы. 
        /// </summary>
        /// <typeparam name="T">Место указателя типа в связном списке</typeparam>
        /// <param name="linkedList">Связной список</param>
        public static void RemoveAll<T>(this LinkedList<T> linkedList)
        {
            var currentNode = linkedList.First;

            while (currentNode != null)
            {
                var nextNode = currentNode.Next;

                linkedList.Remove(currentNode);

                currentNode = nextNode;
            }
        }

        /// <summary>
        /// Вспомогательный метод для вывода всего списка в консоль
        /// </summary>
        /// <typeparam name="T">Место указателя типа в связном списке</typeparam>
        /// <param name="linkedList">Связной список</param>
        /// <param name="firstLine">Заголовок, если необходимо</param>
        public static void OutputConsole<T>(this LinkedList<T> linkedList, string header = null)
        {
            if (!string.IsNullOrEmpty(header))
                Console.WriteLine(header);

            var current = linkedList.First;

            while(current!=null)
            {
                Console.Write(current.Value + (current.Next != null ? ", " : Environment.NewLine));
                current = current.Next;
            }
            Console.WriteLine();
        }
    }
}
