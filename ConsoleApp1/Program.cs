using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 A = new Class1 { Name = "One" };
            var test = A;

            A.Name = "Two";
            Console.WriteLine(test.Name);

            Console.ReadKey();
        }
    }
}
