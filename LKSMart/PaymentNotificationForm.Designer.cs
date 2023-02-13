namespace LKSMart
{
    partial class PaymentNotificationForm
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
            this.notificationLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.paymentCodeLabel = new System.Windows.Forms.Label();
            this.description2 = new System.Windows.Forms.Label();
            this.description1 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notificationLabel
            // 
            this.notificationLabel.AutoSize = true;
            this.notificationLabel.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notificationLabel.Location = new System.Drawing.Point(192, 9);
            this.notificationLabel.Name = "notificationLabel";
            this.notificationLabel.Size = new System.Drawing.Size(295, 46);
            this.notificationLabel.TabIndex = 1;
            this.notificationLabel.Text = "NOTIFICATION";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.paymentCodeLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.description2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.description1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 58);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(654, 366);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // paymentCodeLabel
            // 
            this.paymentCodeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.paymentCodeLabel.AutoSize = true;
            this.paymentCodeLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentCodeLabel.Location = new System.Drawing.Point(3, 294);
            this.paymentCodeLabel.Name = "paymentCodeLabel";
            this.paymentCodeLabel.Size = new System.Drawing.Size(648, 33);
            this.paymentCodeLabel.TabIndex = 2;
            this.paymentCodeLabel.Text = "Payment Code";
            this.paymentCodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // description2
            // 
            this.description2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.description2.AutoSize = true;
            this.description2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description2.Location = new System.Drawing.Point(3, 221);
            this.description2.Name = "description2";
            this.description2.Size = new System.Drawing.Size(648, 32);
            this.description2.TabIndex = 1;
            this.description2.Text = "Please input this code for the payment process:";
            this.description2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // description1
            // 
            this.description1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.description1.AutoSize = true;
            this.description1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description1.Location = new System.Drawing.Point(3, 93);
            this.description1.Name = "description1";
            this.description1.Size = new System.Drawing.Size(648, 32);
            this.description1.TabIndex = 0;
            this.description1.Text = "Are you sure?";
            this.description1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.Color.Lime;
            this.okButton.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.ForeColor = System.Drawing.Color.White;
            this.okButton.Location = new System.Drawing.Point(279, 430);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(121, 56);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.OnOK);
            // 
            // PaymentNotificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(678, 498);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.notificationLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PaymentNotificationForm";
            this.Text = "LKSMart - Payment Notification";
            this.Load += new System.EventHandler(this.OnLoad);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label notificationLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label paymentCodeLabel;
        private System.Windows.Forms.Label description2;
        private System.Windows.Forms.Label description1;
        private System.Windows.Forms.Button okButton;
    }
}