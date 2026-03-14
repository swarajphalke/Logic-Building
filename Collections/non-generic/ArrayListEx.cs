using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class ArrayListEx
    {
        public static void Main()
        {
            ArrayList list = new ArrayList();
            list.Add("Swaraj");
            list.Add(10);
            list.Add(5.5);

            foreach(var i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
