using System;
using System.Linq;
using System.Collections.Generic;



namespace test2
{
    class Program
    {
        static void Main(string[] args)
        {
            // random generator            
            Random r = new Random();
            //list of rando Num
            List<int> list = new List<int>();

            for (int i = 0; i < 3; i++){
                int genRand = r.Next(1000, 9999);
                list.Add(genRand);
            }


            Person P1 = new Person("Alexandre", "Waymel", "20/01/87", 180, list[0], "Javascript", 2020);
            Person P2 = new Person("Miranda", "Borman", "5/05/81", 120, list[1], "C#", 2021);
            Person P3 = new Person("Esmee", "Wayborne", "20/01/87", 45, list[2], "Python", 2022);

            System.Console.WriteLine(P1.GetFullName() + " " + P1.GetHeightDifference(P2.Height) +                   //br
            "CM Difference with  " + P2.GetFullName() + "  ID Number: " + P1.ID + " Subject: " + P3.Sub.GetSubject());

            //Just for jump ligne            
            System.Console.WriteLine(" ");

            System.Console.WriteLine(P2.GetFullName() + " " + P2.GetHeightDifference(P3.Height) +                    //br
            "CM Difference with  " + P3.GetFullName() + "  ID Number:  " + P2.ID + " Subject: " + P1.Sub.GetSubject());

            //Just for jump ligne
            System.Console.WriteLine(" ");

            System.Console.WriteLine(P3.GetFullName() + " " + P3.GetHeightDifference(P1.Height) +                     //br
             "CM Difference with  " + P1.GetFullName() + "  ID Number:  " + P3.ID + " Subject: " + P2.Sub.GetSubject());







        }

    }


}
