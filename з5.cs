using System;

namespace задание_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int A;
            Console.WriteLine("Введите четырёхзначное число А");
            A = Convert.ToInt32(Console.ReadLine());//вывод А
            if ((A / 1000 == A % 10) && ((A / 100) % 10 == (A % 100) / 10))
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
            Console.Read();
        }
    }
}
