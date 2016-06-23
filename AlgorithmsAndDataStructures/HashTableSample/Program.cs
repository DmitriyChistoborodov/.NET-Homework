using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableSample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Изучите самостоятельно материал о классе HashTable. 
            // Реализуйте на его основе хеш-таблицу из списка имен и фамилий ваших одноклассников. 
            // Выведете количество человек и данные о них в консоль из хеш-таблицы.  

            var students = new Hashtable()
            {
                {"Васильченко", "Олег" },
                {"Борисенко", "Валентин" },
                {"Иванов", "Александр" },
                {"Мальченко", "Григорий" },
            };

            Console.WriteLine("Кол-во человек: {0}", students.Count);

            foreach (DictionaryEntry student in students)
            {
                Console.WriteLine("{0} {1}", student.Key, student.Value);
            }

            Console.ReadKey();

        }
    }
}
