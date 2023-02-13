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
    public partial class TransactionHistoryForm : Form
    {
        private readonly Customer customer;
        private readonly DataModel data = new DataModel();

        public TransactionHistoryForm(Customer customer)
        {
            this.customer = customer;
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            foreach (HeaderTransaction headerTransaction in data.HeaderTransactions.Where(
                ht => ht.customer_id == customer.id && ht.deleted_at == null
            ))
            {
                Transaction transaction = new Transaction(headerTransaction)
                {
                    Dock = DockStyle.Top
                };
                transaction.SelectItem += new EventHandler(OnTransactionClicked);
                transactionsPanel.Controls.Add(transaction);
            }
        }

        private void OnTransactionClicked(object sender, EventArgs e)
        {
            productsPanel.Controls.Clear();
            ((Transaction)sender).HeaderTransaction.DetailTransactions.Where(
                dt => dt.deleted_at == null
            ).ToList().ForEach(dt =>
            {
                ProductTransaction productTransaction = new ProductTransaction(dt)
                {
                    Dock = DockStyle.Top
                };
                productsPanel.Controls.Add(productTransaction);
            });
        }

        private void OnBack(object sender, EventArgs e)
        {
            Close();
        }
    }
}
