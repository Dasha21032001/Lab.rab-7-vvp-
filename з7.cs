using System;

namespace задание_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Введите сторону треугольника a");
            a = Convert.ToInt32(Console.ReadLine());//вывод a
            Console.WriteLine("Введите сторону треуголника b");
            b = Convert.ToInt32(Console.ReadLine());//вывод b
            Console.WriteLine("Введите сторону трегугольника c");
            c = Convert.ToInt32(Console.ReadLine());//вывод c
            if ((a + b > c) && (b + c > a) && (c + a > b))
            {
                Console.WriteLine("True");
            }
            else { Console.WriteLine("False"); }
            Console.Read();
        }
    }
}
