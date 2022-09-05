namespace Otomat
{
    class Customer
    {
        public string TakenMoney { get; set; }

        public string Balance { get; set; }

        public string TimeOfBuying { get; set; }

        public Productt ProducttBought { get; set; }

        public Customer()
        {
            ProducttBought = new Productt();
        }
    }
}
