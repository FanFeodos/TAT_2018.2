using System;
namespace task_DEV_8
{
    class CountType:ICommand
    {
        readonly AutoCatalog autoCatalog;
        public CountType(AutoCatalog autoCatalog)
        {
            this.autoCatalog = autoCatalog;
        }
        public void Execute()
        {
            int amountOfBrands = autoCatalog.AmountOfBrands();
            Console.WriteLine(amountOfBrands);
        }
    }
}
