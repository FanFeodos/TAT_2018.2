using System;
using Algorithms;

namespace task_DEV_1
{
    class Program
    {
        // Entry points
        static void Main(string[] args)
        {
            // Getting input
            string inputtedString = StringOperations.ConcatenationInput(args);
            // Output to console
            Console.WriteLine(args.Length > 0 ? "String: " + inputtedString : "String is empty");
            Console.WriteLine("String length: " + inputtedString.Length);
            Console.WriteLine("Substring with unique symbols max length: " + StringOperations.MaxSubstringLength(inputtedString));
        }        
    }
}
