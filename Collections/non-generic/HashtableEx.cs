using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class HashtableEx
    {
        public static void Main()
        {
            Hashtable list = new Hashtable();
            list.Add(101, "Swaraj");
            list.Add(102, "Aditya");
            list.Add(103, "Mayur");
            list.Add(104, "Siddharth");

            list.Remove(103);

            foreach (var key in list)
            {
                Console.WriteLine(key);
            }
        }
    }
}
