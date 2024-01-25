using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace IndexerInCSharp
{
    public static class ExtensionClassExample
    {
        public static void PrintAllConsole<T>(this List<T> list) where T : Xodim 
        {
            for(int i = 0; i < list.Count; i++)
            {
                Console.WriteLine();
                for(int j = 0; j < 9; j++)
                {
                    Console.WriteLine("xodim[{0}] = {1}", j, list[i][j]);
                }
            }
        }

        public static void PrintAllGenericConsole<T>(this List<GenericXodim<T>> list) where T : struct
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 9; j++)
                {
                    Console.WriteLine("xodim[{0}] = {1}", j, list[i][j]);
                }
            }
        }
    }

}
