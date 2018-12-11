using System;
using System.Collections.Generic;
using System.Linq;
namespace task_DEV_8
{
    class AutoCatalog
    {

        private List<Auto> AutoList;
        public AutoCatalog()
        {
            AutoList = new List<Auto>();
        }
        public void AddToCatalog(Auto auto)
        {
            AutoList.Add(auto);
        }
        public  int AmountOfBrands()
        {
            int amountOfBrands = 0;
            amountOfBrands = AutoList.GroupBy(i => i.Brand).Count();
            return amountOfBrands;
        }
        public int AmountOfAllCars()
        {
            int amountOfAllCars = 0;
            foreach (Auto auto in AutoList)
            {
                amountOfAllCars += auto.Amount;
            }
            return amountOfAllCars;
        }
        public double AveragePrice()
        {
            double averagePrice = 0;
            int amountOfAllCars = 0;
            foreach (Auto auto in AutoList)
            {
                amountOfAllCars += auto.Amount;
                averagePrice += auto.Amount*auto.Price;
            }
            return averagePrice/amountOfAllCars;
        }
        public double AverageBrandPrice(string brand)
        {
            bool listContainsBrand = AutoList.Select(i => i.Brand).Contains(brand);
            if (!listContainsBrand)
            {
                throw new Exception($"Catalog doesn't contain {brand}");
            }
            double averageBrandPrice = 0;
            int nubmerofBrand = 0; 
            foreach (Auto auto in AutoList)
            {
                if (auto.Brand == brand)
                {
                    nubmerofBrand += auto.Amount;
                    averageBrandPrice += auto.Price*auto.Amount;
                }
            }
            return averageBrandPrice/nubmerofBrand;
        }
    }
}
