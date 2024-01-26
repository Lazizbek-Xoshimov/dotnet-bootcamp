using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOrEven
{
    public static class ExtentionMethodOddOrEven
    {
        public static void OddOrEven<T>(this T number) where T : struct
        {
            if(number is int)
            {
                if ((int)(object)number % 2 == 0)
                    Console.WriteLine("An even number");
                else
                    Console.WriteLine("An odd number");
            }
            else if(number is float)
            {
                if ((float)(object)number % 2 == 0)
                    Console.WriteLine("An even number");
                else
                    Console.WriteLine("An odd number");
            }
            else if(number is short)
            {
                if ((short)(object)number % 2 == 0)
                    Console.WriteLine("An even number");
                else
                    Console.WriteLine("An odd number");
            }
            else if(number is double)
            {
                if ((double)(object)number % 2 == 0)
                    Console.WriteLine("An even number");
                else
                    Console.WriteLine("An odd number");
            }
        }
    }
}
