namespace Learning_Managment_System
{
    partial class newStud
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
            newStudTitle = new Label();
            firstName = new Label();
            lastName = new Label();
            phone = new Label();
            email = new Label();
            age = new Label();
            firstNameInput = new TextBox();
            lastNameInput = new TextBox();
            emailInput = new TextBox();
            phoneInput = new TextBox();
            ageInput = new TextBox();
            dataInputPanel = new Panel();
            buttonPanel = new Panel();
            closeButt = new Button();
            addButt = new Button();
            coverPanel = new Panel();
            coverPic = new PictureBox();
            dataInputPanel.SuspendLayout();
            buttonPanel.SuspendLayout();
            coverPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)coverPic).BeginInit();
            SuspendLayout();
            // 
            // newStudTitle
            // 
            newStudTitle.AutoSize = true;
            newStudTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            newStudTitle.ForeColor = Color.White;
            newStudTitle.Location = new Point(53, 9);
            newStudTitle.Name = "newStudTitle";
            newStudTitle.Size = new Size(249, 38);
            newStudTitle.TabIndex = 0;
            newStudTitle.Text = "Add New Student";
            // 
            // firstName
            // 
            firstName.AutoSize = true;
            firstName.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            firstName.Location = new Point(18, 2);
            firstName.Name = "firstName";
            firstName.Size = new Size(103, 25);
            firstName.TabIndex = 1;
            firstName.Text = "First Name";
            firstName.Click += label1_Click;
            // 
            // lastName
            // 
            lastName.AutoSize = true;
            lastName.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lastName.Location = new Point(18, 43);
            lastName.Name = "lastName";
            lastName.Size = new Size(101, 25);
            lastName.TabIndex = 2;
            lastName.Text = "Last Name";
            // 
            // phone
            // 
            phone.AutoSize = true;
            phone.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            phone.Location = new Point(18, 120);
            phone.Name = "phone";
            phone.Size = new Size(117, 25);
            phone.TabIndex = 3;
            phone.Text = "Phone Num.";
            // 
            // email
            // 
            email.AutoSize = true;
            email.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            email.Location = new Point(18, 82);
            email.Name = "email";
            email.Size = new Size(58, 25);
            email.TabIndex = 4;
            email.Text = "Email";
            email.Click += label3_Click;
            // 
            // age
            // 
            age.AutoSize = true;
            age.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            age.Location = new Point(18, 162);
            age.Name = "age";
            age.Size = new Size(46, 25);
            age.TabIndex = 5;
            age.Text = "Age";
            // 
            // firstNameInput
            // 
            firstNameInput.Location = new Point(156, 3);
            firstNameInput.Name = "firstNameInput";
            firstNameInput.Size = new Size(185, 27);
            firstNameInput.TabIndex = 6;
            // 
            // lastNameInput
            // 
            lastNameInput.Location = new Point(156, 44);
            lastNameInput.Name = "lastNameInput";
            lastNameInput.Size = new Size(185, 27);
            lastNameInput.TabIndex = 7;
            // 
            // emailInput
            // 
            emailInput.Location = new Point(156, 83);
            emailInput.Name = "emailInput";
            emailInput.Size = new Size(185, 27);
            emailInput.TabIndex = 8;
            // 
            // phoneInput
            // 
            phoneInput.Location = new Point(156, 121);
            phoneInput.Name = "phoneInput";
            phoneInput.Size = new Size(185, 27);
            phoneInput.TabIndex = 9;
            // 
            // ageInput
            // 
            ageInput.Location = new Point(156, 163);
            ageInput.Name = "ageInput";
            ageInput.Size = new Size(185, 27);
            ageInput.TabIndex = 10;
            ageInput.TextChanged += ageInput_TextChanged;
            // 
            // dataInputPanel
            // 
            dataInputPanel.BackColor = Color.White;
            dataInputPanel.Controls.Add(firstNameInput);
            dataInputPanel.Controls.Add(ageInput);
            dataInputPanel.Controls.Add(firstName);
            dataInputPanel.Controls.Add(phoneInput);
            dataInputPanel.Controls.Add(lastName);
            dataInputPanel.Controls.Add(emailInput);
            dataInputPanel.Controls.Add(phone);
            dataInputPanel.Controls.Add(lastNameInput);
            dataInputPanel.Controls.Add(email);
            dataInputPanel.Controls.Add(age);
            dataInputPanel.Location = new Point(0, 198);
            dataInputPanel.Name = "dataInputPanel";
            dataInputPanel.Size = new Size(381, 217);
            dataInputPanel.TabIndex = 11;
            // 
            // buttonPanel
            // 
            buttonPanel.BackColor = Color.FromArgb(43, 180, 200);
            buttonPanel.Controls.Add(closeButt);
            buttonPanel.Controls.Add(addButt);
            buttonPanel.Location = new Point(1, 421);
            buttonPanel.Name = "buttonPanel";
            buttonPanel.Size = new Size(374, 79);
            buttonPanel.TabIndex = 12;
            buttonPanel.Paint += buttonPanel_Paint;
            // 
            // closeButt
            // 
            closeButt.BackColor = Color.White;
            closeButt.FlatAppearance.BorderColor = Color.FromArgb(43, 180, 200);
            closeButt.FlatAppearance.BorderSize = 0;
            closeButt.FlatStyle = FlatStyle.Flat;
            closeButt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            closeButt.ForeColor = Color.FromArgb(43, 180, 200);
            closeButt.Location = new Point(17, 25);
            closeButt.Name = "closeButt";
            closeButt.Size = new Size(142, 38);
            closeButt.TabIndex = 8;
            closeButt.Text = "Close";
            closeButt.UseVisualStyleBackColor = false;
            closeButt.Click += closeButt_Click;
            // 
            // addButt
            // 
            addButt.BackColor = Color.White;
            addButt.FlatAppearance.BorderColor = Color.FromArgb(43, 180, 200);
            addButt.FlatAppearance.BorderSize = 0;
            addButt.FlatStyle = FlatStyle.Flat;
            addButt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            addButt.ForeColor = Color.FromArgb(43, 180, 200);
            addButt.Location = new Point(198, 25);
            addButt.Name = "addButt";
            addButt.Size = new Size(142, 38);
            addButt.TabIndex = 7;
            addButt.Text = "Add Student ";
            addButt.UseVisualStyleBackColor = false;
            addButt.Click += addButt_Click;
            // 
            // coverPanel
            // 
            coverPanel.BackColor = Color.White;
            coverPanel.Controls.Add(coverPic);
            coverPanel.Location = new Point(0, 54);
            coverPanel.Name = "coverPanel";
            coverPanel.Size = new Size(375, 145);
            coverPanel.TabIndex = 13;
            // 
            // coverPic
            // 
            coverPic.BackColor = Color.White;
            coverPic.Image = SchoolManagementSystem.Properties.Resources.login__4_11;
            coverPic.Location = new Point(0, 0);
            coverPic.Name = "coverPic";
            coverPic.Size = new Size(375, 117);
            coverPic.SizeMode = PictureBoxSizeMode.Zoom;
            coverPic.TabIndex = 0;
            coverPic.TabStop = false;
            // 
            // newStud
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 180, 200);
            ClientSize = new Size(373, 512);
            Controls.Add(coverPanel);
            Controls.Add(buttonPanel);
            Controls.Add(dataInputPanel);
            Controls.Add(newStudTitle);
            Name = "newStud";
            Text = "newStud";
            dataInputPanel.ResumeLayout(false);
            dataInputPanel.PerformLayout();
            buttonPanel.ResumeLayout(false);
            coverPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)coverPic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label newStudTitle;
        private Label firstName;
        private Label lastName;
        private Label phone;
        private Label email;
        private Label age;
        private TextBox firstNameInput;
        private TextBox lastNameInput;
        private TextBox emailInput;
        private TextBox phoneInput;
        private TextBox ageInput;
        private Panel dataInputPanel;
        private Panel buttonPanel;
        private Panel coverPanel;
        private PictureBox coverPic;
        private Button closeButt;
        private Button addButt;
    }
}