using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdvancedCSharp.Models
{
    public  static class MyExtensionMethods
    {
        public static float TotalPrices(this ShoppingCart cartParam)
        {
            float total = 0;
            foreach (Product prod in cartParam.Products)
            {
                total += prod.Price;
            }
            return total;
        }
    }
}