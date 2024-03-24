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
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };
            double average = CalculateAverage(array);
            Console.WriteLine("Average: " + average);

            Console.WriteLine("Hello World!");
            Console.WriteLine("Mod1");
            Console.WriteLine("Mod2");
            Console.WriteLine("Mod3");
        }
    }
}
