using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures.Lesson2
{
    public class CustomArrayList<T> : ICollection<T>
    {
        public int Count { get; private set; }
        public int Capacity
        {
            get { return items.Length; }
            set
            {
                var temp = new T[value];
                Array.Copy(items, temp, items.Length);
                items = temp;
            }
        }

        public bool IsReadOnly => false;
        

        private T[] items;

        private void IncreaseCapacity()
        {
            Capacity = items.Length == 0 ? 4 : items.Length << 1;
           
        }

        public CustomArrayList() : this(0)
        { }

        public CustomArrayList(int capacity)
        {
            if (capacity < 0)
                throw new ArgumentException(nameof(capacity));

            items = new T[capacity];
        }

        /// <summary>
        /// TASK: Реализовать динамический массив на основе двусвязного списка (LinkedList<T>). 
        /// </summary>
        /// <param name="linkedList"></param>
        public CustomArrayList(LinkedList<T> linkedList) : this(linkedList.Count)
        {
            var i = 0;
            foreach (var value in linkedList)
                items[i++] = value;

            Count = i;
        }

        /// <summary>
        /// TASK: Реализовать динамический массив на основе статического. 
        /// </summary>
        /// <param name="array"></param>
        public CustomArrayList(T[] array): this(array.Length)
        {
            Array.Copy(array, items, array.Length);
            Count = items.Length;
        }

        public void Add(T item)
        {
            if (Count == Capacity)
                IncreaseCapacity();

            items[Count++] = item;
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void OutputConsole(string header = null)
        {
            if (!string.IsNullOrEmpty(header))
                Console.WriteLine(header);

            Console.WriteLine("Count: {0}", Count);
            Console.WriteLine("Capacity: {0}", Capacity);
            foreach (var item in items)
                Console.Write(item + " ");


            Console.WriteLine();
        }
    }
}
