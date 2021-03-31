using System;

namespace Orders
{
    class Order
    {
        protected string date;
        protected string status;

        public Order()
        {
            OrderDetail orderdetails = new OrderDetail();
        }
        public Order(string date, string status)
        {
            this.date = date;
            this.status = status;
        }

        public void calcTax()
        {
        }
        public void calcTotal()
        {
        }
        public void calcTotalWeight()
        {
        }
        public void GetDate()
        {
        }
        public void GetStatus()
        {
        }

        
        public void SetDate()
        {
        }
        public void SetStatus()
        {
        }
    }
}

