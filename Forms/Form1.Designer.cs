namespace Learning_Managment_System
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Button exitButt;
            sideBar = new Panel();
            panel11 = new Panel();
            pictureBox12 = new PictureBox();
            panel5 = new Panel();
            profPanelButt = new Button();
            pictureBox4 = new PictureBox();
            panel4 = new Panel();
            classPanelButt = new Button();
            pictureBox3 = new PictureBox();
            panel3 = new Panel();
            studentPanelButt = new Button();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            controlPanelIcon = new PictureBox();
            controlPanelButt = new Button();
            userNamePanel = new Panel();
            userName = new Label();
            profilePic = new PictureBox();
            label = new Label();
            currentPanel = new Panel();
            exitButt = new Button();
            sideBar.SuspendLayout();
            panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)controlPanelIcon).BeginInit();
            userNamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)profilePic).BeginInit();
            SuspendLayout();
            // 
            // exitButt
            // 
            exitButt.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            exitButt.BackColor = Color.FromArgb(43, 180, 200);
            exitButt.BackgroundImageLayout = ImageLayout.Center;
            exitButt.Dock = DockStyle.Right;
            exitButt.FlatAppearance.BorderSize = 0;
            exitButt.FlatStyle = FlatStyle.Flat;
            exitButt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            exitButt.ForeColor = Color.White;
            exitButt.ImageAlign = ContentAlignment.MiddleLeft;
            exitButt.Location = new Point(54, 0);
            exitButt.Margin = new Padding(0, 6, 0, 6);
            exitButt.Name = "exitButt";
            exitButt.Size = new Size(92, 42);
            exitButt.TabIndex = 3;
            exitButt.Text = "exit";
            exitButt.UseVisualStyleBackColor = false;
            exitButt.Click += exitButt_Click;
            // 
            // sideBar
            // 
            sideBar.BackColor = Color.FromArgb(43, 180, 200);
            sideBar.BorderStyle = BorderStyle.Fixed3D;
            sideBar.Controls.Add(panel11);
            sideBar.Controls.Add(panel5);
            sideBar.Controls.Add(panel4);
            sideBar.Controls.Add(panel3);
            sideBar.Controls.Add(panel2);
            sideBar.Controls.Add(userNamePanel);
            sideBar.Dock = DockStyle.Left;
            sideBar.ForeColor = Color.White;
            sideBar.Location = new Point(0, 0);
            sideBar.Name = "sideBar";
            sideBar.Size = new Size(150, 612);
            sideBar.TabIndex = 0;
            sideBar.Paint += panel1_Paint;
            // 
            // panel11
            // 
            panel11.Controls.Add(exitButt);
            panel11.Controls.Add(pictureBox12);
            panel11.Dock = DockStyle.Bottom;
            panel11.Location = new Point(0, 566);
            panel11.Margin = new Padding(0, 5, 0, 5);
            panel11.Name = "panel11";
            panel11.Size = new Size(146, 42);
            panel11.TabIndex = 5;
            // 
            // pictureBox12
            // 
            pictureBox12.Dock = DockStyle.Left;
            pictureBox12.Image = SchoolManagementSystem.Properties.Resources.exit1;
            pictureBox12.Location = new Point(0, 0);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(55, 42);
            pictureBox12.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox12.TabIndex = 1;
            pictureBox12.TabStop = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(profPanelButt);
            panel5.Controls.Add(pictureBox4);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 332);
            panel5.Margin = new Padding(0, 5, 0, 5);
            panel5.Name = "panel5";
            panel5.Size = new Size(146, 74);
            panel5.TabIndex = 3;
            // 
            // profPanelButt
            // 
            profPanelButt.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            profPanelButt.BackColor = Color.FromArgb(43, 180, 200);
            profPanelButt.BackgroundImageLayout = ImageLayout.Center;
            profPanelButt.Dock = DockStyle.Right;
            profPanelButt.FlatAppearance.BorderSize = 0;
            profPanelButt.FlatStyle = FlatStyle.Flat;
            profPanelButt.Font = new Font("Cascadia Mono SemiBold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            profPanelButt.ForeColor = Color.White;
            profPanelButt.ImageAlign = ContentAlignment.MiddleLeft;
            profPanelButt.Location = new Point(43, 0);
            profPanelButt.Margin = new Padding(0, 6, 0, 6);
            profPanelButt.Name = "profPanelButt";
            profPanelButt.Size = new Size(103, 74);
            profPanelButt.TabIndex = 3;
            profPanelButt.Text = "Teachers";
            profPanelButt.UseVisualStyleBackColor = false;
            profPanelButt.Click += profPanelButt_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(43, 180, 200);
            pictureBox4.Dock = DockStyle.Left;
            pictureBox4.Image = SchoolManagementSystem.Properties.Resources.teacher1;
            pictureBox4.Location = new Point(0, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(40, 74);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(classPanelButt);
            panel4.Controls.Add(pictureBox3);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 258);
            panel4.Margin = new Padding(0, 5, 0, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(146, 74);
            panel4.TabIndex = 4;
            // 
            // classPanelButt
            // 
            classPanelButt.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            classPanelButt.BackColor = Color.FromArgb(43, 180, 200);
            classPanelButt.BackgroundImageLayout = ImageLayout.Center;
            classPanelButt.Dock = DockStyle.Right;
            classPanelButt.FlatAppearance.BorderSize = 0;
            classPanelButt.FlatStyle = FlatStyle.Flat;
            classPanelButt.Font = new Font("Cascadia Mono SemiBold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            classPanelButt.ForeColor = Color.White;
            classPanelButt.ImageAlign = ContentAlignment.MiddleLeft;
            classPanelButt.Location = new Point(40, 0);
            classPanelButt.Margin = new Padding(0, 6, 0, 6);
            classPanelButt.Name = "classPanelButt";
            classPanelButt.Size = new Size(106, 74);
            classPanelButt.TabIndex = 3;
            classPanelButt.Text = "Classes";
            classPanelButt.UseVisualStyleBackColor = false;
            classPanelButt.Click += classPanelButt_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Left;
            pictureBox3.Image = SchoolManagementSystem.Properties.Resources.class1;
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(40, 74);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(studentPanelButt);
            panel3.Controls.Add(pictureBox2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 184);
            panel3.Margin = new Padding(0, 5, 0, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(146, 74);
            panel3.TabIndex = 3;
            // 
            // studentPanelButt
            // 
            studentPanelButt.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            studentPanelButt.BackColor = Color.FromArgb(43, 180, 200);
            studentPanelButt.BackgroundImageLayout = ImageLayout.Center;
            studentPanelButt.Dock = DockStyle.Right;
            studentPanelButt.FlatAppearance.BorderSize = 0;
            studentPanelButt.FlatStyle = FlatStyle.Flat;
            studentPanelButt.Font = new Font("Cascadia Mono SemiBold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            studentPanelButt.ForeColor = Color.White;
            studentPanelButt.ImageAlign = ContentAlignment.MiddleLeft;
            studentPanelButt.Location = new Point(43, 0);
            studentPanelButt.Margin = new Padding(0, 6, 0, 6);
            studentPanelButt.Name = "studentPanelButt";
            studentPanelButt.Size = new Size(103, 74);
            studentPanelButt.TabIndex = 3;
            studentPanelButt.Text = "Students";
            studentPanelButt.UseVisualStyleBackColor = false;
            studentPanelButt.Click += button1_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(43, 180, 200);
            pictureBox2.Dock = DockStyle.Left;
            pictureBox2.Image = SchoolManagementSystem.Properties.Resources.student1;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 74);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(controlPanelIcon);
            panel2.Controls.Add(controlPanelButt);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 110);
            panel2.Margin = new Padding(0, 10, 0, 10);
            panel2.Name = "panel2";
            panel2.Size = new Size(146, 74);
            panel2.TabIndex = 2;
            // 
            // controlPanelIcon
            // 
            controlPanelIcon.Dock = DockStyle.Left;
            controlPanelIcon.Image = SchoolManagementSystem.Properties.Resources.home1;
            controlPanelIcon.Location = new Point(0, 0);
            controlPanelIcon.Name = "controlPanelIcon";
            controlPanelIcon.Size = new Size(40, 74);
            controlPanelIcon.SizeMode = PictureBoxSizeMode.Zoom;
            controlPanelIcon.TabIndex = 4;
            controlPanelIcon.TabStop = false;
            // 
            // controlPanelButt
            // 
            controlPanelButt.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            controlPanelButt.BackColor = Color.FromArgb(43, 180, 200);
            controlPanelButt.BackgroundImageLayout = ImageLayout.Center;
            controlPanelButt.Dock = DockStyle.Right;
            controlPanelButt.FlatAppearance.BorderSize = 0;
            controlPanelButt.FlatStyle = FlatStyle.Flat;
            controlPanelButt.Font = new Font("Cascadia Mono SemiBold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            controlPanelButt.ForeColor = Color.White;
            controlPanelButt.ImageAlign = ContentAlignment.MiddleLeft;
            controlPanelButt.Location = new Point(40, 0);
            controlPanelButt.Margin = new Padding(0, 6, 0, 6);
            controlPanelButt.Name = "controlPanelButt";
            controlPanelButt.Size = new Size(106, 74);
            controlPanelButt.TabIndex = 3;
            controlPanelButt.Text = "Control Panel";
            controlPanelButt.UseVisualStyleBackColor = false;
            controlPanelButt.Click += controlPanelButt_Click_1;
            // 
            // userNamePanel
            // 
            userNamePanel.Controls.Add(userName);
            userNamePanel.Controls.Add(profilePic);
            userNamePanel.Dock = DockStyle.Top;
            userNamePanel.Location = new Point(0, 0);
            userNamePanel.Name = "userNamePanel";
            userNamePanel.Size = new Size(146, 110);
            userNamePanel.TabIndex = 0;
            // 
            // userName
            // 
            userName.AutoSize = true;
            userName.Dock = DockStyle.Bottom;
            userName.Font = new Font("Cascadia Code", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            userName.Location = new Point(0, 73);
            userName.Name = "userName";
            userName.Size = new Size(97, 37);
            userName.TabIndex = 1;
            userName.Text = "Admin";
            userName.TextAlign = ContentAlignment.MiddleCenter;
            userName.Click += label2_Click_1;
            // 
            // profilePic
            // 
            profilePic.Image = SchoolManagementSystem.Properties.Resources.account111;
            profilePic.Location = new Point(3, 0);
            profilePic.Name = "profilePic";
            profilePic.Size = new Size(144, 69);
            profilePic.SizeMode = PictureBoxSizeMode.Zoom;
            profilePic.TabIndex = 0;
            profilePic.TabStop = false;
            // 
            // label
            // 
            label.Location = new Point(0, 0);
            label.Name = "label";
            label.Size = new Size(100, 23);
            label.TabIndex = 0;
            // 
            // currentPanel
            // 
            currentPanel.Dock = DockStyle.Right;
            currentPanel.Location = new Point(151, 0);
            currentPanel.Name = "currentPanel";
            currentPanel.Size = new Size(911, 612);
            currentPanel.TabIndex = 1;
            currentPanel.Paint += controlPanel_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1062, 612);
            Controls.Add(currentPanel);
            Controls.Add(sideBar);
            Name = "Form1";
            Text = "form1";
            Load += Form1_Load;
            sideBar.ResumeLayout(false);
            panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)controlPanelIcon).EndInit();
            userNamePanel.ResumeLayout(false);
            userNamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)profilePic).EndInit();
            ResumeLayout(false);
        }

        //public override bool Equals(object obj)
        //{
        //    return obj is Form1 form &&
        //           EqualityComparer<PictureBox>.Default.Equals(this.pictureBox1, form.pictureBox1);
        //}

        #endregion

        private Panel sideBar;
        private Panel userNamePanel;

        //public PictureBox pictureBox1 { get; private set; }
        //public PictureBox PictureBox1 { get => this.pictureBox1; set => this.pictureBox1 = value; }
        //public PictureBox PictureBox11 { get => this.pictureBox1; set => this.pictureBox1 = value; }

        private Panel panel2;
        private Button controlPanelButt;
        private Panel panel5;
        private Button profPanelButt;
        private Panel panel4;
        private Button classPanelButt;
        private PictureBox pictureBox3;
        private Panel panel3;
        private Button studentPanelButt;
        private PictureBox pictureBox2;
        private PictureBox profilePic;
        //private FlowLayoutPanel userName;
        private Label userName;
        private PictureBox controlPanelIcon;
        private Panel panel11;
        private Button exitButt;
        private PictureBox pictureBox12;
        private Label label;
        private PictureBox pictureBox4;
        private Panel panel6;
        private Button exportButt;
        private Button importButt;
        private ComboBox pickClass;
        private PictureBox controlPicture1;
        private Panel panel8;
        private Panel newDataPanel;
        private PictureBox controlPicture2;
        private Panel newProfPanel;
        private PictureBox newProfPic;
        private Button newProffButt;
        private Panel newClasspanel;
        private PictureBox pictureBox7;
        private Button newClassButt;
        private Panel newStudPanel;
        private Button newStudButt;
        private PictureBox newStudPic;
        private Panel currentPanel;
    }
}