using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExtension
{
    public static class StringExtension
    {
        public static string ToBinaryDouble(this double value)
        {
            long integerPart = Math.Abs((long)(value - value % 1));
            StringBuilder integerPartStringBuilder = integerPart.ToBinary();
            StringBuilder fractionStringBuilder = new StringBuilder();

            double fraction = Math.Abs(value % 1);
            for (int i = 0; i < 52; i++)
            {
                fractionStringBuilder.Append((int)(fraction * 2) / 1);
                fraction = (fraction * 2) % 1;
            }

            long exponent;

            if (integerPartStringBuilder.IndexOf('1') != -1)
            {
                exponent = 1024 + integerPartStringBuilder.Length - 1 - integerPartStringBuilder.IndexOf('1') - 1;
            }
            else
            {
                exponent = 1024 - (fractionStringBuilder.IndexOf('1') + 1) - 1;
            }

            StringBuilder mantisse = new StringBuilder();
            if (integerPartStringBuilder.IndexOf('1') != -1)
            {
                for (int i = integerPartStringBuilder.IndexOf('1'); i < integerPartStringBuilder.Length; i++)
                {
                    if (i == integerPartStringBuilder.IndexOf('1'))
                    {
                        continue;
                    }
                    mantisse.Append(integerPartStringBuilder[i]);
                }

                for (int i = 0; i <= 52 - integerPartStringBuilder.Length - integerPartStringBuilder.IndexOf('1'); i++)
                {
                    mantisse.Append(fractionStringBuilder[i]);
                }
            }

            else
            {
                for (int i = fractionStringBuilder.IndexOf('1'); i < fractionStringBuilder.Length; i++)
                {
                    if (i == fractionStringBuilder.IndexOf('1'))
                    {
                        continue;
                    }
                    mantisse.Append(fractionStringBuilder[i]);
                }
            }

            StringBuilder result = new StringBuilder();
            result.Append(value > 0 ? 0 : 1);
            result.Append(exponent.ToBinary());
            result.Append(mantisse);

            return result.ToString();
        }

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
        public static StringBuilder Reverse(this StringBuilder sb)
        {
            StringBuilder newStringBuilder = new StringBuilder(sb.Length);
            for (int i = sb.Length - 1; i >= 0; i--)
            {
                newStringBuilder.Append(sb[i]);
            }

            return newStringBuilder;
        }
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
