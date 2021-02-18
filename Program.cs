using System;
using Undarmaa.Lab1;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // undarmaagiin project
            Task1 b = new Task1();
            Console.WriteLine("Hotiin neriig oruulna uu: \n");
            b.City = Console.ReadLine();
            Console.WriteLine("Hot: " + b.City);

            Narmandakh.Lab1.Task1 a = new Narmandakh.Lab1.Task1();
            Console.WriteLine("Nasaa oruulna uu: \n");
            a.Age = Console.ReadLine();
            Console.WriteLine("nas: "+a.Age);

            
        }
    }
}
