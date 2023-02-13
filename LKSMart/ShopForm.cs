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
    public partial class ShopForm : Form
    {
        private readonly Customer customer;
        private readonly DataModel data = new DataModel();

        public ShopForm(Customer customer)
        {
            this.customer = customer;
            InitializeComponent();
        }

        private void Reload()
        {
            string keyword = keywordTextBox.Text;
            int.TryParse(minimumPriceRangeTextBox.Text, out int minimumPrice);
            int.TryParse(maximumPriceRangeTextBox.Text, out int maximumPrice);

            productsPanel.Controls.Clear();

            foreach (Product product in data.Products.Where(
                p => (
                    p.name.Contains(keyword) || keyword == ""
                ) && (
                    p.price >= minimumPrice || minimumPrice == 0
                ) && (
                    p.price <= maximumPrice || maximumPrice == 0
                ) && p.deleted_at == null
            ).OrderByDescending(p => p.id))
            {
                ProductShop productShop = new ProductShop(customer, product)
                {
                    Dock = DockStyle.Top
                };
                productsPanel.Controls.Add(productShop);
            }
        }

        private void OnLoad(object sender, EventArgs e)
        {
            Reload();
        }

        private void OnBack(object sender, EventArgs e)
        {
            Close();
        }

        private void OnKeywordChanged(object sender, EventArgs e)
        {
            Reload();
        }

        private void OnPriceRangePressed(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b') e.Handled = true;
        }

        private void OnPriceRangeChanged(object sender, EventArgs e)
        {
            Reload();
        }
    }
}
