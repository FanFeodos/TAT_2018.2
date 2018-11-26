using System.Collections.Generic;
namespace task_DEV_5
{
   public class AutoShow:ICommand //realize interface of ICommand
    {
        private Dictionary<string, Pair<ulong, ulong>> Autos; //dictionary, key = brand, value = <count,total price>
        private ulong TotalNumberOfAuto;
        private ulong TotalPriceOfAuto;
        public AutoShow () //constructor
        {
            Autos= new Dictionary<string, Pair<ulong, ulong>>();
            TotalNumberOfAuto = 0;
            TotalPriceOfAuto = 0;
        }
  
        public void AddInAutoShow (Auto auto) //Method of add auto
        {
            ulong count = auto.GetCount();
            ulong prices = auto.GetPrice()*count;
            string brand = auto.GetBrand();
            this.TotalNumberOfAuto += count;
            this.TotalPriceOfAuto += prices;
            if (Autos.ContainsKey(brand)) //is dictionary contain this brand?
            {
                Autos[auto.GetBrand()].First += count;
                Autos[auto.GetBrand()].Second += prices;
            }
            else
            {
                Autos.Add(brand, new Pair<ulong, ulong>(count, prices));
            }
        }

        public int GetCountTypes()
        {
            return Autos.Count;
        }
        public ulong GetCountAll()
        {
            return TotalNumberOfAuto;
        }
        public double GetAveragePrice()
        {
            return (TotalPriceOfAuto *1.0)/ TotalNumberOfAuto; //parse to double
        }
        public double GetAveragePriceType(string type)
        {
            return (Autos[type].Second * 1.0) / Autos[type].First; //parse to double
        }
        public bool GetInfoAboutContain(string type)
        {
            if (Autos.ContainsKey(type))
                return true;
            else
                return false;
        }
    }
}
