using System;
namespace task_DEV_8
{
    class Auto
    {
        private const int MinAmount = 1;

        private const int MinCost = 0;
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }
        public Auto(string brand, string model, int amount, double price)
        {
            if ((brand == string.Empty) || (model == string.Empty) || (amount < MinAmount) || (price <= MinCost))
            {
                throw new ArgumentException("Wrong argument.");
            }
            Brand = brand;
            Model = model;
            Amount = amount;
            Price = price;
        }


    }
}
