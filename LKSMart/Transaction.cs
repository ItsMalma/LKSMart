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
    public partial class Transaction : UserControl
    {
        private readonly HeaderTransaction headerTransaction;
        public HeaderTransaction HeaderTransaction => headerTransaction;

        public event EventHandler SelectItem;

        public Transaction(HeaderTransaction headerTransaction)
        {
            this.headerTransaction = headerTransaction;
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            date.Text = headerTransaction.datetime.ToString("yyyy-MM-dd");
            totalPayment.Text = headerTransaction.sub_total.ToString();
            int point = 0;
            headerTransaction.PointHistories.Where(
                ph => ph.deleted_at == null
            ).ToList().ForEach(ph => {
                point += ph.point_gained.GetValueOrDefault(0) - ph.point_deducted.GetValueOrDefault(0);
            });
            pointGainOrDeducted.Text = point.ToString();
            paymentCode.Text = headerTransaction.payment_code;
        }

        private void OnClick(object sender, EventArgs e)
        {
            SelectItem.Invoke(this, e);
        }
    }
}
