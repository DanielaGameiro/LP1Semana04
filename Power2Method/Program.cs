using System;

namespace Power2Method
{
    class Program
    {
        static void Main(string[] args)
        {
            PowersOf2Until5();
            PowersOf2Until5();
        }

        private static void PowersOf2Until5()
        {
            // precisa do 'i <<= 1' para evitar um infinite loop
            for (int i = 1; i <= (1 << 5); i <<= 1)  
            {
                Console.WriteLine(i);
            }
        }
    }
}
