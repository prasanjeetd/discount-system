using System;
using System.Collections.Generic;

namespace Practice.Classlibrary
{
    public class Product
    {
        public int id { get; set; }

        public string name { get; set; }

        public decimal mrp { get; set; }

        public List<IOffer> offers { get; set; }

        public Product()
        {
            this.offers = new List<IOffer>();
        }
    }
}
