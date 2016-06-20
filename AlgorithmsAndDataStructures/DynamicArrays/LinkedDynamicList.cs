using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArrays
{
    //TASK: Реализовать динамический массив на основе двусвязного списка (LinkedList<T>).  
    class LinkedDynamicList<T> : ICollection<T>
    {
        LinkedList<T> items;

        public int Count => items.Count;

        public bool IsReadOnly => false;

        public LinkedDynamicList()
        {
            items = new LinkedList<T>();
        }

        public LinkedDynamicList(IEnumerable<T> collection)
        {
            items = new LinkedList<T>(collection);
        }

        public void Add(T item)
        {
            items.AddLast(item);
        }

        public void Clear()
        {
            items.Clear();
        }

        public bool Contains(T item)
        {
            return items.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            items.CopyTo(array, arrayIndex);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return items.GetEnumerator();
        }

        public bool Remove(T item)
        {
            return items.Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return items.GetEnumerator();
        }

        public void OutputConsole(string header = null)
        {
            if (!string.IsNullOrEmpty(header))
                Console.WriteLine(header);

            Console.WriteLine("Count: {0}", Count);
            foreach (var item in items)
                Console.Write(item + " ");


            Console.WriteLine();
        }
    }
}
