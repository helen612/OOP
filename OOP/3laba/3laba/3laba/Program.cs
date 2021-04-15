using System;
using System.Collections;
using System.Collections.Generic;

namespace lab3
{


    class Program
    {

        static void Main(string[] args)
        {
            Region_list list = new Region_list();
            Metropolis obj = new Metropolis("Minsk", 155000, 333333);
            City obj2 = new City("Kuzan", 1312321, 27, 3);
            City obj3 = new City("Akorn", 3111123, 15, 5);
            Metropolis obj4 = new Metropolis("Sevast", 13123, 555);
            Place obj5 = new Place("Zalutsk", 1235, 4, "Aolod");
            Place obj6 = new Place("Akenam", 123, 6, "Zolot");
            list.Add(obj);
            list.Add(obj2);
            list.Add(obj3);
            list.Add(obj4);
            list.Add(obj5);
            list.Add(obj6);
            list.Add(obj);
            Console.WriteLine(list.ToString());
            Console.WriteLine(" ");
            list.Sort();
            Console.WriteLine(list.ToString());
            Console.WriteLine(" ");
            list.Clear();
            Console.WriteLine(list.ToString());
            Console.ReadLine();

        }
    }
}