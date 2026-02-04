

namespace SWENG421_Lab4.P2
{
    public class SortUtility<T> where T : ProductIF
    {
        private string sortName = "bubblesort";

        public SortUtility(string sortName)
        {
            this.sortName = sortName;
        }

        public string GetName() {
            return sortName; 
        }
        public void SetName(string sortName) { 
            this.sortName = sortName; 
        }

        public virtual List<T> Sort(List<T> data)
        {
            for (int i = 0; i < data.Count - 1; i++)
            {
                for (int j = 0; j < data.Count - i - 1; j++)
                {
                    if (data[j].GetPrice() > data[j + 1].GetPrice())
                    {
                        var temp = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = temp;
                    }
                }
            }
            return data;
        }

        public virtual void Print(List<T> data) { }
    }
}
