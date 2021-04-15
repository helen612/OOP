using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        public static void Main(string [] args)
        {
            Country [] a = new Country[3];
            a[0] = new Republic("Минск", 1919, "Респубика", "Беларусь");
            a[1] = new Kingdom("Лондон", "Королева", "Королевство", "Великобритания");
            a[2] = new Monarchy("Канберра", "Королева", "Конституционная монархия", "Австралия");

            Console.Write("Вывод всех записей:\n");
            foreach (Country o in a)
            {
                Console.WriteLine(o);
            }
			Country search = new Kingdom("Лондон", "Королева", "Королевство", "Великобритания");
			foreach (Country o in a)
			{
				if (search.Equals(o))
				{
					Console.WriteLine("\nРезультат поиска - найден");
					return;
				}
			}
			Console.WriteLine("\nРезультат поиска - не найден");
			Republic r = new Republic("Минск", 1919, "Респубика", "Беларусь");
			r.Cap_name = "Москва";

		}
    }

}

