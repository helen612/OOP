using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Kingdom : Country
    {
        protected string cap_name { get; set; }
        protected string state_head { get; set; }
        public Kingdom() : base()
        {
			cap_name = "NULL";
            state_head = "NULL";
        }
        public Kingdom(string cap_name, string capital, string gover_form, string state_name) : base(gover_form, state_name)
        {
            this.cap_name = cap_name;
			this.state_head = capital;
        }
        public override string ToString()
        {
            return base.ToString() + string.Format($"\nСтолица: {cap_name}\nГлава: {state_head}\n");
        }
        public override bool Equals(object obj)
        {
            if (obj == null || !this.GetType().Equals(obj.GetType())) return false;
            Kingdom c = (Kingdom)obj;
			return base.Equals(obj) && this.cap_name == c.cap_name && this.state_head == c.state_head;
        }
    }
}
