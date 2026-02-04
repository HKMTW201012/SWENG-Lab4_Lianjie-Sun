using SWENG421_Lab4.P2;

namespace SWENG421_Lab4.P1
{
    public class Desk : ProductIF
    {
        private int id;
        private string name;
        private double price;

        public Desk(int id, string name, double price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }

        public int GetID()
        {
            return id;
        }
        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public double GetPrice()
        {
            return price;
        }
        public void SetPrice(double price)
        {
            this.price = price;
        }
    }
}
