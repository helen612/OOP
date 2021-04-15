using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop1
{
    class phone : IComparable
    {
        protected internal int nomer; //семизначное целое число
        protected internal string FIO; //stroka
        protected internal string date; //data (dd.mm.yyyy)
        protected internal string tarif; //stroka
        protected internal int minut; //chislo
        protected internal phone(int nomer, string FIO, string date, string tarif, int minut)
        {
            this.nomer = nomer;
            this.FIO = FIO;
            this.date = date;
            this.tarif = tarif;
            this.minut = minut;
        }

        protected internal phone()                                                   
        {
            nomer = 2117425;
            FIO = "Сыцевич Даниил Николаевич";
            date = "22.12.2017";
            tarif = "Bezlimit";
            minut = 312;
        }

        protected internal phone(phone copy)
        {
            nomer = copy.nomer;
            FIO = copy.FIO;
            date = copy.date;
            tarif = copy.tarif;
            minut = copy.minut;
        }

        protected void SetNomer(int nomer)
        { this.nomer = nomer; }

        protected int GetNomer()
        { return nomer; }

        protected void SetFIO(string FIO)
        { this.FIO = FIO; }

        protected string GetFIO()
        { return FIO; }

        protected void SetDate(string date)
        { this.date = date; }

        protected string GetDate()
        { return date; }

        protected void SetTarif(string tarif)
        { this.tarif = tarif; }

        protected string GetTarif()
        { return tarif; }

        protected void SetMinut(int minut)
        { this.minut = minut; }

        protected int GetMinut()
        { return minut; }

        
         public override bool Equals(object obj)
         {
             if (obj == null)
             return false;
             phone m = obj as phone; // возвращает null если объект нельзя привести к типу
             if (m as phone == null)
             return false;
            return m.nomer == this.nomer && m.FIO == this.FIO && m.date == this.date && m.tarif == this.tarif && m.minut == this.minut;
         }

        public override string ToString()
        {
            return "номер телефона: " + nomer
            + "\nФИО: " + FIO
            + "\nДата регистрации: " + date
            + "\nТарифный план: " + tarif
            + "\nКоличество минут в разговорах: " + minut+"\n";
        }

        public int CompareTo(object obj)
        {
            if (nomer > ((phone)obj).nomer)
                return 1;
            else if (nomer == ((phone)obj).nomer)
                return 0;
            else
                return -1;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            phone phone1 = new phone();
            Console.WriteLine(phone1);
            phone phone2 = new phone(8998626, "Сыцевич Владислав Николаевич", "22.10.2010", "Family", 498);

            MyList<string> strs = new MyList<string>();
            strs.Add("hello");
            //Console.WriteLine(strs.ToString());
            strs.Add("world");
            //Console.WriteLine(strs.ToString());
            strs.Add("yes");
            //Console.WriteLine(strs.ToString());
            //strs.Add("world");
            Console.WriteLine(strs.ToString());
            Console.WriteLine("\n------------------------------------\n");


            MyList<phone> phones = new MyList<phone>();
            string[] tarifs = { "Mamily", "Family", "Damily" };
            string[] names = { "Петя", "Вова", "Жора" };
            string[] surname = { "Петров", "Юрьев", "Васильев" };

            Random r = new Random();

            for (int i = 0; i < 5; i++)
            {
                phones.Add(new phone(r.Next(1000000, 9999999), names[r.Next(names.Length)]+" "+ surname[r.Next(surname.Length)],
                    Convert.ToString(r.Next(1, 31)) + "." + Convert.ToString(r.Next(1, 12)) + "." +
                     Convert.ToString(r.Next(2000, 2020)), tarifs[r.Next(tarifs.Length)], r.Next(100, 400)));
            }
            Console.WriteLine(phones.ToString());
            Console.WriteLine("\n----------------По ФИО--------------------\n");
            phones.Sort((x, y) => x.FIO.CompareTo(y.FIO));
            Console.WriteLine(phones.ToString());
            Console.WriteLine("\n-------------------По дате-----------------\n");
            phones.Sort((x, y) => x.date.CompareTo(y.date));
            Console.WriteLine(phones.ToString());
            Console.WriteLine("\n-------------------По минутам-----------------\n");
            phones.Sort((x, y) => x.minut.CompareTo(y.minut));
            Console.WriteLine(phones.ToString());
            Console.WriteLine("\n------------------По номеру------------------\n");
            phones.Sort((x, y) => x.nomer.CompareTo(y.nomer));
            Console.WriteLine(phones.ToString());
            Console.WriteLine("\n-----------------По тарифу-------------------\n");
            phones.Sort((x, y) => x.tarif.CompareTo(y.tarif));
            Console.WriteLine(phones.ToString());
            Console.WriteLine("\n------------------Поиск------------------\n");
            Console.WriteLine("Введите данные о клиенте\n");
            phone phone4 = new phone();
            Console.WriteLine("Номер: ");
            phone4.nomer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ФИО: ");
            phone4.FIO = Console.ReadLine();
            if(phones.Find((x) => x.FIO == phone4.FIO&& x.nomer == phone4.nomer)!=null)
                Console.WriteLine("\n----------\n"+phones.Find((x) => x.FIO == phone4.FIO
                && x.nomer == phone4.nomer).ToString()+"\n----------\n");
            else Console.WriteLine("\n-----------------Кажется такой записи нет!--------------\n");
            Console.WriteLine("\n-----------------Удаляем последнюю запись и редактируем последнюю--------------\n");
            phones.Remove(phones[phones.Count - 1]);
            phones[0].nomer = r.Next(1000000, 9999999);
            phones[0].FIO = names[r.Next(names.Length)]+" "+surname[r.Next(surname.Length)];
            Console.WriteLine(phones.ToString());
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}


