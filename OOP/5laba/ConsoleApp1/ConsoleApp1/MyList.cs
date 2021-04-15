using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;

namespace oop1
{
	class MyList<T> : List<T> where T : IComparable
	{
		public void Add(T obj)
		{
			if (obj is string)
			{
				base.Add(obj);
				int avgl = 0;
				foreach (var el in this)
				avgl += ((string)Convert.ChangeType(el,typeof(string))).Length;
				avgl /= Count;
				Dictionary<string, int> adding = new Dictionary<string, int>();
				for(int i = 0; i < Count; i++)
					if(((string)Convert.ChangeType(this[i], typeof(string))).Length<avgl)
					{
						if (adding.Keys.
							Contains((string)Convert.ChangeType(this[i], typeof(string))))
							adding[(string)Convert.ChangeType(this[i], typeof(string))]++;
						else
							adding.Add((string)Convert.ChangeType(this[i], typeof(string)), 1);
					}
				foreach(var id in adding.Keys)
				{
					for (int i = 0; i < adding[id]; i++)
						base.Add((T)Convert.ChangeType(id, typeof(T)));
				}
			}
			else
				base.Add(obj);
		}
		public override string ToString()
		{
			string str = "";
			for (int i = 0; i < Count; i++)
				str += this[i] + "\n";
			return str;
		}
	}
}
