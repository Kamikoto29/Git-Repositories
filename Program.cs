﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git_Repositories
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        static void Degree()
        {
            Console.OutputEncoding = Encoding.GetEncoding(1251);
            Console.InputEncoding = Encoding.GetEncoding(1251);

            Console.WriteLine("Виберіть число:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Виберіть степень:");
            int degree = int.Parse(Console.ReadLine());

            int result = 1;

            for (int i = 0; i < degree; i++)
                result *= number;

            Console.WriteLine($"Відповідь: {result}");
        }
    }
}
