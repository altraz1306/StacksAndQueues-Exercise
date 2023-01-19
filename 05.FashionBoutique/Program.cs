using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FashionBoutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));
            var capacity = int.Parse(Console.ReadLine());
            var rackSize = capacity;
            var rack = 1;

            while (stack.Any())
            {
                rackSize -= stack.Peek();
                if (rackSize < 0)
                {
                    rackSize = capacity;
                    rack++;

                    continue;
                }
               stack.Pop();
            }
            Console.WriteLine(rack);
        }
    }
}
