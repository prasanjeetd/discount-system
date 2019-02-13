using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Classlibrary
{
    public class Offers
    {

        public static IOffer comboOffer;

        static Offers()
        {
            comboOffer = new BuyNGetNOffer("Buy 1 Get 1 Combo", 1, 1);
            
        }

        public static IOffer Buy1Get1 = new BuyNGetNOffer("Buy 1 Get 1", 1, 1);

        public static IOffer Buy2Get1 = new BuyNGetNOffer("Buy 2 Get 1", 2, 1);
    }
}
