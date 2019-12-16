using System;

namespace задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int A;
            Console.WriteLine("Введите А");
            A = Convert.ToInt32(Console.ReadLine());//вывод А
            if ((A > 9) && (A < 100) && (A%2==0))
            {
                Console.WriteLine("True");
            }
            else { Console.WriteLine("False"); }
             Console.Read();
        }
    }
}
