using System.Collections.Generic;

namespace SWENG421_Lab4.P2
{
    //The Only Visible Subclass of SortUtility
    public class AlgoSwitchSortUtility<T> : SortUtility<T> where T : ProductIF
    {
        public AlgoSwitchSortUtility(string sortName) : base(sortName) 
        { 

        }

        //Only Sorting! No Printing!
        public override List<T> sort(List<T> data)
        {
            string name = (getName() ?? "bubblesort").ToLower();

            if (name == "quicksort")
            {
                return QuicksortUtility<T>.Sort(data);
            }

            return base.sort(data);
        }

        //Printing After Completed Sorting
        public List<T> sortAndPrint(List<T> data)
        {
            List<T> sorted = sort(data);

            string name = (getName() ?? "bubblesort").ToLower();
            if (name == "quicksort")
            {
                QuicksortUtility<T>.Print(sorted);
            }
            else
            {
                BubblesortUtility<T>.Print(sorted);
            }

            return sorted;
        }
    }
}
