using System;

namespace ConsoleApp1
{
    internal class Program
    {
        public static double CalculateAverage(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new ArgumentException("Array must not be null or empty");
            }

            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }

            return (double)sum / numbers.Length;
        }
        public static int FindMaximum(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new ArgumentException("Array must not be null or empty");
            }

            int max = numbers[0];
            foreach (int num in numbers)
            {
                if (num > max)
                {
                    max = num;
                }
            }

            return max;
        }
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };
            double average = CalculateAverage(array);
            Console.WriteLine("Average: " + average);

            int maximum = FindMaximum(array);
            Console.WriteLine("Maximum value: " + maximum);

            Console.WriteLine("Hello World!");
            Console.WriteLine("Mod1");
            Console.WriteLine("Mod2");
            Console.WriteLine("Mod3");
        }
    }
}
