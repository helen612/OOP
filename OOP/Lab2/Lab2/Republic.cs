using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
	public class Republic : Country
	{
		protected string cap_name;
		public string Cap_name
		{
			 get
				{
					return cap_name;
				} 
			   set 
					{
						cap_name = value; 
					} 
		}
		protected int year_found { get; set; }

		public Republic() : base()
        {
            cap_name = "NULL";
			year_found = 0;
        }
        public Republic(string cap_name, int year_found, string gover_form, string state_name) : base(gover_form, state_name)
        {
            this.cap_name = cap_name;
            this.year_found = year_found;
        }
        public override string ToString()
        {
            return base.ToString() + string.Format($"\nСтолица: {cap_name}\nГод основания: {year_found}");
        }
        public override bool Equals(object obj)
        {
            if (obj == null || !this.GetType().Equals(obj.GetType())) return false;
            Republic c = (Republic)obj;
            return base.Equals(obj) && this.cap_name == c.cap_name && this.year_found == c.year_found;
        }
    }
}
