using System;

namespace Power2Method
{
    class Program
    {
        /// <summary>
        /// Program starts here.
        /// </summary>
        static void Main(string[] args)
        {
            PowersOf2Until5();
            Console.WriteLine();
            PowersOf2Until5();
            Console.WriteLine();
            PowersOf2UntilN(1, 2);
            Console.WriteLine();
            PowersOf2UntilN(2, 4);
        }

        /// <summary>
        /// Prints powers of 2 numbers from 1 to 5.
        /// </summary>
        private static void PowersOf2Until5()
        {
            PowersOf2UntilN(2);
        }

        /// <summary>
        /// Prints powers of 2 numbers from 1 to <see cref="n"/>.
        /// </summary>
        /// <param name="n">The start value to print to.</param>
        private static void PowersOf2UntilN(int n)
        {
            PowersOf2UntilN(1, n);
        }

        /// <summary>
        /// Prints powers of 2 numbers from <see cref="n1"/> to <see cref="n2"/>.
        /// </summary>
        /// <param name="n1">The start value to print to.</param>
        /// <param name="n2">The end value to print to.</param>
        private static void PowersOf2UntilN(int n1, int n2)
        {
            for (int i = 1 << n1; i <= (1 << n2); i <<= 1)
            {
                Console.WriteLine(i);
            }
        }
    }
}
