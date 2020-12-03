using DelegateSelfDemo_Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateSelfDemo_Winform
{
    public partial class DelegateDemo : Form
    {

        ShoppingCart shoppingCart = new ShoppingCart();
        public DelegateDemo()
        {
            InitializeComponent();

            shoppingCart.MockCartData();
        }

        private void btnMessageBox_Click(object sender, EventArgs e)
        {
            decimal subTotal = shoppingCart.GenerateTotal(
                x => MessageBox.Show($"Acutal SubTotal is: {x}"),
                x => MessageBox.Show(x));

            MessageBox.Show($"You will pay {subTotal} for those products");
        }

        private void btnTextBox_Click(object sender, EventArgs e)
        {
            decimal subTotal = shoppingCart.GenerateTotal(
                x => { this.txSubTotal.Text = x.ToString(); },
                x => { });

            MessageBox.Show($"You will pay {subTotal} for those products");
        }
    }
}
