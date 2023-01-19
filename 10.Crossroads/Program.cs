using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.Crossroads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var greenLightTime = int.Parse(Console.ReadLine());
            var freeWindowTime = int.Parse(Console.ReadLine());

            var carsQueue = new Queue<string>();
            string car = string.Empty;
            var counter = 0;

            while ((car = Console.ReadLine()) != "END")
            {
                int greenLight = greenLightTime;
                int freeWindow = freeWindowTime;

                if (car == "green")
                {
                    while (greenLight > 0 && carsQueue.Count != 0)
                    {

                        var firstInQueue = carsQueue.Dequeue();
                        greenLight -= firstInQueue.Count();
                        if (greenLight >= 0)
                        {
                            counter++;
                        }

                        else
                        {
                            freeWindow += greenLight;
                            if (freeWindow < 0)
                            {
                                Console.WriteLine("A crash happened!");
                                Console.WriteLine($"{firstInQueue} was hit at {firstInQueue[firstInQueue.Length + freeWindow]}.");
                                return;
                            }
                            counter++;
                        }
                    }
                }

                else
                {
                    carsQueue.Enqueue(car);
                }
            }
            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{counter} total cars passed the crossroads.");
        }
    }
}

