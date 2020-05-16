namespace test2
{
    public class Subject
    {
        public string Name;
        public int YearDelivery;

        public Subject(string n, int Y)
        {
            this.Name = n;
            this.YearDelivery = Y;
        }
        public string GetSubject()  
        {
            return $"{this.Name} {" year of Delivery "} { this.YearDelivery}";
        }
       
        

    }
}