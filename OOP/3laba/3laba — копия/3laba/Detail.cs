using System;
using System.Collections.Generic;
using System.Text;

namespace lab3
{
    public class Detail : Unit
    {
       
        private string use;
        private string countrymake;
        private int kol;

        public string Use
        {
            get
            { return use; }
            set
            { use = value; }
        }

        public string Countrymake
        {
            get
            { return countrymake; }
            set
            { countrymake = value; }
        }
        public int Kol
        {
            get
            { return kol; }
            set
            { kol = value; }
        }



        public Detail(string colour, string material, int year, string size, string use, string countrymake, int kol) : base(colour, material, year, size)
        {
            Use = use;
            Countrymake = countrymake;
            Kol = kol;
          
        }

        public Detail(Detail detail) : base(detail)
        {
            Use = detail.use;
            Countrymake = detail.countrymake;
            Kol = detail.kol;
            
        }


        public override int Compare(Product o)
        {
            if (o is Mechanizm || (o is Unit && !(o is Detail))) return 1;
            return (-1) * (o as Detail).Kol.CompareTo(Kol);
        }

        public override bool Equals(Object obj)
        {
            if (!(obj is Detail)) return false;
            var detail = (Detail)obj;

            if (Use == detail.use &&
                Countrymake == detail.countrymake &&
                Kol == detail.kol &&
                base.Equals(obj))
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            return base.ToString() +
                $"Где используется: {Use} " + $"Страна производитель: {Countrymake} " + $"Количество: {Kol} штук ";
        }
    }
}
