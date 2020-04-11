using System;

namespace ex._1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int rang = 1; rang <= 5; rang++)
            {
                

                for (int col = 5; col > rang; col--)
                {
                    Console.Write("X");
                }

            Console.WriteLine("X");
            }
             
        }
    }
}
