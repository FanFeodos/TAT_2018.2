using System;
namespace task_DEV_8
{
    class Menu
    {
        private AutoCatalog carCatalog;
        private AutoCatalog truckCatalog;
        private ICommand command;

        public Menu()
        {
            carCatalog=new AutoCatalog();
            truckCatalog=new AutoCatalog();
            ParsetoShow a=new ParsetoShow();
            a.ParseXmlToAutoShow("Cars.xml",carCatalog);
            a.ParseXmlToAutoShow("Trucks.xml",truckCatalog);
        }

        public void Show()
        {
            Console.WriteLine("Enter command:\n" +
                              "1.count_types truck(car)\n" +
                              "2.count_all truck(car)\n" +
                              "3.average_price truck(car)\n" +
                              "4.average_price_ truck(car) type\n" +
                              "5.execute  truck(car)\n" +
                              "0.exit\n");
            bool exit = false;
            while (!exit)
            {
                string[] inputString = Console.ReadLine().Split(' ');
                if (inputString[1] == "truck")
                {
                    exit=Show(inputString, truckCatalog);
                }
                else if (inputString[1] == "car")
                {
                    exit=Show(inputString, carCatalog);
                }
                else
                {
                    Console.WriteLine("Please,repeat input, smth incorrect");
                }
                
            }
        }

        public bool Show(string[] inputString, AutoCatalog autoCatalog)
        {
            AvailableCommands commands = GetCommand(inputString);
            switch (commands)
            {
                case AvailableCommands.count_types:
                    command = new CountType(autoCatalog);
                    command.Execute();
                    break;
                case AvailableCommands.count_all:
                    command = new CountAll(autoCatalog);
                    command.Execute();
                    break;
                case AvailableCommands.average_price:
                    command = new AveragePrice(autoCatalog);
                    command.Execute();
                    break;
                case AvailableCommands.average_price_type:
                    command = new AveragePriceType(autoCatalog, inputString[2]);
                    command.Execute();
                    break;
                case AvailableCommands.exit:
                    return true;
                case AvailableCommands.execute:
                    command = new CountType(autoCatalog);
                    command.Execute();
                    command = new CountAll(autoCatalog);
                    command.Execute();
                    command = new AveragePrice(autoCatalog);
                    command.Execute();
                    break;
                case AvailableCommands.nocommand:
                    Console.WriteLine("Incorrect command");
                    break;
            }
            return false;
        }

        private AvailableCommands GetCommand(string[] str)
        {
            switch (str[0])
            {
                case "count_types":
                    return AvailableCommands.count_types;
                    break;
                case "count_all":
                    return AvailableCommands.count_all;
                    break;
                case "average_price":
                    return AvailableCommands.average_price;
                    break;
                case "average_price_":
                    return AvailableCommands.average_price_type;
                    break;
                case "execute":
                    return AvailableCommands.execute;
                    break;
                case "exit":
                    return AvailableCommands.exit;
                    break;
                default:
                    return AvailableCommands.nocommand;
                    break;
            }
        }
    }
}
