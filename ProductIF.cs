namespace SWENG421_Lab4.P2
{
    public interface ProductIF
    {
        int GetID();
        string GetName();
        void SetName(string name);

        double GetPrice();
        void SetPrice(double price);
    }
}
