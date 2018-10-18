using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_DEV_1
{
    class Program
    {

        // Merge entered string array 
        static string ConcatenationInput(string[] args)
        {
            string mergedinput = "";

            for (int i = 0; i < args.Length; i++)
            {
                // Restore space between arrays
                mergedinput += (i == 0) ? args[i] : " " + args[i];
            }

            return mergedinput;
        }

        // Getting length of longest substring with unique symbols
        static int MaxSubstringLength(string input)
        {
            int maxLength = 0;
            int substringStart = 0; // Start index
            for (int i = 0; i < input.Length; i++)
            {
                int substringLength = 1;

                // Count symbols in tracked substring
                for (int j = i - 1; j >= substringStart; j--)
                {
                    substringLength++;

                    // Finding repeating symbols 
                    if (input[i] == input[j])
                    {
                        substringLength = i - substringStart; // Count length
                        substringStart = j + 1; // Change traced substring
                        break;
                    }
                }

                // Update max length if it needed
                if (substringLength > maxLength)
                {
                    maxLength = substringLength;
                }
            }
            return maxLength;
        }

        static void Main(string[] args)
        {
            // Getting input from CMD
            string inputtedString = ConcatenationInput(args);

            // Output to Console
            Console.WriteLine(args.Length > 0 ?
                "String: " + inputtedString :
                "String is empty");
            Console.WriteLine("String length: " + inputtedString.Length);
            Console.WriteLine("Substring with unique symbols max length: " +
                MaxSubstringLength(inputtedString));
        }
    }
}
