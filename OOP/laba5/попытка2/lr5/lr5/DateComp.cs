using System;
using System.Collections.Generic;
using System.Text;

namespace lr5
{
    class DateComp : Comparer<Phone>
    {
        public override int Compare(Phone x, Phone y)
        {
            return x.GetDate().CompareTo(y.GetDate());
        }
    }
}
