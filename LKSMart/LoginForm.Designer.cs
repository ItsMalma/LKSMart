namespace LKSMart
{
    partial class LoginForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.phoneNumberOrEmailTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberOrEmailLabel = new System.Windows.Forms.Label();
            this.pinNumberLabel = new System.Windows.Forms.Label();
            this.pinNumberTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(256, 81);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(467, 111);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "LKS Mart";
            // 
            // phoneNumberOrEmailTextBox
            // 
            this.phoneNumberOrEmailTextBox.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberOrEmailTextBox.Location = new System.Drawing.Point(249, 231);
            this.phoneNumberOrEmailTextBox.MaxLength = 200;
            this.phoneNumberOrEmailTextBox.Name = "phoneNumberOrEmailTextBox";
            this.phoneNumberOrEmailTextBox.Size = new System.Drawing.Size(480, 44);
            this.phoneNumberOrEmailTextBox.TabIndex = 1;
            // 
            // phoneNumberOrEmailLabel
            // 
            this.phoneNumberOrEmailLabel.AutoSize = true;
            this.phoneNumberOrEmailLabel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberOrEmailLabel.Location = new System.Drawing.Point(322, 192);
            this.phoneNumberOrEmailLabel.Name = "phoneNumberOrEmailLabel";
            this.phoneNumberOrEmailLabel.Size = new System.Drawing.Size(334, 36);
            this.phoneNumberOrEmailLabel.TabIndex = 2;
            this.phoneNumberOrEmailLabel.Text = "Phone Number / Email";
            // 
            // pinNumberLabel
            // 
            this.pinNumberLabel.AutoSize = true;
            this.pinNumberLabel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinNumberLabel.Location = new System.Drawing.Point(394, 292);
            this.pinNumberLabel.Name = "pinNumberLabel";
            this.pinNumberLabel.Size = new System.Drawing.Size(190, 36);
            this.pinNumberLabel.TabIndex = 4;
            this.pinNumberLabel.Text = "PIN Number";
            // 
            // pinNumberTextBox
            // 
            this.pinNumberTextBox.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinNumberTextBox.Location = new System.Drawing.Point(249, 331);
            this.pinNumberTextBox.MaxLength = 6;
            this.pinNumberTextBox.Name = "pinNumberTextBox";
            this.pinNumberTextBox.Size = new System.Drawing.Size(480, 44);
            this.pinNumberTextBox.TabIndex = 3;
            this.pinNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnPinNumberKeyPress);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Lime;
            this.loginButton.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(361, 424);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(256, 69);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "LOGIN";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.OnLogin);
            // 
            // errorLabel
            // 
            this.errorLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(12, 385);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(954, 36);
            this.errorLabel.TabIndex = 6;
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 544);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.pinNumberLabel);
            this.Controls.Add(this.pinNumberTextBox);
            this.Controls.Add(this.phoneNumberOrEmailLabel);
            this.Controls.Add(this.phoneNumberOrEmailTextBox);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.Text = "LKSMart - Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox phoneNumberOrEmailTextBox;
        private System.Windows.Forms.Label phoneNumberOrEmailLabel;
        private System.Windows.Forms.Label pinNumberLabel;
        private System.Windows.Forms.TextBox pinNumberTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label errorLabel;
    }
}

