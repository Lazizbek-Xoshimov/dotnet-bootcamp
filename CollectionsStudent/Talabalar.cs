using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsStudent
{
    public class Talaba : IEnumerable
    {
        private Inson[] _talabalar;

        public Talaba(Inson[] talabalar)
        {
            _talabalar = talabalar;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public TalabalarEnum GetEnumerator()
        {
            return new TalabalarEnum(_talabalar);
        }
    }
}
