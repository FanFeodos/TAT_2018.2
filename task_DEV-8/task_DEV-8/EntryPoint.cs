﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  System.Xml.Linq;

namespace task_DEV_8
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                Menu a = new Menu();
                a.Show();
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
          
        }
    }
}
