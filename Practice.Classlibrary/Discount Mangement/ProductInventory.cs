using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Classlibrary
{
    public class ProductInventory
    {
        public List<Product> products { get; }

        public ProductInventory()
        {
            this.products = new List<Product>
            {
                new Product{id =1, name ="Biscuit",mrp=20, offers = new List<IOffer>{ Offers .Buy1Get1} },
                new Product{id =2, name ="Tea",mrp=50, offers = new List<IOffer>{  Offers .Buy2Get1}},
                new Product{id =3, name ="Milk",mrp=30},
                new Product{id =4, name ="Sugar",mrp=40}
            };

            var comboOffer = new BuyNGetNComboOffer("Buy 1 Get 2 Combo", 1, 2);

            var butter = new Product { id = 5, name = "Butter", mrp = 35 };
            comboOffer.addProduct(butter);
            this.products.Add(butter);

            var cheeze = new Product { id = 6, name = "Cheeze", mrp = 25 };
            comboOffer.addProduct(cheeze);
            this.products.Add(cheeze);

            var cake = new Product { id = 7, name = "Cake", mrp = 45 };
            var chocoloate = new Product { id = 8, name = "Chocolate", mrp = 50 };

            var associatedOffer = new BuyNGetNAssociatedOffer("Buy 1 Get 2 Combo", 1, 2);
            associatedOffer.addProduct(cake, new List<Product> { chocoloate });

            var associatedOffer1 = new BuyNGetNAssociatedOffer("Buy 1 Get 2 Combo", 1, 1);
            associatedOffer1.addProduct(cake, new List<Product> { butter });

        }
    }
}
