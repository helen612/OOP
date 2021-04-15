using System;
using System.Collections.Generic;
using System.Text;

namespace lab3
{
    class Input
    {
        static Product InputMechanizm()
        {
            Console.WriteLine("Введите цвет, материал, тип механизма, производителя, цена:");
            string input1 = Console.ReadLine();
            string[] separators = { "," };
            string[] words = input1.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            Mechanizm first = new Mechanizm(words[0], words[1],  words[2], words[3], Convert.ToInt32(words[4]));
            return first;
        }
        static Unit InputUnit()
        {
            Console.WriteLine("Введите цвет, материал, срок службы, размер:");
            string input1 = Console.ReadLine();
            string[] separators = { "," };
            string[] words = input1.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            Unit first = new Unit(words[0], words[1], Convert.ToInt32(words[2]), words[3]);
            return first;
        }
        static Detail InputDetail()
        {
            Console.WriteLine("Введите цвет, материал, срок службы, размер, где используется, страна производитель, количество:");
            string input1 = Console.ReadLine();
            string[] separators = { "," };
            string[] words = input1.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            Detail first = new Detail(words[0], words[1], Convert.ToInt32(words[2]), words[3], words[4], words[5], Convert.ToInt32(words[6]));
            return first;
        }
    }
}
