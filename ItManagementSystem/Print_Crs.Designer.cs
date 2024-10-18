namespace ItManagementSystem
{
    partial class frmPrintCrs
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPrin = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblToPrint = new System.Windows.Forms.Label();
            this.btnCourse = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNewCourse = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnManageCourse = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDashBoard = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.lblITSchool = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CourseID = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.btnPrin);
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Location = new System.Drawing.Point(318, 75);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel2.Size = new System.Drawing.Size(1018, 588);
            this.panel2.TabIndex = 18;
            // 
            // btnPrin
            // 
            this.btnPrin.BackColor = System.Drawing.Color.Blue;
            this.btnPrin.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnPrin.ForeColor = System.Drawing.Color.Transparent;
            this.btnPrin.Location = new System.Drawing.Point(714, 514);
            this.btnPrin.Name = "btnPrin";
            this.btnPrin.Size = new System.Drawing.Size(266, 46);
            this.btnPrin.TabIndex = 19;
            this.btnPrin.Text = "Print";
            this.btnPrin.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Yellow;
            this.btnRefresh.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.Maroon;
            this.btnRefresh.Location = new System.Drawing.Point(744, 8);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(206, 37);
            this.btnRefresh.TabIndex = 18;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.Location = new System.Drawing.Point(16, 477);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(988, 11);
            this.panel3.TabIndex = 1;
            // 
            // lblToPrint
            // 
            this.lblToPrint.AutoSize = true;
            this.lblToPrint.Font = new System.Drawing.Font("Sylfaen", 36F, System.Drawing.FontStyle.Bold);
            this.lblToPrint.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblToPrint.Location = new System.Drawing.Point(712, 0);
            this.lblToPrint.Name = "lblToPrint";
            this.lblToPrint.Size = new System.Drawing.Size(203, 62);
            this.lblToPrint.TabIndex = 45;
            this.lblToPrint.Text = "To Print";
            // 
            // btnCourse
            // 
            this.btnCourse.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCourse.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCourse.ForeColor = System.Drawing.Color.White;
            this.btnCourse.Location = new System.Drawing.Point(21, 291);
            this.btnCourse.Name = "btnCourse";
            this.btnCourse.Size = new System.Drawing.Size(170, 39);
            this.btnCourse.TabIndex = 57;
            this.btnCourse.Text = "Course";
            this.btnCourse.UseVisualStyleBackColor = false;
            this.btnCourse.Click += new System.EventHandler(this.btnCourse_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.btnNewCourse);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.btnManageCourse);
            this.panel1.Location = new System.Drawing.Point(0, 335);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 147);
            this.panel1.TabIndex = 60;
            // 
            // btnNewCourse
            // 
            this.btnNewCourse.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnNewCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewCourse.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnNewCourse.ForeColor = System.Drawing.Color.White;
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
            this.btnPrint.ForeColor = System.Drawing.Color.MidnightBlue;
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
            this.btnExit.TabIndex = 59;
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
            this.btnDashBoard.TabIndex = 58;
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
            this.btnStudent.TabIndex = 56;
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
            this.lblITSchool.TabIndex = 55;
            this.lblITSchool.Text = "IT School";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Sylfaen", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblFrom.Location = new System.Drawing.Point(14, 160);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(79, 35);
            this.lblFrom.TabIndex = 54;
            this.lblFrom.Text = "From";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Sylfaen", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblWelcome.Location = new System.Drawing.Point(29, 105);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(224, 48);
            this.lblWelcome.TabIndex = 53;
            this.lblWelcome.Text = "WELCOME ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CourseID,
            this.CourseName,
            this.Hour,
            this.Description});
            this.dataGridView1.Location = new System.Drawing.Point(16, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1153, 426);
            this.dataGridView1.TabIndex = 42;
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
            // frmPrintCrs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1335, 663);
            this.Controls.Add(this.btnCourse);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDashBoard);
            this.Controls.Add(this.btnStudent);
            this.Controls.Add(this.lblITSchool);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblToPrint);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmPrintCrs";
            this.Text = "Course Print Form";
            this.Load += new System.EventHandler(this.frmPrintCrs_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPrin;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblToPrint;
        private System.Windows.Forms.Button btnCourse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNewCourse;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnManageCourse;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDashBoard;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Label lblITSchool;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn CourseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hour;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}