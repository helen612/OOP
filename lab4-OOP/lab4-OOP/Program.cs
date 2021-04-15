using System;
using System.Collections;
using System.Collections.Generic;

namespace std
{
    public class animal
    {
        public string name;
        public string clas;
        public int aWeight;
        public animal()
        {
            name = "unknown";
            clas = "unknown";
            aWeight = 0;
        }
        public animal(string name, string clas, int aWeight)
        {
            this.name = name;
            this.clas = clas;
            this.aWeight = aWeight;
        }
    }
    public class Node<T>
    {
        public Node(T data)
        {
            Data = data;
        }
        public T Data { get; set; }
        public Node<T> Next { get; set; }
    }
    public class LinkedList<T> : IEnumerable // односвязный список
    {
        static Node<T> head; // головной/первый элемент
        static Node<T> tail; // последний/хвостовой элемент
        static int count;  // количество элементов в списке
        // добавление элемента
        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);
            if (head == null)
                head = node;
            else
                tail.Next = node;
            tail = node;
            count++;
        }
        // удаление элемента
        public bool Remove(T data)
        {
            Node<T> current = head;
            Node<T> previous = null;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    // Если узел в середине или в конце
                    if (previous != null)
                    {

                        // убираем узел current, теперь previous ссылается не на current, а на current.Next
                        previous.Next = current.Next;

                        // Если current.Next не установлен, значит узел последний,
                        // изменяем переменную tail
                        if (current.Next == null)
                            tail = previous;
                    }
                    else
                    {
                        // если удаляется первый элемент
                        // переустанавливаем значение head
                        head = head.Next;

                        // если после удаления список пуст, сбрасываем tail
                        if (head == null)
                            tail = null;
                    }
                    count--;
                    return true;
                }

                previous = current;
                current = current.Next;
            }
            return false;
        }
        public int Count { get { return count; } }
        // реализация интерфейса IEnumerable
        IEnumerator IEnumerable.GetEnumerator()
        {
            Node<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
        public static LinkedList<T> operator +(T a, LinkedList<T> l)
        {
            Node<T> node = new Node<T>(a);
            Node<T> current = head;
            node.Next = current;
            head = node;
            count++;
            return l;
        }
        public static LinkedList<T> operator --(LinkedList<T> a)
        {
            Node<T> current = head;
            head = current.Next;
            count--;
            return a;
        }
        // Удаление по индексу
        //public int this[int index]
        //{
        //    get
        //    {
        //        if (index < 0 || index >= count)
        //        {
        //            throw new Exception("Going out of the List");
        //        }
        //        Node<T> current = head;
        //        for (int i = 0; i < index; i++)
        //        {
        //            if (i == index - 1)
        //            {
        //                if (current.Next.Next == null) tail = current;
        //                current.Next = current.Next.Next;
        //                count--;
        //                return 1;
        //            }
        //            current.Next = current;
        //        }
        //        if (index == 0)
        //        {
        //            head = current.Next;
        //            count--;
        //            return 1;
        //        }
        //        return 0;
        //    }
        //}
        //public int this[int index, T element]
        //{
        //    get
        //    {
        //        if (index < 0 || index > count)
        //        {
        //            throw new Exception("Going out of the list");
        //        }
        //        Node<T> node = new Node<T>(element);
        //        Node<T> current = head;
        //        if (index == count)
        //        {
        //            tail.Next = node;
        //            tail = node;
        //            count++;
        //            return 1;
        //        }
        //        for (int i = 0; i < index; i++)
        //        {
        //            if (i == index - 1)
        //            {
        //                Node<T> temp;
        //                temp = current.Next;
        //                current.Next = node;
        //                node.Next = temp;
        //                count++;
        //            }
        //            current.Next = current;
        //            return 1;
        //        }
        //        if (index == 0)
        //        {
        //            node.Next = current;
        //            head = node;
        //            count++;
        //            return 1;
        //        }

        //        return 0;
        //    }
        //}
        //public static bool operator ==(LinkedList<T> a, LinkedList<T> b)
        //{
        //    if (Equals(a, b)) return true;
        //    else return false;
        //}
        //public static bool operator !=(LinkedList<T> a, LinkedList<T> b)
        //{
        //    if (Equals(a, b)) return false;
        //    else return true;
        //}

    }

    class Program
    {
        static int Main()
        {

            LinkedList<animal> Llist = new LinkedList<animal>();
            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Choose the action\n" +
                    "1. Add to the end\n" +
                    "2. Add to the begin\n" +
                    "3. Remove from begin\n" +
                    "4. Show list\n" +
                    "0. Exit");
                try
                {
                    switch (Console.ReadLine())
                    {
                        case "0":
                            {
                                //Console.ResetColor();
                                Environment.Exit(0);
                                break;
                            }
                        case "1":
                            {
                                animal someAnimal = new animal();
                                Console.Write("Enter the name of your animal: ");
                                //Console.ForegroundColor = ConsoleColor.White;
                                someAnimal.name = Console.ReadLine();
                                Console.Write("Enter the class of your animal: ");
                                someAnimal.clas = Console.ReadLine();
                                Console.Write("Enter the averange weight of your animal: ");
                                someAnimal.aWeight = Convert.ToInt32(Console.ReadLine());
                                Llist.Add(someAnimal);
                                break;
                            }
                        case "2":
                            {
                                animal someAnimal = new animal();
                                Console.Write("Enter the name of your animal: ");
                                //Console.ForegroundColor = ConsoleColor.White;
                                someAnimal.name = Console.ReadLine();
                                Console.Write("Enter the class of your animal: ");
                                someAnimal.clas = Console.ReadLine();
                                Console.Write("Enter the averange weight of your animal: ");
                                someAnimal.aWeight = Convert.ToInt32(Console.ReadLine());
                                object p = someAnimal + Llist;
                                Console.WriteLine("The first element was added");
                                break;
                            }
                        case "3":
                            {
                                --Llist;
                                Console.WriteLine("The first elemnt was deleted!");
                                break;
                            }
                        case "4":
                            {
                                Console.WriteLine("Your list:");
                                Console.ForegroundColor = ConsoleColor.Blue;
                                foreach (animal item in Llist)
                                {
                                    Console.WriteLine($"Name of the animal: {item.name}" + "\n" +
                                        $"Class of the animal: {item.clas}" + "\n" +
                                        $"Averange weight of the animal: {item.aWeight}" + "\n");
                                }
                                Console.ResetColor();
                                Console.WriteLine();
                                break;
                            }
                    }
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\n\nSource: {e.Source}\nMessage: {e.Message}");
                }
                finally
                {
                    Console.ResetColor();
                }
                Console.ReadKey();
            }
        }
    }
}