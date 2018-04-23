using System;
using System.ComponentModel;
using System.Text;

namespace WindowsApplication1
{
    public class Customer
    {

        public Customer()
        {

        }

        private string _FirstName;
        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }

        private string _LastName;
        public string LastName
        {
            get { return _LastName; }
            set
            {
                _LastName = value;
            }
        }


        private BindingList<Order> _Orders = new BindingList<Order>();
        public BindingList<Order> Orders
        {
            get { return _Orders; }
            set { _Orders = value; }
        }
    }

    public static class DataGenerator
    {
         static    Random random = new Random();
        private static string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }

        private static string GetRandomName()
        {
            return RandomString(1, false) + RandomString(5, true);
        }
        public static object GetData()
        {
  
            BindingList<Customer> customers = new BindingList<Customer>();
            for (int i = 0; i < random.Next(20, 100); i++)
            {
                Customer customer = new Customer();
                customers.Add(customer);
                customer.FirstName = GetRandomName();
                customer.LastName = GetRandomName();
                for (int j = 0; j < random.Next(20,100); j++)
                {
                    Order order = new Order();
                    customer.Orders.Add(order);
                    order.Amount = random.Next(10000);
                    order.Date = DateTime.Now.AddDays(500 - random.Next(1000));
                    order.ProductName = GetRandomName();
                }
            }
            return customers;
        }
    }
}
