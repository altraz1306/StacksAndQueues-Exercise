using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.KeyRevolver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bulletPrice = int.Parse(Console.ReadLine());
            var barrelSize = int.Parse(Console.ReadLine());
            var bullets = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                );
            var locks = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                );
            var intelligence = int.Parse(Console.ReadLine());
            var barretReload = barrelSize;
            var counter = 0;

            while (bullets.Count != 0 || locks.Count != 0)
            {
                if (barretReload != 0)
                {
                    if (bullets.Pop() <= locks.Peek())
                    {
                        Console.WriteLine("Bang!");
                        locks.Dequeue();
                    }
                    else
                    {
                        Console.WriteLine("Ping!");
                    }
                    barretReload--;
                    counter++;
                }
                if (barretReload == 0 && bullets.Any())
                {
                    Console.WriteLine("Reloading!");
                    barretReload = barrelSize;
                }
                if (bullets.Count == 0 && locks.Count != 0)
                {
                    Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
                    return;
                }
                if (!locks.Any())
                {
                    Console.WriteLine($"{bullets.Count} bullets left. Earned ${intelligence - counter * bulletPrice}");
                    return;
                }
            }


        }
    }
}
