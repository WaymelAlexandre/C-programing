using System;
using System.Linq;
using System.Collections.Generic;

namespace test2
{
    public class Person
    {
        //attribu
        public string Fristname;
        public string Surname;
        public string Date;
        public int Height;
        public int ID;

        public Subject Sub;


        //My constructor
        public Person(string fristname, string surname, string Date, int height, int ID, string n, int Y)
        {
            this.Fristname = fristname;
            this.Surname = surname;
            this.Date = Date;
            this.Height = height;
            this.ID = ID;
            this.Sub = new Subject(n, Y);

        }

        //methode
        public string GetFullName()
        {
            return $"{this.Fristname} { this.Surname}";
        }
        public int GetHeightDifference(int Sheight)
        {
            if (this.Height > Sheight)
            {
                return this.Height - Sheight;
            }

            else
            {
                return Sheight - this.Height;
            }
        }
    }
}