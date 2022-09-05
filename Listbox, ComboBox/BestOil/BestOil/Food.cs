namespace BestOil
{
    class Food
    {
        public string FoodName { get; set; }

        public double Price { get; set; }

        public int Number { get; set; }
        public Food(string food, double price)
        {
            FoodName = food;
            Price = price;
            Number = 0;
        }
    }
}
