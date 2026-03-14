using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class QueueEx
    {
        public static void Main()
        {
            Queue q = new Queue();

            q.Enqueue("A");
            q.Enqueue("B");
            q.Enqueue("C");

            while (q.Count > 0)
            {
                Console.WriteLine(q.Dequeue());
            }
        }
    }
}
