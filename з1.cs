using System;

namespace Лаб.раб__7
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B;
            Console.WriteLine("Введите А");
            A = Convert.ToInt32(Console.ReadLine());//вывод А
            Console.WriteLine("Введите В");
            B = Convert.ToInt32(Console.ReadLine());//вывод В
            if ((A > 2) && (B <= 3))
            {
                Console.WriteLine("True");
            }
            else { Console.WriteLine("False"); }
            Console.Read();
        }
    }

}
