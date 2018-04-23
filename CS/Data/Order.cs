using System;

namespace WindowsApplication1
{
    public class Order
    {

        public Order()
        {

        }

        private DateTime _Date;
        public DateTime Date
        {
            get { return _Date; }
            set { _Date = value; }
        }

        private string _ProductName;
        public string ProductName
        {
            get { return _ProductName; }
            set { _ProductName = value; }
        }

        private decimal _Amount;
        public decimal Amount
        {
            get { return _Amount; }
            set { _Amount = value; }
        }

    }
}
