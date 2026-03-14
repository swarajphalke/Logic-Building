using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.generic
{
    internal class QueueEx
    {
        static void Main()
        {
            Queue<string> names = new Queue<string>();

            names.Enqueue("Rahul");
            names.Enqueue("Priya");
            names.Enqueue("Amit");

            while (names.Count > 0)
            {
                Console.WriteLine(names.Dequeue());
            }
        }
    }
}
