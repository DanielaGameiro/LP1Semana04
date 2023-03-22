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
            PowersOf2UntilN(4, 8);
            Console.WriteLine();
            PowersOf2UntilN(2, 4);
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
            PowersOf2UntilN(1, n);
        }

        /// <summary>
        /// Prints numbers from <see cref="n1"/> to <see cref="n2"/>.
        /// </summary>
        /// <param name="n1">The minimum value to print to.</param>
        /// <param name="n2">The maximum value to print to.</param>
        private static void PowersOf2UntilN(int n1, int n2)
        {
            for (int i = n1; i <= n2; i++)
            {
                Console.WriteLine(i);
            }
        } 
    }
}
