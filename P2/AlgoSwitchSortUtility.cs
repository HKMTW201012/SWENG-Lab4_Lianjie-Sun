using SWENG421_Lab4.P2;

namespace SWENG421_Lab4.P1
{
    internal class AlgoSwitchSortUtility<T> : SortUtility<T> where T : ProductIF
    {
        private ISortAlgo<T> algorithm;

        public AlgoSwitchSortUtility(string sortName, ISortAlgo<T> algorithm) : base(sortName)
        {
            this.algorithm = algorithm;
        }

        public override List<T> Sort(List<T> data)
        {
            return algorithm.Sort(data);
        }

        public override void Print(List<T> data)
        {
            algorithm.Print(data);
        }

        public void SetAlgorithm(ISortAlgo<T> algorithm)
        {
            this.algorithm = algorithm;
        }
    }
}
