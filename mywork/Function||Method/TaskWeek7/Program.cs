using System;
using System.Linq;


namespace funciton
{
    class Program
    {
        static void Main(string[] args)
        {
	///------------------------------------------------------------------------------------------------\\\
	///------------------------------------------------------------------------------------------------\\\
	///----------------- DELETE THE /* AND */JUST BEFORT ----------------------------------------------\\\
	///------------------------------ EX1 START -------------------------------------------------------\\\
	///-------------------------------- AND -----------------------------------------------------------\\\
	///------------------------------ EX1 END ---------------------------------------------------------\\\
	///------------------------------------------------------------------------------------------------\\\
	///------------------------------------------------------------------------------------------------\\\    

/*  //ex1 strart <<<=================================================                  
            

        //static void Main(string[] args)

            Console.WriteLine (Add(2, 3));
            Console.ReadKey();
        }
            public static int Add(int num1, int num2){
            
                return num1 + num2 ;
            }

*/  //ex1 end <<<===================================================

/*  //ex2 start<<<==================================================       
        
        //static void Main(string[] args)

            welcome("John");
        }   
            static void  welcome(string name){
                Console.WriteLine("Welcome frien " + name +" !");  
                Console.WriteLine("Have a nice day! "); 
                   
            }
*/  //ex2 end <<<===================================================

/*  //ex3 start <<<=================================================      
            
        //static void Main(string[] args)

            Console.WriteLine("The sum of two numbers is : " + welcome(15,16));
        }
            static int welcome(int num1,int num2){
              
            int maganum = num1 + num2;
            return maganum; 
            }

*/  //ex3 end <<<===================================================
            
/*  //ex4 start <<<=================================================      
        
        //static void Main(string[] args)

            Console.WriteLine(space("This is a test string. "));
            

        }    
            static string space(string li){
                
                
                return  li = (li + "containes " + (li.Split(' ').Length-1) + " spaces") ;
               
            }    
            
*/  //ex4 end <<<===================================================

/*  //ex5 start <<<=================================================

        //static void Main(string[] args)
        numbre(5, 7, 3, 2, 9);

        }
            static void numbre (int num1, int num2, int num3, int num4, int num5){

                int[] list = new int [5];
                list [0] = num1;
                list [1] = num2;
                list [2] = num3;
                list [3] = num4;
                list [4] = num5;
            
                System.Console.WriteLine("The sum of the elements of the array is " + list.Sum());
            }
            
*/ //ex5 end   <<<===================================================
  
/*  //ex6 start <<<===================================================

        //static void Main(string[] args)
              
            
            ChangeInt(10,20);
            

        }
            static void ChangeInt(int fristParameter, int secondParameter)        
            {	
                
                int temp = fristParameter;

                fristParameter = secondParameter;
                secondParameter = temp;
	                
	            Console.WriteLine("Now the 1st number is : " + fristParameter + ", and the 2nd number is :" + secondParameter);
                 
            }   
            
         
/ //ex6 end <<<===================================================

/*  //ex7 start <<<=================================================

        //static void Main(string[] args){

            num(3, 2);

        }
            static void num(int num1 ,int  num2) 
            {

                double power = Math.Pow(num1, num2); 
                int contre =Convert.ToInt32(power);
                Console.WriteLine("So, the number "+ num1 + " ^ (to the power) " + num2 + " = " + contre );
                
            }
        
*/ //ex7 end <<<===================================================

/*  //ex8 start <<<=================================================

        //static void Main(string[] args)


            fibon(5);
        }
             static void fibon(int num ){
                
                int num1= 1;
                int num2= 0;                
                int sum = 0;
            
                
            
                System.Console.WriteLine("The Fibonacci series of 5 numbers is : " );
                for (int i = 0; i < num; i++)
                
                {
                    System.Console.Write(sum);
                    sum=num1+num2;
                    num1=num2;
                    num2=sum;
                }
                
            
            }
            
        
        
        
         
*/  //ex8 end <<<===================================================

/*  //ex9 start <<<=================================================

        //static void Main(string[] args)

        
            Console.WriteLine(PrimCheck(31));
        }
        static string PrimCheck(int num1){
            int hola =0;
            for (int i = 1; i <= num1; i++)
            {
                if (num1 % i == 0)
                {
                  hola++;
                }                    
            }

            if (hola == 2)
            {
                return (num1 + " is a prime number"); 
            }
            else
            {
                return (num1 +  " is not a prime numbre "); 
            }                
        }
       
*/  //ex9 end <<<===================================================

                    
/*  //ex10 start <<<================================================


        total(1234);
        }
        static void total(int num){
            int sum=0;
            while(num!=0)
            {       
                sum += num % 10;
                num = num / 10;                      
            }

        System.Console.WriteLine(sum);
        }
*/  //ex10 end <<<===================================================     

    }
}
