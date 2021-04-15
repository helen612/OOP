using System;
using System.Collections.Generic;
using System.Text;

namespace lab3
{
    class City : Region
    {
        protected int Parks;

        private int Houses;
        public int parks
        {
            get
            {
                return this.Parks;
            }
            set
            {
                this.Parks = value;
            }
        }
        public int houses
        {
            get
            {
                return this.Houses;
            }
            set
            {
                this.Houses = value;
            }
        }
        public City() { }

        public City(string name, int area, int parks)
            : base(name, area)
        {
            Parks = parks;
        }

        public City(string name, int area, int parks, int houses)
            : base(name, area)
        {
            Parks = parks;
            Houses = houses;
        }

        public override int Compare(Region o)
        {
            if (o is Metropolis || o is Place) return 1;
            return (o as City).Houses.CompareTo(Houses);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            City trt = obj as City;
            if (trt as City == null)
                return false;

            return trt.Name == this.Name && trt.Area == this.Area && trt.Parks == this.Parks;
        }
        public override string ToString()
        {
            return base.ToString() + $"с {Parks} парком/парками и {Houses} домами";
        }
    }
}
