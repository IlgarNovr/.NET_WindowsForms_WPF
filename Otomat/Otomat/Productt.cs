namespace Otomat
{
    class Productt
    {
        public double ProducttPrice { get; set; }
        public string ProducttName { get; set; }
        public int ProducttAmount { get; set; }
        public Productt() { }

        public Productt(int producttAmount, double producttPrice, string producttName)
        {
            ProducttPrice = producttPrice;
            ProducttName = producttName;
            ProducttAmount = producttAmount;
        }
    }
}
