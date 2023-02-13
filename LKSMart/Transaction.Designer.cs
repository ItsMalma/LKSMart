namespace LKSMart
{
    partial class Transaction
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
            this.paymentCode = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.totalPayment = new System.Windows.Forms.Label();
            this.pointGainOrDeducted = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.ColumnCount = 4;
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainPanel.Controls.Add(this.paymentCode, 3, 0);
            this.mainPanel.Controls.Add(this.date, 0, 0);
            this.mainPanel.Controls.Add(this.totalPayment, 1, 0);
            this.mainPanel.Controls.Add(this.pointGainOrDeducted, 2, 0);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.RowCount = 1;
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainPanel.Size = new System.Drawing.Size(996, 96);
            this.mainPanel.TabIndex = 1;
            this.mainPanel.Click += new System.EventHandler(this.OnClick);
            // 
            // paymentCode
            // 
            this.paymentCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.paymentCode.AutoSize = true;
            this.paymentCode.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentCode.Location = new System.Drawing.Point(750, 32);
            this.paymentCode.Name = "paymentCode";
            this.paymentCode.Size = new System.Drawing.Size(243, 32);
            this.paymentCode.TabIndex = 4;
            this.paymentCode.Text = "Payment Code";
            this.paymentCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.paymentCode.Click += new System.EventHandler(this.OnClick);
            // 
            // date
            // 
            this.date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(3, 32);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(243, 32);
            this.date.TabIndex = 1;
            this.date.Text = "Date";
            this.date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.date.Click += new System.EventHandler(this.OnClick);
            // 
            // totalPayment
            // 
            this.totalPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.totalPayment.AutoSize = true;
            this.totalPayment.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPayment.Location = new System.Drawing.Point(252, 32);
            this.totalPayment.Name = "totalPayment";
            this.totalPayment.Size = new System.Drawing.Size(243, 32);
            this.totalPayment.TabIndex = 3;
            this.totalPayment.Text = "Total Payment";
            this.totalPayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.totalPayment.Click += new System.EventHandler(this.OnClick);
            // 
            // pointGainOrDeducted
            // 
            this.pointGainOrDeducted.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pointGainOrDeducted.AutoSize = true;
            this.pointGainOrDeducted.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointGainOrDeducted.Location = new System.Drawing.Point(501, 16);
            this.pointGainOrDeducted.Name = "pointGainOrDeducted";
            this.pointGainOrDeducted.Size = new System.Drawing.Size(243, 64);
            this.pointGainOrDeducted.TabIndex = 2;
            this.pointGainOrDeducted.Text = "Point Gain / Deducted";
            this.pointGainOrDeducted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pointGainOrDeducted.Click += new System.EventHandler(this.OnClick);
            // 
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.mainPanel);
            this.Name = "Transaction";
            this.Size = new System.Drawing.Size(996, 96);
            this.Load += new System.EventHandler(this.OnLoad);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainPanel;
        private System.Windows.Forms.Label paymentCode;
        private System.Windows.Forms.Label totalPayment;
        private System.Windows.Forms.Label pointGainOrDeducted;
        private System.Windows.Forms.Label date;
    }
}
