using System;
using System.Collections.Generic;
using System.Text;

namespace lr5A
{
    class MyList
    {
        List<string> myList = new List<string>();

        public void Add(string obj)
        {
            myList.Add(obj);
            dubl(obj);
        }
        private void dubl(string obj)
        {
            int avgl = 0;
            foreach (string el in myList)
            {
                avgl += el.Length;
            }
            avgl /= myList.Count;
            if (obj.Length < avgl)
            {
                myList.Add(obj);
            }
        }
public object Return(int index)
        {
            return myList[index];
        }

        public override string ToString()
        {
            string str = "";
            for (int i = 0; i < myList.Count; i++)
                str += myList[i] + "\n";
            return str;
        }
    }
}
