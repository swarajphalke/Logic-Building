using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class Prime
    {
        void IsPrime(int num)
        {
            if (num<0)
            {
                Console.WriteLine("Not Prime");
            }
            int count = 0;
            for(int i = 1; i<=num; i++)
            {
                
                if (num % i == 0)
                {
                    count++;
                }
            }

            if(count == 2)
            {
                Console.WriteLine("Prime Number ");
            }
            else
            {
                Console.WriteLine("Not Prime");
            }
        }

        public static void Main(string[] args) { 
        
            Prime p = new Prime();

            for(int i = 1; i<= 100; i++)
            {

            p.IsPrime(i);
                Console.Write(i+ " ");
            }
        }
    }
}
