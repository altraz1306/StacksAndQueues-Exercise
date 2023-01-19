using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FastFood
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var qtyFood = int.Parse(Console.ReadLine());

            Queue<int> queue = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));
            Console.WriteLine(queue.Max());
            while (queue.Any())
            {
                qtyFood -= queue.Peek();
                if (qtyFood < 0)
                {
                    break;
                }
                queue.Dequeue();
            }
            if (queue.Any())
            {
                Console.WriteLine($"Orders left: {string.Join(" ", queue)}");
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
