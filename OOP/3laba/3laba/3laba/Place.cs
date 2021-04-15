using System;
using System.Collections.Generic;
using System.Text;

namespace lab3
{
    class Place : City
    {
        private string Street;
        public string street
        {
            get
            {
                return this.Street;
            }
            set
            {
                this.Street = value;
            }
        }

        public Place() { }

        public Place(string name, int area, int parks, string street)
            : base(name, area, parks)
        {
            Street = street;
        }


        public override int Compare(Region o)
        {
            if (o is Metropolis || (o is City && !(o is Place))) return 1;
            return (-1) * (o as Place).Street.CompareTo(Street);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Place trt = obj as Place;
            if (trt as Place == null)
                return false;

            return trt.Name == this.Name && trt.Area == this.Area && trt.Parks == this.Parks && trt.Street == this.Street;
        }
        public override string ToString()
        {
            return base.ToString() + $" и находится на улице {Street}.";
        }

    }
}
