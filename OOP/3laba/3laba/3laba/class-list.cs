using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace lab3
{
    class Region_list
    {
        List<Region> list = new List<Region>();
        public void Add(Region a)
        {
            list.Add(a);
        }

        public void Insert(int Pos, Region a)
        {
            list.Insert(Pos, a);
        }

        public void RemoveAr(int Index)
        {
            list.RemoveAt(Index);
        }

        public void Clear()
        {
            list.Clear();
        }

        public object Return(int Index)
        {
            return list[Index];
        }


        public void Sort()
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (this.list[i].Compare(this.list[j]) > 0)
                    {
                        Region o = this.list[i];
                        this.list[i] = this.list[j];
                        this.list[j] = o;
                    }
                }
            }
        }

        public override string ToString()
        {
            string retVal = string.Empty;
            foreach (Region obj in list)
            {
                if (string.IsNullOrEmpty(retVal))
                    retVal += obj.ToString();
                else
                    retVal += string.Format("\n{0}", obj.ToString());
            }
            return retVal;
        }
    }
}
