using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sets
{
    class Program
    {
        static void Main(string[] args)
        {
            bool rez;

            int[] array = { 1, 2, 3, 4, 5, 6 };

            var set1 = new HashSet();
            var set2 = new HashSet(array);

            set1.Add(1);
            set1.Add(2);
            set1.Add(3);
            set1.Add(4);
            set1.Add(7); //Расскоментировать!

            rez = set1.IsSubset(set2);

            Console.WriteLine("Множество set1 является подмножеством множества set2: {0} ", rez);
        }
    }
}
