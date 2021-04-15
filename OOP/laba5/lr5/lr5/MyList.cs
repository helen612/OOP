using System;
using System.Collections.Generic;
using System.Text;

namespace lr5
{
    class MyList
    {
        List<Phone> list = new List<Phone>();
        private static int count;

        public void Add(Phone obj)
        {
            list.Add(obj);
            count++;
        }

        public void AddAt(int index, Phone obj)
        {
            list.Insert(index, obj);
            count++;
        }

        public void Clear()
        {
            list.Clear();
            count = 0;
        }

        public void RemoveAt(int index)
        {
            list.RemoveAt(index);
            count--;
        }

        public void Edit(int index)
        {
            string input1;

            Console.WriteLine("Введите телефон, ФИО владельца, дату, тариф, минуты:\n");

            input1 = Console.ReadLine();

            string[] separators = {", "};
            string[] words = input1.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            Phone tempPhone = new Phone(Convert.ToInt32(words[0]), words[1], words[2], words[3], Convert.ToInt32(words[4]));

            list[index] = tempPhone;
        }

        public void Search(int nomer)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].GetNomer() == nomer)
                {
                    Console.WriteLine(list[i].ToString());
                }
            }
        }

        public void Sort(int field, int direction)
        {
            int choice1 = 0, choice2 = 0;
            Console.WriteLine("Выберите поле для сортировки(1 - номер, 2 - фио, 3 - дата, 4 - тариф, 5 - минут): ");
            while (choice1 < 1 || choice1 > 5)
            {
                choice1 = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Выберите направление сортировки(1 - По возрастанию, 2 - По убыванию): ");
            while (choice2 < 1 || choice2 > 2)
            {
                choice2 = Convert.ToInt32(Console.ReadLine());
            }
            Phone.SortVar = choice1;

            NomerComp nomer = new NomerComp();
            FIOComp fIO = new FIOComp();
            DateComp date = new DateComp();
            TarifComp tarif = new TarifComp();
            MinComp min = new MinComp();

            if (choice1 == 1 && choice2 == 1)
            {
                list.Sort(nomer);
            }

            if (choice1 == 1 && choice2 == 2)
            {
                list.Sort(nomer);
                list.Reverse();
            }

            if (choice1 == 2 && choice2 == 1)
            {
                list.Sort(fIO);
            }

            if (choice1 == 2 && choice2 == 2)
            {
                list.Sort(fIO);
                list.Reverse();
            }

            if (choice1 == 3 && choice2 == 1)
            {
                list.Sort(date);
            }

            if (choice1 == 3 && choice2 == 2)
            {
                list.Sort(date);
                list.Reverse();
            }

            if (choice1 == 4 && choice2 == 1)
            {
                list.Sort(tarif);
            }

            if (choice1 == 4 && choice2 == 2)
            {
                list.Sort(tarif);
                list.Reverse();
            }

            if (choice1 == 5 && choice2 == 1)
            {
                list.Sort(min);
            }
            if (choice1 == 5 && choice2 == 2)
            {
                list.Sort(min);
                list.Reverse();
            }
        }

        public override string ToString()
        {
            int count = 0;
            string str = string.Empty;
            foreach (Phone obj in list)
            {
                if (string.IsNullOrEmpty(str))
                {
                    str = str + string.Format("\n{0} - {1}", count, obj.ToString());
                    count++;
                }
                else
                {
                    str += string.Format("\n{0} - {1}", count, obj.ToString());
                    count++;
                }
            }
            return str;
        }
    }
}
