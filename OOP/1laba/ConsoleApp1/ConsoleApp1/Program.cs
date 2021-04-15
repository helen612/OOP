using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop1
{
    class phone
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
            + " ФИО: " + FIO
            + " Дата регистрации: " + date
            + " Тарифный план: " + tarif
            + " Количество минут в разговорах: " + minut;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            phone phone1 = new phone();
            Console.WriteLine(phone1);
            phone phone2 = new phone(8998626, "Сыцевич Владислав Николаевич", "22.10.2010", "Family", 498);
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
            phone4.minut = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(phone4);
            Console.ReadKey();
        }
    }
}


