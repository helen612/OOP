using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop1
{
    class phone
    {
        public int nomer; //семизначное целое число
        public string FIO; //stroka
        public string date; //data (dd.mm.yyyy)
        public string tarif; //stroka

        public phone()
        {
            nomer = 2117425;
            FIO   = "Сыцевич Даниил Николаевич";
            date  = "22.12.2017";
            tarif  = "Bezlimit";
        }

        public phone(int nomer,string FIO, string date, string tarif)
        {
            this.nomer = nomer;
            this.FIO = FIO;
            this.date = date;
            this.tarif = tarif;
        }

        public void SetNomer(int nomer)
        { this.nomer = nomer; }

        public int GetNomer()
        { return nomer; }

        public void SetFIO(string FIO)
        { this.FIO = FIO; }

        public string GetFIO()
        { return FIO; }
        public void SetDate(string date)
        { this.date = date; }

        public string GetDate()
        { return date; }

        public void SetTarif(string tarif)
        { this.tarif = tarif; }

        public string GetTarif()
        { return tarif; }

        public phone(phone copy)
        {
            nomer = copy.nomer;
            FIO = copy.FIO;
            date = copy.date;
            tarif = copy.tarif;
        }
        public override string ToString()
        {
            return "номер телефона: " + nomer
            + " ФИО: " + FIO
            + " Дата регистрации: " + date
            + " Тарифный план: " + tarif;
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            phone m = obj as phone; // возвращает null если объект нельзя привести к типу
            if (m as phone == null)
                return false;
            return m.nomer == this.nomer && m.FIO == this.FIO && m.date == this.date && m.tarif == this.tarif;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            phone phone1 = new phone();
            Console.WriteLine(phone1);
            phone phone2 = new phone(8998626, "Сыцевич Владислав Николаевич", "22.10.2010", "Family");
            Console.WriteLine(phone2);
            phone phone3 = new phone(phone1);
            Console.WriteLine(phone3);
            Console.WriteLine(phone1.Equals(phone3));
            Console.WriteLine(phone1.Equals(phone2));
            Console.WriteLine("Введите данные о клиенте");
            phone phone4 = new phone();
            phone4.nomer = Convert.ToInt32(Console.ReadLine());
            phone4.FIO = Console.ReadLine();
            phone4.date = Console.ReadLine();
            phone4.tarif = Console.ReadLine();
            Console.WriteLine(phone4);
            Console.ReadKey();
        }
    }
}

        