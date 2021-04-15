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
            + " ФИО: " + FIO
            + " Дата регистрации: " + date
            + " Тарифный план: " + tarif
            + " Количество минут в разговорах: " + minut;
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
            phone phone2 = new phone(8998626, "Сыцевич Владислав Николаевич", "22.10.2010", "Family", 498);
            MyStack<phone> stack1 = new MyStack<phone>();
            MyStack<phone> stack2 = new MyStack<phone>();
            for(int i = 0;i<5;i++)
            {
                stack1.push(phone2);
                stack2.push(phone2);
            }
            MyStack<phone> cl = stack1.clone();
            while(!cl.isEmpty())
            {
                stack2.push(cl.pop());
            }
            stack1.print();
            Console.WriteLine("-------------------------");
            stack2.print();
            Console.WriteLine("Д" +
                "ва стека равны - {0}\n\n",stack1.Equals(stack2));
            Console.ReadKey();
        }
    }
}


