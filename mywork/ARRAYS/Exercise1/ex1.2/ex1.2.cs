using System;
using System.Linq;


namespace ex1._2

{
    class Program
    {
        static void Main(string[] args)
        {
            
            int [] num = {34, 5, 67, 1, 99, 34, 44, 78, 34, 0};
            int n1 = num.Length-1;
            
            
            

            for (int i = 0; i < num.Length; i++) 
            {
                
               Console.Write(num[i]);
               if (i<n1)
               {
                   Console.Write(" +  ");
               }

            
            }           
            Console.Write(" = "); 
            Console.WriteLine(num.Sum());


            
                
        }
    }
}
