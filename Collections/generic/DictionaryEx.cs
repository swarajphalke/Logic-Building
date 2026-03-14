using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.generic
{
    internal class DictionaryEx
    {
        public static void Main()
        {
            Dictionary<int, string> d = new Dictionary<int, string>();
            d.Add(1, "Swaraj");
            d.Add(2, "Mayur");
            d.Add(3, "Viraj");

            foreach(var item in d)
            {
                Console.WriteLine(item);
            }
        }
    }
}
