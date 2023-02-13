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
    public partial class AddToCartForm : Form
    {
        private readonly Customer customer;
        private readonly Product product;
        private readonly DataModel dataModel = new DataModel();

        public AddToCartForm(Customer customer, Product product)
        {
            this.customer = customer;
            this.product = product;
            InitializeComponent();
        }

        public AddToCartForm(Cart cart)
        {
            customer = cart.Customer;
            product = cart.Product;
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
            productTotal.Maximum = product.stock;
            productPrice.Text = product.price.ToString();
        }

        private void OnSubmit(object sender, EventArgs e)
        {
            Cart cart = Cart.Carts.FirstOrDefault(c => c.Customer.id == customer.id && c.Product.id == product.id);
            if (cart == null)
            {
                Cart.Carts.Add(new Cart()
                {
                    Customer = customer,
                    Product = product,
                    Total = ((int)productTotal.Value)
                });
            }
            else
            {
                Cart.Carts[Cart.Carts.IndexOf(cart)] = new Cart()
                {
                    Customer = customer,
                    Product = product,
                    Total = ((int)productTotal.Value)
                };
            }
            Close();
        }
    }
}
