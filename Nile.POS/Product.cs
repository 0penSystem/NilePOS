namespace Nile.POS
{
    public class Product
    {
        private static int _lastID = 0;
        private int _id;
        private string _name;
        private decimal _unitPrice;
        private bool _discontinued;

        public Product(string name, decimal unitPrice, bool discontinued)
        {
            _id = ++_lastID;
            _name = name;
            _unitPrice = unitPrice;
            _discontinued = discontinued;
        }

        public int ID
        {
            get
            {
                return _id;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }

        }

        public decimal UnitPrice
        {
            get
            {
                return _unitPrice;
            }
        }

        public bool Discontinued
        {
            get
            {
                return _discontinued;
            }

        }
    }
}