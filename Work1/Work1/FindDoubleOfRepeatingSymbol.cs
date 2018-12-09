using System;
using System.Collections.Generic;
namespace Work1
{
    class FindDoubleOfRepeatingSymbol
    {
        //method of finding pair of symbol
        public string findDoubleOfRepeatingSymbol(string s)
        {
            if (s.Length <= 1) // check input for correct
                throw new Exception("Length of string is small");
            else if (s.Length == 2)
                return s; // simple output, when it is possible
            else
            {
                //dictionary: key = pair of sybol, value = number of repeat
                Dictionary<string, int> doublesymbol = new Dictionary<string, int>(); 
                int maxRepeat = 1; 
                string temp, nameRepeat;
                nameRepeat = s.Substring(0, 2);
                for (int i = 0; i < s.Length - 1; i++)
                {
                    temp = s.Substring(i, 2);
                    if (!doublesymbol.ContainsKey(temp)) //check this pair in dicitionary
                    {
                        doublesymbol.Add(temp,1);
                    }
                    else
                    {
                        doublesymbol[temp]++; 
                        if (doublesymbol[temp] > maxRepeat) //check maximum
                        {
                            maxRepeat = doublesymbol[temp];
                            nameRepeat = temp;
                        }
                            
                    }
                }
                return nameRepeat;
            }
        }
    }
}
