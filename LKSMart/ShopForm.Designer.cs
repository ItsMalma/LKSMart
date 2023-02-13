namespace LKSMart
{
    partial class ShopForm
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
            this.components = new System.ComponentModel.Container();
            this.shopLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.keywordLabel = new System.Windows.Forms.Label();
            this.keywordTextBox = new System.Windows.Forms.TextBox();
            this.priceRangeLabel = new System.Windows.Forms.Label();
            this.minimumPriceRangeTextBox = new System.Windows.Forms.TextBox();
            this.maximumPriceRangeTextBox = new System.Windows.Forms.TextBox();
            this.priceRangeToLabel = new System.Windows.Forms.Label();
            this.productsPanel = new System.Windows.Forms.Panel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // shopLabel
            // 
            this.shopLabel.AutoSize = true;
            this.shopLabel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shopLabel.Location = new System.Drawing.Point(12, 9);
            this.shopLabel.Name = "shopLabel";
            this.shopLabel.Size = new System.Drawing.Size(104, 37);
            this.shopLabel.TabIndex = 1;
            this.shopLabel.Text = "SHOP";
            this.shopLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Red;
            this.backButton.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(1039, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(127, 53);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.OnBack);
            // 
            // keywordLabel
            // 
            this.keywordLabel.AutoSize = true;
            this.keywordLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keywordLabel.Location = new System.Drawing.Point(13, 84);
            this.keywordLabel.Name = "keywordLabel";
            this.keywordLabel.Size = new System.Drawing.Size(120, 32);
            this.keywordLabel.TabIndex = 6;
            this.keywordLabel.Text = "Keyword";
            // 
            // keywordTextBox
            // 
            this.keywordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.keywordTextBox.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keywordTextBox.Location = new System.Drawing.Point(139, 81);
            this.keywordTextBox.Name = "keywordTextBox";
            this.keywordTextBox.Size = new System.Drawing.Size(1027, 40);
            this.keywordTextBox.TabIndex = 7;
            this.keywordTextBox.TextChanged += new System.EventHandler(this.OnKeywordChanged);
            // 
            // priceRangeLabel
            // 
            this.priceRangeLabel.AutoSize = true;
            this.priceRangeLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceRangeLabel.Location = new System.Drawing.Point(13, 137);
            this.priceRangeLabel.Name = "priceRangeLabel";
            this.priceRangeLabel.Size = new System.Drawing.Size(167, 32);
            this.priceRangeLabel.TabIndex = 8;
            this.priceRangeLabel.Text = "Price Range";
            // 
            // minimumPriceRangeTextBox
            // 
            this.minimumPriceRangeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.minimumPriceRangeTextBox.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimumPriceRangeTextBox.Location = new System.Drawing.Point(186, 134);
            this.minimumPriceRangeTextBox.Name = "minimumPriceRangeTextBox";
            this.minimumPriceRangeTextBox.Size = new System.Drawing.Size(219, 40);
            this.minimumPriceRangeTextBox.TabIndex = 9;
            this.minimumPriceRangeTextBox.Text = "0";
            this.minimumPriceRangeTextBox.TextChanged += new System.EventHandler(this.OnPriceRangeChanged);
            this.minimumPriceRangeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnPriceRangePressed);
            // 
            // maximumPriceRangeTextBox
            // 
            this.maximumPriceRangeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maximumPriceRangeTextBox.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maximumPriceRangeTextBox.Location = new System.Drawing.Point(440, 134);
            this.maximumPriceRangeTextBox.Name = "maximumPriceRangeTextBox";
            this.maximumPriceRangeTextBox.Size = new System.Drawing.Size(219, 40);
            this.maximumPriceRangeTextBox.TabIndex = 10;
            this.maximumPriceRangeTextBox.Text = "0";
            this.maximumPriceRangeTextBox.TextChanged += new System.EventHandler(this.OnPriceRangeChanged);
            this.maximumPriceRangeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnPriceRangePressed);
            // 
            // priceRangeToLabel
            // 
            this.priceRangeToLabel.AutoSize = true;
            this.priceRangeToLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceRangeToLabel.Location = new System.Drawing.Point(411, 137);
            this.priceRangeToLabel.Name = "priceRangeToLabel";
            this.priceRangeToLabel.Size = new System.Drawing.Size(23, 32);
            this.priceRangeToLabel.TabIndex = 11;
            this.priceRangeToLabel.Text = "-";
            // 
            // productsPanel
            // 
            this.productsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productsPanel.AutoScroll = true;
            this.productsPanel.Location = new System.Drawing.Point(19, 191);
            this.productsPanel.Name = "productsPanel";
            this.productsPanel.Size = new System.Drawing.Size(1147, 505);
            this.productsPanel.TabIndex = 12;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1178, 744);
            this.Controls.Add(this.productsPanel);
            this.Controls.Add(this.priceRangeToLabel);
            this.Controls.Add(this.maximumPriceRangeTextBox);
            this.Controls.Add(this.minimumPriceRangeTextBox);
            this.Controls.Add(this.priceRangeLabel);
            this.Controls.Add(this.keywordTextBox);
            this.Controls.Add(this.keywordLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.shopLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShopForm";
            this.Text = "LKSMart - Shop";
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label shopLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label keywordLabel;
        private System.Windows.Forms.TextBox keywordTextBox;
        private System.Windows.Forms.Label priceRangeLabel;
        private System.Windows.Forms.TextBox minimumPriceRangeTextBox;
        private System.Windows.Forms.TextBox maximumPriceRangeTextBox;
        private System.Windows.Forms.Label priceRangeToLabel;
        private System.Windows.Forms.Panel productsPanel;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}