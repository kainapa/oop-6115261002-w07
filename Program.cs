using System;

namespace oop_6115261002_e07
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Nitat", "Ninchawee", 25000, 20, 30, 10);
            Lecturer l1 = new Lecturer("Nitat", "Ninchawee", 25000, 5, 10, 20, 20, 30, 20);
            Personnel p2 = new Personnel("Nitat", "Ninchawee", 25000, 5, 30, 10, 60);
            Console.WriteLine(p1.ToString());
            Console.WriteLine(l1.ToString());
            Console.WriteLine(p2.ToString());
           
        }
    }
}
