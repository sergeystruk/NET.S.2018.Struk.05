using System;

namespace IntegerReceiver
{
    /// <summary>
    /// Class gives extension methods for char type
    /// </summary>
    public static class CharExtension
    {
        /// <summary>
        /// Converts char to integer
        /// </summary>
        /// <param name="value">
        /// Value is the converting character, could lay between '0' and '9', 'A' and 'B'
        /// </param>
        /// <returns>
        /// Integer, converted from this character
        /// </returns>
        public static int CharToInt(this char value)
        {
            if ((int)value >= 'A' && (int)value <= 'F')
            {
                return 10 + (int)(value - 'A');
            }

            if ((int)(value) >= '0' && (int)(value) <= '9')
            {
                return (int)(value - '0');
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(value));
            }
        }
    }
}