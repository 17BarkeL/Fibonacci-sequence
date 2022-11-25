using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Fibonacci_sequence
{
    class Program
    {
        static List<decimal> fibonacciSequence = new List<decimal>();
        static Stopwatch stopwatch = new Stopwatch();

        static void Main(string[] args)
        {
            stopwatch.Start();
            fibonacci(138); // 138 maximum
            stopwatch.Stop();

            foreach (decimal number in fibonacciSequence)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine($"Took {stopwatch.Elapsed} to run");
            Console.ReadLine();
        }

        static decimal fibonacci(int index)
        {
            decimal result;

            if (index < fibonacciSequence.Count)
            {
                return fibonacciSequence[index];
            }

            else if (index <= 1)
            {
                result = index;
            }

            else
            {
                result = fibonacci(index - 2) + fibonacci(index - 1);
            }

            fibonacciSequence.Add(result);
            return result;
        }
    }
}
