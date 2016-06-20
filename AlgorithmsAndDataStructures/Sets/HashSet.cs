using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sets
{
    //TASK: Реализуйте множество на основе массива и добавьте в него значения: “John”, “Mark”, 1, 2, 3.
    //Author: Основной целью я себе поставил реализовать методы по работе с множеством(Объединение, разность, пересечение, и тд.)
    //Поэтому я не наследовался от интерфейса ISet  
    public class HashSet : ArrayList
    {
        public HashSet()
        {

        }

        public HashSet(ICollection items) : base(items)
        {
        }

        public HashSet Union(HashSet other)
        {
            var result = new HashSet(ToArray());

            foreach (var item in other)
            {
                if (!Contains(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }

        public HashSet Difference(HashSet other)
        {
            var result = new HashSet(ToArray());
            foreach (var item in other)
            {
                result.Remove(item);
            }

            return result;
        }

        public HashSet Intersection(HashSet other)
        {
            var result = new HashSet();
            var currentItems = ToArray();

            foreach (var item in currentItems)
            {
                if (other.Contains(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }

        public bool IsSubset(HashSet other)
        {
            var result = new HashSet(ToArray());

            foreach (var item in other)
            {
                result.Remove(item);
            }

            return result.Count == 0;
        }

        public HashSet SymmetricDifference(HashSet other)
        {
            var union = Union(other);                // 1 2 3 4 5 6
            var intersection = Intersection(other);  // 3 4
            return union.Difference(intersection);      // 1 2 5 6
        }
    }
}
