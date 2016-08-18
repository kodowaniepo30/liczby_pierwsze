using System;

namespace LiczbyPierwsze
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            bool itIs = false;
            for (int j = 1; j <= n; j++)
            {           
                itIs = true;
                for (int i = 2; i * i <= j; i++)
                {
                    if (j % i == 0)
                        itIs = false;
                }
                Console.Write(j);
                if (j == 1)
                    itIs = false;
                if (itIs)
                    Console.WriteLine(" TAK");
                else
                    Console.WriteLine(" NIE");                 
            }
            Console.ReadLine();
        }
    }
}