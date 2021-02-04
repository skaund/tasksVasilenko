using System;

namespace the_task_46_1
{
    class Program
    {

        static void PrintLine(string symbol, uint symbolsCount)
        {
            for (int i = 0; i < symbolsCount; i++)
            {
                Console.Write(symbol);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите символ: ");
            string symbol = Console.ReadLine();

            Console.WriteLine("Введите количество символов: ");
            uint symbolsCount = uint.Parse(Console.ReadLine());

            PrintLine(symbol, symbolsCount);
            Console.ReadLine();
        }
    }
}
