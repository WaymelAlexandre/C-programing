using System;

namespace exercise1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name. ");
            string Name = Console.ReadLine();

            for (int i = 0; i < 10; i++)
            {
                

                for (int N = 0; N < 10; N++)
                {
                    Console.Write(Name +" ");
                }

            Console.WriteLine(Name + " ");
            }
                

        }
    }
}
