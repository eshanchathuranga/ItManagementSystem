namespace ItManagementSystem
{
    partial class frmNwCrs
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtHour = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblHour = new System.Windows.Forms.Label();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblCourses = new System.Windows.Forms.Label();
            this.btnCourse = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnNewCourse = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnManageCourse = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDashBoard = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.lblITSchool = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.CourseID = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.txtHour);
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Controls.Add(this.txtCourseName);
            this.panel1.Controls.Add(this.lblDescription);
            this.panel1.Controls.Add(this.lblHour);
            this.panel1.Controls.Add(this.lblCourseName);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(318, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1018, 588);
            this.panel1.TabIndex = 47;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAdd.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Transparent;
            this.btnAdd.Location = new System.Drawing.Point(780, 518);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(142, 46);
            this.btnAdd.TabIndex = 35;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClear.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Transparent;
            this.btnClear.Location = new System.Drawing.Point(595, 518);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(142, 46);
            this.btnClear.TabIndex = 34;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // txtHour
            // 
            this.txtHour.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtHour.Location = new System.Drawing.Point(689, 356);
            this.txtHour.Name = "txtHour";
            this.txtHour.Size = new System.Drawing.Size(233, 35);
            this.txtHour.TabIndex = 30;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtDescription.Location = new System.Drawing.Point(252, 397);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(581, 103);
            this.txtDescription.TabIndex = 28;
            // 
            // txtCourseName
            // 
            this.txtCourseName.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtCourseName.Location = new System.Drawing.Point(252, 356);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(311, 35);
            this.txtCourseName.TabIndex = 27;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblDescription.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblDescription.Location = new System.Drawing.Point(84, 400);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(138, 27);
            this.lblDescription.TabIndex = 23;
            this.lblDescription.Text = "Description :";
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblHour.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblHour.Location = new System.Drawing.Point(595, 359);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(75, 27);
            this.lblHour.TabIndex = 22;
            this.lblHour.Text = "Hour :";
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblCourseName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblCourseName.Location = new System.Drawing.Point(63, 359);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(156, 27);
            this.lblCourseName.TabIndex = 21;
            this.lblCourseName.Text = "Course Name :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Location = new System.Drawing.Point(14, 324);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(988, 11);
            this.panel2.TabIndex = 20;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CourseID,
            this.CourseName,
            this.Hour,
            this.Description});
            this.dataGridView1.Location = new System.Drawing.Point(14, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(988, 329);
            this.dataGridView1.TabIndex = 19;
            // 
            // lblCourses
            // 
            this.lblCourses.AutoSize = true;
            this.lblCourses.Font = new System.Drawing.Font("Sylfaen", 36F, System.Drawing.FontStyle.Bold);
            this.lblCourses.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblCourses.Location = new System.Drawing.Point(707, 0);
            this.lblCourses.Name = "lblCourses";
            this.lblCourses.Size = new System.Drawing.Size(189, 62);
            this.lblCourses.TabIndex = 48;
            this.lblCourses.Text = "Courses";
            // 
            // btnCourse
            // 
            this.btnCourse.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCourse.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCourse.ForeColor = System.Drawing.Color.White;
            this.btnCourse.Location = new System.Drawing.Point(21, 291);
            this.btnCourse.Name = "btnCourse";
            this.btnCourse.Size = new System.Drawing.Size(170, 39);
            this.btnCourse.TabIndex = 52;
            this.btnCourse.Text = "Course";
            this.btnCourse.UseVisualStyleBackColor = false;
            this.btnCourse.Click += new System.EventHandler(this.btnCourse_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel3.Controls.Add(this.btnNewCourse);
            this.panel3.Controls.Add(this.btnPrint);
            this.panel3.Controls.Add(this.btnManageCourse);
            this.panel3.Location = new System.Drawing.Point(0, 335);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(318, 147);
            this.panel3.TabIndex = 55;
            // 
            // btnNewCourse
            // 
            this.btnNewCourse.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnNewCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewCourse.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnNewCourse.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnNewCourse.Location = new System.Drawing.Point(65, 11);
            this.btnNewCourse.Name = "btnNewCourse";
            this.btnNewCourse.Size = new System.Drawing.Size(212, 34);
            this.btnNewCourse.TabIndex = 16;
            this.btnNewCourse.Text = "New Course";
            this.btnNewCourse.UseVisualStyleBackColor = false;
            this.btnNewCourse.Click += new System.EventHandler(this.btnNewCourse_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(65, 101);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(212, 34);
            this.btnPrint.TabIndex = 18;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnManageCourse
            // 
            this.btnManageCourse.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnManageCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageCourse.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnManageCourse.ForeColor = System.Drawing.Color.White;
            this.btnManageCourse.Location = new System.Drawing.Point(65, 56);
            this.btnManageCourse.Name = "btnManageCourse";
            this.btnManageCourse.Size = new System.Drawing.Size(212, 34);
            this.btnManageCourse.TabIndex = 17;
            this.btnManageCourse.Text = "Manage  Course";
            this.btnManageCourse.UseVisualStyleBackColor = false;
            this.btnManageCourse.Click += new System.EventHandler(this.btnManageCourse_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnExit.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(22, 564);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(217, 39);
            this.btnExit.TabIndex = 54;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDashBoard
            // 
            this.btnDashBoard.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnDashBoard.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnDashBoard.ForeColor = System.Drawing.Color.White;
            this.btnDashBoard.Location = new System.Drawing.Point(22, 492);
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.Size = new System.Drawing.Size(170, 39);
            this.btnDashBoard.TabIndex = 53;
            this.btnDashBoard.Text = "Dash Board";
            this.btnDashBoard.UseVisualStyleBackColor = false;
            this.btnDashBoard.Click += new System.EventHandler(this.btnDashBoard_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStudent.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnStudent.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnStudent.ForeColor = System.Drawing.Color.White;
            this.btnStudent.Location = new System.Drawing.Point(21, 242);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(170, 39);
            this.btnStudent.TabIndex = 51;
            this.btnStudent.Text = "Student";
            this.btnStudent.UseVisualStyleBackColor = false;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // lblITSchool
            // 
            this.lblITSchool.AutoSize = true;
            this.lblITSchool.Font = new System.Drawing.Font("Sylfaen", 27.75F, System.Drawing.FontStyle.Bold);
            this.lblITSchool.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblITSchool.Location = new System.Drawing.Point(104, 150);
            this.lblITSchool.Name = "lblITSchool";
            this.lblITSchool.Size = new System.Drawing.Size(178, 48);
            this.lblITSchool.TabIndex = 50;
            this.lblITSchool.Text = "IT School";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Sylfaen", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblWelcome.Location = new System.Drawing.Point(29, 105);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(224, 48);
            this.lblWelcome.TabIndex = 49;
            this.lblWelcome.Text = "WELCOME ";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Sylfaen", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblFrom.Location = new System.Drawing.Point(14, 160);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(79, 35);
            this.lblFrom.TabIndex = 56;
            this.lblFrom.Text = "From";
            // 
            // CourseID
            // 
            this.CourseID.HeaderText = "Course ID";
            this.CourseID.Name = "CourseID";
            // 
            // CourseName
            // 
            this.CourseName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CourseName.HeaderText = "Course Name";
            this.CourseName.Name = "CourseName";
            // 
            // Hour
            // 
            this.Hour.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Hour.HeaderText = "Hour";
            this.Hour.Name = "Hour";
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // frmNwCrs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1335, 663);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.btnCourse);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDashBoard);
            this.Controls.Add(this.btnStudent);
            this.Controls.Add(this.lblITSchool);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblCourses);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmNwCrs";
            this.Text = "New Course Form";
            this.Load += new System.EventHandler(this.frmNwCrs_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtHour;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblCourses;
        private System.Windows.Forms.Button btnCourse;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnNewCourse;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnManageCourse;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDashBoard;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Label lblITSchool;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DataGridViewButtonColumn CourseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hour;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}