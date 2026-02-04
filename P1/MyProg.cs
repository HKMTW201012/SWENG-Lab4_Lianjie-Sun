using SWENG421_Lab4.P2;

namespace SWENG421_Lab4.P1
{
    public class MyProg
    {
        public static void Main(string[] args)
        {
            Company xyz = new Company();

            // Bubblesort
            xyz.sortUtility = new AlgoSwitchSortUtility<ProductIF>("bubblesort", new BubblesortUtility<ProductIF>());
            List<ProductIF> desks = GetProducts();
            var bubbleSorted = xyz.sortUtility.Sort(desks);
            xyz.sortUtility.Print(bubbleSorted);

            Console.WriteLine();

            // Quicksort
            ((AlgoSwitchSortUtility<ProductIF>)xyz.sortUtility).SetAlgorithm(new QuicksortUtility<ProductIF>());
            xyz.sortUtility.SetName("quicksort");
            var quickSorted = xyz.sortUtility.Sort(desks);
            xyz.sortUtility.Print(quickSorted);
        }

        public static List<ProductIF> GetProducts()
        {
            return new List<ProductIF>
            {
                new Desk(1, "Writing Desk", 20.30),
                new Desk(2, "Corner Desk", 15.25),
                new Desk(3, "Lap Desk", 25.13),
                new Desk(4, "Standing Desk", 15.85),
                new Desk(5, "Floating Desk", 22.56)
            };
        }
    }
}
