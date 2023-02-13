namespace LKSMart
{
    partial class TransactionHistoryForm
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
            this.transactionHistoryLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.productsPanel = new System.Windows.Forms.Panel();
            this.productsLabel = new System.Windows.Forms.Label();
            this.transactionsPanel = new System.Windows.Forms.Panel();
            this.transactionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // transactionHistoryLabel
            // 
            this.transactionHistoryLabel.AutoSize = true;
            this.transactionHistoryLabel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionHistoryLabel.Location = new System.Drawing.Point(12, 17);
            this.transactionHistoryLabel.Name = "transactionHistoryLabel";
            this.transactionHistoryLabel.Size = new System.Drawing.Size(389, 37);
            this.transactionHistoryLabel.TabIndex = 1;
            this.transactionHistoryLabel.Text = "TRANSACTION HISTORY";
            this.transactionHistoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Red;
            this.backButton.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(1039, 9);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(127, 53);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.OnBack);
            // 
            // productsPanel
            // 
            this.productsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productsPanel.AutoScroll = true;
            this.productsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productsPanel.Location = new System.Drawing.Point(12, 413);
            this.productsPanel.Name = "productsPanel";
            this.productsPanel.Size = new System.Drawing.Size(1147, 219);
            this.productsPanel.TabIndex = 14;
            // 
            // productsLabel
            // 
            this.productsLabel.AutoSize = true;
            this.productsLabel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsLabel.Location = new System.Drawing.Point(13, 374);
            this.productsLabel.Name = "productsLabel";
            this.productsLabel.Size = new System.Drawing.Size(634, 36);
            this.productsLabel.TabIndex = 15;
            this.productsLabel.Text = "Products bought for the selected transaction";
            // 
            // transactionsPanel
            // 
            this.transactionsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.transactionsPanel.AutoScroll = true;
            this.transactionsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.transactionsPanel.Location = new System.Drawing.Point(16, 141);
            this.transactionsPanel.Name = "transactionsPanel";
            this.transactionsPanel.Size = new System.Drawing.Size(1147, 230);
            this.transactionsPanel.TabIndex = 16;
            // 
            // transactionLabel
            // 
            this.transactionLabel.AutoSize = true;
            this.transactionLabel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionLabel.Location = new System.Drawing.Point(13, 102);
            this.transactionLabel.Name = "transactionLabel";
            this.transactionLabel.Size = new System.Drawing.Size(179, 36);
            this.transactionLabel.TabIndex = 17;
            this.transactionLabel.Text = "Transaction";
            // 
            // TransactionHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1178, 644);
            this.Controls.Add(this.transactionLabel);
            this.Controls.Add(this.transactionsPanel);
            this.Controls.Add(this.productsLabel);
            this.Controls.Add(this.productsPanel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.transactionHistoryLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TransactionHistoryForm";
            this.Text = "LKSMart - Transaction History";
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label transactionHistoryLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Panel productsPanel;
        private System.Windows.Forms.Label productsLabel;
        private System.Windows.Forms.Panel transactionsPanel;
        private System.Windows.Forms.Label transactionLabel;
    }
}