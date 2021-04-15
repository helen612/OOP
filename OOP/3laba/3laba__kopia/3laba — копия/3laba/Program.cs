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
            Mechanizm obj = new Mechanizm("Пластик", "Красный", "Зубчатый", "EcoForm", 101);
            
            for (int i = 0; i < 3;i++)
                obj.setSortWeight(i, i+1);
            
            Unit obj2 = new Unit("Древесина", "Желтый", 7, "Средний");
            Detail obj7 = new Detail("Алюминий", "Бирюзовый", 20, "Cредний", "В часах", "Албания", 99);
            Unit obj3 = new Unit("Металл", "Оранжевый", 13, "Маленький");
            Mechanizm obj4 = new Mechanizm("Эко-пластик", "Желтый", "Гидравлический", "SichCompany", 98);
            Detail obj5 = new Detail("Металл", "Черный", 5, "Большой", "В технике", "Япония", 1001);
            Detail obj6 = new Detail("Алюминий", "Желтый", 20, "Cредний", "В часах", "Хорватия", 1000);
            Mechanizm obj8 = new Mechanizm("Эко-пластик", "Синий", "Гидравлический", "SichCompany", 120);

            list.Add(obj);
            list.Add(obj2);
            list.Add(obj3);
            list.Add(obj4);
            list.Add(obj5);
            list.Add(obj6);
            list.Add(obj7);
            list.Add(obj8);

            Console.WriteLine(list.ToString());
            Console.WriteLine(" ");
            Console.WriteLine("Сортировка:");
            list.Sort(1);
            Console.WriteLine(list.ToString());
            Console.ReadLine();

        }
    }
}