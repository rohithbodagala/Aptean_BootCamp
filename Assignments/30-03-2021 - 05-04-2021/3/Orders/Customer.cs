using System;

namespace Orders
{
    class Customer
    {
        protected string address;
        protected string name;

        public Customer()
        {
        }
        public Customer(string address, string name)
        {
            this.address = address;
            this.name = name;

            Order order = new Order();
        }
        
    }
}

