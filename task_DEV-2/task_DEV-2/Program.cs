using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_DEV_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StringWork test = new StringWork();
                Console.WriteLine(test.Translate(args[0]));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


           
        }


    }
}
