namespace Learning_Managment_System
{
    partial class newProf
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
            coverPanel = new Panel();
            coverPic = new PictureBox();
            buttonPanel = new Panel();
            closeButt = new Button();
            addButt = new Button();
            dataInputPanel = new Panel();
            firstName = new TextBox();
            studName = new Label();
            phone = new TextBox();
            label1 = new Label();
            email = new TextBox();
            label2 = new Label();
            lastName = new TextBox();
            label3 = new Label();
            newProfTitle = new Label();
            coverPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)coverPic).BeginInit();
            buttonPanel.SuspendLayout();
            dataInputPanel.SuspendLayout();
            SuspendLayout();
            // 
            // coverPanel
            // 
            coverPanel.BackColor = Color.White;
            coverPanel.Controls.Add(coverPic);
            coverPanel.Location = new Point(-4, 56);
            coverPanel.Name = "coverPanel";
            coverPanel.Size = new Size(381, 145);
            coverPanel.TabIndex = 17;
            // 
            // coverPic
            // 
            coverPic.BackColor = Color.White;
            coverPic.Image = SchoolManagementSystem.Properties.Resources.login__5_1;
            coverPic.Location = new Point(3, 12);
            coverPic.Name = "coverPic";
            coverPic.Size = new Size(375, 117);
            coverPic.SizeMode = PictureBoxSizeMode.Zoom;
            coverPic.TabIndex = 0;
            coverPic.TabStop = false;
            // 
            // buttonPanel
            // 
            buttonPanel.BackColor = Color.FromArgb(43, 180, 200);
            buttonPanel.Controls.Add(closeButt);
            buttonPanel.Controls.Add(addButt);
            buttonPanel.Location = new Point(-3, 423);
            buttonPanel.Name = "buttonPanel";
            buttonPanel.Size = new Size(374, 79);
            buttonPanel.TabIndex = 16;
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
            addButt.Text = "Add Prof";
            addButt.UseVisualStyleBackColor = false;
            addButt.Click += addButt_Click;
            // 
            // dataInputPanel
            // 
            dataInputPanel.BackColor = Color.White;
            dataInputPanel.Controls.Add(firstName);
            dataInputPanel.Controls.Add(studName);
            dataInputPanel.Controls.Add(phone);
            dataInputPanel.Controls.Add(label1);
            dataInputPanel.Controls.Add(email);
            dataInputPanel.Controls.Add(label2);
            dataInputPanel.Controls.Add(lastName);
            dataInputPanel.Controls.Add(label3);
            dataInputPanel.Location = new Point(-4, 200);
            dataInputPanel.Name = "dataInputPanel";
            dataInputPanel.Size = new Size(381, 203);
            dataInputPanel.TabIndex = 15;
            // 
            // firstName
            // 
            firstName.Location = new Point(156, 19);
            firstName.Name = "firstName";
            firstName.Size = new Size(185, 27);
            firstName.TabIndex = 6;
            // 
            // studName
            // 
            studName.AutoSize = true;
            studName.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            studName.Location = new Point(18, 18);
            studName.Name = "studName";
            studName.Size = new Size(103, 25);
            studName.TabIndex = 1;
            studName.Text = "First Name";
            // 
            // phone
            // 
            phone.Location = new Point(156, 137);
            phone.Name = "phone";
            phone.Size = new Size(185, 27);
            phone.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(18, 59);
            label1.Name = "label1";
            label1.Size = new Size(101, 25);
            label1.TabIndex = 2;
            label1.Text = "Last Name";
            // 
            // email
            // 
            email.Location = new Point(156, 99);
            email.Name = "email";
            email.Size = new Size(185, 27);
            email.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(18, 136);
            label2.Name = "label2";
            label2.Size = new Size(117, 25);
            label2.TabIndex = 3;
            label2.Text = "Phone Num.";
            // 
            // lastName
            // 
            lastName.Location = new Point(156, 60);
            lastName.Name = "lastName";
            lastName.Size = new Size(185, 27);
            lastName.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(18, 98);
            label3.Name = "label3";
            label3.Size = new Size(58, 25);
            label3.TabIndex = 4;
            label3.Text = "Email";
            // 
            // newProfTitle
            // 
            newProfTitle.AutoSize = true;
            newProfTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            newProfTitle.ForeColor = Color.White;
            newProfTitle.Location = new Point(79, 9);
            newProfTitle.Name = "newProfTitle";
            newProfTitle.Size = new Size(210, 38);
            newProfTitle.TabIndex = 14;
            newProfTitle.Text = "Add New Prof.";
            // 
            // newProf
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 180, 200);
            ClientSize = new Size(373, 512);
            Controls.Add(coverPanel);
            Controls.Add(buttonPanel);
            Controls.Add(dataInputPanel);
            Controls.Add(newProfTitle);
            Name = "newProf";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "newProf";
            coverPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)coverPic).EndInit();
            buttonPanel.ResumeLayout(false);
            dataInputPanel.ResumeLayout(false);
            dataInputPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel coverPanel;
        private PictureBox coverPic;
        private Panel buttonPanel;
        private Button closeButt;
        private Button addButt;
        private Panel dataInputPanel;
        private TextBox firstName;
        private Label studName;
        private TextBox phone;
        private Label label1;
        private TextBox email;
        private Label label2;
        private TextBox lastName;
        private Label label3;
        private Label newProfTitle;
    }
}