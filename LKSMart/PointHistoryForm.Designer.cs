namespace LKSMart
{
    partial class PointHistoryForm
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
            this.backButton = new System.Windows.Forms.Button();
            this.transactionHistoryLabel = new System.Windows.Forms.Label();
            this.currentPointLabel = new System.Windows.Forms.Label();
            this.currentPoint = new System.Windows.Forms.Label();
            this.pointsPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Red;
            this.backButton.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(1039, 9);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(127, 53);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.OnBack);
            // 
            // transactionHistoryLabel
            // 
            this.transactionHistoryLabel.AutoSize = true;
            this.transactionHistoryLabel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionHistoryLabel.Location = new System.Drawing.Point(12, 9);
            this.transactionHistoryLabel.Name = "transactionHistoryLabel";
            this.transactionHistoryLabel.Size = new System.Drawing.Size(389, 37);
            this.transactionHistoryLabel.TabIndex = 6;
            this.transactionHistoryLabel.Text = "TRANSACTION HISTORY";
            this.transactionHistoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // currentPointLabel
            // 
            this.currentPointLabel.AutoSize = true;
            this.currentPointLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentPointLabel.Location = new System.Drawing.Point(15, 77);
            this.currentPointLabel.Name = "currentPointLabel";
            this.currentPointLabel.Size = new System.Drawing.Size(195, 32);
            this.currentPointLabel.TabIndex = 8;
            this.currentPointLabel.Text = "Current Point :";
            // 
            // currentPoint
            // 
            this.currentPoint.AutoSize = true;
            this.currentPoint.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentPoint.Location = new System.Drawing.Point(231, 77);
            this.currentPoint.Name = "currentPoint";
            this.currentPoint.Size = new System.Drawing.Size(179, 32);
            this.currentPoint.TabIndex = 9;
            this.currentPoint.Text = "Current Point";
            // 
            // pointsPanel
            // 
            this.pointsPanel.AutoScroll = true;
            this.pointsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pointsPanel.Location = new System.Drawing.Point(16, 122);
            this.pointsPanel.Name = "pointsPanel";
            this.pointsPanel.Size = new System.Drawing.Size(1147, 510);
            this.pointsPanel.TabIndex = 10;
            // 
            // PointHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1178, 644);
            this.Controls.Add(this.pointsPanel);
            this.Controls.Add(this.currentPoint);
            this.Controls.Add(this.currentPointLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.transactionHistoryLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PointHistoryForm";
            this.Text = "LKSMart - Point History";
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label transactionHistoryLabel;
        private System.Windows.Forms.Label currentPointLabel;
        private System.Windows.Forms.Label currentPoint;
        private System.Windows.Forms.Panel pointsPanel;
    }
}