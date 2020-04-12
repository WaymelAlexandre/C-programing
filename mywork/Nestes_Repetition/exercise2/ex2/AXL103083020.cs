using System;

namespace ex._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("how whyle you want to be ?? ");
            
            string inputString = Console.ReadLine();
            int input = int.Parse(inputString);

            for (int rang = input; rang > 0; rang--)
            {
                
                
                for (int col = 1; col < rang; col++)
                {
                    Console.Write("X");            
                }
              
            Console.WriteLine("X");
              
            }
        }
    }
}
