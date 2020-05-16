using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {


            Colour C3 = new Colour(255, 255, 255);
            Colour C4 = new Colour(255, 0, 0);
            Decoration I = new Decoration(C4, "Flower");
            System.Console.WriteLine(C4.PrintColour());



            Cookie C1 = new Cookie("round", 30000000, C3, I);

            System.Console.WriteLine(C1.PrintCookie()+ " The Rgb colour of the cookie is  " + C3.PrintColour() + ", colors of decoration is  " + I.PrintIcing());
        }
    }



}
