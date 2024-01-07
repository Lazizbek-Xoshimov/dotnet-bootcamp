namespace DelegateMisol
{
    public class Program
    {
        public delegate int Calculation(int a, int b);
        public static void Main(string[] args)
        {
            Calculation calculate = new Calculation(Multiplication);
            Console.WriteLine(calculate.Invoke(6, 7));
        }
        private static int Multiplication(int a, int b)
        {
            return a * b;
        }
    }
}