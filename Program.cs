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
            var myObj = new Undarmaa.Lab1.Task2 { City = "Ulaanbaatar" };
            Console.WriteLine(myObj.City);

            Task1 a = new Task1();
            a.Age = Console.ReadLine();
            Console.WriteLine("nas: "+a.Age);

            
        }
    }
}
