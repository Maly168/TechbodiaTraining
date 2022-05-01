using System.Collections.Generic;

namespace TechbodiaTraining.Test
{
    public class RomanDecoderService
    {
        public static string DecodeRomanToInteger(string romanNumbers)
        {
            romanNumbers = romanNumbers.ToUpper();
            Dictionary<char, int> romanValues = new()
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };

            int number = 0;
            for (int romanNumer = 0; romanNumer < romanNumbers.Length; romanNumer++)
            {
                if (!romanValues.TryGetValue(romanNumbers[romanNumer], out int output))
                {
                    return "Invalid roman number";
                }
                if (romanNumer + 1 < romanNumbers.Length
                    && romanValues[romanNumbers[romanNumer]] < romanValues[romanNumbers[romanNumer + 1]])
                {
                    number -= romanValues[romanNumbers[romanNumer]];
                }
                else
                {
                    number += romanValues[romanNumbers[romanNumer]];
                }
            }
            return number.ToString();
        }
    }
}