namespace OddOrEven
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer: ");
            int numberInt = int.Parse(Console.ReadLine());
            Console.Write("Enter an float: ");
            float numberFloat = float.Parse(Console.ReadLine());
            Console.Write("Enter an double: ");
            double numberDouble = double.Parse(Console.ReadLine()); 

            numberInt.OddOrEven();
            numberFloat.OddOrEven();
            numberDouble.OddOrEven();
        }
    }
}