namespace test
{
    public class Decoration
    {
        public Colour col;

        public string Text;

        public Decoration(Colour col, string text){

            this.col = col;
            this.Text = text;

        }
       

        public string PrintIcing() {
            return this.col + " " +  this.Text ;
        }
        
    }
}