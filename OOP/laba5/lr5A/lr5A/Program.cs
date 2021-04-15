using System;

namespace lr5A
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList strs = new MyList();
            strs.Add("hello");
            Console.WriteLine(strs.ToString());
            strs.Add("world");
            Console.WriteLine(strs.ToString());
            strs.Add("yo");
            Console.WriteLine(strs.ToString());
            strs.Add("world");
            Console.WriteLine(strs.ToString());
            Console.WriteLine("\n------------------------------------\n");

            Console.ReadLine();
        }
    }
}
