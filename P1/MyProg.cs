using System.Collections.Generic;
using SWENG421_Lab4.P2;

namespace SWENG421_Lab4.P1
{
    public class MyProg
    {
        public static void Main(string[] args)
        {
            List<Desk> desks = GetProducts();

            Company xyz = new Company();

            xyz.sortUtility = new AlgoSwitchSortUtility<Desk>("bubblesort");

            //Bubble Sort and Print
            xyz.sortUtility.setName("bubblesort");
            ((AlgoSwitchSortUtility<Desk>)xyz.sortUtility).sortAndPrint(desks);

            //Quick Sort and Print
            xyz.sortUtility.setName("quicksort");
            ((AlgoSwitchSortUtility<Desk>)xyz.sortUtility).sortAndPrint(desks);
        }

        public static List<Desk> GetProducts()
        {
            return new List<Desk>
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
