﻿using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number = 2;
            int count = 19;
            float totalPrice = 20.95f;
            char character = 'A';
            string firstName = "Toua";
            bool isWorking = true;
            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
            Console.WriteLine("Hello World!");
            Console.WriteLine("{0},{1}",byte.MinValue,byte.MaxValue);
            Console.WriteLine("{0},{1}",float.MaxValue,float.MinValue);
        }
    }
}
