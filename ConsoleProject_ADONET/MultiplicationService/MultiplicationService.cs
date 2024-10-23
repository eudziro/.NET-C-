using System;
using System.Linq;

﻿namespace Multiplication.Services
{
    public class MultiplicationService
    {
        public static int Multiplication(int a, int b)
        {
            return (a+b)*(a-b);
        }
        public static double Calculator(double value1, double value2, char val3)
        {
            switch (val3)
            {
                case 'm': return value1 * value2; break;
                case 'd': return value1 / value2; break;
                case 'a': return value1 + value2; break;
                case 's': return value1 - value2; break;
                default: return 0;
            }
        }
        public void TableTimesON5()
        {
            int i = 0;
            while (i <= 10)
            {
                Console.WriteLine(i * 5);
                ++i;
            }
        }
        public static double CalculateAverage(int[] array)
        {
            int size = array.Length;
            int total = 0;
            for (int i = 0; i < size; i++)
            {
                total += array[i];
            }
            return total / size;
        }
        public static int LinearSearch(int[] array)
        {
            return array.Max();
        }

    }
}
