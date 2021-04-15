using System;
using System.Collections.Generic;
using System.Text;

namespace lr5
{
    class FIOComp : Comparer<Phone>
    {
        public override int Compare(Phone x, Phone y)
        {
            return x.GetFIO().CompareTo(y.GetFIO());
        }
    }
}
