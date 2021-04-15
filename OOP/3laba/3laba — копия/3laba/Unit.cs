using System;
using System.Collections.Generic;
using System.Text;

namespace lab3
{
    public class Unit : Product
    {
        private int year;
        private string size;
        public int Year
        {
            get
            { return year; }
            set
            { year = value; }
        }
        public string Size
        {
            get
            { return size; }
            set
            { size = value; }
        }



        public Unit(string colour, string material, int year, string size) : base(colour, material)
        {
            Year = year;
            Size = size;
        }

        public Unit(Unit unit) : base(unit)
        {
            Year = unit.year;
            Size = unit.size;
        }

        public override int Compare(Product o)
        {
            if (o is Mechanizm || o is Detail) return 1;
            return (o as Unit).Year.CompareTo(Year);
        }
        public override bool Equals(Object obj)
        {
            if (!(obj is Unit)) return false;
            var unit = (Unit)obj;

            if (Year == unit.year &&
                Size == unit.size &&
                base.Equals(obj))
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            return base.ToString() +
                $"Размер: {Size} " + $"Срок службы: {Year} лет ";
        }

        
    }
}
