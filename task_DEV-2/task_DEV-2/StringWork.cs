using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_DEV_2
{
    class StringWork
    {


        private string[] EnglishTranslit = {"A", "B", "V", "G","D","E", "YO", "ZH", "Z",
                "I", "Y", "K", "L", "M", "N", "O", "P", "R", "S", "T", "U", "F", "KH",
                "TS", "CH", "SH", "SCH", "", "Y", "", "E", "YU", "YA"  };

         private string[] EnglishToRussianENG = { "SCH", "YO", "ZH", "KH", "TS", "CH", "SH", "YU", "YA", "Y",
            "E", "A", "B", "V", "G", "D", "Z", "I", "K", "L", "M", "N", "O", "P" , "R", "S", "T", "U", "F", "J", "C", "H", "Q", "X"};

        string[] EnglishToRussianRUS = {  "(Щ/СЧ)", "Ё", "Ж", "Х", "Ц", "Ч", "Ш", "Ю", "Я", "(Й/Ы)",
            "(Е/Э)", "А", "Б", "В", "Г", "Д", "З", "И", "К", "Л", "М", "Н", "О", "П" , "Р", "С", "Т", "У", "Ф", "ДЖ", "СИ", "Х", "КУ", "ИКС" };

        public bool IsRussian(string s)
        {
            s = s.ToUpper();
            for (int i = 0; i < s.Length; i++)
            {
                int ValueOf = (int)s[i];
                if ((ValueOf == 1025) ||( ValueOf >= 1040 && ValueOf <= 1071))
                    return true;
            }
            return false;
        }

        public bool IsEnglish(string s)
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
       
        public  StringBuilder TranslateToEnglish (string  input)
       {
            StringBuilder EngTrasklip = new StringBuilder("");
            for (int i = 0; i < input.Length; i++)
            {
                int ValueOf = (int)input[i];
                if (ValueOf != 1025 && ValueOf < 1040 && ValueOf > 1071)
                    EngTrasklip = EngTrasklip.Append(input[i]);
                else
                {
                    ValueOf=ValueOf-1040;
                    if (ValueOf < 0)
                        EngTrasklip = EngTrasklip.Append(EnglishTranslit[6]);
                    else if (ValueOf < 6)
                        EngTrasklip = EngTrasklip.Append(EnglishTranslit[ValueOf]);
                    else
                        EngTrasklip = EngTrasklip.Append(EnglishTranslit[ValueOf + 1]);
                }
            }
                
            return EngTrasklip;
        }

       public StringBuilder TranslateToRussian (string input)
        {
            for (int i=0; i< EnglishToRussianENG.Length; i++)
            {
                while (input.Contains(EnglishToRussianENG[i]))
                    input = input.Replace(EnglishToRussianENG[i],EnglishToRussianRUS[i]);
            }
            StringBuilder TranslateToRussian = new StringBuilder(input);
            return TranslateToRussian;
            
        }
        public StringBuilder Translate (string input)
        {
            input = input.ToUpper();
            bool IsRussian = this.IsRussian(input);
            bool IsEnglish = this.IsEnglish(input);
            if (IsEnglish == true && IsRussian == true)
            {
                throw new Exception ("You used both of language");
            }
            else if (IsEnglish == false && IsRussian == false)
            {
               throw new Exception ("You don't use any of the languages ");
            }
            else if (IsEnglish == true)
            {
                StringBuilder TranslateToRus = this.TranslateToRussian(input);
                return TranslateToRus;
                
            }
            else
            {
                StringBuilder TranslateToEng = this.TranslateToEnglish(input);
                return TranslateToEng;
            }

        }
    }
}
