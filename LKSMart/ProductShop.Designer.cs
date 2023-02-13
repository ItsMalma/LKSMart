namespace LKSMart
{
    partial class ProductShop
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.productImage = new System.Windows.Forms.PictureBox();
            this.descriptionPanel = new System.Windows.Forms.TableLayoutPanel();
            this.productPrice = new System.Windows.Forms.Label();
            this.productStock = new System.Windows.Forms.Label();
            this.productName = new System.Windows.Forms.Label();
            this.addToCartButton = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productImage)).BeginInit();
            this.descriptionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.ColumnCount = 3;
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainPanel.Controls.Add(this.productImage, 0, 0);
            this.mainPanel.Controls.Add(this.descriptionPanel, 1, 0);
            this.mainPanel.Controls.Add(this.addToCartButton, 2, 0);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.RowCount = 1;
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainPanel.Size = new System.Drawing.Size(998, 98);
            this.mainPanel.TabIndex = 1;
            // 
            // productImage
            // 
            this.productImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productImage.Image = global::LKSMart.ImagesResource.not_available;
            this.productImage.Location = new System.Drawing.Point(3, 3);
            this.productImage.Name = "productImage";
            this.productImage.Size = new System.Drawing.Size(94, 92);
            this.productImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.productImage.TabIndex = 0;
            this.productImage.TabStop = false;
            // 
            // descriptionPanel
            // 
            this.descriptionPanel.ColumnCount = 1;
            this.descriptionPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.descriptionPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.descriptionPanel.Controls.Add(this.productPrice, 0, 2);
            this.descriptionPanel.Controls.Add(this.productStock, 0, 1);
            this.descriptionPanel.Controls.Add(this.productName, 0, 0);
            this.descriptionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionPanel.Location = new System.Drawing.Point(103, 3);
            this.descriptionPanel.Name = "descriptionPanel";
            this.descriptionPanel.RowCount = 3;
            this.descriptionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.descriptionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.descriptionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.descriptionPanel.Size = new System.Drawing.Size(667, 92);
            this.descriptionPanel.TabIndex = 1;
            // 
            // productPrice
            // 
            this.productPrice.AutoSize = true;
            this.productPrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productPrice.Location = new System.Drawing.Point(3, 60);
            this.productPrice.Name = "productPrice";
            this.productPrice.Size = new System.Drawing.Size(157, 27);
            this.productPrice.TabIndex = 2;
            this.productPrice.Text = "Product Price";
            // 
            // productStock
            // 
            this.productStock.AutoSize = true;
            this.productStock.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productStock.Location = new System.Drawing.Point(3, 30);
            this.productStock.Name = "productStock";
            this.productStock.Size = new System.Drawing.Size(134, 23);
            this.productStock.TabIndex = 1;
            this.productStock.Text = "Product Stock";
            // 
            // productName
            // 
            this.productName.AutoSize = true;
            this.productName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productName.Location = new System.Drawing.Point(3, 0);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(166, 27);
            this.productName.TabIndex = 0;
            this.productName.Text = "Product Name";
            // 
            // addToCartButton
            // 
            this.addToCartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.addToCartButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.addToCartButton.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToCartButton.Location = new System.Drawing.Point(776, 22);
            this.addToCartButton.Name = "addToCartButton";
            this.addToCartButton.Size = new System.Drawing.Size(219, 54);
            this.addToCartButton.TabIndex = 2;
            this.addToCartButton.Text = "ADD TO CART";
            this.addToCartButton.UseVisualStyleBackColor = false;
            this.addToCartButton.Click += new System.EventHandler(this.OnAddToCart);
            // 
            // ProductShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.mainPanel);
            this.Name = "ProductShop";
            this.Size = new System.Drawing.Size(998, 98);
            this.Load += new System.EventHandler(this.OnLoad);
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productImage)).EndInit();
            this.descriptionPanel.ResumeLayout(false);
            this.descriptionPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainPanel;
        private System.Windows.Forms.PictureBox productImage;
        private System.Windows.Forms.TableLayoutPanel descriptionPanel;
        private System.Windows.Forms.Label productPrice;
        private System.Windows.Forms.Label productStock;
        private System.Windows.Forms.Label productName;
        private System.Windows.Forms.Button addToCartButton;
    }
}
