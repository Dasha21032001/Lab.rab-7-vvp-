using System;

namespace задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;
            Console.WriteLine("Введите А");
            A = Convert.ToInt32(Console.ReadLine());//вывод А
            Console.WriteLine("Введите В");
            B = Convert.ToInt32(Console.ReadLine());//вывод В
            Console.WriteLine("Введите C");
            C = Convert.ToInt32(Console.ReadLine());//вывод C
            if ((A < B) && (B < C))
            {
                Console.WriteLine("True");
            }
            else { Console.WriteLine("False"); }
            Console.Read();
        }
    }
}
