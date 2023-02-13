using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LKSMart
{
    public partial class ProfileForm : Form
    {
        private Customer customer;
        private readonly DataModel data = new DataModel();
        private string profilePictureName = string.Empty;

        public ProfileForm(Customer customer)
        {
            this.customer = customer;

            InitializeComponent();
        }

        protected private void OnLoad(object sender, EventArgs e)
        {
            genderComboBox.Items.AddRange(new string[]
            {
                "None", "Male", "Female"
            });

            nameTextBox.Text = customer.name;
            phoneNumberTextBox.Text = customer.phone_number;
            emailTextBox.Text = customer.email;
            pinTextBox.Text = customer.pin_number;
            dateOfBirthDateTimePicker.Value = customer.date_of_birth ?? DateTime.Now;
            addressRichTextBox.Text = customer.address;
            genderComboBox.SelectedIndex = genderComboBox.Items.IndexOf(customer.gender ?? "None");
            profilePictureName = customer.profile_image_name;
            profilePictureBox.Image = (Bitmap)ImagesResource.ResourceManager.GetObject(profilePictureName);

            nameErrorLabel.Text = pinErrorLabel.Text = dateOfBirthErrorLabel.Text = "";
        }

        private void OnBack(object sender, EventArgs e)
        {
            customer = null;
            Close();
        }

        private void OnEditName(object sender, EventArgs e)
        {
            nameErrorLabel.Text = "";
            customer.name = nameTextBox.Text;
            data.Customers.AddOrUpdate(customer);
            data.SaveChanges();
        }

        private void OnEditPin(object sender, EventArgs e)
        {
            pinErrorLabel.Text = "";
            if (pinTextBox.Text.Length != 6)
            {
                pinErrorLabel.Text = "Length of pin must be 6 characters";
                return;
            }
            customer.pin_number = pinTextBox.Text;
            data.Customers.AddOrUpdate(customer);
            data.SaveChanges();
        }

        private void OnPinKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b') e.Handled = true;
        }

        private void OnEditDateOfBirth(object sender, EventArgs e)
        {
            dateOfBirthErrorLabel.Text = "";
            customer.date_of_birth = dateOfBirthDateTimePicker.Value;
            data.Customers.AddOrUpdate(customer);
            data.SaveChanges();
        }

        private void OnEditAddress(object sender, EventArgs e)
        {
            customer.address = addressRichTextBox.Text;
            data.Customers.AddOrUpdate(customer);
            data.SaveChanges();
        }

        private void OnEditGender(object sender, EventArgs e)
        {
            customer.gender = genderComboBox.SelectedText;
            data.Customers.AddOrUpdate(customer);
            data.SaveChanges();
        }

        private void OnEditProfilePicture(object sender, EventArgs e)
        {
            Enabled = false;
            ProfilePictureMenu profilePictureMenu = new ProfilePictureMenu();
            profilePictureMenu.ShowDialog();
            Enabled = true;
            if (profilePictureMenu.SelectedImage != null)
            {
                profilePictureBox.Image = profilePictureMenu.SelectedImage;
                profilePictureName = profilePictureMenu.SelectedImageName;
            }
            else
            {
                profilePictureBox.Image = ImagesResource.default_profile_picture;
                profilePictureName = "default_profile_picture";
            }
        }

        private void OnUploadProfilePicture(object sender, EventArgs e)
        {
            customer.profile_image_name = profilePictureName ?? "default_profile_picture";
            data.Customers.AddOrUpdate(customer);
            data.SaveChanges();
        }
    }
}
