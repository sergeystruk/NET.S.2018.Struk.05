using System.Text;

namespace StringExtension
{
    /// <summary>
    /// Gives extension methods for StringBuilder type
    /// </summary>
    public static class StringBuilderExtensions
    {
        /// <summary>
        /// Reverses the StringBuilder and returns it
        /// </summary>
        /// <param name="sb">
        /// StringBuilder to reverse
        /// </param>
        /// <returns>
        /// Reversed StringBuilder
        /// </returns>
        public static StringBuilder Reverse(this StringBuilder sb)
        {
            StringBuilder newStringBuilder = new StringBuilder(sb.Length);
            for (int i = sb.Length - 1; i >= 0; i--)
            {
                newStringBuilder.Append(sb[i]);
            }

            return newStringBuilder;
        }

        /// <summary>
        /// Gives the index of char element in StringBuilder
        /// </summary>
        /// <param name="sb">
        /// Initial StringBuilder
        /// </param>
        /// <param name="elem">
        /// Char element to find
        /// </param>
        /// <returns>
        /// Index of this element (or -1 if element wasn't found)
        /// </returns>
        public static int IndexOf(this StringBuilder sb, char elem)
        {
            for (int i = 0; i < sb.Length; i++)
            {
                if (sb[i] == elem)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}