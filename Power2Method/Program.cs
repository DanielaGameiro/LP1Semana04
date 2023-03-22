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
            PowersOf2UntilN(1);
            Console.WriteLine();
            PowersOf2UntilN(4);
        }

        /// <summary>
        /// Prints numbers from 1 to 5.
        /// </summary>
        private static void PowersOf2Until5()
        {
            PowersOf2UntilN(2);
        }

        /// <summary>
        /// Prints numbers from 1 to <see cref="n"/>.
        /// </summary>
        /// <param name="n">The maximum value to print to.</param>
        private static void PowersOf2UntilN(int n)
        {
            for (int i = 1; i <= (1 << n); i <<= 1)
            {
                Console.WriteLine(i);
            }
        }
    }
}
