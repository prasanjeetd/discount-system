using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Practice.Classlibrary
{
    public class BuyNGetNComboOffer : BuyNGetNOffer
    {
        public List<Product> products { get; set; } = new List<Product>();

        public BuyNGetNComboOffer(string name, int buyN, int getN) : base(name, buyN, getN)
        {
        }

        public void addProduct(Product product)
        {
            product.offers.Add(this);
            this.products.Add(product);
        }


        public override decimal calculate(Cart cart, CartItem item)
        {
            List<int> productIdList = this.products.Select(x => x.id).ToList();

            List<CartItem> offerProduts = cart.items
                                            .Where(x => productIdList.Contains(x.product.id))
                                            .ToList();

            int qty = offerProduts.Sum(x => x.qty);
            decimal mrp = offerProduts.Max(x => x.product.mrp);

            decimal total = calculate(mrp, qty);

            offerProduts.ForEach(x => x.isOfferApplied = true);

            return total;
        }
    }
}
