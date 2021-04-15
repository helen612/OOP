using System;
using System.Collections.Generic;
using System.Text;

namespace lab3
{
    public class Mechanizm : Product
    {
        private string type;
        private string proizv;
        private float price;

        public string Type
        {
            get
            { return type; }
            set
            { type = value; }
        }

        public string Proizv
        {
            get
            { return proizv; }
            set
            { proizv = value; }
        }
        protected float Price
        {
            get
            { return price; }
            set
            { price = value; }
        }

        public Mechanizm(string colour, string material, string type, string proizv, float price) : base(colour, material)
        {
            Type = type;
            Proizv = proizv;
            Price = price;

        }

        public Mechanizm(Mechanizm mechanizm) : base(mechanizm)
        {
            Type = mechanizm.type;
            Proizv = mechanizm.proizv;
            Price = mechanizm.Price;
        }
        public override int Compare(Product o)
        {
          if (o is Unit) return -1;
          if (o is Detail) return 1;
            return (-1) * (o as Mechanizm).Price.CompareTo(Price);
        }

        public override bool Equals(Object obj)
        {
            if (!(obj is Mechanizm)) return false;
            var mechanizm = (Mechanizm)obj;

            if (Type == mechanizm.type &&
            Proizv == mechanizm.proizv &&
            Price == mechanizm.Price &&
                base.Equals(obj))
                return true;
                else
                return false;
        }

        public override string ToString()
        {

            return base.ToString() +
                $"Тип механизма: {Type} " + $"Производитель: {Proizv} " + $"Цена: {Price}$ ";
        }

      
    }
}
