using System;
using System.Collections.Generic;
using System.Text;

namespace lr5
{
    class MinComp : Comparer<Phone>
    {
        public override int Compare(Phone x, Phone y)
        {
            return x.GetMinut().CompareTo(y.GetMinut());
        }
    }
}
