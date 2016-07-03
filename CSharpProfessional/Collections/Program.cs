using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // TASK 1: Используя класс SortedList, создайте небольшую коллекцию и выведите на экран значения пар 
            // «ключ - значение» сначала в алфавитном порядке, а затем в обратном.
            var sortedList = new SortedList();

            sortedList.Add(5, "Five");
            sortedList.Add(6, "Six");
            sortedList.Add(1, "One");
            sortedList.Add(4, "Four");

            foreach (DictionaryEntry item in sortedList)
            {
                Console.WriteLine("{0} - {1}",item.Key, item.Value);
            }

            Console.WriteLine("В обратном порядке: ");

            var descSortedList = new SortedList(new DescendingComparer());

            descSortedList.Add(5, "Five");
            descSortedList.Add(6, "Six");
            descSortedList.Add(1, "One");
            descSortedList.Add(4, "Four");

            foreach (DictionaryEntry item in descSortedList)
            {
                Console.WriteLine("{0} - {1}", item.Key, item.Value);
            }


            Console.ReadKey();
        }


    }

    public class DescendingComparer : IComparer
    {
        readonly CaseInsensitiveComparer comparer = new CaseInsensitiveComparer();

        public int Compare(object x, object y)
        {
            return -1 * comparer.Compare(x, y);
        }
    }
}
