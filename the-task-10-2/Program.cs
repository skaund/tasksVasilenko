using System;

namespace the_task_10_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstV, secV, twV;
            Console.WriteLine("Введите первое число: ");
            firstV = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");
            secV = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите третье число: ");
            twV = double.Parse(Console.ReadLine());

            double resultS = firstV + secV + twV;

            double resultY = firstV * secV * twV;

            Console.WriteLine("Сложением данных чисел является: " + resultS);
            Console.WriteLine("Умножением данных чисел является: " + resultY);

            Console.ReadLine();
        }
    }
}