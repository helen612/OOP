using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace lab3
{
    class Region_list
    {
        List<Product> list = new List<Product>();
        public void Add(Product a)
        {
            list.Add(a);
        }

        public void Insert(int Pos, Product a)
        {
            list.Insert(Pos, a);
        }

        public void RemoveAt(int Index)
        {
            list.RemoveAt(Index);
        }

        public void Clear()
        {
            list.Clear();
        }

        public void Sort(int vec)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (this.list[i].Compare(this.list[j])*vec > 0)
                    {
                        Product o = this.list[i];
                        this.list[i] = this.list[j];
                        this.list[j] = o;
                    }
                }
            }
        }

        public override string ToString()
        {
            string retVal = string.Empty;
            foreach (Product obj in list)
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
