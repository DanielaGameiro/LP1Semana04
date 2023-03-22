using System;

namespace Power2Method
{
    class Program
    {
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

        private static void PowersOf2Until5()
        {
            PowersOf2UntilN(2);
        }

        private static void PowersOf2UntilN(int n)
        {
            for (int i = 1; i <= (1 << n); i <<= 1)
            {
                Console.WriteLine(i);
            }
        }
    }
}
