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
    public partial class MainForm : Form
    {
        private readonly DataModel data = new DataModel();
        private Customer customer;
        private readonly Timer timer = new Timer();

        public MainForm(Customer customer)
        {

            this.customer = customer;

            timer.Tick += new EventHandler(OnTimerTicked);
            timer.Interval = 1000;

            InitializeComponent();
        }

        private void OnTimerTicked(object sender, EventArgs e)
        {
            liveDateTimeLabel.Text = DateTime.Now.ToString("yyyy-MM-dd, HH:mm:ss");
        }

        private void Reload()
        {
            welcomeLabel.Text = $"Welcome, {customer.name}!";

            liveDateTimeLabel.Text = DateTime.Now.ToString("yyyy-MM-dd, HH:mm:ss");
            timer.Start();

            profilePictureBox.Image = (Bitmap)ImagesResource.ResourceManager.GetObject(customer.profile_image_name);
        }

        private void OnLoad(object sender, EventArgs e)
        {
            Reload();
        }

        private void OnLogout(object sender, EventArgs e)
        {
            customer = null;
            Close();
        }

        private void OnMenuClosed(object sender, EventArgs e)
        {
            Show();
            Reload();
        }

        private void OnProfileMenuClicked(object sender, EventArgs e)
        {
            Hide();
            ProfileForm profileForm = new ProfileForm(customer);
            profileForm.FormClosed += new FormClosedEventHandler(OnMenuClosed);
            profileForm.Show();
        }

        private void OnShopMenuClicked(object sender, EventArgs e)
        {
            Hide();
            ShopForm shopForm = new ShopForm(customer);
            shopForm.FormClosed += new FormClosedEventHandler(OnMenuClosed);
            shopForm.Show();
        }

        private void OnCartMenuClicked(object sender, EventArgs e)
        {
            Hide();
            CartForm cartForm = new CartForm(customer);
            cartForm.FormClosed += new FormClosedEventHandler(OnMenuClosed);
            cartForm.Show();
        }

        private void OnTransactionHistoryMenuClicked(object sender, EventArgs e)
        {
            Hide();
            TransactionHistoryForm transactionHistoryForm = new TransactionHistoryForm(customer);
            transactionHistoryForm.FormClosed += new FormClosedEventHandler(OnMenuClosed);
            transactionHistoryForm.Show();
        }

        private void OnPointHistoryMenuClicked(object sender, EventArgs e)
        {
            Hide();
            PointHistoryForm pointHistoryForm = new PointHistoryForm(customer);
            pointHistoryForm.FormClosed += new FormClosedEventHandler(OnMenuClosed);
            pointHistoryForm.Show();
        }
    }
}
