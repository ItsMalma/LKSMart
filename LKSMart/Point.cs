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
    public partial class Point : UserControl
    {
        private readonly PointHistory pointHistory;

        public Point(PointHistory pointHistory)
        {
            this.pointHistory = pointHistory;
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            date.Text = pointHistory.created_at.ToString("yyyy-MM-dd");
            paymentCode.Text = pointHistory.HeaderTransaction.payment_code;
            pointGain.Text = (pointHistory.point_gained - pointHistory.point_deducted).ToString();
            pointBefore.Text = pointHistory.point_before.ToString();
            pointAfter.Text = pointHistory.point_after.ToString();
        }
    }
}
