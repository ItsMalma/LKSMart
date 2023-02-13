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
    public partial class PointHistoryForm : Form
    {
        private readonly Customer customer;

        public PointHistoryForm(Customer customer)
        {
            this.customer = customer;
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            currentPoint.Text = customer.point.ToString();
            foreach (PointHistory pointHistory in customer.PointHistories.Where(ph => ph.deleted_at == null))
            {
                Point point = new Point(pointHistory)
                {
                    Dock = DockStyle.Top
                };
                pointsPanel.Controls.Add(point);
            }
        }

        private void OnBack(object sender, EventArgs e)
        {
            Close();
        }
    }
}
