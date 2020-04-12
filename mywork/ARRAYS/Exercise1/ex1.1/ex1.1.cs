using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("how many are you ?? ");
            
            string inputString = Console.ReadLine();
            int input = int.Parse(inputString);

            string [] noms = new string[input];

            for (int i = 0; i < noms.Length; i++)
            {
                Console.WriteLine(" Names pls ");
                
                noms[i] = Console.ReadLine();

                
            }
            for (int i = 0; i < noms.Length; i++)
            {
                Console.WriteLine("bonjours " + noms[i] + " !!");
            }

            
            
    

            

        }
    }
}
