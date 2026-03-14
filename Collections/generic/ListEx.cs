using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.generic
{
    internal class ListEx
    {
        public static void Main()
        {
            List<string> l = new List<string>();
            l.Add("Swaraj");
            l.Add("Viraj");
            l.Add("Mayur");

            foreach(string item in l)
            {
                Console.WriteLine(item);
            }
        }
    }
}
