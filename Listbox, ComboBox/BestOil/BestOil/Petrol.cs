namespace BestOil
{
    class Petrol
    {
        public string PetrolName { get; set; }

        public double Price { get; set; }
        public Petrol(string petrol, double price)
        {
            PetrolName = petrol;
            Price = price;
        }
        public override string ToString()
        {
            return PetrolName;
        }
    }
}
