using System;

namespace ex._3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int col = 0; col<5; col++)
            {
                

                for (int rang = 0; rang < col; rang++)
                {
                  Console.Write("X");  
                }
            Console.WriteLine("X");   
            }
            
        }
    }
}
