namespace _03_String_Programs
{
    internal class ReverseString
    {
        void reverse(string str)
        {
            string rev = "";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                rev += str[i];
            }
            Console.WriteLine(rev);
        }
        static void Main(string[] args)
        {
            ReverseString r = new ReverseString();
            r.reverse("Swaraj");
        }
    }
}
