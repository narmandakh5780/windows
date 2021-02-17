using System;
using Narmandakh.Lab1;
using Undarmaa.Lab1;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // undarmaagiin project
            Task2 b = new Task2();
            Console.WriteLine("Hotiin neriig oruulna uu: \n");
            b.City = Console.ReadLine();
            Console.WriteLine("Hot: " + b.City);

            Task1 a = new Task1();
            Console.WriteLine("Nasaa oruulna uu: \n");
            a.Age = Console.ReadLine();
            Console.WriteLine("nas: "+a.Age);

            
        }
    }
}
