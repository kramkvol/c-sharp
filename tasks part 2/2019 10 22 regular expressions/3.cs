﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    class Tringle
    {
        public double Katet_1;
        public double Katet_2;
        public Tringle()
        {
            Katet_1 = 0;
            Katet_2 = 0;
        }
        public Tringle(double k1, double k2)
        {
            Katet_1 = k1;
            Katet_2 = k2;
        }
        public double Tringle_square(double a, double b)
        {
            return (a * b) / 2;
        }
        public string ToShortString()
        {
            return "Катет 1: " + Katet_1 + "\n" + "Катет 2: " + Katet_2 + "\n" + "Площадь треугольника: " + Tringle_square(Katet_1, Katet_2);
        }
        static void Main(string[] args)
        {
            Tringle a1 = new Tringle();
            a1.Katet_1 = 7;
            Tringle a2 = new Tringle();
            a1.Katet_2 = 8;
            Console.WriteLine(a1.ToShortString());
            Console.ReadKey();
        }
    }
}
