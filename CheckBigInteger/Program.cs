using System;
using System.Numerics;

namespace CheckBigInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            var save = false;
            BigInteger big = 2;

            while (!save)
            {
                try
                {
                    big = big * big; // тоже самое

                    Console.WriteLine("\n\n\n\n");
                    Console.WriteLine(big);
                }
                catch (OutOfMemoryException)
                {
                    Console.WriteLine("ERROR MEMORY");
                    save = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                    save = true;
                }
            }

            Console.ReadLine();
        }
    }
}
