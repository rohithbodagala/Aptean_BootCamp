using System;

namespace Orders
{
    class Item : OrderDetail
    {
        protected string description;
        protected string shippingWeight;

        public Item()
        {


        }
        public Item(string description, string shippingWeight)
        {
            this.description = description;
            this.shippingWeight = shippingWeight;
        }

        public void GetDescription()
        {
        }
        public void getPriceForQuality()
        {
        }
        public void GetShippingWeight()
        {
        }
        public void getWeight()
        {
        }
       
        public void SetDescription()
        {
        }
        public void SetShippingWeight()
        {
        }

    }
}