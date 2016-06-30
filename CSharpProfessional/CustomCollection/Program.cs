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
            Console.WriteLine("Нечётные числа в квадрате:"); // TASK 1

            var collection = GetOddNumbers(new[] { 5, 1, 7, 5, 3, 4, 1, 7, 5, 4 });

            foreach (var item in collection)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine("\n\nКоллекция месяцев:"); // TASK 2

            var monthsCollection = new MonthsCollection();

            foreach (var month in monthsCollection)
            {
                Console.WriteLine("[{0}] - {1} | days: {2}", month.SerialNumber, month.Name, month.DaysOfMonth);
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
