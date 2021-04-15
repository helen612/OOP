using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Monarchy : Country
    {
		protected string сapitel { get; set; }
        protected string monarchs { get; set; }
        public Monarchy() : base()
        {
			сapitel = "NULL";
			monarchs = "NULL";
        }
        public Monarchy(string сapitel, string monarchs, string gover_form, string state_name) : base(gover_form, state_name)
        {
			this.сapitel = сapitel;
            this.monarchs = monarchs;
        }
        public override string ToString()
        {
            return base.ToString() + string.Format($"\nСтолица: {сapitel}\nМонарх: {monarchs}");
        }
        public override bool Equals(object obj)
        {
            if (obj == null || !this.GetType().Equals(obj.GetType())) return false;
            Monarchy c = (Monarchy)obj;
            return base.Equals(obj) && this.monarchs == c.monarchs && this.сapitel == c.сapitel;
        }
    }
}
