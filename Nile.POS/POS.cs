namespace Nile.POS
{

    public class POS
    {


        public POS()
        {
            Customers = new Customers();
            Products = new Products();
        }

        public Customers Customers
        {
            get; set;
        }

        public Products Products
        {
            get; set;
        }
    }


}
