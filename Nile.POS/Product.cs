namespace Nile.POS
{
    public class Product
    {
        private static int _lastID = 0;

        public Product(string name, decimal unitPrice, bool discontinued)
        {
            ID = ++_lastID;
            Name = name;
            UnitPrice = unitPrice;
            Discontinued = discontinued;
        }

        public int ID
        {
            get; private set;
        }

        public string Name
        {
            get; private set;
        }

        public decimal UnitPrice
        {
            get; private set;
        }

        public bool Discontinued
        {
            get; private set;

        }
    }
}