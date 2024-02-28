namespace Learning_Managment_System
{
    partial class ControlPanel
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
            Label addDataLabel;
            Label classesBlockLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlPanel));
            panel1 = new Panel();
            panel8 = new Panel();
            newDataPanel = new Panel();
            controlPicture2 = new PictureBox();
            newProfPanel = new Panel();
            newProfPic = new PictureBox();
            newProffButt = new Button();
            newClasspanel = new Panel();
            pictureBox7 = new PictureBox();
            newClassButt = new Button();
            newStudPanel = new Panel();
            newStudButt = new Button();
            newStudPic = new PictureBox();
            panel6 = new Panel();
            exportButt = new Button();
            importButt = new Button();
            pickClass = new ComboBox();
            controlPicture1 = new PictureBox();
            addDataLabel = new Label();
            classesBlockLabel = new Label();
            panel1.SuspendLayout();
            panel8.SuspendLayout();
            newDataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)controlPicture2).BeginInit();
            newProfPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)newProfPic).BeginInit();
            newClasspanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            newStudPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)newStudPic).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)controlPicture1).BeginInit();
            SuspendLayout();
            // 
            // addDataLabel
            // 
            addDataLabel.AutoSize = true;
            addDataLabel.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            addDataLabel.Location = new Point(477, 3);
            addDataLabel.Name = "addDataLabel";
            addDataLabel.Size = new Size(411, 62);
            addDataLabel.TabIndex = 2;
            addDataLabel.Text = "     Add New Data";
            addDataLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // classesBlockLabel
            // 
            classesBlockLabel.AutoSize = true;
            classesBlockLabel.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            classesBlockLabel.Location = new Point(6, 33);
            classesBlockLabel.Name = "classesBlockLabel";
            classesBlockLabel.Size = new Size(464, 62);
            classesBlockLabel.TabIndex = 7;
            classesBlockLabel.Text = "Control classes data";
            classesBlockLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel6);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(911, 612);
            panel1.TabIndex = 2;
            // 
            // panel8
            // 
            panel8.Controls.Add(newDataPanel);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 284);
            panel8.Name = "panel8";
            panel8.Size = new Size(911, 293);
            panel8.TabIndex = 4;
            // 
            // newDataPanel
            // 
            newDataPanel.BackColor = Color.Transparent;
            newDataPanel.Controls.Add(addDataLabel);
            newDataPanel.Controls.Add(controlPicture2);
            newDataPanel.Controls.Add(newProfPanel);
            newDataPanel.Controls.Add(newClasspanel);
            newDataPanel.Controls.Add(newStudPanel);
            newDataPanel.Dock = DockStyle.Top;
            newDataPanel.Location = new Point(0, 0);
            newDataPanel.Name = "newDataPanel";
            newDataPanel.Size = new Size(911, 290);
            newDataPanel.TabIndex = 3;
            // 
            // controlPicture2
            // 
            controlPicture2.Dock = DockStyle.Left;
            controlPicture2.Image = (Image)resources.GetObject("controlPicture2.Image");
            controlPicture2.Location = new Point(0, 0);
            controlPicture2.Name = "controlPicture2";
            controlPicture2.Size = new Size(470, 290);
            controlPicture2.SizeMode = PictureBoxSizeMode.Zoom;
            controlPicture2.TabIndex = 6;
            controlPicture2.TabStop = false;
            // 
            // newProfPanel
            // 
            newProfPanel.Controls.Add(newProfPic);
            newProfPanel.Controls.Add(newProffButt);
            newProfPanel.Location = new Point(773, 59);
            newProfPanel.Margin = new Padding(10);
            newProfPanel.Name = "newProfPanel";
            newProfPanel.Padding = new Padding(10);
            newProfPanel.Size = new Size(138, 231);
            newProfPanel.TabIndex = 4;
            // 
            // newProfPic
            // 
            newProfPic.Dock = DockStyle.Top;
            newProfPic.Image = SchoolManagementSystem.Properties.Resources.login__5_1;
            newProfPic.Location = new Point(10, 10);
            newProfPic.Name = "newProfPic";
            newProfPic.Size = new Size(118, 67);
            newProfPic.SizeMode = PictureBoxSizeMode.Zoom;
            newProfPic.TabIndex = 2;
            newProfPic.TabStop = false;
            // 
            // newProffButt
            // 
            newProffButt.BackColor = Color.FromArgb(43, 180, 200);
            newProffButt.Dock = DockStyle.Bottom;
            newProffButt.FlatAppearance.BorderSize = 0;
            newProffButt.FlatStyle = FlatStyle.Flat;
            newProffButt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            newProffButt.ForeColor = Color.White;
            newProffButt.Location = new Point(10, 85);
            newProffButt.Margin = new Padding(10, 5, 10, 5);
            newProffButt.Name = "newProffButt";
            newProffButt.Padding = new Padding(5);
            newProffButt.Size = new Size(118, 136);
            newProffButt.TabIndex = 0;
            newProffButt.Text = "New Prof.";
            newProffButt.UseVisualStyleBackColor = false;
            newProffButt.Click += newProffButt_Click;
            // 
            // newClasspanel
            // 
            newClasspanel.Controls.Add(pictureBox7);
            newClasspanel.Controls.Add(newClassButt);
            newClasspanel.ForeColor = SystemColors.ActiveCaptionText;
            newClasspanel.Location = new Point(625, 59);
            newClasspanel.Margin = new Padding(10);
            newClasspanel.Name = "newClasspanel";
            newClasspanel.Padding = new Padding(10);
            newClasspanel.Size = new Size(138, 231);
            newClasspanel.TabIndex = 2;
            // 
            // pictureBox7
            // 
            pictureBox7.Dock = DockStyle.Top;
            pictureBox7.Image = SchoolManagementSystem.Properties.Resources.login__6_1;
            pictureBox7.Location = new Point(10, 10);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(118, 67);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 1;
            pictureBox7.TabStop = false;
            // 
            // newClassButt
            // 
            newClassButt.BackColor = Color.FromArgb(43, 180, 200);
            newClassButt.Dock = DockStyle.Bottom;
            newClassButt.FlatAppearance.BorderSize = 0;
            newClassButt.FlatStyle = FlatStyle.Flat;
            newClassButt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            newClassButt.ForeColor = Color.White;
            newClassButt.Location = new Point(10, 85);
            newClassButt.Margin = new Padding(10, 5, 10, 5);
            newClassButt.Name = "newClassButt";
            newClassButt.Padding = new Padding(5);
            newClassButt.Size = new Size(118, 136);
            newClassButt.TabIndex = 0;
            newClassButt.Text = "New Class";
            newClassButt.UseVisualStyleBackColor = false;
            newClassButt.Click += newClassButt_Click;
            // 
            // newStudPanel
            // 
            newStudPanel.Controls.Add(newStudButt);
            newStudPanel.Controls.Add(newStudPic);
            newStudPanel.Location = new Point(477, 59);
            newStudPanel.Margin = new Padding(10);
            newStudPanel.Name = "newStudPanel";
            newStudPanel.Padding = new Padding(10);
            newStudPanel.Size = new Size(138, 231);
            newStudPanel.TabIndex = 3;
            // 
            // newStudButt
            // 
            newStudButt.BackColor = Color.FromArgb(43, 180, 200);
            newStudButt.Dock = DockStyle.Bottom;
            newStudButt.FlatAppearance.BorderSize = 0;
            newStudButt.FlatStyle = FlatStyle.Flat;
            newStudButt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            newStudButt.ForeColor = Color.White;
            newStudButt.Location = new Point(10, 85);
            newStudButt.Margin = new Padding(10, 5, 10, 5);
            newStudButt.Name = "newStudButt";
            newStudButt.Padding = new Padding(5);
            newStudButt.Size = new Size(118, 136);
            newStudButt.TabIndex = 3;
            newStudButt.Text = "New Student";
            newStudButt.UseVisualStyleBackColor = false;
            newStudButt.Click += newStudButt_Click;
            // 
            // newStudPic
            // 
            newStudPic.Dock = DockStyle.Top;
            newStudPic.Image = SchoolManagementSystem.Properties.Resources.login__4_2;
            newStudPic.Location = new Point(10, 10);
            newStudPic.Name = "newStudPic";
            newStudPic.Size = new Size(118, 67);
            newStudPic.SizeMode = PictureBoxSizeMode.Zoom;
            newStudPic.TabIndex = 2;
            newStudPic.TabStop = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(classesBlockLabel);
            panel6.Controls.Add(exportButt);
            panel6.Controls.Add(importButt);
            panel6.Controls.Add(pickClass);
            panel6.Controls.Add(controlPicture1);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(911, 284);
            panel6.TabIndex = 3;
            // 
            // exportButt
            // 
            exportButt.BackColor = Color.FromArgb(43, 180, 200);
            exportButt.FlatAppearance.BorderColor = Color.FromArgb(43, 180, 200);
            exportButt.FlatAppearance.BorderSize = 5;
            exportButt.FlatStyle = FlatStyle.Flat;
            exportButt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            exportButt.ForeColor = Color.White;
            exportButt.Location = new Point(252, 206);
            exportButt.Name = "exportButt";
            exportButt.Size = new Size(142, 38);
            exportButt.TabIndex = 6;
            exportButt.Text = "Export Data";
            exportButt.UseVisualStyleBackColor = false;
            exportButt.Click += exportButt_Click;
            // 
            // importButt
            // 
            importButt.BackColor = Color.Transparent;
            importButt.FlatAppearance.BorderColor = Color.FromArgb(43, 180, 200);
            importButt.FlatAppearance.BorderSize = 5;
            importButt.FlatStyle = FlatStyle.Flat;
            importButt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            importButt.Location = new Point(48, 206);
            importButt.Name = "importButt";
            importButt.Size = new Size(142, 38);
            importButt.TabIndex = 2;
            importButt.Text = "Import Data";
            importButt.UseVisualStyleBackColor = false;
            importButt.Click += importButt_Click;
            // 
            // pickClass
            // 
            pickClass.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            pickClass.FormattingEnabled = true;
            pickClass.Location = new Point(0, 110);
            pickClass.Name = "pickClass";
            pickClass.Size = new Size(464, 28);
            pickClass.TabIndex = 5;
            pickClass.Text = "     Pick a class";
            pickClass.SelectedIndexChanged += pickClass_SelectedIndexChanged;
            // 
            // controlPicture1
            // 
            controlPicture1.Dock = DockStyle.Right;
            controlPicture1.Image = SchoolManagementSystem.Properties.Resources.login__1_1;
            controlPicture1.Location = new Point(463, 0);
            controlPicture1.Name = "controlPicture1";
            controlPicture1.Size = new Size(448, 284);
            controlPicture1.SizeMode = PictureBoxSizeMode.Zoom;
            controlPicture1.TabIndex = 0;
            controlPicture1.TabStop = false;
            // 
            // ControlPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "ControlPanel";
            Size = new Size(911, 612);
            panel1.ResumeLayout(false);
            panel8.ResumeLayout(false);
            newDataPanel.ResumeLayout(false);
            newDataPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)controlPicture2).EndInit();
            newProfPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)newProfPic).EndInit();
            newClasspanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            newStudPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)newStudPic).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)controlPicture1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
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
        private Panel panel6;
        private Button exportButt;
        private Button importButt;
        private ComboBox pickClass;
        private PictureBox controlPicture1;
    }
}
