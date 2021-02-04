using System;

namespace the_task_16_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Введите число и вы узнаете четное ли оно или нет: ");

            a = int.Parse(Console.ReadLine());

            int b = a % 2;

            if (b == 0)
            {
                Console.WriteLine("Вы ввели четное число!");
            }
            else
            {
                Console.WriteLine("Вы ввели нечетное число!");
            }
        }
    }
}