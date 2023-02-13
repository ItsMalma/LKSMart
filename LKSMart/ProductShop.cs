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
    public partial class ProductShop : UserControl
    {
        private readonly Customer customer;
        private readonly Product product;

        public ProductShop(Customer customer, Product product)
        {
            this.customer = customer;
            this.product = product;
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            string productImageName = "not_available";
            if (product.image_name != "null")
            {
                string[] splittedProductImageName = $"_{product.image_name}".Split('.');
                productImageName = string.Join("", splittedProductImageName.Take(splittedProductImageName.Length - 1));
            }
            productImage.Image = (Bitmap)ImagesResource.ResourceManager.GetObject(productImageName);
            productName.Text = product.name;
            productStock.Text = product.stock.ToString();
            productPrice.Text = product.price.ToString();
        }

        private void OnAddToCart(object sender, EventArgs e)
        {
            for(Control parent = Parent; parent != null; parent = parent.Parent)
            {
                if (parent is Form)
                {
                    parent.Hide();
                    break;
                }
            }
            AddToCartForm addToCartForm = new AddToCartForm(customer, product);
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
    }
}
