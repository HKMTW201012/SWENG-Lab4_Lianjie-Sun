
namespace SWENG421_Lab4.P2
{
    public interface ISortAlgo<T> where T : ProductIF
    {
        List<T> Sort(List<T> data);
        void Print(List<T> data);
    }
}
