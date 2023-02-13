using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LKSMart
{
    public partial class ProductCart : UserControl
    {
        private readonly Cart cart;

        public ProductCart(Cart cart)
        {
            this.cart = cart;

            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            string productImageName = "not_available";
            if (cart.Product.image_name != "null")
            {
                string[] splittedProductImageName = $"_{cart.Product.image_name}".Split('.');
                productImageName = string.Join("", splittedProductImageName.Take(splittedProductImageName.Length - 1));
            }
            productImage.Image = (Bitmap)ImagesResource.ResourceManager.GetObject(productImageName);
            productName.Text = cart.Product.name;
            productQuantity.Text = cart.Total.ToString();
            productPrice.Text = cart.Product.price.ToString();
        }

        private void OnEdit(object sender, EventArgs e)
        {
            for (Control parent = Parent; parent != null; parent = parent.Parent)
            {
                if (parent is Form)
                {
                    parent.Hide();
                    break;
                }
            }
            AddToCartForm addToCartForm = new AddToCartForm(cart);
            addToCartForm.FormClosed += OnAddToFormClosed;
            addToCartForm.Show();
        }

        private void OnAddToFormClosed(object sender, FormClosedEventArgs e)
        {
            for (Control parent = Parent; parent != null; parent = parent.Parent)
            {
                if (parent is Form)
                {
                    parent.Show();
                    break;
                }
            }
        }

        private void OnDelete(object sender, EventArgs e)
        {
            for (Control parent = Parent; parent != null; parent = parent.Parent)
            {
                if (parent is Form)
                {
                    if (MessageBox.Show(
                        parent,
                        "Are you sure want to delete this cart?",
                        "LKSMart - Delete Cart Confirmation",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2
                    ) == DialogResult.Yes) Cart.Carts.RemoveAt(Cart.Carts.IndexOf(cart));
                    break;
                }
            }
            Parent.Controls.Remove(this);
        }
    }
}
