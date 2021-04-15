using System;
using System.Collections.Generic;
using System.Text;

namespace lr5
{
    class NomerComp : Comparer<Phone>
    {
        public override int Compare(Phone x, Phone y)
        {
            return x.GetNomer().CompareTo(y.GetNomer());
        }
    }
}
