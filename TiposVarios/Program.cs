﻿using System;

namespace TiposVarios
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 22;
            uint height = 180;
            short year = 2023;
            ushort price = 54000;
            long CarPrice = 13000000;
            ulong HousePrice = 25000500;
            byte weight = 130;
            sbyte size = 11;

            Console.WriteLine(age);
            Console.WriteLine(height);
            Console.WriteLine(year);
            Console.WriteLine(price);
            Console.WriteLine(CarPrice);
            Console.WriteLine(HousePrice);
            Console.WriteLine(weight);
            Console.WriteLine(size);


            char LatinU = 'Ǔ';
            char LatinE = 'Ȅ';
            char Exclamation = '!';
            char li = 'ਈ';
            char ca = 'ਚ';

            Console.WriteLine(LatinU);
            Console.WriteLine(LatinE);
            Console.WriteLine(Exclamation);
            Console.WriteLine(li);
            Console.WriteLine(ca);


            float pi = 3.1415f;
            double preciseWeight = 77.5234;
            decimal mathResult = 3.99999999m;

            Console.WriteLine(pi);
            Console.WriteLine(preciseWeight);
            Console.WriteLine(mathResult);


            bool IsHigher = true;
            bool IsEqual = 3 == 5;

            Console.WriteLine(IsHigher);
            Console.WriteLine(IsEqual);


            



        }
    }
}
