using System;

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
            if (a < 0)
            {
                a = Math.Abs(a);
            }

            if (b < 0)
            {
                b = Math.Abs(b);
            }

            if (a == b)
            {
                if (a == 0)
                {
                    return 0;
                }

                return a;
            }

            if (a == 0)
            {
                return b;
            }

            if (b == 0)
            {
                return a;
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
            if (a < 0)
            {
                a = Math.Abs(a);
            }

            if (b < 0)
            {
                b = Math.Abs(b);
            }

            if (c < 0)
            {
                c = Math.Abs(c);
            }

            if (a == b && b == c)
            {
                if (a == 0)
                {
                    return 0;
                }

                return a;
            }

            if (a == 0)
            {
                return EuclidAlgorithm(b, c);
            }

            if (b == 0)
            {
                return EuclidAlgorithm(a, c);
            }

            if (c == 0)
            {
                return EuclidAlgorithm(a, b);
            }

            int currentGCD = EuclidAlgorithm(a, b);
            return EuclidAlgorithm(currentGCD, c);
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
                if (array[i] < 0)
                {
                    array[i] = Math.Abs(array[i]);
                }
            }

            int currentGCD = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                currentGCD = EuclidAlgorithm(currentGCD, array[i]);
                //int currentElement = array[i];
                //while (currentGCD!=currentElement)
                //{
                //    if (currentGCD > currentElement)
                //    {
                //        currentGCD -= currentElement;
                //    }
                //    else
                //    {
                //        currentElement -= currentGCD;
                //    }
                //}
            }

            return currentGCD;
        }

        /// <summary>
        /// Stein's Algorithm for finding GCD of two integers
        /// </summary>
        /// <param name="a">
        /// First number
        /// </param>
        /// <param name="b">
        /// Second number
        /// </param>
        /// <returns>
        /// GCD of two numbers
        /// </returns>
        public static int SteinAlgorithm(int a, int b)
        {
            if (a < 0)
            {
                a = Math.Abs(a);
            }

            if (b < 0)
            {
                b = Math.Abs(b);
            }

            if (a == b)
            {
                if (a == 0)
                {
                    return 0;
                }

                return a;
            }

            if (a == 0)
            {
                return b;
            }

            if(b == 0)
            {
                return a;
            }

            if ((~a & 1) != 0)
            {
                if ((b & 1) !=0)
                {
                    return SteinAlgorithm(a >> 1, b);
                }
                else
                {
                    return SteinAlgorithm(a >> 1, b >> 1) << 1;
                }
            }

            if ((~b & 1) != 0)
            {
                return SteinAlgorithm(a, b >> 1);
            }

            if (a > b)
            {
                return SteinAlgorithm((a - b) >> 1, b);
            }

            return SteinAlgorithm((b - a) >> 1, a);
        }

        /// <summary>
        /// Stein's Algorithm for finding GCD of three integers
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
        public static int SteinAlgorithm(int a, int b, int c)
        {
            if (a < 0)
            {
                a = Math.Abs(a);
            }

            if (b < 0)
            {
                b = Math.Abs(b);
            }
            if (c < 0)
            {
                c = Math.Abs(a);
            }

            if (a == b && b == c)
            {
                if (a == 0)
                {
                    return 0;
                }

                return a;
            }

            if (a == 0)
            {
                return SteinAlgorithm(b, c);
            }

            if (b == 0)
            {
                return SteinAlgorithm(a, c);
            }

            if (c == 0)
            {
                return SteinAlgorithm(a, b);
            }

            int currentGCD = SteinAlgorithm(a, b);
            return SteinAlgorithm(currentGCD, c);
           
        }

        /// <summary>
        /// Stein's Algorithm for finding GCD of array of integers
        /// </summary>
        /// <param name="array">
        /// Array of numbers
        /// </param>
        /// <returns>
        /// GCD of array numbers
        /// </returns>
        public static int SteinAlgorithm(params int[] array)
        {
            int[] newArray = array;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    newArray[i] = Math.Abs(array[i]);
                }
            }

            int countEqual = 0;
            for (int i = 1; i < newArray.Length; i++)
            {
                if (newArray[0] == newArray[i])
                {
                    countEqual++;
                }
            }

            if (countEqual==newArray.Length-1)
            {
                return newArray[0];
            }

            int currentGCD = SteinAlgorithm(newArray[0], newArray[1]);

            for (int i = 2; i < newArray.Length; i++)
            {
                 currentGCD = SteinAlgorithm(currentGCD, newArray[i]);
            }

            return currentGCD;
        }
    }
}