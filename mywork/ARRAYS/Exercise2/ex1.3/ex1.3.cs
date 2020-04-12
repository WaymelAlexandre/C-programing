using System;
using System.Collections.Generic;
using System.Collections;



namespace ex1._3
{
    class Program
    {
        static void Main(string[] args)
        {
          
            List<string> Names = new List<string>();    
            

            while (true)
            {
            Names.Add(Console.ReadLine());

                if (Names.Contains("stop"))
                {
                    Names.Remove("stop"); 
                    Names.Reverse();

                    foreach (string item in Names)
                    {
                        Console.WriteLine(item);                    
                    }
                break;
                }
                
            }
            
            
        }
    }
}
