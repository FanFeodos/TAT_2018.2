using System;
using System.Text.RegularExpressions;
namespace work2
{
    class FindWebSite
    {
        //regular expression for web-site 
        private static Regex url= new Regex(@"(ftp|http|https):\/\/(\w+:{0,1}\w*@)?(\S+)(:[0-9]+)?(\/|\/([\w#!:.?+=&%@!\-\/]))?");
        public string findUrl(string s)
        {
            Match startMatch = url.Match(s);
            if (!startMatch.Success) //Check that string contains tags
            {
                throw new Exception("There is no URL at your string ");
            }
            return startMatch.ToString();
        }
    }
}
