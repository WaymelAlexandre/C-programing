using System;

namespace myworks
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            Console.WriteLine("What is your name. ");
            string Name = Console.ReadLine();
            

            Console.WriteLine("How many time you want a print your name? ");

            string YourNunb =Console.ReadLine();
            
            int input = int.Parse(YourNunb);
 
            while (i < input)
            {
                Console.WriteLine(Name);

                i ++;
            }
        }
    }
}
