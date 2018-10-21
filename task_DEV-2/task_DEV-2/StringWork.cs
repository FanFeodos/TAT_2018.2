using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_DEV_2
{
    public static class StringWork
    {
        public static bool IsRussian(string s)
        {
            s = s.ToUpper();
            for (int i = 0; i < s.Length; i++)
            {
                int ValueOf = (int)s[i];
                if (ValueOf == 1025 && ValueOf >= 1040 && ValueOf <= 1061)
                    return true;
            }
            return false;
        }

        public static bool IsEnglish(string s)
        {
            s = s.ToUpper();
            for (int i = 0; i < s.Length; i++)
            {
                int ValueOf = (int)s[i];
                if (ValueOf >= 65 && ValueOf <= 90)
                    return true;
            }
            return false;
        }
        public static int NumberInAlphabet (string s, string[] EnglishTranslit)
        {
            int NumberInAlphabet = -1;
            for (int i=0; NumberInAlphabet==-1 && i<EnglishTranslit.Length; i++)
            {
                bool result = EnglishTranslit[i].Equals(s);
                if (result == true)
                    NumberInAlphabet = i;
            }
            return NumberInAlphabet;
        }
        public static StringBuilder TranslateToEnglish (string  input, string [] EnglishTranslit)
       {
            StringBuilder EngTrasklip = new StringBuilder("");
            input = input.ToUpper();
            for (int i = 0; i < input.Length; i++)
            {
                int ValueOf = (int)input[i];
                if (ValueOf != 1025 && ValueOf < 1040 && ValueOf > 1061)
                    EngTrasklip = EngTrasklip.Append(input[i]);
                else
                {
                    ValueOf=ValueOf-1040;
                    if (ValueOf < 0)
                        EngTrasklip = EngTrasklip.Append(EnglishTranslit[6]);
                    else if (ValueOf <= 6)
                        EngTrasklip = EngTrasklip.Append(EnglishTranslit[ValueOf]);
                    else
                        EngTrasklip = EngTrasklip.Append(EnglishTranslit[ValueOf + 1]);
                }
            }
                
            return EngTrasklip;
        }

       public static StringBuilder [] TranslateToRussian (string input, string[] EnglishTranslit, char [] rusLetters )
        {
            int counter = 1;
            input = input.ToUpper();
            StringBuilder[] RusTransklip = new StringBuilder[100];
            RusTransklip[0] = new StringBuilder("");
            for (int i =0; i< input.Length; i++)
            {
                int temp = (int)input[i];
                if (temp<65 && temp>90)
                {
                    for (int k = 0; k < counter; k++)
                    {
                        RusTransklip[k] = RusTransklip[k].Append(input[i]);
                    }
                    continue;
                }
                if (temp==72||temp==67)
                {
                    for (int k = 0; k < counter; k++)
                    { 
                        RusTransklip[k] =RusTransklip[k].Append(" ");
                    }
                }
                else if (temp>=65 && temp <=90)
                {
                    string s = input[i].ToString();
                    int numberInAlphabet = NumberInAlphabet(s, EnglishTranslit);
                    if (numberInAlphabet==10)
                    {
                        for (int k = 0; k < counter; k++)
                        {
                            string y = RusTransklip[k].ToString();
                            RusTransklip[counter + k] = new StringBuilder(y);
                        }

                        for (int j = 0; j < counter; j++)
                        {
                            string r = rusLetters[numberInAlphabet].ToString();
                            RusTransklip[j] = RusTransklip[j].Append(r);
                        }
                      
                        for (int z=0; z< counter; z++)
                        {
                            string v = rusLetters[28].ToString();
                            RusTransklip[counter + z] = RusTransklip[counter + z].Append(v);
                        }
                        counter*=2;
                    }
                    else if (numberInAlphabet == 5)
                    {
                        for (int k = 0; k < counter; k++)
                        {
                            string y = RusTransklip[k].ToString();
                            RusTransklip[counter + k] = new StringBuilder(y);
                        }

                        for (int j = 0; j < counter; j++)
                        {
                            string r = rusLetters[numberInAlphabet].ToString();
                            RusTransklip[j] = RusTransklip[j].Append(r);
                        }

                        for (int z = 0; z < counter; z++)
                        {
                            string v = rusLetters[30].ToString();
                            RusTransklip[counter + z] = RusTransklip[counter + z].Append(v);
                        }
                        counter *= 2;
                    }
                    else
                    {
                        for (int j = 0; j < counter; j++)
                        {
                            string r = rusLetters[numberInAlphabet].ToString();
                            RusTransklip[j] = RusTransklip[j].Append(r);
                        }
                    }

                }
                if (i-1>=0)
                {
                    int temp1 = (int)input[i - 1];
                    if (temp >= 65 && temp <= 90 && temp1 >= 65 && temp1 <= 90)
                    {
                        char[] doubled = { input[i-1], input[i] };
                        string doubledSymbol = new string(doubled);
                        int numberInAlphabet = NumberInAlphabet(doubledSymbol, EnglishTranslit);
                        if (numberInAlphabet>-1)
                        {
                            for (int k = 0; k < counter; k++)
                            {
                                string y = RusTransklip[k].ToString();
                                RusTransklip[counter + k] = new StringBuilder(y);
                            }

                            for (int z = 0; z < counter; z++)
                            {

                                string v = RusTransklip[z].ToString();
                                v=v.TrimEnd(v[v.Length - 1]);
                                v = v.TrimEnd(v[v.Length - 1]);
                                RusTransklip[counter + z] = new StringBuilder(v);
                                string m = rusLetters[numberInAlphabet].ToString();
                                RusTransklip[counter + z] = RusTransklip[counter + z].Append(m);
                            }
                            counter *= 2;
                        }
                    }
                        

                }
                if (i - 2 >= 0)
                {
                    int temp2 = (int)input[i - 2];
                    int temp1 = (int)input[i - 1];
                    if (temp >= 65 && temp <= 90 && temp1 >= 65 && temp1 <= 90 && temp2 >= 65 && temp2 <= 90)
                    {
                        char[] doubled = { input[i - 2], input[i - 1], input[i] };
                        string doubledSymbol = new string(doubled);
                        int numberInAlphabet = NumberInAlphabet(doubledSymbol, EnglishTranslit);
                        if (numberInAlphabet > -1)
                        {
                            for (int k = 0; k < counter; k++)
                            {
                                string y = RusTransklip[k].ToString();
                                RusTransklip[counter + k] = new StringBuilder(y);
                            }

                            for (int z = 0; z < counter; z++)
                            {

                                string v = RusTransklip[z].ToString();
                                v = v.TrimEnd(v[v.Length - 1]);
                                v = v.TrimEnd(v[v.Length - 1]);
                                RusTransklip[counter + z] = new StringBuilder(v);
                                string m = rusLetters[numberInAlphabet].ToString();
                                RusTransklip[counter + z] = RusTransklip[counter + z].Append(m);
                            }
                            counter *= 2;
                        }
                    }


                }


            }
            return RusTransklip;
        }
    }
}
