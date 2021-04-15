using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Product
{
    private string colour;
    private string material;
    private float price;

    private static int countProduct;
    protected string Material
    {
        get
        { return material; }
        set
        { material = value; }
    }
    protected float Price
    {
        get
        { return price; }
        set
        { price = value; }
    }
    protected string Colour
    {
        get
        { return colour; }
        set
        { colour = value; }
    }
    public Product(string material, float price, string colour)
    {
        Colour = colour;
        Material = material;
        Price = price;
        countProduct++;
    }

    public Product(Product product)
    {
        Colour = product.Colour;
        Material = product.Material;
        Price = product.Price;
        countProduct++;
    }

    public override bool Equals(Object obj)
    {
        if (!(obj is Product)) return false;
        var product = (Product)obj;

        if (Material == product.Material &&
        Price == product.Price &&
        Colour == product.Colour)
            return true;
        else
            return false;
    }
    public override string ToString()
    {
        return $"Количество изделий: {countProduct}\n" +
               $"Цвет: {Colour}\n" +
               $"Материал: {Material}\n" +
               $"Цена: {Price}$";
    }
}

public class Mechanizm : Product
{
    private string type;
    private string proizv;

    public string Type
    {
        get
        { return type; }
        set
        { type = value; }
    }

    public string Proizv
    {
        get
        { return proizv; }
        set
        { proizv = value; }
    }


    public Mechanizm(string colour, string material, float price, string type, string proizv) : base(colour, price, material)
    {
        Type = type;
        Proizv = proizv;

    }

    public Mechanizm(Mechanizm mechanizm) : base(mechanizm)
    {
        Type = mechanizm.type;
        Proizv = mechanizm.proizv;
    }

    public override bool Equals(Object obj)
    {
        if (!(obj is Mechanizm)) return false;
        var mechanizm = (Mechanizm)obj;

        if (Type == mechanizm.type &&
        Proizv == mechanizm.proizv &&
            base.Equals(obj))
            return true;
        else
            return false;
    }

    public override string ToString()
    {

        return base.ToString() +
            $"\nТип механизма: {Type}\n" +
            $"Производитель: {Proizv}\n";
    }
}

public class Unit : Product
{
    private int year;
    private string size;
    public int Year
    {
        get
        { return year; }
        set
        { year = value; }
    }
    public string Size
    {
        get
        { return size; }
        set
        { size = value; }
    }



    public Unit(string colour, string material, float price, int year, string size) : base(colour, price, material)
    {
        Year = year;
        Size = size;
    }

    public Unit(Unit unit) : base(unit)
    {
        Year = unit.year;
        Size = unit.size;
    }

    public override bool Equals(Object obj)
    {
        if (!(obj is Unit)) return false;
        var unit = (Unit)obj;

        if (Year == unit.year &&
            Size == unit.size &&
            base.Equals(obj))
            return true;
        else
            return false;
    }

    public override string ToString()
    {
        return base.ToString() +
            $"\nРазмер: {Size} \n" +
            $"Срок службы: {Year} лет\n";
    }
}

public class Detail : Unit
{
    private bool disassembled;
    private string use;
    private string countrymake;

    public string Use
    {
        get
        { return use; }
        set
        { use = value; }
    }

    public string Countrymake
    {
        get
        { return countrymake; }
        set
        { countrymake = value; }
    }

    public bool Disassembled
    {
        get
        { return disassembled; }
        set
        { disassembled = value; }
    }


    public Detail(string colour, string material, float price, int year, string size, string use, string countrymake, bool disassembled) : base(colour, material, price, year, size)
    {
        Use = use;
        Countrymake = countrymake;
        Disassembled = disassembled;
    }

    public Detail(Detail detail) : base(detail)
    {
        Use = detail.use;
        Countrymake = detail.countrymake;
        Disassembled = detail.disassembled;
    }

    public override bool Equals(Object obj)
    {
        if (!(obj is Detail)) return false;
        var detail = (Detail)obj;

        if (Use == detail.use &&
            Countrymake == detail.countrymake &&
            Disassembled == detail.disassembled &&
            base.Equals(obj))
            return true;
        else
            return false;
    }

    public override string ToString()
    {
        return base.ToString() +
            $"Где используется: {Use}\n" +
            $"Страна производитель: {Countrymake}\n" +
            $"Разбираемая: {Disassembled} \n";
    }
}

class Program
{

    static void Main(string[] args)
    {
        var products = new object[11];
        //mechanizm unit detail
        var mechanizm1 = new Mechanizm("Пластик", "Красный", 101, "Зубчатый", "EcoForm");
        var mechanizm2 = new Mechanizm("Эко-пластик", "Желтый", 103, "Гидравлический", "SichCompany");
        var mechanizm3 = new Mechanizm("Металл", "Синий", 12, "Пневматический", "Homeless");
        var unit1 = new Unit("Древесина", "Фиолетовый", 26, 7, "Средний");
        var unit2 = new Unit("Металл", "Оранжевый", 59, 13, "Маленький");
        var unit3 = new Unit("Углепластик", "Синий", 111, 10, "Большой");
        var detail1 = new Detail("Алюминий", "Желтый", 50, 20, "Cредний", "В часах", "Хорватия", true);
        var detail2 = new Detail("Металл", "Черный", 2000, 5, "Большой", "В технике", "США", false);
        var detail3 = new Detail("Платина", "Красный", 1000, 10, "Большой", "В диванах", "Беларусь", true);
        var detail4 = new Detail("Алюминий", "Белый", 12, 20, "Маленький", "В зубных щетках", "Китай", false);
        
        products[0] = mechanizm1;
        products[1] = mechanizm2;
        products[2] = mechanizm3;

        products[3] = unit1;
        products[4] = unit2;
        products[5] = unit3;

        products[6] = detail1;
        products[7] = detail2;
        products[8] = detail3;
        products[9] = detail4;
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(products[i]);
        }
        Detail find = new Detail("Алюминий", "Белый", 12, 20, "Маленький", "В зубных щетках", "Китай", false);
        for (int i = 0; i < 10; i++)
        {
            if (products[i].Equals(find) == true)
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("найденный объект");
                Console.WriteLine(products[i]);
            }
        }



        Console.ReadKey();
    }
}


