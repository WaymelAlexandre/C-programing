using System;

namespace exercise3
{
    class Program
    {
        static void Main(string[] args)
        {       
           
            int num = 6, Space, Number;  
            Console.WriteLine("Print paramid");


            for (int i = 1; i <= num; i++) // Total number of layer for pramid  
            {  
            for (Space = 1; Space <= (num - i); Space++) // Loop For Space  
            Console.Write(" ");  
            for (Number = 1; Number <= i; Number++) //increase the value  
            Console.Write('*');  
            for (Number = (i - 1); Number >= 1; Number--) //decrease the value  
            Console.Write('*');  
            Console.WriteLine();  
            }
      
    
        }
    }
}
