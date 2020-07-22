using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.DelegatesDemo
{
    public class ShoppingCartModel
    {
        // whenever you use this, it gotta return void and do someting
        public delegate void MentionDiscount(decimal subTotal);

        // Func is a special type of delegate

        public List<ProductModel> Items { get; set; } = new List<ProductModel>();

        // Func is a special type of delegate
        // Func has 17 override, and most in, in, in .... , out
        // Action is a special type of delegate too, just action, no return value
        public decimal GenerateTotal(MentionDiscount mentionSubTotal,
            Func<List<ProductModel>, decimal, decimal> calculateDiscountedTotal,
            Action<string> tellUserWeAreDiscounting)
        {
            decimal subTotal = Items.Sum(x => x.Price);

            mentionSubTotal(subTotal);

            tellUserWeAreDiscounting("We are applying your discount!");

            return calculateDiscountedTotal(Items, subTotal);

        }
    }
}
