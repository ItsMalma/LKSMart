namespace LKSMart
{
    partial class AddToCartForm
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
            this.productName = new System.Windows.Forms.Label();
            this.productPrice = new System.Windows.Forms.Label();
            this.productTotal = new System.Windows.Forms.NumericUpDown();
            this.submitButton = new System.Windows.Forms.Button();
            this.productImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.productTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productImage)).BeginInit();
            this.SuspendLayout();
            // 
            // productNameLabel
            // 
            this.productName.AutoSize = true;
            this.productName.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productName.Location = new System.Drawing.Point(12, 415);
            this.productName.Name = "productNameLabel";
            this.productName.Size = new System.Drawing.Size(289, 46);
            this.productName.TabIndex = 0;
            this.productName.Text = "Product Name";
            // 
            // productPrice
            // 
            this.productPrice.AutoSize = true;
            this.productPrice.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productPrice.Location = new System.Drawing.Point(14, 461);
            this.productPrice.Name = "productPrice";
            this.productPrice.Size = new System.Drawing.Size(182, 32);
            this.productPrice.TabIndex = 2;
            this.productPrice.Text = "Product Price";
            // 
            // productTotal
            // 
            this.productTotal.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productTotal.Location = new System.Drawing.Point(422, 12);
            this.productTotal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.productTotal.Name = "productTotal";
            this.productTotal.Size = new System.Drawing.Size(244, 40);
            this.productTotal.TabIndex = 3;
            this.productTotal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.Lime;
            this.submitButton.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.ForeColor = System.Drawing.Color.White;
            this.submitButton.Location = new System.Drawing.Point(422, 58);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(175, 51);
            this.submitButton.TabIndex = 4;
            this.submitButton.Text = "SUBMIT";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.OnSubmit);
            // 
            // productImage
            // 
            this.productImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productImage.Image = global::LKSMart.ImagesResource.not_available;
            this.productImage.Location = new System.Drawing.Point(16, 12);
            this.productImage.Name = "productImage";
            this.productImage.Size = new System.Drawing.Size(400, 400);
            this.productImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.productImage.TabIndex = 1;
            this.productImage.TabStop = false;
            // 
            // AddToCartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 498);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.productTotal);
            this.Controls.Add(this.productPrice);
            this.Controls.Add(this.productImage);
            this.Controls.Add(this.productName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddToCartForm";
            this.Text = "LKSMart - Add To Cart";
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.productTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label productName;
        private System.Windows.Forms.PictureBox productImage;
        private System.Windows.Forms.Label productPrice;
        private System.Windows.Forms.NumericUpDown productTotal;
        private System.Windows.Forms.Button submitButton;
    }
}