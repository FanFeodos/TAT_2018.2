using System; 
namespace task_DEV_5
{
    //Program allows the user to get some minimal information 
    //about the car dealership

    //Entry Point
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("To enter the machine, use the following pattern: Geely Atlas 2 10000");
                // Input cars
                AutoShow autoShow = new AutoShow();
                do
                {
                    Console.WriteLine("Do you want to input car? (y/n)");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "y")
                    {
                        Console.Write("Enter car: ");
                        string car = Console.ReadLine();
                        string[] carParams = new string[4];
                        for(int i=0; i<carParams.Length-1; i++) //Parse string to params of car
                        {
                            int indexOfSpace = car.IndexOf(' '); 
                            carParams[i]= car.Substring(0, indexOfSpace);
                            car = car.Remove(0, indexOfSpace+1);
                        }
                        carParams[3] = car;
                        if (UInt64.TryParse(carParams[2], out ulong count) && UInt64.TryParse(carParams[3], out ulong price)) //is price correct?
                        {
                            Auto auto = new Auto(carParams[0], carParams[1], count, price);
                            autoShow.AddInAutoShow(auto);
                        }
                        else
                            Console.WriteLine("Incorrect entry, I'm sorry");
                       
                    }
                    else if (answer == "n")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Wrong command! Try entry again");
                    }
                }
                while (true);
                Console.WriteLine("Use this numbers of commands: \n1 -count types, \n2-count all, " +
                   "\n3-average price, \n4-average price type, \n0-Exit \n------------------");
                // Commands input
                do
                {
                    Console.Write("Enter number of comand: ");
                    string numberOfCommand = Console.ReadLine();
                    if (numberOfCommand=="1")
                    {
                        Console.WriteLine(autoShow.GetCountTypes());
                    }
                    else if (numberOfCommand == "2")
                    {
                        Console.WriteLine(autoShow.GetCountAll());
                    }
                    else if(numberOfCommand=="3")
                    {
                        Console.WriteLine(autoShow.GetAveragePrice());
                    }
                    else if(numberOfCommand=="4")
                    {
                        Console.WriteLine("Enter brand of cars");
                        string brand = Console.ReadLine();
                        if (autoShow.GetInfoAboutContain(brand))
                            Console.WriteLine(autoShow.GetAveragePriceType(brand));
                        else
                            Console.WriteLine("Your brand isn't in this autoshow");
                    }
                    else if (numberOfCommand == "0")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Try to Enter correct number, bro");
                    }
                }
                while (true);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
