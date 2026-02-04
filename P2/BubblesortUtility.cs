using SWENG421_Lab4.P2;

namespace SWENG421_Lab4.P1
{
    internal class BubblesortUtility<T> : SortUtility<T>, ISortAlgo<T> where T : ProductIF
    {
        public BubblesortUtility() : base("bubblesort") { }

        public override void Print(List<T> data)
        {
            foreach (T item in data)
            {
                System.Console.WriteLine($"{item.GetID()}, {item.GetName()}, {item.GetPrice()}");
            }
        }
    }
}
