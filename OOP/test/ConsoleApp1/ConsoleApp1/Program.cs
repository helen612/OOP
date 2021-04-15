using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

abstract class Engine
{
    static int count;
    protected string Name;
    public string name
    {
        get
        {
            return this.Name;
        }
        set
        {
            this.Name = value;
        }
    }
    protected int Year;
    public int year
    {
        get
        {
            return this.Year;
        }
        set
        {
            this.Year = value;
        }
    }
    protected int WorkingLife;
    public int workingLife
    {
        get
        {
            return this.WorkingLife;
        }
        set
        {
            this.WorkingLife = value;
        }
    }
    public Engine(string Name, int WorkingLife, int Year)
    {
        this.Name = Name;
        this.Year = Year;
        this.WorkingLife = WorkingLife;
        count++;
        Console.WriteLine("Количество введенных двигателей: " + count);
    }
    public override string ToString()
    {
        return "Название: " + Name
        +
        " Срок службы: " + WorkingLife +
        " Год выхода: " + Year;
    }
    public override bool Equals(object obj)
    {
        if (obj == null)
            return false;
        Engine m = obj as Engine; // возвращает null если объект нельзя привести к типу
        if (m as Engine == null)
            return false;
        return m.Name == this.Name && m.WorkingLife == this.WorkingLife && m.Year == this.Year;
    }

}
class InternalCombustionEngine : Engine
{
    protected string TypeOfFuelUsed;
    public string typeOfFuelUsed
    {
        get
        {
            return this.TypeOfFuelUsed;
        }
        set
        {
            this.TypeOfFuelUsed = value;
        }
    }
    protected string MethodOfProcessingTheWorkingMixture;
    public string methodOfProcessingTheWorkingMixture
    {
        get
        {
            return this.MethodOfProcessingTheWorkingMixture;
        }
        set
        {
            this.MethodOfProcessingTheWorkingMixture = value;
        }
    }
    protected int Volume;
    public int volume
    {
        get
        {
            return this.Volume;
        }
        set
        {
            this.Volume = value;
        }
    }
    public InternalCombustionEngine(string name, int workinglife, int year, string TypeOfFuelUsed, string MethodOfProcessingTheWorkingMixture, int Volume) : base(name, workinglife, year)
    {
        this.MethodOfProcessingTheWorkingMixture = MethodOfProcessingTheWorkingMixture;
        this.Volume = Volume;
        this.TypeOfFuelUsed = TypeOfFuelUsed;
    }
    public override string ToString()
    {
        return base.ToString() + TypeOfFuelUsed +
        " Способ образования горючей смеси: " + MethodOfProcessingTheWorkingMixture +
        " Объём(см3): " + Volume;

    }
    public override bool Equals(object obj)
    {
        if (obj == null)
            return false;
        InternalCombustionEngine m = obj as InternalCombustionEngine; // возвращает null если объект нельзя привести к типу
        if (m as InternalCombustionEngine == null)
            return false;
        return base.Equals(obj) && m.TypeOfFuelUsed == this.TypeOfFuelUsed && m.MethodOfProcessingTheWorkingMixture == this.MethodOfProcessingTheWorkingMixture && m.Volume == this.Volume;
    }
}
class Diesel : Engine
{
    protected string Type { get; set; }
    public string type
    {
        get
        {
            return this.Type;
        }
        set
        {
            this.Type = value;
        }
    }
    protected string TypeEngine;
    public string typeEngine
    {
        get
        {
            return this.TypeEngine;
        }
        set
        {
            this.TypeEngine = value;
        }
    }
    protected int Volume1 { get; set; }
    public int volume1
    {
        get
        {
            return this.Volume1;
        }
        set
        {
            this.Volume1 = value;
        }
    }

