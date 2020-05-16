namespace test
{
    public class Cookie
    {

        public string shape;
        public int weight;
        public Colour col;
        public Decoration Icing;
        
        public Cookie()
        {
            this.shape = "";
            this.weight = 0;
        }

        public Cookie(string S, int W, Colour C, Decoration I)
        {
            this.shape = S;
            this.weight = W;
            this.col = C;
            this.Icing= I;
        }
        
        
        public string PrintCookie() {
            return this.shape + " " + this.weight  ;
        }
       
        


    }

}




/*      public cookies(string aShape, int aWeight){

            this.shape = aShape;
            this.weight = aWeight;

        }*/
