using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_DEV_3
{
    class ConvertToSystems
    {
        private string[] signs = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9",
            "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" }; // massive of signs in systems

        bool IsCorrect(string[] input) //check input for Correct
        {
            int maxOfBase = 20;
            int inputLength = input.Length;
            if (inputLength !=2)
                throw new Exception("incorrect input");
            string decimalField = input[0];
            string systemBaseField = input[1];
            bool parseDecimal = int.TryParse(decimalField, out int DecimalPart);
            bool parseBase = int.TryParse(systemBaseField, out int Basepart);
            if (parseBase == false || parseDecimal == false)
                throw new Exception("incorrect input");
            if (Basepart > maxOfBase)
                throw new Exception("Base is too much");
            return true;
            
        }
        public StringBuilder Convertation(string[] input) //convertation process
        {
            StringBuilder result = new StringBuilder("");
            bool IsCorrected = IsCorrect(input);
            int DecimalPart = int.Parse(input[0]);
            int BasePart = int.Parse(input[1]);
            int Remainder = 0;
            int quotient = DecimalPart;
            do
            {
                Remainder = quotient % BasePart;
                result = result.Append(signs[Remainder]);
                quotient /= BasePart;
            }
            while (quotient > 0);
            int resultLength = result.Length;
            for (int i = 0; i < resultLength / 2; i++)
            {
                char temp = result[i];
                result[i] = result[resultLength - i - 1];
                result[resultLength - i - 1] = temp;
            }
            return result;
        }

    }
}
