﻿using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what s your name?");
            var name = Console.ReadLine();
            Console.WriteLine("Hello, " + name);
            
        }
    }
}