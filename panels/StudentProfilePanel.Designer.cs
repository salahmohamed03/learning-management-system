namespace SchoolManagementSystem.panels
{
    partial class StudentProfilePanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentProfilePanel));
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            pictureBox1 = new PictureBox();
            stuName = new Label();
            stuAge = new Label();
            stuEmail = new Label();
            stuPhone = new Label();
            stuGrade = new Label();
            stuID = new Label();
            StudentsTable = new DataGridView();
            Name = new DataGridViewTextBoxColumn();
            vScrollBar1 = new VScrollBar();
            label1 = new Label();
            comboBox1 = new ComboBox();
            addCourse = new Button();
            Delete = new Button();
            Edit = new Button();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)StudentsTable).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(911, 612);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // stuName
            // 
            stuName.AutoSize = true;
            stuName.BackColor = Color.FromArgb(43, 180, 200);
            stuName.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            stuName.ForeColor = Color.White;
            stuName.Location = new Point(187, 36);
            stuName.Name = "stuName";
            stuName.Size = new Size(69, 29);
            stuName.TabIndex = 1;
            stuName.Text = "label1";
            stuName.Click += label1_Click;
            // 
            // stuAge
            // 
            stuAge.AutoSize = true;
            stuAge.BackColor = SystemColors.ButtonHighlight;
            stuAge.Font = new Font("Yu Gothic UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            stuAge.ForeColor = Color.FromArgb(11, 111, 125);
            stuAge.Location = new Point(228, 122);
            stuAge.Name = "stuAge";
            stuAge.Size = new Size(43, 17);
            stuAge.TabIndex = 2;
            stuAge.Text = "label2";
            stuAge.Click += stuAge_Click;
            // 
            // stuEmail
            // 
            stuEmail.AutoSize = true;
            stuEmail.BackColor = SystemColors.ButtonHighlight;
            stuEmail.Font = new Font("Yu Gothic UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            stuEmail.ForeColor = Color.FromArgb(11, 111, 125);
            stuEmail.Location = new Point(236, 183);
            stuEmail.Name = "stuEmail";
            stuEmail.Size = new Size(43, 17);
            stuEmail.TabIndex = 3;
            stuEmail.Text = "label3";
            // 
            // stuPhone
            // 
            stuPhone.AutoSize = true;
            stuPhone.BackColor = SystemColors.ButtonHighlight;
            stuPhone.Font = new Font("Yu Gothic UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            stuPhone.ForeColor = Color.FromArgb(11, 111, 125);
            stuPhone.Location = new Point(243, 153);
            stuPhone.Name = "stuPhone";
            stuPhone.Size = new Size(43, 17);
            stuPhone.TabIndex = 4;
            stuPhone.Text = "label4";
            // 
            // stuGrade
            // 
            stuGrade.AutoSize = true;
            stuGrade.BackColor = SystemColors.ButtonHighlight;
            stuGrade.Font = new Font("Yu Gothic UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            stuGrade.ForeColor = Color.FromArgb(11, 111, 125);
            stuGrade.Location = new Point(578, 153);
            stuGrade.Name = "stuGrade";
            stuGrade.Size = new Size(43, 17);
            stuGrade.TabIndex = 5;
            stuGrade.Text = "label5";
            // 
            // stuID
            // 
            stuID.AutoSize = true;
            stuID.BackColor = Color.FromArgb(43, 180, 200);
            stuID.Font = new Font("Yu Gothic UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            stuID.ForeColor = Color.White;
            stuID.Location = new Point(271, 75);
            stuID.Name = "stuID";
            stuID.Size = new Size(43, 17);
            stuID.TabIndex = 6;
            stuID.Text = "label6";
            // 
            // StudentsTable
            // 
            StudentsTable.AllowUserToAddRows = false;
            StudentsTable.AllowUserToDeleteRows = false;
            StudentsTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(233, 245, 247);
            StudentsTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            StudentsTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            StudentsTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            StudentsTable.BackgroundColor = SystemColors.ControlLight;
            StudentsTable.BorderStyle = BorderStyle.None;
            StudentsTable.CellBorderStyle = DataGridViewCellBorderStyle.None;
            StudentsTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(43, 180, 200);
            dataGridViewCellStyle12.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = Color.White;
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(43, 180, 200);
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            StudentsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            StudentsTable.ColumnHeadersHeight = 35;
            StudentsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            StudentsTable.Columns.AddRange(new DataGridViewColumn[] { Name });
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = SystemColors.Window;
            dataGridViewCellStyle14.Font = new Font("Cooper Black", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle14.ForeColor = Color.Silver;
            dataGridViewCellStyle14.SelectionBackColor = Color.FromArgb(252, 252, 252);
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.False;
            StudentsTable.DefaultCellStyle = dataGridViewCellStyle14;
            StudentsTable.EnableHeadersVisualStyles = false;
            StudentsTable.Location = new Point(42, 239);
            StudentsTable.Name = "StudentsTable";
            StudentsTable.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = SystemColors.Control;
            dataGridViewCellStyle15.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle15.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = Color.Transparent;
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.True;
            StudentsTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            StudentsTable.RowHeadersVisible = false;
            StudentsTable.RowHeadersWidth = 51;
            StudentsTable.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Silver;
            StudentsTable.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            StudentsTable.RowTemplate.Height = 29;
            StudentsTable.ScrollBars = ScrollBars.None;
            StudentsTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            StudentsTable.Size = new Size(746, 216);
            StudentsTable.TabIndex = 7;
            StudentsTable.CellContentClick += StudentsTable_CellContentClick;
            StudentsTable.RowsAdded += StudentsTable_RowsAdded;
            StudentsTable.RowsRemoved += StudentsTable_RowsRemoved;
            // 
            // Name
            // 
            dataGridViewCellStyle13.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle13.SelectionForeColor = Color.Transparent;
            Name.DefaultCellStyle = dataGridViewCellStyle13;
            Name.HeaderText = "Courses";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
            Name.ReadOnly = true;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(823, 239);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(26, 216);
            vScrollBar1.TabIndex = 8;
            vScrollBar1.Scroll += vScrollBar1_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(241, 241, 241);
            label1.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(43, 180, 200);
            label1.Location = new Point(42, 496);
            label1.Name = "label1";
            label1.Size = new Size(175, 21);
            label1.TabIndex = 11;
            label1.Text = "Add a new course";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(42, 531);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(402, 28);
            comboBox1.TabIndex = 12;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // addCourse
            // 
            addCourse.BackColor = Color.FromArgb(43, 180, 200);
            addCourse.FlatStyle = FlatStyle.Flat;
            addCourse.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            addCourse.ForeColor = Color.White;
            addCourse.Location = new Point(482, 531);
            addCourse.Name = "addCourse";
            addCourse.Size = new Size(80, 29);
            addCourse.TabIndex = 13;
            addCourse.Text = "Add";
            addCourse.UseVisualStyleBackColor = false;
            addCourse.Click += addCourse_Click;
            // 
            // Delete
            // 
            Delete.BackColor = Color.Red;
            Delete.FlatStyle = FlatStyle.Flat;
            Delete.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Delete.ForeColor = Color.White;
            Delete.Location = new Point(807, 531);
            Delete.Name = "Delete";
            Delete.Size = new Size(80, 29);
            Delete.TabIndex = 14;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = false;
            Delete.Click += Delete_Click;
            // 
            // Edit
            // 
            Edit.BackColor = Color.DarkGray;
            Edit.FlatStyle = FlatStyle.Flat;
            Edit.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Edit.ForeColor = Color.White;
            Edit.Location = new Point(708, 531);
            Edit.Name = "Edit";
            Edit.Size = new Size(80, 29);
            Edit.TabIndex = 15;
            Edit.Text = "Edit";
            Edit.UseVisualStyleBackColor = false;
            Edit.Click += Edit_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(43, 180, 200);
            label6.Font = new Font("Yu Gothic UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(187, 75);
            label6.Name = "label6";
            label6.Size = new Size(78, 17);
            label6.TabIndex = 26;
            label6.Text = "ID Number:";
            label6.Click += label6_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.Font = new Font("Yu Gothic UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(11, 111, 125);
            label4.Location = new Point(187, 183);
            label4.Name = "label4";
            label4.Size = new Size(43, 17);
            label4.TabIndex = 25;
            label4.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Font = new Font("Yu Gothic UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(11, 111, 125);
            label3.Location = new Point(187, 153);
            label3.Name = "label3";
            label3.Size = new Size(50, 17);
            label3.TabIndex = 24;
            label3.Text = "Phone:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Font = new Font("Yu Gothic UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(11, 111, 125);
            label2.Location = new Point(187, 122);
            label2.Name = "label2";
            label2.Size = new Size(35, 17);
            label2.TabIndex = 23;
            label2.Text = "Age:";
            // 
            // StudentProfilePanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Edit);
            Controls.Add(Delete);
            Controls.Add(addCourse);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(vScrollBar1);
            Controls.Add(StudentsTable);
            Controls.Add(stuID);
            Controls.Add(stuGrade);
            Controls.Add(stuPhone);
            Controls.Add(stuEmail);
            Controls.Add(stuAge);
            Controls.Add(stuName);
            Controls.Add(pictureBox1);
 //           Name = "StudentProfilePanel";
            Size = new Size(911, 612);
            Load += StudentProfilePanel_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)StudentsTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label stuName;
        private Label stuAge;
        private Label stuEmail;
        private Label stuPhone;
        private Label stuGrade;
        private Label stuID;
        private DataGridView StudentsTable;
        private VScrollBar vScrollBar1;
        private DataGridViewTextBoxColumn Name;
        private Label label1;
        private ComboBox comboBox1;
        private Button addCourse;
        private Button Delete;
        private Button Edit;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}
