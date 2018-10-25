using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_DEV_3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StringBuilder output = new StringBuilder();
                ConvertToSystems outputted = new ConvertToSystems();
                output = outputted.Convertation(args);
                Console.WriteLine(output);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
