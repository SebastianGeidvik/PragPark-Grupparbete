using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionClasses
{
    public static class StringExtensions
    {
        /// <summary>
        /// Limits the number of consecutive whitespaces to one by removing the rest as well as doing a normal .Trim().
        /// </summary>
        /// <param name="stringToTrim"></param>
        /// <returns></returns>
        public static string SuperTrim(this string stringToTrim)
        {
            string superTrimmedString = stringToTrim.Trim();
            for (int i = 0; i < superTrimmedString.Length - 1; i++)
            {
                if (superTrimmedString[i] == ' ')
                {
                    if (superTrimmedString[i + 1] == ' ')
                    {
                        superTrimmedString = superTrimmedString.Remove(i, 1);
                        i--;
                    }
                }
            }
            return superTrimmedString;
        }
    }
}
