using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.generic
{
    internal class StackEx
    {
        static void Main()
        {
            Stack<int> numbers = new Stack<int>();

            numbers.Push(10);
            numbers.Push(20);
            numbers.Push(30);

            //while(numbers.Count > 0)
            //{
            //    numbers.Pop();
            //}
            Console.WriteLine(numbers.Peek());
            foreach (int i in numbers) {
                Console.WriteLine(i);
            }
        }
    }
}
