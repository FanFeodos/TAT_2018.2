namespace task_DEV_5
{
    //clas Car 
    public class Auto
    {

        private string Brand { get; }
        public string GetBrand()
        {
            return Brand;
        }
        private string Model { get; }
        public string GetModel()
        {
            return Model;
        }
        private ulong Count { get; }
        public ulong GetCount()
        {
            return Count;
        }
        private ulong Price { get; }
        public ulong GetPrice()
        {
            return Price;
        }
        //Connstructor of class
        public Auto (string brand, string model, ulong count, ulong price)
        {
            this.Brand= brand;
            this.Model = model;
            this.Count = count;
            this.Price = price;
        }

       
    }
}
