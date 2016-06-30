using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = GetOddNumbers(new[] { 5, 1, 7, 5, 3, 4, 1, 7, 5, 4 });

            foreach (var item in collection)
            {
                Console.Write("{0} ", item);
            }

            Console.ReadKey();
        }


        //TASK 1: Cоздайте метод, который в качестве аргумента принимает массив целых чисел и возвращает 
        //коллекцию квадратов всех нечетных чисел массива.Для формирования коллекции используйте оператор yield.
        public static IEnumerable<int> GetOddNumbers(IEnumerable<int> numbers)
        {
            foreach (var number in numbers)
            {
                if ((number % 2) != 0)
                    yield return number * number;
            }
        }
    }
}
