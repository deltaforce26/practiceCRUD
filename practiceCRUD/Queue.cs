using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceCRUD
{
    static class Queue
    {
        public static Queue<Object> CreateQueue()
        {
            return new Queue<Object>();
        }

        public static void ReadQueue(Queue<Object> ints)
        {
            foreach (var item in ints)
            {
                Console.WriteLine(item);
            }
        }

        public static void DeleteQueue(Queue<Object> values)
        {
            values.Clear();
        }

        public static void PeekQueue(Queue<Object> ints)
        {
            Console.WriteLine(ints.Peek());
        }

    }
}
