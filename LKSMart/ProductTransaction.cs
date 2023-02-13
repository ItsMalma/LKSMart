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
    public partial class ProductTransaction : UserControl
    {
        private readonly DetailTransaction detailTransaction;

        public ProductTransaction(DetailTransaction detailTransaction)
        {
            this.detailTransaction = detailTransaction;
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            string productImageName = "not_available";
            if (detailTransaction.Product.image_name != "null")
            {
                string[] splittedProductImageName = $"_{detailTransaction.Product.image_name}".Split('.');
                productImageName = string.Join("", splittedProductImageName.Take(splittedProductImageName.Length - 1));
            }
            productImage.Image = (Bitmap)ImagesResource.ResourceManager.GetObject(productImageName);
            productName.Text = detailTransaction.Product.name;
            productQuantity.Text = detailTransaction.quantity.ToString();
            productPrice.Text = detailTransaction.Product.price.ToString();
        }
    }
}
