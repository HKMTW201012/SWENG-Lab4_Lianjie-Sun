using SWENG421_Lab4.P2;

namespace SWENG421_Lab4.P1
{
    internal class QuicksortUtility<T> : SortUtility<T>, ISortAlgo<T> where T : ProductIF
    {
        public QuicksortUtility() : base("quicksort") { }

        public override List<T> Sort(List<T> data)
        {
            data.Sort((x, y) => x.GetPrice().CompareTo(y.GetPrice()));
            return data;
        }

        public override void Print(List<T> data)
        {
            foreach (T item in data)
            {
                System.Console.WriteLine($"{item.GetPrice()}, {item.GetName()}, {item.GetID()}");
            }
        }
    }
}
