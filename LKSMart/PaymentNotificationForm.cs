using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LKSMart
{
    public partial class PaymentNotificationForm : Form
    {
        private readonly Payment payment;
        private readonly DataModel data = new DataModel();

        private bool ok = false;
        public bool Ok => ok;

        public PaymentNotificationForm(Payment payment)
        {
            this.payment = payment;
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            description1.Text = $"Your order has been submitted successfully.\nPlease continue the payment process in your {payment.Type.name} application.";
            paymentCodeLabel.Text = payment.Code;
        }

        private void OnOK(object sender, EventArgs e)
        {
            ok = true;
            using (DbContextTransaction transaction = data.Database.BeginTransaction())
            {
                try
                {
                    HeaderTransaction headerTransaction = new HeaderTransaction()
                    {
                        customer_id = payment.Customer.id,
                        payment_type_id = payment.Type.id,
                        datetime = DateTime.Now,
                        sub_total = payment.SubTotal,
                        point_used = payment.UseAvailablePoint ? payment.AvailablePoint : 0,
                        payment_code = payment.Code,
                        created_at = DateTime.Now,
                    };
                    headerTransaction = data.HeaderTransactions.Add(headerTransaction);
                    foreach (Cart cart in payment.Carts)
                    {
                        data.DetailTransactions.Add(new DetailTransaction()
                        {
                            header_transaction_id = headerTransaction.id,
                            product_id = cart.Product.id,
                            price = cart.Product.price,
                            quantity = cart.Total,
                            created_at = DateTime.Now
                        });
                        cart.Product.stock -= (cart.Product.stock - cart.Total < 0 ? cart.Product.stock : cart.Total);
                        data.Products.AddOrUpdate(cart.Product);
                    }
                    if (payment.UseAvailablePoint)
                    {
                        data.PointHistories.Add(new PointHistory()
                        {
                            customer_id = payment.Customer.id,
                            header_transaction_id = headerTransaction.id,
                            point_gained = 0,
                            point_deducted = payment.Customer.point,
                            point_before = payment.Customer.point,
                            point_after = 0,
                            created_at = DateTime.Now
                        });
                        payment.Customer.point = 0;
                    }
                    else
                    {
                        int pointGained = (int)Math.Round(payment.SubTotal * (decimal)0.2);
                        data.PointHistories.Add(new PointHistory()
                        {
                            customer_id = payment.Customer.id,
                            header_transaction_id = headerTransaction.id,
                            point_gained = pointGained,
                            point_deducted = 0,
                            point_before = payment.Customer.point,
                            point_after = pointGained,
                            created_at = DateTime.Now
                        });
                        payment.Customer.point = pointGained;
                    }
                    data.Customers.AddOrUpdate(payment.Customer);
                    data.SaveChanges();

                    transaction.Commit();

                    payment.Carts.ForEach(cart => Cart.Carts.Remove(cart));
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                    transaction.Rollback();
                }
                finally
                {
                    Close();
                }
            }
        }
    }
}
