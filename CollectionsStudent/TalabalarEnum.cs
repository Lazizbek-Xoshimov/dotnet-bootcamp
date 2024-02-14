using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsStudent
{
    public class TalabalarEnum : IEnumerator
    {
        public Inson[] talabalar;
        int position = -1;

        public TalabalarEnum(Inson[] talabalar) 
        {
            this.talabalar = talabalar;
        }
        
        public bool MoveNext()
        {
            position++;
            return (position < talabalar.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public Inson Current
        {
            get
            {
                try
                {
                    return talabalar[position];
                }
                catch (System.IndexOutOfRangeException) 
                {
                    throw new System.IndexOutOfRangeException();
                }
            }
        }
    }
}
