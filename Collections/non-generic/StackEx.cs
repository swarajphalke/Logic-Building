using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class StackEx
    {
        public static void Main()
        {
            Stack st = new Stack();

            st.Push("A");
            st.Push("B");
            st.Push("C");

            while (st.Count > 0)
            {
                Console.WriteLine(st.Pop());
            }
        }
    }
}
