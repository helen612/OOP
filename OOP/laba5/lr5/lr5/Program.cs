using System;

namespace lr5
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList list = new MyList();

            Phone obj1 = new Phone(2117425, "Сыцевич Даниил Николаевич", "20.02.2009", "Безлимит ", 300);
            Phone obj2 = new Phone(8998626, "Сыцевич Владислав Николаевич", "12.02.2000", "Семейный ", 400);
            Phone obj3 = new Phone(3210909, "Папко Андрей Вадимович", "12.12.2009", "Клоун", 12);
            Phone obj4 = new Phone(1231242, "Алексеенок Александр Андреевич", "05.05.2005", "Супер", 100);
            Phone obj5 = new Phone(9787872, "Кандеев Максим Вадимович", "04.04.2004", "Семейный", 312);
            Phone obj6 = new Phone(7482164, "Якорь Игорь Янович", "08.08.20010", "Безлимитище", 321);

            list.Add(obj1);
            list.Add(obj2);
            list.Add(obj3);
            list.Add(obj4);
            list.Add(obj5);
            list.Add(obj6);

            list.Search(2117425);
            //list.RemoveAt(3);

            list.Sort(1, 2);
            Console.WriteLine(list.ToString());



            Console.ReadLine();
        }
    }
}
