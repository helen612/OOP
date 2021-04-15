using System;
using System.Collections.Generic;
using System.Text;

namespace lr5
{
    class TarifComp : Comparer<Phone>
    {
        public override int Compare(Phone x, Phone y)
        {
            return x.GetTarif().CompareTo(y.GetTarif());
        }
    }
}
