using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_String_Programs
{
    internal class RemoveDuplicate
    {
        void duplicates(string str)
        {
            string result = "";

            for (int i = 0; i < str.Length; i++)
            {
                bool found = false;
                for (int j = 0; j < result.Length; j++)
                {
                    if (str[i] == result[j])
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    result += str[i];
                }
            }
            Console.WriteLine(result);
        }
        public static void Main(string[] args)
        {
            RemoveDuplicate r = new RemoveDuplicate();
            r.duplicates("Swaraj");
        }
    }
}
