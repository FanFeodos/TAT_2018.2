using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_DEV_8
{
    class AveragePriceType:ICommand
    {
        private AutoCatalog autoCatalog;
        private string brand;
        public AveragePriceType(AutoCatalog autoCatalog, string brand)
        {
            this.autoCatalog = autoCatalog;
            this.brand = brand;
        }
        public void Execute()
        {
            double averageBrandPrice = autoCatalog.AverageBrandPrice(brand);
            Console.WriteLine(averageBrandPrice);
        }

    }
}
