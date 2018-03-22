using System.Text;

namespace StringExtension
{
    /// <summary>
    /// Gives extension methods for long type
    /// </summary>
    public static class LongExtension
    {
        /// <summary>
        /// Converts long value to bunary format
        /// </summary>
        /// <param name="value">
        /// Value which is need to be converted
        /// </param>
        /// <returns>
        /// StringBuilder with binary performance of value
        /// </returns>
        public static StringBuilder ToBinary(this long value)
        {
            StringBuilder sb = new StringBuilder();
            long b;
            while (value != 0)
            {
                b = value % 2;
                sb.Append(b);
                value /= 2;
            }

            return sb.Reverse();
        }
    }
}