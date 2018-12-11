using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_DEV_8
{
    class AveragePrice: ICommand
    {
        private AutoCatalog autoCatalog;
        public AveragePrice(AutoCatalog autoCatalog)
        {
            this.autoCatalog = autoCatalog;
        }
        public void Execute()
        {
            double averagePrice = autoCatalog.AveragePrice();
            Console.WriteLine(averagePrice);
        }
    }
}
