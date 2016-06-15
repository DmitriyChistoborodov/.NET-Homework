using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    /// <summary>
    /// TASK: Реализуйте очередь с приоритетами. В качестве примера используйте список задач рабтника,
    /// когда он заканчивает одну задачу он переходит к следующей(самой приоритетной). 
    /// Начальник добавляя элемент в очередь указывает ее приоритет. 
    /// По сревнению с обычной очередью, каждый элемент такой очереди будет иметь свой приоритет.  
    /// </summary>
    public class JobQueue
    {
        //key = job, value = priority
        private List<KeyValuePair<Action, int>> items;

        public JobQueue()
        {
            items = new List<KeyValuePair<Action, int>>();
        }

        public void Enqueue(Action func, int priority)
        {
            var index = items.FindIndex(x => x.Value < priority);
            items.Insert(index < 0 ? 0 : index , new KeyValuePair<Action, int>(func, priority));
        }

        public void CompleteAll()
        {
            foreach (var item in items)
                item.Key();

        }

        //TASK: Дополните методами DequeueLast() и DequeueFirst().  
        public Action DequeueFirst()
        {
            if(items.Count==0)
                throw new InvalidOperationException("Очередь пуста");

            var item = items.First();
            items.Remove(items.First());
            return item.Key;
        }

        public Action DequeueLast()
        {
            if (items.Count == 0)
                throw new InvalidOperationException("Очередь пуста");

            var item = items.Last();
            items.Remove(items.Last());
            return item.Key;
        }
    }

}
