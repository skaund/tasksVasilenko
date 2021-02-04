using System;

namespace the_task_21da
{
    class Program
    {
        static void Main(string[] args)
        {
            double UsdToRub = 75.39;
            double USD;

            Console.WriteLine("Введите сумму в долларах");

            USD = double.Parse(Console.ReadLine());

            Console.WriteLine(USD + " долларов в рублях будет = " + USD + UsdToRub);

            Console.ReadLine();
            
        }
    }
}