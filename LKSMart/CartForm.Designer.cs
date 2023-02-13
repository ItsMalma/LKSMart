namespace LKSMart
{
    partial class CartForm
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
            this.submitButton = new System.Windows.Forms.Button();
            this.totalPanel = new System.Windows.Forms.TableLayoutPanel();
            this.amountToPayValue = new System.Windows.Forms.Label();
            this.amountToPayLabel = new System.Windows.Forms.Label();
            this.description2Divider = new System.Windows.Forms.Label();
            this.description2Panel = new System.Windows.Forms.TableLayoutPanel();
            this.availablePointValue = new System.Windows.Forms.Label();
            this.availablePointLabel = new System.Windows.Forms.Label();
            this.totalValue = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.description1Divider = new System.Windows.Forms.Label();
            this.description1Panel = new System.Windows.Forms.TableLayoutPanel();
            this.platformFeeValue = new System.Windows.Forms.Label();
            this.platformFeeLabel = new System.Windows.Forms.Label();
            this.subTotalValue = new System.Windows.Forms.Label();
            this.subTotalLabel = new System.Windows.Forms.Label();
            this.usePointCheckbox = new System.Windows.Forms.CheckBox();
            this.paymentTypeComboBox = new System.Windows.Forms.ComboBox();
            this.backButton = new System.Windows.Forms.Button();
            this.cartLabel = new System.Windows.Forms.Label();
            this.paymentTypeLabel = new System.Windows.Forms.Label();
            this.productsPanel = new System.Windows.Forms.Panel();
            this.totalPanel.SuspendLayout();
            this.description2Panel.SuspendLayout();
            this.description1Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.Lime;
            this.submitButton.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.ForeColor = System.Drawing.Color.White;
            this.submitButton.Location = new System.Drawing.Point(467, 820);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(256, 60);
            this.submitButton.TabIndex = 49;
            this.submitButton.Text = "SUBMIT";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.OnSubmit);
            // 
            // totalPanel
            // 
            this.totalPanel.ColumnCount = 2;
            this.totalPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.totalPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.totalPanel.Controls.Add(this.amountToPayValue, 0, 0);
            this.totalPanel.Controls.Add(this.amountToPayLabel, 0, 0);
            this.totalPanel.Location = new System.Drawing.Point(25, 738);
            this.totalPanel.Name = "totalPanel";
            this.totalPanel.RowCount = 1;
            this.totalPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.totalPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.totalPanel.Size = new System.Drawing.Size(1115, 51);
            this.totalPanel.TabIndex = 48;
            // 
            // amountToPayValue
            // 
            this.amountToPayValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.amountToPayValue.AutoSize = true;
            this.amountToPayValue.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountToPayValue.Location = new System.Drawing.Point(560, 9);
            this.amountToPayValue.Name = "amountToPayValue";
            this.amountToPayValue.Size = new System.Drawing.Size(552, 32);
            this.amountToPayValue.TabIndex = 4;
            this.amountToPayValue.Text = "Amount To Pay";
            // 
            // amountToPayLabel
            // 
            this.amountToPayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.amountToPayLabel.AutoSize = true;
            this.amountToPayLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountToPayLabel.Location = new System.Drawing.Point(3, 9);
            this.amountToPayLabel.Name = "amountToPayLabel";
            this.amountToPayLabel.Size = new System.Drawing.Size(551, 32);
            this.amountToPayLabel.TabIndex = 3;
            this.amountToPayLabel.Text = "Amount To Pay";
            // 
            // description2Divider
            // 
            this.description2Divider.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.description2Divider.Location = new System.Drawing.Point(22, 722);
            this.description2Divider.Name = "description2Divider";
            this.description2Divider.Size = new System.Drawing.Size(1115, 2);
            this.description2Divider.TabIndex = 47;
            // 
            // description2Panel
            // 
            this.description2Panel.ColumnCount = 2;
            this.description2Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.description2Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.description2Panel.Controls.Add(this.availablePointValue, 1, 1);
            this.description2Panel.Controls.Add(this.availablePointLabel, 0, 1);
            this.description2Panel.Controls.Add(this.totalValue, 1, 0);
            this.description2Panel.Controls.Add(this.totalLabel, 0, 0);
            this.description2Panel.Location = new System.Drawing.Point(24, 595);
            this.description2Panel.Name = "description2Panel";
            this.description2Panel.RowCount = 2;
            this.description2Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.description2Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.description2Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.description2Panel.Size = new System.Drawing.Size(1115, 114);
            this.description2Panel.TabIndex = 46;
            // 
            // availablePointValue
            // 
            this.availablePointValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.availablePointValue.AutoSize = true;
            this.availablePointValue.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availablePointValue.Location = new System.Drawing.Point(560, 69);
            this.availablePointValue.Name = "availablePointValue";
            this.availablePointValue.Size = new System.Drawing.Size(552, 32);
            this.availablePointValue.TabIndex = 27;
            this.availablePointValue.Text = "Available Point";
            // 
            // availablePointLabel
            // 
            this.availablePointLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.availablePointLabel.AutoSize = true;
            this.availablePointLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availablePointLabel.Location = new System.Drawing.Point(3, 69);
            this.availablePointLabel.Name = "availablePointLabel";
            this.availablePointLabel.Size = new System.Drawing.Size(551, 32);
            this.availablePointLabel.TabIndex = 26;
            this.availablePointLabel.Text = "Available Point";
            // 
            // totalValue
            // 
            this.totalValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.totalValue.AutoSize = true;
            this.totalValue.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalValue.Location = new System.Drawing.Point(560, 12);
            this.totalValue.Name = "totalValue";
            this.totalValue.Size = new System.Drawing.Size(552, 32);
            this.totalValue.TabIndex = 25;
            this.totalValue.Text = "Total";
            // 
            // totalLabel
            // 
            this.totalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(3, 12);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(551, 32);
            this.totalLabel.TabIndex = 2;
            this.totalLabel.Text = "Total";
            // 
            // description1Divider
            // 
            this.description1Divider.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.description1Divider.Location = new System.Drawing.Point(21, 577);
            this.description1Divider.Name = "description1Divider";
            this.description1Divider.Size = new System.Drawing.Size(1115, 2);
            this.description1Divider.TabIndex = 45;
            // 
            // description1Panel
            // 
            this.description1Panel.ColumnCount = 2;
            this.description1Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.description1Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.description1Panel.Controls.Add(this.platformFeeValue, 1, 1);
            this.description1Panel.Controls.Add(this.platformFeeLabel, 0, 1);
            this.description1Panel.Controls.Add(this.subTotalValue, 1, 0);
            this.description1Panel.Controls.Add(this.subTotalLabel, 0, 0);
            this.description1Panel.Location = new System.Drawing.Point(23, 450);
            this.description1Panel.Name = "description1Panel";
            this.description1Panel.RowCount = 2;
            this.description1Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.description1Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.description1Panel.Size = new System.Drawing.Size(1115, 114);
            this.description1Panel.TabIndex = 44;
            // 
            // platformFeeValue
            // 
            this.platformFeeValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.platformFeeValue.AutoSize = true;
            this.platformFeeValue.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.platformFeeValue.Location = new System.Drawing.Point(560, 69);
            this.platformFeeValue.Name = "platformFeeValue";
            this.platformFeeValue.Size = new System.Drawing.Size(552, 32);
            this.platformFeeValue.TabIndex = 3;
            this.platformFeeValue.Text = "5%";
            // 
            // platformFeeLabel
            // 
            this.platformFeeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.platformFeeLabel.AutoSize = true;
            this.platformFeeLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.platformFeeLabel.Location = new System.Drawing.Point(3, 69);
            this.platformFeeLabel.Name = "platformFeeLabel";
            this.platformFeeLabel.Size = new System.Drawing.Size(551, 32);
            this.platformFeeLabel.TabIndex = 2;
            this.platformFeeLabel.Text = "5% Platform Fee";
            // 
            // subTotalValue
            // 
            this.subTotalValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.subTotalValue.AutoSize = true;
            this.subTotalValue.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalValue.Location = new System.Drawing.Point(560, 12);
            this.subTotalValue.Name = "subTotalValue";
            this.subTotalValue.Size = new System.Drawing.Size(552, 32);
            this.subTotalValue.TabIndex = 1;
            this.subTotalValue.Text = "Sub-Total";
            // 
            // subTotalLabel
            // 
            this.subTotalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.subTotalLabel.AutoSize = true;
            this.subTotalLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalLabel.Location = new System.Drawing.Point(3, 12);
            this.subTotalLabel.Name = "subTotalLabel";
            this.subTotalLabel.Size = new System.Drawing.Size(551, 32);
            this.subTotalLabel.TabIndex = 0;
            this.subTotalLabel.Text = "Sub-Total";
            // 
            // usePointCheckbox
            // 
            this.usePointCheckbox.AutoSize = true;
            this.usePointCheckbox.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usePointCheckbox.Location = new System.Drawing.Point(25, 408);
            this.usePointCheckbox.Name = "usePointCheckbox";
            this.usePointCheckbox.Size = new System.Drawing.Size(347, 36);
            this.usePointCheckbox.TabIndex = 43;
            this.usePointCheckbox.Text = "Pay using available point";
            this.usePointCheckbox.UseVisualStyleBackColor = true;
            this.usePointCheckbox.CheckedChanged += new System.EventHandler(this.OnUseAvailablePointChanged);
            // 
            // paymentTypeComboBox
            // 
            this.paymentTypeComboBox.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentTypeComboBox.FormattingEnabled = true;
            this.paymentTypeComboBox.Location = new System.Drawing.Point(25, 359);
            this.paymentTypeComboBox.Name = "paymentTypeComboBox";
            this.paymentTypeComboBox.Size = new System.Drawing.Size(330, 40);
            this.paymentTypeComboBox.TabIndex = 42;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Red;
            this.backButton.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(1044, 15);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(127, 53);
            this.backButton.TabIndex = 40;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.OnBack);
            // 
            // cartLabel
            // 
            this.cartLabel.AutoSize = true;
            this.cartLabel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartLabel.Location = new System.Drawing.Point(8, 23);
            this.cartLabel.Name = "cartLabel";
            this.cartLabel.Size = new System.Drawing.Size(105, 37);
            this.cartLabel.TabIndex = 39;
            this.cartLabel.Text = "CART";
            this.cartLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // paymentTypeLabel
            // 
            this.paymentTypeLabel.AutoSize = true;
            this.paymentTypeLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentTypeLabel.Location = new System.Drawing.Point(19, 324);
            this.paymentTypeLabel.Name = "paymentTypeLabel";
            this.paymentTypeLabel.Size = new System.Drawing.Size(189, 32);
            this.paymentTypeLabel.TabIndex = 50;
            this.paymentTypeLabel.Text = "Payment Type";
            // 
            // productsPanel
            // 
            this.productsPanel.AutoScroll = true;
            this.productsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productsPanel.Location = new System.Drawing.Point(15, 83);
            this.productsPanel.Name = "productsPanel";
            this.productsPanel.Size = new System.Drawing.Size(1151, 227);
            this.productsPanel.TabIndex = 51;
            // 
            // CartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1178, 894);
            this.Controls.Add(this.productsPanel);
            this.Controls.Add(this.paymentTypeLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.totalPanel);
            this.Controls.Add(this.description2Divider);
            this.Controls.Add(this.description2Panel);
            this.Controls.Add(this.description1Divider);
            this.Controls.Add(this.description1Panel);
            this.Controls.Add(this.usePointCheckbox);
            this.Controls.Add(this.paymentTypeComboBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.cartLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CartForm";
            this.Text = "LKSMart - Cart";
            this.Load += new System.EventHandler(this.OnLoad);
            this.totalPanel.ResumeLayout(false);
            this.totalPanel.PerformLayout();
            this.description2Panel.ResumeLayout(false);
            this.description2Panel.PerformLayout();
            this.description1Panel.ResumeLayout(false);
            this.description1Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TableLayoutPanel totalPanel;
        private System.Windows.Forms.Label amountToPayValue;
        private System.Windows.Forms.Label amountToPayLabel;
        private System.Windows.Forms.Label description2Divider;
        private System.Windows.Forms.TableLayoutPanel description2Panel;
        private System.Windows.Forms.Label availablePointValue;
        private System.Windows.Forms.Label availablePointLabel;
        private System.Windows.Forms.Label totalValue;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label description1Divider;
        private System.Windows.Forms.TableLayoutPanel description1Panel;
        private System.Windows.Forms.Label platformFeeValue;
        private System.Windows.Forms.Label platformFeeLabel;
        private System.Windows.Forms.Label subTotalValue;
        private System.Windows.Forms.Label subTotalLabel;
        private System.Windows.Forms.CheckBox usePointCheckbox;
        private System.Windows.Forms.ComboBox paymentTypeComboBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label cartLabel;
        private System.Windows.Forms.Label paymentTypeLabel;
        private System.Windows.Forms.Panel productsPanel;
    }
}