using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_sequence
{
    class Program
    {
        static List<ulong> fibonacciSequence = new List<ulong>();

        static void Main(string[] args)
        {
            fibonacci(92); // 92 maximum

            foreach (ulong number in fibonacciSequence)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine(fibonacciSequence.Count);
            Console.ReadLine();
        }

        static ulong fibonacci(int index)
        {
            ulong result;

            if (index < fibonacciSequence.Count)
            {
                return fibonacciSequence[index];
            }

            else if (index <= 1)
            {
                result = (ulong)index;
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
