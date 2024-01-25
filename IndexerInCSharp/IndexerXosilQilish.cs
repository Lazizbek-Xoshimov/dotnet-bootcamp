using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerInCSharp
{
    public class IndexerXosilQilish
    {
        private int[] massiv = new int[4];

        public int this[int index]
        {
            get
            {
                return massiv[index];
            }
            set
            {
                massiv[index] = value;
            }
        }
    }
}
