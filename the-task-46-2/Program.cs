﻿using System;

namespace the_task_46_2
{
    class Program
    {

        static int IndexOf(int [] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    return i;
                }
            }

            return -1;
        }

        static int[] GetRandomArray(uint length, int minValue, int maxValue)
        {
            int[] myArray = new int[length];

            Random random = new Random();

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = random.Next(minValue, maxValue);
            }

            return myArray;
        }


        static void Main(string[] args)
        {
            int[] myArray = GetRandomArray(10, -20, 10);

            int result = IndexOf(myArray, 1000);

            Console.WriteLine(result);
        }
    }
}
