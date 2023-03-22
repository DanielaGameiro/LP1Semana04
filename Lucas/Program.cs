using System;

namespace Lucas
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            int n;
            int l;

            Console.Write("What Lucas number do you want? ");

            s = Console.ReadLine();
            n = int.Parse(s);
            l = Lucas(n);

            Console.WriteLine($"The {n}th Lucas number is {l}.");
        }

        private static int Lucas(int n)
        {
            int lucas;

            if (n == 1)
            {
                lucas = 2;
            }

            else if (n == 2)
            {
                lucas = 1;
            }
            
            else 
            {
                lucas = Lucas(n - 1) + Lucas(n - 2);
            }

            return lucas;
        }
    }
}
