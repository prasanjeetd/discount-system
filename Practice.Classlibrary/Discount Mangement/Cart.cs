using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Practice.Classlibrary
{
    public class Cart
    {
        public List<CartItem> items { get; set; }

        public Cart()
        {
            this.items = new List<CartItem>();
            this.add();
        }

        public void add()
        {
            foreach (Product product in new ProductInventory().products)
            {
                this.items.Add(new CartItem { product = product, qty = 1 });
            }

            this.items.Find(x => x.product.id == 1).qty = 3;
            this.items.Find(x => x.product.id == 2).qty = 6;
            this.items.Find(x => x.product.id == 5).qty = 4;
            this.items.Find(x => x.product.id == 6).qty = 3;


        }

        public void calculate()
        {
            Console.WriteLine("Price calculation on Basket with offers");
            Console.WriteLine("-----------------------------------------------------------");


            decimal total = 0;
            decimal cartTotal = 0;

            List<CartItem> offerProducts = new List<CartItem>();

            Console.WriteLine("Basket items:");
            foreach (CartItem item in this.items)
            {
                total += item.calculate(this);

                decimal itemPrice = item.product.mrp * item.qty;

                cartTotal += itemPrice;

                if (item.offerApplied != null)
                {
                    offerProducts.Add(item);
                }

                Console.WriteLine($"Cart Item price of \t {item.product.name} of \t mrp: {item.product.mrp} * qty: { item.qty} \t is {itemPrice}");
            }

            decimal discount = cartTotal - total;

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine($"Total cost of the cart \t\t\t is {cartTotal}");
            Console.WriteLine($"Total discount on the cart \t\t is {discount}");
            Console.WriteLine($"Total cost of the cart after discount \t is {total}");

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine($"Offers applied on the basket are:");
            foreach (CartItem item in offerProducts)
            {
                Console.WriteLine($"Offer {item.offerApplied.name} \t applied on product: \t {item.product.name}");

            }
        }
    }
}
;