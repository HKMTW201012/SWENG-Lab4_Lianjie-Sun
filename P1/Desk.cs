namespace SWENG421_Lab4.P2
{
    public class Desk : ProductIF
    {
        private readonly int id;
        private string name;
        private double price;

        public Desk(int id, string name, double price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }

        public int GetID() => id;

        public string GetName() => name;
        public void SetName(string name) => this.name = name;

        public double GetPrice() => price;
        public void SetPrice(double price) => this.price = price;
    }
}
