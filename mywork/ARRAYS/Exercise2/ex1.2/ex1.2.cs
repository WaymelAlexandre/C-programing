using System;
using System.Linq;

namespace ex1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that reads in 5 numbers. It then asks the user for another number and outputs whether the number has already been entered.
            
            5 nums +(1 /=to the 5nums display text (if else))

            */
           
            // remplire the array
            Console.WriteLine("pls entre 5 nums");
            
            int[] mynums = new int[5];
        
            for (int i=0; i<mynums.Length; i++)
            {
            mynums[i] = int.Parse(Console.ReadLine());
            }


            //numbre a check
            Console.WriteLine("quel est le numbre a check");

            string blabla = Console.ReadLine();
            int check = int.Parse(blabla);

            if(mynums.Contains(check))
            {
                int total = mynums.Count(check => check == 1);
                Console.Write("the numbre "+ check + " et deja utiliser "+ total + " fois dans la base de donner desolee ");
         
            }
            else
            {
                Console.Write("you can use this num ");
             
            }
            
        }
    }                
}            