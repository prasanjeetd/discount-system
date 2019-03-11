using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Classlibrary
{
    public class BuyNGetNOffer : IOffer
    {
        protected int buyN = 0;
        protected int getN = 0;

        public string name { get; set; } = "";


        public BuyNGetNOffer(string name, int buyN, int getN)
        {
            this.buyN = buyN;
            this.getN = getN;
            this.name = name;
        }

        protected decimal calculate(decimal mrp, int qty)
        {
            decimal total = mrp * qty;

            if (qty >= buyN)
            {

                int remainder;
                int quotation = Math.DivRem(qty, (buyN + getN), out remainder);

                int totalQty = quotation + remainder;

                total = totalQty * mrp;
            }

            return total;
        }
        public virtual decimal calculate(Cart cart, CartItem item)
        {
            decimal total = calculate(item.product.mrp, item.qty);

            return total;

        }

    }
}
