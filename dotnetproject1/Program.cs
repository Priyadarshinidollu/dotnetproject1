﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetproject1
{
    class Program
    {
        static void Main(string[] args)
        {
            string textAge = "-23";
            int ag = Convert.ToInt32(textAge);
            Console.WriteLine(ag);

            int x = 10, y = 20, z = 6;

            int age = 23;
            Console.WriteLine(age);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue); 

            long bigNumber = 9000000000L;
            Console.WriteLine(bigNumber);

            double negative = -35.3D;
            Console.WriteLine(negative);
            Console.WriteLine(double.PositiveInfinity);
            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.MaxValue);

            float precision = 5.000001F;
            Console.WriteLine(precision);
            Console.WriteLine(float.MinValue);
            Console.WriteLine(float.MaxValue);

            decimal money = 10.0M;
            Console.WriteLine(money);
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);
            Console.ReadLine();

            age = 31;
            Console.WriteLine(age);

            Concepts concepts = new Concepts();
            concepts.TextBasedData();

            int a = 10;
            int b = 3;
            int rem = a % b; Console.ReadLine();
            Console.WriteLine(rem);
            a = 5;
            rem = a % b;
            string name;
             Console.Write("my name is  : ");
            name = Console.ReadLine();

            Console.WriteLine(name);
        }
    }
}
