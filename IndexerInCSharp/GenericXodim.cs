using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerInCSharp
{
    public class GenericXodim<T>
    {
        private T[] genericxodim = new T[9];
        public T this[int index]
        {
            get
            {
                return genericxodim[index];
            }
            set
            {
                genericxodim[index] = value;
            }
        }
    }
}
