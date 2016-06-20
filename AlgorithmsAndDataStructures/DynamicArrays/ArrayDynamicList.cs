using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArrays
{
    //// TASK: Реализовать динамический массив на основе статического. 
    public class ArrayDynamicList<T> : ICollection<T>
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

        public ArrayDynamicList() : this(0)
        { }

        public ArrayDynamicList(int capacity)
        {
            if (capacity < 0)
                throw new ArgumentException(nameof(capacity));

            items = new T[capacity];
        }

        public ArrayDynamicList(T[] array): this(array.Length)
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
