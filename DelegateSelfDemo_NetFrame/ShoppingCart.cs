using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegateSelfDemo_Lib
{
    public delegate void MentionSubTotal(decimal subtotal);
    public class ShoppingCart
    {
        public List<ProductModel> Products = new List<ProductModel>();

        public decimal GenerateTotal(MentionSubTotal mentionSubTotal,
            Action<string> discountAlert)
        {
            decimal output = 0;

            output = Products.Sum(x => x.Price);
            mentionSubTotal?.Invoke(output);

            if (Products.Count > 3)
            {
                output = output * 0.39M;
                discountAlert?.Invoke("Discount with 0.39!");
            }

            return output;
        }

        public void MockCartData()
        {
            this.Products.Add(new ProductModel { ItemName = "Vegetable", Price = 2M });
            this.Products.Add(new ProductModel { ItemName = "Pork", Price = 4M });
            this.Products.Add(new ProductModel { ItemName = "Beef", Price = 8M });
            this.Products.Add(new ProductModel { ItemName = "Orange", Price = 2M });
        }
    }
}
