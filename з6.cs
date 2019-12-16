using System;

namespace задание_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Введите a");
            a = Convert.ToInt32(Console.ReadLine());//вывод a
            Console.WriteLine("Введите b");
            b = Convert.ToInt32(Console.ReadLine());//вывод b
            Console.WriteLine("Введите c");
            c = Convert.ToInt32(Console.ReadLine());//вывод c
                if ((a * a) == (b * b) + (c * c))
            { Console.WriteLine("Треугольник прямоугольный"); }
            
                else if ((b * b) == (a * a) + (c * c))
            { Console.WriteLine("Треугольник прямоугольный"); }
            
                else if ((c * c) == (a * a) + (b * b))
            { Console.WriteLine("Треугольник прямоугольный"); }
                
                else
            { Console.WriteLine("Треугольник не прямоугольный"); }
            Console.Read();
        }
    }
}
