using System;
using Narmandakh.Lab1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1 a = new Task1();
            a.Age = Console.ReadLine();
            Console.WriteLine("nas: "+a.Age);
        }
    }
}
