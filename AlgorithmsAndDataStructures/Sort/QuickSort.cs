using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    public static class QuickSort
    {
        private static int Partition<T>(this T[] array, int left, int right)
            where T : IComparable<T>
        {
            int i = left;

            for (int j = left; j <= right; j++)
            {
                if (array[j].CompareTo(array[right]) <= 0)
                {
                    array.Swap(i++, j); 
                }
            }

            return i - 1;
        }

        public static void Quicksort<T>(this T[] array, int left, int right)
            where T : IComparable<T>
        { 
            if (left >= right) return;
            int i = Partition(array, left, right);
            Quicksort(array, left, i - 1);
            Quicksort(array, i + 1, right);
        }

    }
}
