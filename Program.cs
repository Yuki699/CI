
namespace ConsoleApplication1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Add(5, 2);
            System.Console.WriteLine("Test");
            System.Console.WriteLine("cos");
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Minus(int a, int b)
        {
            return a - b;
        }
    }
}
