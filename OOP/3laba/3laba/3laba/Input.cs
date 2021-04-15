using System;
using System.Collections.Generic;
using System.Text;

namespace lab3
{
    class Input
    {
        static Region InputMetropolis()
        {
            Console.WriteLine("Введите Название, площадь, население");
            string input1 = Console.ReadLine();
            string[] separators = { "," };
            string[] words = input1.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            Metropolis first = new Metropolis(words[0], Convert.ToInt32(words[1]), Convert.ToInt32(words[2]));
            return first;
        }
        static City InputCity()
        {
            Console.WriteLine("Введите Название, площадь, кол-во парков, кол-во домов:");
            string input1 = Console.ReadLine();
            string[] separators = { "," };
            string[] words = input1.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            City first = new City(words[0], Convert.ToInt32(words[1]), Convert.ToInt32(words[2]), Convert.ToInt32(words[3]));
            return first;
        }
        static Place InputPlace()
        {
            Console.WriteLine("Введите Название, площадь, кол-во парков, улицу:");
            string input1 = Console.ReadLine();
            string[] separators = { "," };
            string[] words = input1.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            Place first = new Place(words[0], Convert.ToInt32(words[1]), Convert.ToInt32(words[2]), words[3]);
            return first;
        }
    }
}
