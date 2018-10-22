namespace Algorithms
{
    // Operations for strings
    public static class StringOperations
    {
        // Merge entered string array 
        public static string ConcatenationInput(string[] args)
        {
            string mergedinput = "";
            for (int i = 0; i < args.Length; i++)
            {
                // Paste " " symbol between array elements
                mergedinput += (i == 0) ? args[i] : " " + args[i];
            }

            return mergedinput;
        }

        // Length of longest substring with unique symbols
        public static int MaxSubstringLength(string input)
        {
            int maxLength = 0;
            int substringStart = 0; // Start index of tracked substring 
            // Basic symbol through all string 
            for (int i = 0; i < input.Length; i++)
            {
                int substringLength = 1; //including basic symbol
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

                // Update max length if necessery
                if (substringLength > maxLength)
                {
                    maxLength = substringLength;
                }
            }

            return maxLength;
        }
    }
}
