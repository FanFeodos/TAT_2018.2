using System;
namespace Work1
{
    /// <summary>
    /// Display a pair of consecutive letters, as often as possible in the line
    /// </summary>
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                FindDoubleOfRepeatingSymbol a = new FindDoubleOfRepeatingSymbol();
                string b = a.findDoubleOfRepeatingSymbol(args[0]);
                Console.WriteLine(b);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
