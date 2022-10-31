using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i;
            int[] tab = new int[] { 10, 20, 30, 40, 50 , 60};
            Console.Write(" N : ");
            n = int.Parse(Console.ReadLine());
            for (i = 5; i > 0; i--)
            {
                if (tab[i - 1] > n)
                {
                    tab[i] = tab[i - 1];
                    tab[i - 1] = n;
                }
            }
            for (i = 0; i < 6; i++)
            {
                Console.Write("\t" + tab[i]);
            }
            Console.ReadLine();
        }
    }
}
