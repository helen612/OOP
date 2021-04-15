using System;
using System.Collections.Generic;
using System.Text;

namespace lr5
{
    class MyList : List<Phone>
    {

        public void Edit(int index, Phone novyi)
        {
            base[index] = novyi;
        }

        public override string ToString()
        {
            string str = "";
            for (int i = 0; i < Count; i++)
                str += this[i] + "\n";
            return str;
        }
    }
}
