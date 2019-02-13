using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Classlibrary
{
    public class CartItem
    {
        public bool isOfferApplied { get; set; } = false;

        public decimal price { get; set; }

        public Product product { get; set; }

        public IOffer offerApplied { get; set; }

        public int qty { get; set; }

        public decimal calculate(Cart cart)
        {
            if (isOfferApplied)
                return 0;

            price = product.mrp * qty;

            if (product.offers.Count > 0)
            {
                offerApplied = product.offers[0];

                decimal itemTotal = offerApplied.calculate(cart, this);
                
                price = itemTotal;

                isOfferApplied = true;

            }

            return price;

        }
    }
}
