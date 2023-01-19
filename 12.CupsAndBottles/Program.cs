using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.CupsAndBottles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cupCapacity = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));
            var waters = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            var bottleCount = 0;
            var wastedWater = 0;

            while (cupCapacity.Any())
            {
                var currentBottle = waters.Pop();
                
                if (cupCapacity.Peek() <= currentBottle)
                {
                    wastedWater += currentBottle - cupCapacity.Peek();
                    cupCapacity.Dequeue();
                }
                else
                {
                    var currentCup = cupCapacity.Dequeue();
                    currentCup -= currentBottle;
                    while (true)
                    {
                        var newBottle = waters.Pop();
                        if (newBottle < currentCup)
                        {
                            currentCup -= newBottle;
                        }
                        else
                        {
                            wastedWater += newBottle - currentCup;
                            break;
                        }
                        if (waters.Count == 0)
                        {
                            Console.WriteLine($"Cups: {currentCup + " " + string.Join(" ", waters)}");
                            Console.WriteLine($"Wasted litters of water: {wastedWater}");
                            return;
                        }
                    }
                }
                if (waters.Count == 0)
                {
                    break;
                }
            }
            if (cupCapacity.Any())
            {
                Console.WriteLine($"Cups: {string.Join(" ", cupCapacity)}");
                Console.WriteLine($"Wasted litters of water: {wastedWater}");
            }
            else
            {
                Console.WriteLine($"Bottles: {string.Join(" ", waters)}");
                Console.WriteLine($"Wasted litters of water: {wastedWater}");
            }
        }
    }
}