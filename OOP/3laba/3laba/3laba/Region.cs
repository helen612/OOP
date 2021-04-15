using System;
using System.Collections.Generic;
using System.Text;

namespace lab3
{
    abstract class Region : ICompareableRegion
    {
        protected string Name;
        protected int Area;
        public string name
        {
            get
            {
                return this.Name;
            }
            set
            {
                this.Name = value;
            }
        }
        public int area
        {
            get
            {
                return this.Area;
            }
            set
            {
                this.Area = value;
            }
        }
        public Region() { }

        public Region(string name, int area)
        {
            Name = name;
            Area = area;
        }


        public virtual int Compare(Region o)
        {
            return this.Name.CompareTo(o.Name);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Region trt = obj as Region;
            if (trt as Region == null)
                return false;

            return trt.Name == this.Name && trt.Area == this.Area;
        }
        public virtual String ToString()
        {
            return $"{Name} площадью {Area} м^2";
        }
    }
}
