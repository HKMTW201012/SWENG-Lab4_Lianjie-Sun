using System;
using System.Collections.Generic;

namespace SWENG421_Lab4.P2
{
    internal static class QuicksortUtility<T> where T : ProductIF
    {
        public static List<T> Sort(List<T> data)
        {
            data.Sort((a, b) => a.GetPrice().CompareTo(b.GetPrice()));
            return data;
        }

        public static void Print(List<T> data)
        {
            foreach (T item in data)
            {
                Console.WriteLine($"{item.GetPrice():0.00}, {item.GetName()}, {item.GetID()}");
            }
            Console.WriteLine();
        }
    }
}
