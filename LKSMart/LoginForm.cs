using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LKSMart
{
    public partial class LoginForm : Form
    {
        private readonly DataModel data = new DataModel();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void OnPinNumberKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b') e.Handled = true;
        }

        private void OnMainFormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void OnLogin(object sender, EventArgs e)
        {
            this.errorLabel.Text = "";

            string phoneNumberOrEmail = phoneNumberOrEmailTextBox.Text;
            string pinNumber = pinNumberTextBox.Text;
            Customer customer = data.Customers.Where(
                c => (
                    c.phone_number == phoneNumberOrEmail ||
                    c.email == phoneNumberOrEmail
                ) && c.pin_number == pinNumber && c.deleted_at == null
            ).FirstOrDefault();
            if(customer == null)
            {
                errorLabel.Text = "Invalid Phone Number / Email / Pin";
                return;
            }

            this.Hide();
            MainForm mainForm = new MainForm(customer);
            mainForm.FormClosed += new FormClosedEventHandler(OnMainFormClosed);
            mainForm.Show();
        }
    }
}
