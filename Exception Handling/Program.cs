namespace Exception_Handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 10;
                int b = 0;
                int result = a / b;
                Console.WriteLine("Result: " + result);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Error: Cannot divide by zero");
            }
            finally
            {
                Console.WriteLine("Finally Block Executed");
            }

        }
    }
}
