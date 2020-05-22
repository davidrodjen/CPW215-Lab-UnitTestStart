using System;
using System.Text.RegularExpressions;

namespace BusinessLogic
{
    public static class Validator
    {
        /// <summary>
        /// Determines if string is a valid Social Security number
        /// </summary>
        /// <param name="ssn"></param>
        /// <returns></returns>
        public static bool IsSsn(string ssn)
        {
            ///throw new NotImplementedException();
            if (ssn == string.Empty)
                return false;
            Regex pattern = new Regex(@"^([1 - 9])(?!\1{ 2 } -\1{ 2}
            -\1{ 4})[1-9]{2}-[1-9]{2}-[1-9]{4}");
            return pattern.IsMatch(ssn);
        }

        /// <summary>
        /// Checks if a number is within range
        /// </summary>
        /// <param name="numToTest">The number to test</param>
        /// <param name="minValue">The minimum INCLUSIVE range</param>
        /// <param name="maxValue">The maximum INCLUSIVE range</param>
        /// <returns></returns>
        public static bool IsWithinRange(int numToTest, int minValue, int maxValue)
        {
            if(numToTest <= maxValue || numToTest >= minValue)
            {
                return true;
            }
            else
            {
                return false;
            }
            //throw new NotImplementedException();
        }
    }
}
