using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_task_10_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstV, secV;
            Console.WriteLine("Введите первое число: ");
            firstV = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");
            secV = double.Parse(Console.ReadLine());

            double result = (firstV + secV) / 2;

            Console.WriteLine("Среднее арифметическое чисел = " + result);

            Console.ReadLine();
        }
    }
}
