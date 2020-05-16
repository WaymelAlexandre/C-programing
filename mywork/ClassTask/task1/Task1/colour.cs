namespace test
{
    public class Colour
    {
        public int red;
        public int green;
        public int blue;


        public Colour(int Red, int Green, int Blue)
        {
            this.red = Red;
            this.green = Green;
            this.blue = Blue;
        }

        public string PrintColour() {
            return $"{this.red} {this.green} {this.blue}";
        }
        

    }
}