using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatestCommonDivisor
{
    /// <summary>
    /// Class gives algorithms to find greatest common divisor
    /// </summary>
    public static class Algorithm
    {
        /// <summary>
        /// GCD for two integers
        /// </summary>
        /// <param name="a">
        /// First number
        /// </param>
        /// <param name="b">
        /// Second number
        /// </param>
        /// <returns>
        /// GCD of a and b
        /// </returns>
        public static int EuclidAlgorithm(int a, int b)
        {
            if (a <= 0 || b <= 0)
            {
                if (a <= 0)
                {
                    throw new ArgumentNullException(nameof(a));
                }
                else
                {
                    throw new ArgumentNullException(nameof(b));
                }
            }

            while (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }

            return a;
        }

        /// <summary>
        /// GCD for three integers
        /// </summary>
        /// <param name="a">
        /// First number
        /// </param>
        /// <param name="b">
        /// Second number
        /// </param>
        /// <param name="c">
        /// Third number
        /// </param>
        /// <returns>
        /// GCD of three numbers
        /// </returns>
        public static int EuclidAlgorithm(int a, int b, int c)
        {
            if (a <= 0 || b <= 0 || c<=0)
            {
                if (a <= 0)
                {
                    throw new ArgumentNullException(nameof(a));
                }
                if (b<=0)
                {
                    throw new ArgumentNullException(nameof(b));
                }
                else
                {
                    throw new ArgumentNullException(nameof(c));
                }
            }

            while (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }
            
            while (a!=c)
            {
                if (a > c)
                {
                    a -= c;
                }
                else
                {
                    c -= a;
                }
            }

            return a;
        }

        /// <summary>
        /// GCD for variable count of integers
        /// </summary>
        /// <param name="array">
        /// Array of integers
        /// </param>
        /// <returns>
        /// GCD for this array
        /// </returns>
        public static int EuclidAlgorithm(params int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] <= 0)
                {
                    throw new ArgumentNullException(nameof(array));
                }
            }

            int currentGCD = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                int currentElement = array[i];
                while (currentGCD!=currentElement)
                {
                    if (currentGCD > currentElement)
                    {
                        currentGCD -= currentElement;
                    }
                    else
                    {
                        currentElement -= currentGCD;
                    }
                }
            }

            return currentGCD;
        }
    }
}
