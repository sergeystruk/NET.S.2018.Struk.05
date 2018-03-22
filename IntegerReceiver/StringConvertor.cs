using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace IntegerReceiver
{
    /// <summary>
    /// Class for string extension methods
    /// </summary>
    public static class StringConvertor
    {
        /// <summary>
        /// Method converts the string to uint number from different converting notations(from 2 to 16)
        /// </summary>
        /// <param name="entranseString">
        /// String to convert
        /// </param>
        /// <param name="notation">
        /// Dimension of converting
        /// </param>
        /// <returns>
        /// Converted number
        /// </returns>
        public static uint ConvertToInt(this string entranseString, int notation)
        {
            if (notation < 2 || notation > 16)
            {
                throw new ArgumentOutOfRangeException(nameof(notation));
            }

            if (notation < 10)
            {
                for (int i = 0; i < entranseString.Length; i++)
                {
                    if (entranseString[i] < '0' || entranseString[i] >= notation.ToString().ToCharArray()[0])
                    {
                        throw new ArgumentException(nameof(entranseString));
                    }
                }

            }

            uint result = 0;
            for (int i = entranseString.Length - 1; i >= 0; i--)
            {
                result += (uint)(entranseString[i].CharToInt() * Math.Pow(notation, entranseString.Length - 1 - i));
            }

            return result;
        }
    }
}

