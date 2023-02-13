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
    public partial class ProfilePictureMenu : Form
    {
        private Image selectedImage = null;
        public Image SelectedImage => selectedImage;

        private string selectedImageName = null;
        public string SelectedImageName => selectedImageName;

        public ProfilePictureMenu()
        {
            InitializeComponent();
        }

        private void OnAvatar1Clicked(object sender, EventArgs e)
        {
            selectedImage = ImagesResource.avatar1;
            selectedImageName = "avatar1";
            Close();
        }

        private void OnAvatar2Clicked(object sender, EventArgs e)
        {
            selectedImage = ImagesResource.avatar2;
            selectedImageName = "avatar2";
            Close();
        }

        private void OnAvatar3Clicked(object sender, EventArgs e)
        {
            selectedImage = ImagesResource.avatar3;
            selectedImageName = "avatar3";
            Close();
        }

        private void OnAvatar4Clicked(object sender, EventArgs e)
        {
            selectedImage = ImagesResource.avatar4;
            selectedImageName = "avatar4";
            Close();
        }

        private void OnAvatar5Clicked(object sender, EventArgs e)
        {
            selectedImage = ImagesResource.avatar5;
            selectedImageName = "avatar5";
            Close();
        }

        private void OnAvatar6Clicked(object sender, EventArgs e)
        {
            selectedImage = ImagesResource.avatar6;
            selectedImageName = "avatar6";
            Close();
        }

        private void OnDefaultAvatarClicked(object sender, EventArgs e)
        {
            selectedImage = ImagesResource.default_profile_picture;
            selectedImageName = "default_profile_picture";
            Close();
        }
    }
}
