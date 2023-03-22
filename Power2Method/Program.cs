using System;

namespace Power2Method
{
    class Program
    {
        /// <summary>
        /// Program starts here. Calls the methods to print powers of 2.
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
        /// Calls the method PowersOf2UntilN() to print powers of 2 until arg = 2.
        /// </summary>
        private static void PowersOf2Until5()
        {
            PowersOf2UntilN(2);
        }

        /// <summary>
        /// Prints numbers from 1 to n.
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
