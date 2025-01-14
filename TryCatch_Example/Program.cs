﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = -1;
            while (num < 0)
            {
                try
                {
                    Console.WriteLine("Please enter a number");
                    num=int.Parse(Console.ReadLine());
                    Console.WriteLine($"Square of {num} is {num * num}");
                }
                catch
                {
                    Console.WriteLine("Something went wrong.");
                }
            }
        }
    }
}
