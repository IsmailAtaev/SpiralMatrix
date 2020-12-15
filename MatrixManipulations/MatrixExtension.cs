using System;

namespace MatrixManipulations
{
    /// <summary>
    /// Matrix manipulation.
    /// </summary>
    public static class MatrixExtension
    {
        /// <summary>
        /// Method fills the matrix with natural numbers, starting from 1 in the top-left corner,
        /// increasing in an inward, clockwise spiral order.
        /// </summary>
        /// <param name="size">Matrix order.</param>
        /// <returns>Filled matrix.</returns>
        /// <exception cref="ArgumentException">Throw ArgumentException, if matrix order less or equal zero.</exception>
        /// <example> size = 3
        ///     1 2 3
        ///     8 9 4
        ///     7 6 5.
        /// </example>
        /// <example> size = 4
        ///     1  2  3  4
        ///     12 13 14 5
        ///     11 16 15 6
        ///     10 9  8  7.
        /// </example>
        public static int[,] GetMatrix(int size)
        {
            if (size <= 0)
            {
                throw new ArgumentException($"Parameter {nameof(size)} must be greater than 0.");
            }

            int[,] array = new int[size, size];
            int k = 0, l = 0;
            int m = size;
            int n = size;
            int number = 0;

            while (k < m && l < n)
            {
                for (int i = l; i < n; ++i)
                {
                    number++;
                    array[k, i] = number;
                }

                k++;
                for (int i = k; i < m; ++i)
                {
                    number++;
                    array[i, n - 1] = number;
                }

                n--;
                if (k < m)
                {
                    for (int i = n - 1; i >= l; --i)
                    {
                        number++;
                        array[m - 1, i] = number;
                    }

                    m--;
                }

                if (l < n)
                {
                    for (int i = m - 1; i >= k; --i)
                    {
                        number++;
                        array[i, l] = number;
                    }

                    l++;
                }
            }

            return array;
        }
    }
}