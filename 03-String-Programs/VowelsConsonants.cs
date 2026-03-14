using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_String_Programs
{
    internal class VowelsConsonants
    {
        void vowel(string str)
        {
            str = str.ToLower();
            int vowelCount = 0;
            int consonantCount = 0;
            string vowels = "";
            string consonants = "";

            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];

                if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                {
                    vowelCount++;
                    vowels += ch;
                }
                else if (ch != ' ' && ch >= 'a' && ch <= 'z')
                {
                    consonantCount++;
                    consonants += ch;
                }
            }
            Console.WriteLine("Vowels are " + vowelCount + " and " + vowels);
            Console.WriteLine("Consonants are " + consonantCount + " and " + consonants);

        }

        public static void Main(string[] args)
        {
            VowelsConsonants c = new VowelsConsonants();
            c.vowel("India is my country");
        }
    }
}
