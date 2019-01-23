namespace task_DEV_8
{
    class Add:ICommand
    {
        private AutoCatalog autoCatalog;
        private Auto auto;
        public Add(AutoCatalog carCatalog, Auto auto)
        {
            this.autoCatalog = carCatalog;
            this.auto = auto;
        }
        public void Execute()
        {
            autoCatalog.AddToCatalog(auto);
        }
    }
}
