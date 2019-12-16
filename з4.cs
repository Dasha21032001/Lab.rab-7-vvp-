using System;

namespace задание_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int A;
            Console.WriteLine("Введите трёхзначное число А");
            A = Convert.ToInt32(Console.ReadLine());//вывод А
            int c = A % 10;//число единиц
            int b = (A / 10) % 10;//число десятков
            int a = A / 100;//число сотен
                if ((a < b) && (b < c))
            {
                Console.WriteLine("Возрастающая последовательность: True");
            }
                else { Console.WriteLine("Возрастающая последовательность: False"); }

                if ((a > b) && (b > c))
            {
                Console.WriteLine("Убывающая последовательность: True");
            }
                else { Console.WriteLine("Убывастающая последовательность: False"); }
            Console.Read();
        }
    }
}
