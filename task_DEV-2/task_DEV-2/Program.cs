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
            string[] EnglishTranslit = {"A", "B", "V", "G","D","E", "YO", "ZH", "Z",
                "I", "Y", "K", "L", "M", "N", "O", "P", "R", "S", "T", "U", "F", "KH",
                "TS", "CH", "SH", "SCH", "", "Y", "", "E", "YU", "YA"  };
            char[] rusLetters = {'А','Б','В','Г','Д','Е','Ё','Ж','З','И','Й',
            'К','Л','М','Н','О','П','Р','С','Т','У','Ф','Х','Ц','Ч','Ш','Щ',
            'Ъ','Ы','Ь','Э','Ю','Я'};
            bool IsRussian = StringWork.IsRussian(args[0]);
            bool IsEnglish = StringWork.IsEnglish(args[0]);
            if (IsEnglish==true && IsRussian==true)
            {
                Console.WriteLine("You used both of language");
            }
            else if (IsEnglish == false && IsRussian == false)
            {
                Console.WriteLine("you don't use any of the languages ");
            }
            else if (IsEnglish == true)
            {
                StringBuilder[] Translate= StringWork.TranslateToRussian(args[0], EnglishTranslit, rusLetters);
                for (int i=0; i<Translate.Length; i++)
                {
                    if (Translate[i] != null)
                        Console.WriteLine($"{Translate[i]}");
                }
            }
            else
            {
                StringBuilder TranslateToEng= StringWork.TranslateToEnglish(args[0], EnglishTranslit);
                Console.WriteLine($"{TranslateToEng}");
            }

           
        }


    }
}
