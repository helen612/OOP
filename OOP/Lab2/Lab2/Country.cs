using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2
{
    public abstract class Country
    {
        protected string gover_form { get; set; }
        protected string state_name { get; set; } 
		public Country()
        {
            gover_form = "NULL";
			state_name = "NULL";
        }
        public Country(string gover_form, string cap_name)
        {
            this.gover_form = gover_form;
            this.state_name = cap_name;
        }
        public override string ToString()
        {
            return string.Format($"\nФорма правления: {gover_form}\nНазвание Государства: {state_name}");
        }
        public override bool Equals(object obj)
        {
            if (obj == null || !this.GetType().Equals(obj.GetType())) return false;
            Country c = (Country)obj;
            return this.gover_form == c.gover_form && this.state_name == c.state_name;
        }
    }
}
