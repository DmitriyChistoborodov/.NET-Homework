using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            var tasks = new JobQueue();

            tasks.Enqueue(() => Console.WriteLine("priority: 0"), 0);
            tasks.Enqueue(() => Console.WriteLine("priority: 3"), 3);
            tasks.Enqueue(() => Console.WriteLine("priority: 5"), 5);
            tasks.Enqueue(() => Console.WriteLine("priority: 2"), 2);
            tasks.Enqueue(() => Console.WriteLine("priority: 6"), 6);
            tasks.Enqueue(() => Console.WriteLine("priority: 7"), 7);
            tasks.Enqueue(() => Console.WriteLine("priority: 9"), 9);
            tasks.Enqueue(() => Console.WriteLine("priority: 1"), 1);

            tasks.Dequeue()();

            Console.WriteLine();

            tasks.CompleteAll();

            Console.ReadKey();
        }

        
    }
}
