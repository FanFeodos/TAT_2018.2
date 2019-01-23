using System;
/// <summary>
/// Find, validate and display a link to the site, if there is one in an arbitrary string
/// </summary>
namespace work2
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                FindWebSite a = new FindWebSite();
                string s = a.findUrl(args[0]);
                Console.WriteLine(s);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }
    }
}
