using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_DEV_3
{
    public class Converter
    {
       static  private string signs = "0123456789ABCDEFGHIJ"; // massive of signs in systems

        private bool IsCorrect(string[] input) //check input for Correct/
        {
            int maxOfBase = 20;
            int minOfBase = 2;
            if (input.Length !=2)
                throw new Exception("incorrect input");
            string decimalField = input[0];
            string systemBaseField = input[1];
            bool parseDecimal = int.TryParse(decimalField, out int DecimalPart);
            bool parseBase = int.TryParse(systemBaseField, out int Basepart);
            if (parseBase == false || parseDecimal == false)
                throw new Exception("incorrect input");
            if (Basepart > maxOfBase || Basepart<minOfBase)
                throw new Exception("Base is out of range");
            return true;
            
        }
        public string Convertation(string[] input) //convertation process
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
            return result.ToString();
        }

    }
}
