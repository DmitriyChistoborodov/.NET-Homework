using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    public static class BubbleSort
    {
        public static void Swap<T>(this T[] items, int left, int right)
        {
            if (left != right)
            {
                T temp = items[left];
                items[left] = items[right];
                items[right] = temp;
            }
        }

        // Метод реализует сортировку пузырьком 
        // Author: это дано как пример в уроке
        public static void sourceBubbleSort(this int[] items)
        {
            bool swapped;

            do
            {
                swapped = false;

                for (int i = 1; i < items.Length; i++)
                {
                    if (items[i - 1].CompareTo(items[i]) > 0)
                    {
                        Swap(items, i - 1, i);

                        swapped = true;
                    }
                }
            }

            while (swapped != false);
        }

        // TASK: Усовершенствуйте сортировку пузырьком в первом примере урока. 
        // Подумайте, как можно уменьшить количество итераций циклов. 
        // Author: это уже моя реализация
        public static void MyBubbleSort<T>(this T[] items)
            where T : IComparable<T>
        {
            var swapped = true;

            for (int i = items.Length; swapped; i--)
            {
                swapped = false;

                for (var j = 1; j < i; j++)
                {
                    if (items[j - 1].CompareTo(items[j]) > 0)
                    {
                        items.Swap(j - 1, j);
                        swapped = true;
                    }
                }
            }
        }



    }
}
