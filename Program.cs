using System;
using System.CodeDom.Compiler;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices.ComTypes;

namespace ExampleApp
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите число 1 ");
            var num = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите число 2 ");
            var num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите число 3 ");
            var num3 = Convert.ToDouble(Console.ReadLine());

            var res = num * 2;
            var res2 = num2 - 3;
            var res3 = Math.Pow(num3, 2);
            var sum = res + res2 + res3;
            var res4 = 12;
            Console.WriteLine($" {res} {res2} {res3} {sum}"); 
        }
    }
}

