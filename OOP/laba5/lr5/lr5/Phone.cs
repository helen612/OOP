using System;
using System.Collections.Generic;
using System.Text;

namespace lr5
{
    class Phone : IComparable
    {
        private int nomer; //семизначное целое число
        private string FIO; //stroka
        private string date; //data (dd.mm.yyyy)
        private string tarif; //stroka
        private int minut; //chislo

        public static int SortVar = 0;

        public Phone(int nm, string fio, string dat, string tar, int min)
        {
            nomer = nm;
            FIO = fio;
            date = dat;
            tarif = tar;
            minut = min;
        }

        public Phone()
        {
            nomer = 2117425;
            FIO = "Сыцевич Даниил Николаевич";
            date = "22.12.2017";
            tarif = "Bezlimit";
            minut = 312;
        }

        public Phone(Phone copy)
        {
            nomer = copy.nomer;
            FIO = copy.FIO;
            date = copy.date;
            tarif = copy.tarif;
            minut = copy.minut;
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

        public void SetMinut(int minut)
        { this.minut = minut; }

        public int GetMinut()
        { return minut; }


        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Phone m = obj as Phone; // возвращает null если объект нельзя привести к типу
            if (m as Phone == null)
                return false;
            return m.nomer == this.nomer && m.FIO == this.FIO && m.date == this.date && m.tarif == this.tarif && m.minut == this.minut;
        }

        public override string ToString()
        {
            return "номер телефона: " + nomer
            + "\nФИО: " + FIO
            + "\nДата регистрации: " + date
            + "\nТарифный план: " + tarif
            + "\nКоличество минут в разговорах: " + minut + "\n";
        }

        public int CompareTo(object obj)
        {
            if (nomer > ((Phone)obj).nomer)
                return 1;
            else if (nomer == ((Phone)obj).nomer)
                return 0;
            else
                return -1;
        }
    }
}
