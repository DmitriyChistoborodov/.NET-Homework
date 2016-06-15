using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    public class CustomLinkedList<T> : LinkedList<T>
    {
        public CustomLinkedList(IEnumerable<T> collection) : base(collection)
        {

        }

        /// <summary>
        /// TASK: Напишите программу, которая удаляет все узлы связанного списка, 
        /// находящиеся в позициях с номерами кратными пяти. 
        /// </summary>
        /// <param name="number">Кратное число</param>
        public void RemoveMultiplesOf(int number)
        {
            // Зачинаем с головы
            var current = First;

            for (int i = 1; current != null; i++)
            {
                // Заранее узнаем следующий узел, так как при удалении текущено узла
                // следующий узел узнать уже мы не сможем
                var next = current.Next;

                // Кратен ли итератор указаному числу в аргументе
                if (i % number == 0)
                    Remove(current); // Собственно удаляем узел

                current = next; // Переходим к следующему узлу
            }
        }

        ///<summary>
        /// TASK: Задайте двухвсязный список размерностью десять элементов, добавьте три 
        /// произвольных элемента после пятого, использовав для этого метод AddAfter(). 
        ///</summary> 
        /// <param name="after">После какого узла начинать добавлять новые узлы</param>
        /// <param name="values">узлы, которые необходимо добавить</param>
        public void AddAfterRange(LinkedListNode<T> after, params T[] values)
        {
            foreach (var value in values)
            {
                var node = new LinkedListNode<T>(value);
                AddAfter(after, node);
                after = node;
            }
        }

        /// <summary>
        /// TASK: Добавьте по элементу в начало и в конец списка, использовав для этого методы AddFirst(), AddLast().
        /// </summary>
        /// <param name="first">Узел который необходимо добавить в начало связного списка</param>
        /// <param name="last">Узел который необходимо добавить в конец связного списка</param>
        public void AddFirstAndLast(T first, T last)
        {
            AddFirst(first);
            AddLast(last);
        }

        /// <summary>
        /// TASK: Использовав метод Remove() удалите из списка все элементы. 
        /// </summary>
        /// <param name="linkedList">Связной список</param>
        public void RemoveAll()
        {
            var currentNode = First;

            while (currentNode != null)
            {
                var nextNode = currentNode.Next;

                Remove(currentNode);

                currentNode = nextNode;
            }
        }

        /// <summary>
        /// Вспомогательный метод для вывода всего списка в консоль
        /// </summary>
        /// <param name="firstLine">Заголовок, если необходимо</param>
        public void OutputConsole(string header = null)
        {
            if (!string.IsNullOrEmpty(header))
                Console.WriteLine(header);

            var current = First;

            while(current!=null)
            {
                Console.Write(current.Value + (current.Next != null ? ", " : Environment.NewLine));
                current = current.Next;
            }
            Console.WriteLine();
        }
    }
}
