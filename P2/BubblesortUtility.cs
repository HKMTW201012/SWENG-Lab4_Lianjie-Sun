using System;
using System.Collections.Generic;

namespace SWENG421_Lab4.P2
{
    internal static class BubblesortUtility<T> where T : ProductIF
    {
        public static void Print(List<T> data)
        {
            foreach (T item in data)
            {
                Console.WriteLine($"{item.GetID()}, {item.GetName()}, {item.GetPrice():0.00}");
            }
            Console.WriteLine();
        }
    }
}
