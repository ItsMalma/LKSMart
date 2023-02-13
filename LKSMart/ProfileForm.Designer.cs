namespace LKSMart
{
    partial class ProfileForm
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
            this.profileLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.inputsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.nameErrorLabel = new System.Windows.Forms.Label();
            this.nameEditPictureBox = new System.Windows.Forms.PictureBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.pinTextBox = new System.Windows.Forms.TextBox();
            this.pinLabel = new System.Windows.Forms.Label();
            this.dateOfBirth = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.profilePictureLabel = new System.Windows.Forms.Label();
            this.pinEditPictureBox = new System.Windows.Forms.PictureBox();
            this.dateOfBirthEditPictureBox = new System.Windows.Forms.PictureBox();
            this.addressEditPictureBox = new System.Windows.Forms.PictureBox();
            this.genderEditPictureBox = new System.Windows.Forms.PictureBox();
            this.pinErrorLabel = new System.Windows.Forms.Label();
            this.dateOfBirthErrorLabel = new System.Windows.Forms.Label();
            this.dateOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.addressRichTextBox = new System.Windows.Forms.RichTextBox();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.profilePictureInputPanel = new System.Windows.Forms.TableLayoutPanel();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.profilePictureUploadButton = new System.Windows.Forms.Button();
            this.inputsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nameEditPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinEditPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOfBirthEditPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressEditPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderEditPictureBox)).BeginInit();
            this.profilePictureInputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // profileLabel
            // 
            this.profileLabel.AutoSize = true;
            this.profileLabel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileLabel.Location = new System.Drawing.Point(12, 9);
            this.profileLabel.Name = "profileLabel";
            this.profileLabel.Size = new System.Drawing.Size(152, 37);
            this.profileLabel.TabIndex = 0;
            this.profileLabel.Text = "PROFILE";
            this.profileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Red;
            this.backButton.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(1039, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(127, 53);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.OnBack);
            // 
            // inputsPanel
            // 
            this.inputsPanel.ColumnCount = 4;
            this.inputsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.inputsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.inputsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.inputsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.inputsPanel.Controls.Add(this.phoneNumberTextBox, 1, 1);
            this.inputsPanel.Controls.Add(this.phoneNumberLabel, 0, 1);
            this.inputsPanel.Controls.Add(this.nameErrorLabel, 3, 0);
            this.inputsPanel.Controls.Add(this.nameEditPictureBox, 2, 0);
            this.inputsPanel.Controls.Add(this.nameTextBox, 1, 0);
            this.inputsPanel.Controls.Add(this.nameLabel, 0, 0);
            this.inputsPanel.Controls.Add(this.emailLabel, 0, 2);
            this.inputsPanel.Controls.Add(this.emailTextBox, 1, 2);
            this.inputsPanel.Controls.Add(this.pinTextBox, 1, 3);
            this.inputsPanel.Controls.Add(this.pinLabel, 0, 3);
            this.inputsPanel.Controls.Add(this.dateOfBirth, 0, 4);
            this.inputsPanel.Controls.Add(this.addressLabel, 0, 5);
            this.inputsPanel.Controls.Add(this.genderLabel, 0, 6);
            this.inputsPanel.Controls.Add(this.profilePictureLabel, 0, 7);
            this.inputsPanel.Controls.Add(this.pinEditPictureBox, 2, 3);
            this.inputsPanel.Controls.Add(this.dateOfBirthEditPictureBox, 2, 4);
            this.inputsPanel.Controls.Add(this.addressEditPictureBox, 2, 5);
            this.inputsPanel.Controls.Add(this.genderEditPictureBox, 2, 6);
            this.inputsPanel.Controls.Add(this.pinErrorLabel, 3, 3);
            this.inputsPanel.Controls.Add(this.dateOfBirthErrorLabel, 3, 4);
            this.inputsPanel.Controls.Add(this.dateOfBirthDateTimePicker, 1, 4);
            this.inputsPanel.Controls.Add(this.addressRichTextBox, 1, 5);
            this.inputsPanel.Controls.Add(this.genderComboBox, 1, 6);
            this.inputsPanel.Controls.Add(this.profilePictureInputPanel, 1, 7);
            this.inputsPanel.Location = new System.Drawing.Point(12, 73);
            this.inputsPanel.Name = "inputsPanel";
            this.inputsPanel.RowCount = 8;
            this.inputsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.inputsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.inputsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.inputsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.inputsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.inputsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.inputsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.inputsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.inputsPanel.Size = new System.Drawing.Size(1154, 859);
            this.inputsPanel.TabIndex = 5;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneNumberTextBox.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberTextBox.Location = new System.Drawing.Point(233, 107);
            this.phoneNumberTextBox.MaxLength = 200;
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.ReadOnly = true;
            this.phoneNumberTextBox.Size = new System.Drawing.Size(455, 40);
            this.phoneNumberTextBox.TabIndex = 9;
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberLabel.Location = new System.Drawing.Point(3, 111);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(203, 32);
            this.phoneNumberLabel.TabIndex = 8;
            this.phoneNumberLabel.Text = "Phone Number";
            // 
            // nameErrorLabel
            // 
            this.nameErrorLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nameErrorLabel.AutoSize = true;
            this.nameErrorLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.nameErrorLabel.Location = new System.Drawing.Point(786, 26);
            this.nameErrorLabel.Name = "nameErrorLabel";
            this.nameErrorLabel.Size = new System.Drawing.Size(75, 32);
            this.nameErrorLabel.TabIndex = 7;
            this.nameErrorLabel.Text = "Error";
            // 
            // nameEditPictureBox
            // 
            this.nameEditPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameEditPictureBox.Image = global::LKSMart.ImagesResource.edit;
            this.nameEditPictureBox.Location = new System.Drawing.Point(713, 18);
            this.nameEditPictureBox.Name = "nameEditPictureBox";
            this.nameEditPictureBox.Size = new System.Drawing.Size(48, 48);
            this.nameEditPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.nameEditPictureBox.TabIndex = 6;
            this.nameEditPictureBox.TabStop = false;
            this.nameEditPictureBox.Click += new System.EventHandler(this.OnEditName);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(233, 22);
            this.nameTextBox.MaxLength = 200;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(455, 40);
            this.nameTextBox.TabIndex = 6;
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(3, 26);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(88, 32);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "Name";
            // 
            // emailLabel
            // 
            this.emailLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(3, 196);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(84, 32);
            this.emailLabel.TabIndex = 10;
            this.emailLabel.Text = "Email";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.emailTextBox.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(233, 192);
            this.emailTextBox.MaxLength = 200;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.ReadOnly = true;
            this.emailTextBox.Size = new System.Drawing.Size(455, 40);
            this.emailTextBox.TabIndex = 11;
            // 
            // pinTextBox
            // 
            this.pinTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pinTextBox.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinTextBox.Location = new System.Drawing.Point(233, 277);
            this.pinTextBox.MaxLength = 6;
            this.pinTextBox.Name = "pinTextBox";
            this.pinTextBox.Size = new System.Drawing.Size(455, 40);
            this.pinTextBox.TabIndex = 12;
            this.pinTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnPinKeyPress);
            // 
            // pinLabel
            // 
            this.pinLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pinLabel.AutoSize = true;
            this.pinLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinLabel.Location = new System.Drawing.Point(3, 281);
            this.pinLabel.Name = "pinLabel";
            this.pinLabel.Size = new System.Drawing.Size(61, 32);
            this.pinLabel.TabIndex = 14;
            this.pinLabel.Text = "PIN";
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateOfBirth.AutoSize = true;
            this.dateOfBirth.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirth.Location = new System.Drawing.Point(3, 366);
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.Size = new System.Drawing.Size(168, 32);
            this.dateOfBirth.TabIndex = 15;
            this.dateOfBirth.Text = "Date of Birth";
            // 
            // addressLabel
            // 
            this.addressLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(3, 494);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(117, 32);
            this.addressLabel.TabIndex = 16;
            this.addressLabel.Text = "Address";
            // 
            // genderLabel
            // 
            this.genderLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLabel.Location = new System.Drawing.Point(3, 622);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(107, 32);
            this.genderLabel.TabIndex = 17;
            this.genderLabel.Text = "Gender";
            // 
            // profilePictureLabel
            // 
            this.profilePictureLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.profilePictureLabel.AutoSize = true;
            this.profilePictureLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profilePictureLabel.Location = new System.Drawing.Point(3, 754);
            this.profilePictureLabel.Name = "profilePictureLabel";
            this.profilePictureLabel.Size = new System.Drawing.Size(186, 32);
            this.profilePictureLabel.TabIndex = 18;
            this.profilePictureLabel.Text = "Profile Picture";
            // 
            // pinEditPictureBox
            // 
            this.pinEditPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pinEditPictureBox.Image = global::LKSMart.ImagesResource.edit;
            this.pinEditPictureBox.Location = new System.Drawing.Point(713, 273);
            this.pinEditPictureBox.Name = "pinEditPictureBox";
            this.pinEditPictureBox.Size = new System.Drawing.Size(48, 48);
            this.pinEditPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pinEditPictureBox.TabIndex = 19;
            this.pinEditPictureBox.TabStop = false;
            this.pinEditPictureBox.Click += new System.EventHandler(this.OnEditPin);
            // 
            // dateOfBirthEditPictureBox
            // 
            this.dateOfBirthEditPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateOfBirthEditPictureBox.Image = global::LKSMart.ImagesResource.edit;
            this.dateOfBirthEditPictureBox.Location = new System.Drawing.Point(713, 358);
            this.dateOfBirthEditPictureBox.Name = "dateOfBirthEditPictureBox";
            this.dateOfBirthEditPictureBox.Size = new System.Drawing.Size(48, 48);
            this.dateOfBirthEditPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.dateOfBirthEditPictureBox.TabIndex = 20;
            this.dateOfBirthEditPictureBox.TabStop = false;
            this.dateOfBirthEditPictureBox.Click += new System.EventHandler(this.OnEditDateOfBirth);
            // 
            // addressEditPictureBox
            // 
            this.addressEditPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addressEditPictureBox.Image = global::LKSMart.ImagesResource.edit;
            this.addressEditPictureBox.Location = new System.Drawing.Point(713, 486);
            this.addressEditPictureBox.Name = "addressEditPictureBox";
            this.addressEditPictureBox.Size = new System.Drawing.Size(48, 48);
            this.addressEditPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.addressEditPictureBox.TabIndex = 21;
            this.addressEditPictureBox.TabStop = false;
            this.addressEditPictureBox.Click += new System.EventHandler(this.OnEditAddress);
            // 
            // genderEditPictureBox
            // 
            this.genderEditPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.genderEditPictureBox.Image = global::LKSMart.ImagesResource.edit;
            this.genderEditPictureBox.Location = new System.Drawing.Point(713, 614);
            this.genderEditPictureBox.Name = "genderEditPictureBox";
            this.genderEditPictureBox.Size = new System.Drawing.Size(48, 48);
            this.genderEditPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.genderEditPictureBox.TabIndex = 22;
            this.genderEditPictureBox.TabStop = false;
            this.genderEditPictureBox.Click += new System.EventHandler(this.OnEditGender);
            // 
            // pinErrorLabel
            // 
            this.pinErrorLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pinErrorLabel.AutoSize = true;
            this.pinErrorLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.pinErrorLabel.Location = new System.Drawing.Point(786, 281);
            this.pinErrorLabel.Name = "pinErrorLabel";
            this.pinErrorLabel.Size = new System.Drawing.Size(75, 32);
            this.pinErrorLabel.TabIndex = 23;
            this.pinErrorLabel.Text = "Error";
            // 
            // dateOfBirthErrorLabel
            // 
            this.dateOfBirthErrorLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateOfBirthErrorLabel.AutoSize = true;
            this.dateOfBirthErrorLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirthErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.dateOfBirthErrorLabel.Location = new System.Drawing.Point(786, 366);
            this.dateOfBirthErrorLabel.Name = "dateOfBirthErrorLabel";
            this.dateOfBirthErrorLabel.Size = new System.Drawing.Size(75, 32);
            this.dateOfBirthErrorLabel.TabIndex = 24;
            this.dateOfBirthErrorLabel.Text = "Error";
            // 
            // dateOfBirthDateTimePicker
            // 
            this.dateOfBirthDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateOfBirthDateTimePicker.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirthDateTimePicker.Location = new System.Drawing.Point(233, 362);
            this.dateOfBirthDateTimePicker.Name = "dateOfBirthDateTimePicker";
            this.dateOfBirthDateTimePicker.Size = new System.Drawing.Size(455, 40);
            this.dateOfBirthDateTimePicker.TabIndex = 25;
            // 
            // addressRichTextBox
            // 
            this.addressRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addressRichTextBox.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressRichTextBox.Location = new System.Drawing.Point(233, 428);
            this.addressRichTextBox.MaxLength = 200;
            this.addressRichTextBox.Name = "addressRichTextBox";
            this.addressRichTextBox.Size = new System.Drawing.Size(455, 165);
            this.addressRichTextBox.TabIndex = 26;
            this.addressRichTextBox.Text = "";
            // 
            // genderComboBox
            // 
            this.genderComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.genderComboBox.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Location = new System.Drawing.Point(233, 618);
            this.genderComboBox.MaxLength = 10;
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(455, 40);
            this.genderComboBox.TabIndex = 27;
            // 
            // profilePictureInputPanel
            // 
            this.profilePictureInputPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.profilePictureInputPanel.ColumnCount = 2;
            this.profilePictureInputPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 172F));
            this.profilePictureInputPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.profilePictureInputPanel.Controls.Add(this.profilePictureBox, 0, 0);
            this.profilePictureInputPanel.Controls.Add(this.profilePictureUploadButton, 1, 0);
            this.profilePictureInputPanel.Location = new System.Drawing.Point(233, 684);
            this.profilePictureInputPanel.Name = "profilePictureInputPanel";
            this.profilePictureInputPanel.RowCount = 1;
            this.profilePictureInputPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.profilePictureInputPanel.Size = new System.Drawing.Size(455, 172);
            this.profilePictureInputPanel.TabIndex = 28;
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.profilePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profilePictureBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.profilePictureBox.Location = new System.Drawing.Point(3, 3);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(166, 166);
            this.profilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePictureBox.TabIndex = 0;
            this.profilePictureBox.TabStop = false;
            this.profilePictureBox.Click += new System.EventHandler(this.OnEditProfilePicture);
            // 
            // profilePictureUploadButton
            // 
            this.profilePictureUploadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.profilePictureUploadButton.BackColor = System.Drawing.Color.Lime;
            this.profilePictureUploadButton.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profilePictureUploadButton.ForeColor = System.Drawing.Color.White;
            this.profilePictureUploadButton.Location = new System.Drawing.Point(175, 122);
            this.profilePictureUploadButton.Name = "profilePictureUploadButton";
            this.profilePictureUploadButton.Size = new System.Drawing.Size(162, 47);
            this.profilePictureUploadButton.TabIndex = 1;
            this.profilePictureUploadButton.Text = "UPLOAD";
            this.profilePictureUploadButton.UseVisualStyleBackColor = false;
            this.profilePictureUploadButton.Click += new System.EventHandler(this.OnUploadProfilePicture);
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1178, 944);
            this.Controls.Add(this.inputsPanel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.profileLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProfileForm";
            this.Text = "LKSMart - Profile";
            this.Load += new System.EventHandler(this.OnLoad);
            this.inputsPanel.ResumeLayout(false);
            this.inputsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nameEditPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinEditPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOfBirthEditPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressEditPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderEditPictureBox)).EndInit();
            this.profilePictureInputPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label profileLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TableLayoutPanel inputsPanel;
        private System.Windows.Forms.PictureBox nameEditPictureBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label nameErrorLabel;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox pinTextBox;
        private System.Windows.Forms.Label pinLabel;
        private System.Windows.Forms.Label dateOfBirth;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label profilePictureLabel;
        private System.Windows.Forms.PictureBox pinEditPictureBox;
        private System.Windows.Forms.PictureBox dateOfBirthEditPictureBox;
        private System.Windows.Forms.PictureBox addressEditPictureBox;
        private System.Windows.Forms.PictureBox genderEditPictureBox;
        private System.Windows.Forms.Label pinErrorLabel;
        private System.Windows.Forms.Label dateOfBirthErrorLabel;
        private System.Windows.Forms.DateTimePicker dateOfBirthDateTimePicker;
        private System.Windows.Forms.RichTextBox addressRichTextBox;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.TableLayoutPanel profilePictureInputPanel;
        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.Button profilePictureUploadButton;
    }
}