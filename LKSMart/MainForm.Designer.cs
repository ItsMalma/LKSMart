namespace LKSMart
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.liveDateTimeLabel = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.menusPanel = new System.Windows.Forms.TableLayoutPanel();
            this.transactionHistoryMenuPanel = new System.Windows.Forms.Panel();
            this.transactionHistoryMenuLabel = new System.Windows.Forms.Label();
            this.transactionHistoryMenuPictureBox = new System.Windows.Forms.PictureBox();
            this.shopMenuPanel = new System.Windows.Forms.Panel();
            this.shopMenuLabel = new System.Windows.Forms.Label();
            this.shopMenuPictureBox = new System.Windows.Forms.PictureBox();
            this.profileMenuPanel = new System.Windows.Forms.Panel();
            this.profileMenuLabel = new System.Windows.Forms.Label();
            this.profileMenuPictureBox = new System.Windows.Forms.PictureBox();
            this.pointMenuPanel = new System.Windows.Forms.Panel();
            this.pointMenuLabel = new System.Windows.Forms.Label();
            this.pointMenuPictureBox = new System.Windows.Forms.PictureBox();
            this.cartButton = new System.Windows.Forms.PictureBox();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.menusPanel.SuspendLayout();
            this.transactionHistoryMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionHistoryMenuPictureBox)).BeginInit();
            this.shopMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shopMenuPictureBox)).BeginInit();
            this.profileMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileMenuPictureBox)).BeginInit();
            this.pointMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pointMenuPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(198, 12);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(310, 37);
            this.welcomeLabel.TabIndex = 1;
            this.welcomeLabel.Text = "Welcome, <Name>!";
            // 
            // liveDateTimeLabel
            // 
            this.liveDateTimeLabel.AutoSize = true;
            this.liveDateTimeLabel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liveDateTimeLabel.Location = new System.Drawing.Point(198, 58);
            this.liveDateTimeLabel.Name = "liveDateTimeLabel";
            this.liveDateTimeLabel.Size = new System.Drawing.Size(0, 37);
            this.liveDateTimeLabel.TabIndex = 2;
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.Red;
            this.logoutButton.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.ForeColor = System.Drawing.Color.White;
            this.logoutButton.Location = new System.Drawing.Point(994, 12);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(172, 53);
            this.logoutButton.TabIndex = 3;
            this.logoutButton.Text = "LOGOUT";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.OnLogout);
            // 
            // menusPanel
            // 
            this.menusPanel.ColumnCount = 3;
            this.menusPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.menusPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.menusPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.menusPanel.Controls.Add(this.transactionHistoryMenuPanel, 2, 0);
            this.menusPanel.Controls.Add(this.shopMenuPanel, 1, 0);
            this.menusPanel.Controls.Add(this.profileMenuPanel, 0, 0);
            this.menusPanel.Controls.Add(this.pointMenuPanel, 1, 1);
            this.menusPanel.Location = new System.Drawing.Point(12, 198);
            this.menusPanel.Name = "menusPanel";
            this.menusPanel.RowCount = 2;
            this.menusPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.menusPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.menusPanel.Size = new System.Drawing.Size(1154, 434);
            this.menusPanel.TabIndex = 5;
            // 
            // transactionHistoryMenuPanel
            // 
            this.transactionHistoryMenuPanel.Controls.Add(this.transactionHistoryMenuLabel);
            this.transactionHistoryMenuPanel.Controls.Add(this.transactionHistoryMenuPictureBox);
            this.transactionHistoryMenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transactionHistoryMenuPanel.Location = new System.Drawing.Point(771, 3);
            this.transactionHistoryMenuPanel.Name = "transactionHistoryMenuPanel";
            this.transactionHistoryMenuPanel.Size = new System.Drawing.Size(380, 211);
            this.transactionHistoryMenuPanel.TabIndex = 8;
            this.transactionHistoryMenuPanel.Click += new System.EventHandler(this.OnTransactionHistoryMenuClicked);
            // 
            // transactionHistoryMenuLabel
            // 
            this.transactionHistoryMenuLabel.AutoSize = true;
            this.transactionHistoryMenuLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionHistoryMenuLabel.Location = new System.Drawing.Point(17, 162);
            this.transactionHistoryMenuLabel.Name = "transactionHistoryMenuLabel";
            this.transactionHistoryMenuLabel.Size = new System.Drawing.Size(347, 33);
            this.transactionHistoryMenuLabel.TabIndex = 6;
            this.transactionHistoryMenuLabel.Text = "TRANSACTION HISTORY";
            this.transactionHistoryMenuLabel.Click += new System.EventHandler(this.OnTransactionHistoryMenuClicked);
            // 
            // transactionHistoryMenuPictureBox
            // 
            this.transactionHistoryMenuPictureBox.Image = global::LKSMart.ImagesResource.transaction_history;
            this.transactionHistoryMenuPictureBox.Location = new System.Drawing.Point(118, 15);
            this.transactionHistoryMenuPictureBox.Name = "transactionHistoryMenuPictureBox";
            this.transactionHistoryMenuPictureBox.Size = new System.Drawing.Size(144, 144);
            this.transactionHistoryMenuPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.transactionHistoryMenuPictureBox.TabIndex = 6;
            this.transactionHistoryMenuPictureBox.TabStop = false;
            this.transactionHistoryMenuPictureBox.Click += new System.EventHandler(this.OnTransactionHistoryMenuClicked);
            // 
            // shopMenuPanel
            // 
            this.shopMenuPanel.Controls.Add(this.shopMenuLabel);
            this.shopMenuPanel.Controls.Add(this.shopMenuPictureBox);
            this.shopMenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shopMenuPanel.Location = new System.Drawing.Point(387, 3);
            this.shopMenuPanel.Name = "shopMenuPanel";
            this.shopMenuPanel.Size = new System.Drawing.Size(378, 211);
            this.shopMenuPanel.TabIndex = 7;
            // 
            // shopMenuLabel
            // 
            this.shopMenuLabel.AutoSize = true;
            this.shopMenuLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shopMenuLabel.Location = new System.Drawing.Point(143, 162);
            this.shopMenuLabel.Name = "shopMenuLabel";
            this.shopMenuLabel.Size = new System.Drawing.Size(93, 33);
            this.shopMenuLabel.TabIndex = 6;
            this.shopMenuLabel.Text = "SHOP";
            this.shopMenuLabel.Click += new System.EventHandler(this.OnShopMenuClicked);
            // 
            // shopMenuPictureBox
            // 
            this.shopMenuPictureBox.Image = global::LKSMart.ImagesResource.shop;
            this.shopMenuPictureBox.Location = new System.Drawing.Point(117, 15);
            this.shopMenuPictureBox.Name = "shopMenuPictureBox";
            this.shopMenuPictureBox.Size = new System.Drawing.Size(144, 144);
            this.shopMenuPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.shopMenuPictureBox.TabIndex = 6;
            this.shopMenuPictureBox.TabStop = false;
            this.shopMenuPictureBox.Click += new System.EventHandler(this.OnShopMenuClicked);
            // 
            // profileMenuPanel
            // 
            this.profileMenuPanel.Controls.Add(this.profileMenuLabel);
            this.profileMenuPanel.Controls.Add(this.profileMenuPictureBox);
            this.profileMenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileMenuPanel.Location = new System.Drawing.Point(3, 3);
            this.profileMenuPanel.Name = "profileMenuPanel";
            this.profileMenuPanel.Size = new System.Drawing.Size(378, 211);
            this.profileMenuPanel.TabIndex = 6;
            // 
            // profileMenuLabel
            // 
            this.profileMenuLabel.AutoSize = true;
            this.profileMenuLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileMenuLabel.Location = new System.Drawing.Point(122, 162);
            this.profileMenuLabel.Name = "profileMenuLabel";
            this.profileMenuLabel.Size = new System.Drawing.Size(135, 33);
            this.profileMenuLabel.TabIndex = 6;
            this.profileMenuLabel.Text = "PROFILE";
            this.profileMenuLabel.Click += new System.EventHandler(this.OnProfileMenuClicked);
            // 
            // profileMenuPictureBox
            // 
            this.profileMenuPictureBox.Image = global::LKSMart.ImagesResource.profile;
            this.profileMenuPictureBox.Location = new System.Drawing.Point(117, 15);
            this.profileMenuPictureBox.Name = "profileMenuPictureBox";
            this.profileMenuPictureBox.Size = new System.Drawing.Size(144, 144);
            this.profileMenuPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profileMenuPictureBox.TabIndex = 6;
            this.profileMenuPictureBox.TabStop = false;
            this.profileMenuPictureBox.Click += new System.EventHandler(this.OnProfileMenuClicked);
            // 
            // pointMenuPanel
            // 
            this.pointMenuPanel.Controls.Add(this.pointMenuLabel);
            this.pointMenuPanel.Controls.Add(this.pointMenuPictureBox);
            this.pointMenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pointMenuPanel.Location = new System.Drawing.Point(387, 220);
            this.pointMenuPanel.Name = "pointMenuPanel";
            this.pointMenuPanel.Size = new System.Drawing.Size(378, 211);
            this.pointMenuPanel.TabIndex = 9;
            this.pointMenuPanel.Click += new System.EventHandler(this.OnPointHistoryMenuClicked);
            // 
            // pointMenuLabel
            // 
            this.pointMenuLabel.AutoSize = true;
            this.pointMenuLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointMenuLabel.Location = new System.Drawing.Point(74, 162);
            this.pointMenuLabel.Name = "pointMenuLabel";
            this.pointMenuLabel.Size = new System.Drawing.Size(230, 33);
            this.pointMenuLabel.TabIndex = 6;
            this.pointMenuLabel.Text = "POINT HISTORY";
            this.pointMenuLabel.Click += new System.EventHandler(this.OnPointHistoryMenuClicked);
            // 
            // pointMenuPictureBox
            // 
            this.pointMenuPictureBox.Image = global::LKSMart.ImagesResource.point_history;
            this.pointMenuPictureBox.Location = new System.Drawing.Point(117, 15);
            this.pointMenuPictureBox.Name = "pointMenuPictureBox";
            this.pointMenuPictureBox.Size = new System.Drawing.Size(144, 144);
            this.pointMenuPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pointMenuPictureBox.TabIndex = 6;
            this.pointMenuPictureBox.TabStop = false;
            this.pointMenuPictureBox.Click += new System.EventHandler(this.OnPointHistoryMenuClicked);
            // 
            // cartButton
            // 
            this.cartButton.Image = global::LKSMart.ImagesResource.cart;
            this.cartButton.Location = new System.Drawing.Point(1102, 71);
            this.cartButton.Name = "cartButton";
            this.cartButton.Size = new System.Drawing.Size(64, 64);
            this.cartButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cartButton.TabIndex = 4;
            this.cartButton.TabStop = false;
            this.cartButton.Click += new System.EventHandler(this.OnCartMenuClicked);
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profilePictureBox.Image = global::LKSMart.ImagesResource.default_profile_picture;
            this.profilePictureBox.Location = new System.Drawing.Point(12, 12);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(180, 180);
            this.profilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePictureBox.TabIndex = 0;
            this.profilePictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 644);
            this.Controls.Add(this.menusPanel);
            this.Controls.Add(this.cartButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.liveDateTimeLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.profilePictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "LKSMart";
            this.Load += new System.EventHandler(this.OnLoad);
            this.menusPanel.ResumeLayout(false);
            this.transactionHistoryMenuPanel.ResumeLayout(false);
            this.transactionHistoryMenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionHistoryMenuPictureBox)).EndInit();
            this.shopMenuPanel.ResumeLayout(false);
            this.shopMenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shopMenuPictureBox)).EndInit();
            this.profileMenuPanel.ResumeLayout(false);
            this.profileMenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileMenuPictureBox)).EndInit();
            this.pointMenuPanel.ResumeLayout(false);
            this.pointMenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pointMenuPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label liveDateTimeLabel;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.PictureBox cartButton;
        private System.Windows.Forms.TableLayoutPanel menusPanel;
        private System.Windows.Forms.Panel profileMenuPanel;
        private System.Windows.Forms.Label profileMenuLabel;
        private System.Windows.Forms.PictureBox profileMenuPictureBox;
        private System.Windows.Forms.Panel transactionHistoryMenuPanel;
        private System.Windows.Forms.Label transactionHistoryMenuLabel;
        private System.Windows.Forms.PictureBox transactionHistoryMenuPictureBox;
        private System.Windows.Forms.Panel shopMenuPanel;
        private System.Windows.Forms.Label shopMenuLabel;
        private System.Windows.Forms.PictureBox shopMenuPictureBox;
        private System.Windows.Forms.Panel pointMenuPanel;
        private System.Windows.Forms.Label pointMenuLabel;
        private System.Windows.Forms.PictureBox pointMenuPictureBox;
    }
}