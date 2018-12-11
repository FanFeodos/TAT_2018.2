using System;
namespace task_DEV_8
{
    class CountAll:ICommand
    {
        readonly AutoCatalog autoCatalog;
        public CountAll(AutoCatalog autoCatalog)
        {
            this.autoCatalog = autoCatalog;
        }
        public void Execute()
        {
            int amountOfCars = autoCatalog.AmountOfAllCars();
            Console.WriteLine(amountOfCars);
        }
    }
}
