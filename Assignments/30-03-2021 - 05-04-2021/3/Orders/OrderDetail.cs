using System;

namespace Orders
{
    class OrderDetail
    {
        protected string quantity;
        protected string taxStatus;

        public OrderDetail()
        {


        }
        public OrderDetail(string quantity, string taxStatus)
        {
            this.quantity = quantity;
            this.taxStatus = taxStatus;
        }
    
        public void calcSubTotal()
        {
        }
        public void calcWeight()
        {
        }
        
    }
}

