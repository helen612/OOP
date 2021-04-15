using System;
using System.Collections.Generic;
using System.Text;

namespace lab3
{
    class Metropolis : Region
    {
        private int Population;
        public int population
        {
            get
            {
                return this.Population;
            }
            set
            {
                this.Population = value;
            }
        }
        public Metropolis() { }

        public Metropolis(string name, int area, int population)
            : base(name, area)
        {
            Population = population;
        }


        public override string ToString()
        {
            return base.ToString() + $" с населением {Population}.";
        }


        public override int Compare(Region o)
        {
            if (o is City) return -1;
            if (o is Place) return 1;
            return (-1) * (o as Metropolis).Population.CompareTo(Population);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Metropolis trt = obj as Metropolis;
            if (trt as Metropolis == null)
                return false;

            return trt.Name == this.Name && trt.Area == this.Area && trt.Population == this.Population;
        }
    }
}
