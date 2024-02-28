namespace Learning_Managment_System
{
    partial class NewClass
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
            codeInput = new TextBox();
            studName = new Label();
            timeInput = new TextBox();
            label1 = new Label();
            hallInput = new TextBox();
            time = new Label();
            nameInput = new TextBox();
            hall = new Label();
            newClassTitle = new Label();
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
            coverPanel.Location = new Point(-4, 57);
            coverPanel.Name = "coverPanel";
            coverPanel.Size = new Size(381, 145);
            coverPanel.TabIndex = 21;
            // 
            // coverPic
            // 
            coverPic.BackColor = Color.White;
            coverPic.Image = SchoolManagementSystem.Properties.Resources.login__6_1;
            coverPic.Location = new Point(3, 3);
            coverPic.Name = "coverPic";
            coverPic.Size = new Size(375, 147);
            coverPic.SizeMode = PictureBoxSizeMode.Zoom;
            coverPic.TabIndex = 0;
            coverPic.TabStop = false;
            // 
            // buttonPanel
            // 
            buttonPanel.BackColor = Color.FromArgb(43, 180, 200);
            buttonPanel.Controls.Add(closeButt);
            buttonPanel.Controls.Add(addButt);
            buttonPanel.Location = new Point(-3, 424);
            buttonPanel.Name = "buttonPanel";
            buttonPanel.Size = new Size(374, 79);
            buttonPanel.TabIndex = 20;
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
            addButt.Text = "Add Class";
            addButt.UseVisualStyleBackColor = false;
            addButt.Click += addButt_Click;
            // 
            // dataInputPanel
            // 
            dataInputPanel.BackColor = Color.White;
            dataInputPanel.Controls.Add(codeInput);
            dataInputPanel.Controls.Add(studName);
            dataInputPanel.Controls.Add(timeInput);
            dataInputPanel.Controls.Add(label1);
            dataInputPanel.Controls.Add(hallInput);
            dataInputPanel.Controls.Add(time);
            dataInputPanel.Controls.Add(nameInput);
            dataInputPanel.Controls.Add(hall);
            dataInputPanel.Location = new Point(-4, 201);
            dataInputPanel.Name = "dataInputPanel";
            dataInputPanel.Size = new Size(381, 203);
            dataInputPanel.TabIndex = 19;
            // 
            // codeInput
            // 
            codeInput.Location = new Point(156, 19);
            codeInput.Name = "codeInput";
            codeInput.Size = new Size(185, 27);
            codeInput.TabIndex = 6;
            // 
            // studName
            // 
            studName.AutoSize = true;
            studName.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            studName.Location = new Point(18, 18);
            studName.Name = "studName";
            studName.Size = new Size(60, 25);
            studName.TabIndex = 1;
            studName.Text = "Code ";
            // 
            // timeInput
            // 
            timeInput.Location = new Point(156, 137);
            timeInput.Name = "timeInput";
            timeInput.Size = new Size(185, 27);
            timeInput.TabIndex = 9;
            timeInput.TextChanged += timeInput_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(18, 59);
            label1.Name = "label1";
            label1.Size = new Size(62, 25);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // hallInput
            // 
            hallInput.Location = new Point(156, 99);
            hallInput.Name = "hallInput";
            hallInput.Size = new Size(185, 27);
            hallInput.TabIndex = 8;
            // 
            // time
            // 
            time.AutoSize = true;
            time.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            time.Location = new Point(18, 136);
            time.Name = "time";
            time.Size = new Size(54, 25);
            time.TabIndex = 3;
            time.Text = "Time";
            // 
            // nameInput
            // 
            nameInput.Location = new Point(156, 60);
            nameInput.Name = "nameInput";
            nameInput.Size = new Size(185, 27);
            nameInput.TabIndex = 7;
            // 
            // hall
            // 
            hall.AutoSize = true;
            hall.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            hall.Location = new Point(18, 98);
            hall.Name = "hall";
            hall.Size = new Size(46, 25);
            hall.TabIndex = 4;
            hall.Text = "Hall";
            // 
            // newClassTitle
            // 
            newClassTitle.AutoSize = true;
            newClassTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            newClassTitle.ForeColor = Color.White;
            newClassTitle.Location = new Point(79, 10);
            newClassTitle.Name = "newClassTitle";
            newClassTitle.Size = new Size(214, 38);
            newClassTitle.TabIndex = 18;
            newClassTitle.Text = "Add New Class";
            // 
            // NewClass
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 180, 200);
            ClientSize = new Size(373, 512);
            Controls.Add(coverPanel);
            Controls.Add(buttonPanel);
            Controls.Add(dataInputPanel);
            Controls.Add(newClassTitle);
            Name = "NewClass";
            Text = "NewClass";
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
        private TextBox codeInput;
        private Label studName;
        private TextBox timeInput;
        private Label label1;
        private TextBox hallInput;
        private Label time;
        private TextBox nameInput;
        private Label hall;
        private Label newClassTitle;
    }
}