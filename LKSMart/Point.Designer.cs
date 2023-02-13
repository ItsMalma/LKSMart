namespace LKSMart
{
    partial class Point
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
            this.pointAfter = new System.Windows.Forms.Label();
            this.pointBefore = new System.Windows.Forms.Label();
            this.pointGain = new System.Windows.Forms.Label();
            this.paymentCode = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.ColumnCount = 5;
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mainPanel.Controls.Add(this.pointAfter, 4, 0);
            this.mainPanel.Controls.Add(this.pointBefore, 3, 0);
            this.mainPanel.Controls.Add(this.pointGain, 2, 0);
            this.mainPanel.Controls.Add(this.paymentCode, 1, 0);
            this.mainPanel.Controls.Add(this.date, 0, 0);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.RowCount = 1;
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.mainPanel.Size = new System.Drawing.Size(996, 96);
            this.mainPanel.TabIndex = 0;
            // 
            // pointAfter
            // 
            this.pointAfter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pointAfter.AutoSize = true;
            this.pointAfter.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointAfter.Location = new System.Drawing.Point(799, 32);
            this.pointAfter.Name = "pointAfter";
            this.pointAfter.Size = new System.Drawing.Size(194, 32);
            this.pointAfter.TabIndex = 4;
            this.pointAfter.Text = "Point After";
            this.pointAfter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pointBefore
            // 
            this.pointBefore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pointBefore.AutoSize = true;
            this.pointBefore.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointBefore.Location = new System.Drawing.Point(600, 32);
            this.pointBefore.Name = "pointBefore";
            this.pointBefore.Size = new System.Drawing.Size(193, 32);
            this.pointBefore.TabIndex = 3;
            this.pointBefore.Text = "Point Before";
            this.pointBefore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pointGain
            // 
            this.pointGain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pointGain.AutoSize = true;
            this.pointGain.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointGain.Location = new System.Drawing.Point(401, 32);
            this.pointGain.Name = "pointGain";
            this.pointGain.Size = new System.Drawing.Size(193, 32);
            this.pointGain.TabIndex = 2;
            this.pointGain.Text = "Point Gain";
            this.pointGain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // paymentCode
            // 
            this.paymentCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.paymentCode.AutoSize = true;
            this.paymentCode.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentCode.Location = new System.Drawing.Point(202, 16);
            this.paymentCode.Name = "paymentCode";
            this.paymentCode.Size = new System.Drawing.Size(193, 64);
            this.paymentCode.TabIndex = 1;
            this.paymentCode.Text = "Payment Code";
            this.paymentCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // date
            // 
            this.date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(3, 32);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(193, 32);
            this.date.TabIndex = 0;
            this.date.Text = "Date";
            this.date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Point
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.mainPanel);
            this.Name = "Point";
            this.Size = new System.Drawing.Size(996, 96);
            this.Load += new System.EventHandler(this.OnLoad);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainPanel;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label pointAfter;
        private System.Windows.Forms.Label pointBefore;
        private System.Windows.Forms.Label pointGain;
        private System.Windows.Forms.Label paymentCode;
    }
}
