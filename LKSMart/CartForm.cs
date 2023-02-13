using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LKSMart
{
    public partial class CartForm : Form
    {
        private List<Cart> carts = new List<Cart>();
        private readonly Customer customer;
        private readonly DataModel data = new DataModel();
        private int availablePoint;
        private decimal subTotal, platformFee, total, amountToPay;

        public CartForm(Customer customer)
        {
            this.customer = customer;
            InitializeComponent();
        }

        private void OnBack(object sender, EventArgs e)
        {
            Close();
        }

        private void ReloadCarts()
        {
            productsPanel.Controls.Clear();
            subTotal = 0;
            carts = Cart.Carts.Where(c => c.Customer.id == customer.id).ToList();
            foreach (Cart cart in carts)
            {
                productsPanel.Controls.Add(new ProductCart(cart)
                {
                    Dock = DockStyle.Top
                });
                subTotal += cart.Total * cart.Product.price;
            }
            platformFee = subTotal * (decimal)0.05;
            total = subTotal + platformFee;
            availablePoint = usePointCheckbox.Checked ? customer.point : -1;
            amountToPay = total - (availablePoint == -1 ? 0 : availablePoint);

            subTotalValue.Text = subTotal.ToString();
            platformFeeValue.Text = platformFee.ToString();
            totalValue.Text = total.ToString();
            availablePointValue.Text = availablePoint == -1 ? "Not used" : availablePoint.ToString();
            amountToPayValue.Text = amountToPay.ToString();
        }

        private void OnUseAvailablePointChanged(object sender, EventArgs e)
        {
            ReloadCarts();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            ReloadCarts();
            foreach (PaymentType paymentType in data.PaymentTypes.Where(pt => pt.deleted_at == null))
            {
                paymentTypeComboBox.Items.Add(paymentType.name);
            }
            paymentTypeComboBox.SelectedIndex = 0;
        }

        private void OnSubmit(object sender, EventArgs e)
        {
            if (carts.Count < 1) return;

            Random random = new Random();
            string paymentCode = new string(
                Enumerable.Repeat<string>("ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890", 12).Select(
                    str => str[random.Next(str.Length)]
                ).ToArray()
            );

            PaymentType paymentType = data.PaymentTypes.Where(
                pt => pt.name == (string)paymentTypeComboBox.SelectedItem && pt.deleted_at == null
            ).First();

            Hide();
            PaymentNotificationForm paymentNotificationForm = new PaymentNotificationForm(
                new Payment()
                {
                    Type = paymentType,
                    Code = paymentCode,
                    Customer = customer,
                    Carts = carts,
                    SubTotal = subTotal,
                    AvailablePoint = availablePoint,
                    UseAvailablePoint = usePointCheckbox.Checked,
                }
            );
            paymentNotificationForm.FormClosed += OnPaymentNotificationClosed;
            paymentNotificationForm.Show();
        }

        private void OnPaymentNotificationClosed(object sender, FormClosedEventArgs e)
        {
            Show();
            if (((PaymentNotificationForm)sender).Ok)
            {
                Close();
            }
        }
    }
}
