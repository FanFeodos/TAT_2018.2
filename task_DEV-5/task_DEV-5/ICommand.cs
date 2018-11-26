namespace task_DEV_5
{
    //interface of programm
    public interface ICommand
    {
        int GetCountTypes(); 
        ulong GetCountAll();
        double GetAveragePrice();
        double GetAveragePriceType(string type);
        void AddInAutoShow(Auto auto);
        bool GetInfoAboutContain(string type);

    }
}
