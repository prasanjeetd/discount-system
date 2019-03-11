using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Classlibrary
{
   public interface IOffer
    {
        string name { get; set; }

        decimal calculate(Cart cart, CartItem item);
    }
}