    public Diesel(string Name, int WorkingLife, int Year, string Type, string TypeEngine, int Volume) : base(Name, WorkingLife, Year)
    {
        this.TypeEngine = TypeEngine;
        this.Volume1 = Volume;
        this.Type = Type;

        Console.WriteLine();

    }
    public override string ToString()
    {
        return base.ToString() + " Тип : " + Type +
        " Тип двигателя: " + TypeEngine +
        " Объём(см3): " + Volume1;

    }
    public override bool Equals(object obj)
    {
        if (obj == null)
            return false;
        Diesel m = obj as Diesel; // возвращает null если объект нельзя привести к типу
        if (m as Diesel == null)
            return false;
        return base.Equals(obj) && m.Type == this.Type && m.TypeEngine == this.TypeEngine && m.Volume1 == this.Volume1;
    }
}
class TurboJetEngine : Engine
{
    protected int P { get; set; }
    public int p
    {
        get
        {
            return this.P;
        }
        set
        {
            this.P = value;
        }
    }
    protected int Expenditure;
    public int expenditure
    {
        get
        {
            return this.Expenditure;
        }

        set
        {
            this.Expenditure = value;
        }
    }
    protected int Weight;
    public int weight
    {
        get
        {
            return this.Weight;
        }
        set
        {
            this.Weight = value;
        }
    }


    public TurboJetEngine(string Name, int WorkingLife, int Year, int P, int Expenditure, int Weight) : base(Name, WorkingLife, Year)
    {
        this.Expenditure = Expenditure;
        this.Weight = Weight;
        this.P = P;
    }
    public override string ToString()
    {
        return base.ToString() + " Давление: " + P +
        " Расход: " + Expenditure +
        "Вес: " + Weight;

    }
    public override bool Equals(object obj)
    {
        if (obj == null)
            return false;
        TurboJetEngine m = obj as TurboJetEngine; // возвращает null если объект нельзя привести к типу
        if (m as TurboJetEngine == null)
            return false;
        return base.Equals(obj) && m.P == this.P && m.Expenditure == this.Expenditure && m.Weight == this.Weight;
    }
}
class Program
{
    static void Main(string[] args)
    {
        InternalCombustionEngine Engine1 = new InternalCombustionEngine("Двигатель внутреннего сгорания", 25, 1999, "Бензин", "Поршневой двигатель", 1500);
        Diesel Engine2 = new Diesel("Дизель", 30, 1995, "Грузовик", "Четырёхтактный двигатель", 1700);
        TurboJetEngine Engine3 = new TurboJetEngine("Турбореактивный двигатель", 30, 2011, 40, 35, 25);
        TurboJetEngine Engine4 = new TurboJetEngine("Турбореактивный двигатель", 32, 2014, 30, 21, 13);
        Diesel Engine5 = new Diesel("Дизель", 30, 1996, "Легковой", "Трехтактный двигатель", 1700);
        InternalCombustionEngine Engine6 = new InternalCombustionEngine("Двигатель внутреннего сгорания", 24, 1999, "Бензин", "Поршневой двигатель", 1500);
        TurboJetEngine Engine7 = new TurboJetEngine("Турбореактивный двигатель", 32, 2014, 30, 21, 13);
        TurboJetEngine Engine8 = new TurboJetEngine("Турбореактивный двигатель", 30, 2005, 28, 35, 25);
        Diesel Engine9 = new Diesel("Дизель", 30, 1995, "Мотоцикл", "Четырёхтактный двигатель", 1700);
        Diesel Engine10 = new Diesel("Дизель", 30, 1995, "Автобус", "Четырёхтактный двигатель", 1700);
        Diesel Engine11 = new Diesel("Дизель", 30, 1995, "Автобус", "Четырёхтактный двигатель", 1700);
        Engine[] arr = new Engine[100];
        arr[0] = Engine1;
        arr[1] = Engine2;
        arr[2] = Engine3;
        arr[3] = Engine4;
        arr[4] = Engine5;
        arr[5] = Engine6;
        arr[6] = Engine7;
        arr[7] = Engine8;
        arr[8] = Engine9;
        arr[9] = Engine10;
        arr[10] = Engine11;
        for (int i = 0; i < 10; i++)
        {
           Console.WriteLine(arr[i]);
        }
        Diesel Naiti = new Diesel("Дизель", 30, 1995, "Автобус", "Четырёхтактный двигатель", 1700);
        for (int i = 0; i < 10; i++)
        {
            if (arr[i].Equals(Naiti) == true)
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("найденный объект");
                Console.WriteLine(arr[i]);

            }
        }

        Console.ReadKey();
    }
}
