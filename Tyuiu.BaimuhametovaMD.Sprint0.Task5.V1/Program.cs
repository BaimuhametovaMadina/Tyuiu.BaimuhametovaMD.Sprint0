﻿using Tyuiu.BaimuhametovaMD.Sprint0.Task5.V1.Lib;

namespace Tyuiu.BaimuhametovaMD.Sprint0.Task5.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.Addition(1, 5));
            Console.WriteLine(DataService.Substraction(15, 5));
            Console.WriteLine(DataService.Multiplication(10, 10));
            Console.WriteLine(DataService.Division(5, 0));
            Console.ReadKey();
        }
    }
}
