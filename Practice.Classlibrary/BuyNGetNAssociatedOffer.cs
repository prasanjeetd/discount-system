using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Practice.Classlibrary
{
    public class BuyNGetNAssociatedOffer : BuyNGetNOffer
    {
        public Product sourceProduct { get; set; }

        public List<Product> offerProducts { get; set; } = new List<Product>();

        public BuyNGetNAssociatedOffer(string name, int buyN, int getN) : base(name, buyN, getN)
        {
        }

        public void addProduct(Product sourceProduct, List<Product> offerProducts)
        {
            this.sourceProduct.offers.Add(this);
            this.sourceProduct = sourceProduct;
            this.offerProducts.AddRange(offerProducts);
        }

        public override decimal calculate(Cart cart, CartItem item)
        {
            List<int> productIdList = this.offerProducts.Select(x => x.id).ToList();
            productIdList.Add(this.sourceProduct.id);

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
