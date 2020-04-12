using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {

        Console.WriteLine("Size of the triangle");

        string inputString = Console.ReadLine();
            int input = int.Parse(inputString);

            for (int col = 0; col<input; col++)
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
