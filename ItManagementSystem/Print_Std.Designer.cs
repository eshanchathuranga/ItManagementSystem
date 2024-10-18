namespace ItManagementSystem
{
    partial class frmPrintStd
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
            this.btnCourse = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDashBoard = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.lblITSchool = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RadAll = new System.Windows.Forms.RadioButton();
            this.RadFemale = new System.Windows.Forms.RadioButton();
            this.RadMale = new System.Windows.Forms.RadioButton();
            this.lblGender = new System.Windows.Forms.Label();
            this.btnPrin = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRegistration = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnManageStudent = new System.Windows.Forms.Button();
            this.lblToPrint = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IDNo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BOD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCourse
            // 
            this.btnCourse.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCourse.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCourse.ForeColor = System.Drawing.Color.White;
            this.btnCourse.Location = new System.Drawing.Point(21, 443);
            this.btnCourse.Name = "btnCourse";
            this.btnCourse.Size = new System.Drawing.Size(170, 39);
            this.btnCourse.TabIndex = 42;
            this.btnCourse.Text = "Course";
            this.btnCourse.UseVisualStyleBackColor = false;
            this.btnCourse.Click += new System.EventHandler(this.btnCourse_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnExit.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(22, 564);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(217, 39);
            this.btnExit.TabIndex = 44;
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
            this.btnDashBoard.TabIndex = 43;
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
            this.btnStudent.TabIndex = 41;
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
            this.lblITSchool.TabIndex = 40;
            this.lblITSchool.Text = "IT School";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Sylfaen", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblFrom.Location = new System.Drawing.Point(14, 160);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(249, 35);
            this.lblFrom.TabIndex = 39;
            this.lblFrom.Text = "Student Print Form";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Sylfaen", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblWelcome.Location = new System.Drawing.Point(29, 105);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(224, 48);
            this.lblWelcome.TabIndex = 38;
            this.lblWelcome.Text = "WELCOME ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.RadAll);
            this.panel2.Controls.Add(this.RadFemale);
            this.panel2.Controls.Add(this.RadMale);
            this.panel2.Controls.Add(this.lblGender);
            this.panel2.Controls.Add(this.btnPrin);
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Location = new System.Drawing.Point(318, 75);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel2.Size = new System.Drawing.Size(1018, 588);
            this.panel2.TabIndex = 48;
            // 
            // RadAll
            // 
            this.RadAll.AutoSize = true;
            this.RadAll.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold);
            this.RadAll.Location = new System.Drawing.Point(435, 11);
            this.RadAll.Name = "RadAll";
            this.RadAll.Size = new System.Drawing.Size(60, 31);
            this.RadAll.TabIndex = 27;
            this.RadAll.TabStop = true;
            this.RadAll.Text = "All";
            this.RadAll.UseVisualStyleBackColor = true;
            // 
            // RadFemale
            // 
            this.RadFemale.AutoSize = true;
            this.RadFemale.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold);
            this.RadFemale.Location = new System.Drawing.Point(512, 11);
            this.RadFemale.Name = "RadFemale";
            this.RadFemale.Size = new System.Drawing.Size(101, 31);
            this.RadFemale.TabIndex = 26;
            this.RadFemale.TabStop = true;
            this.RadFemale.Text = "Female";
            this.RadFemale.UseVisualStyleBackColor = true;
            // 
            // RadMale
            // 
            this.RadMale.AutoSize = true;
            this.RadMale.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold);
            this.RadMale.Location = new System.Drawing.Point(637, 11);
            this.RadMale.Name = "RadMale";
            this.RadMale.Size = new System.Drawing.Size(79, 31);
            this.RadMale.TabIndex = 25;
            this.RadMale.TabStop = true;
            this.RadMale.Text = "Male";
            this.RadMale.UseVisualStyleBackColor = true;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblGender.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblGender.Location = new System.Drawing.Point(315, 13);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(96, 27);
            this.lblGender.TabIndex = 24;
            this.lblGender.Text = "Gender :";
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
            this.btnPrin.Click += new System.EventHandler(this.btnPrin_Click);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Location = new System.Drawing.Point(14, 477);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(988, 11);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel3.Controls.Add(this.btnRegistration);
            this.panel3.Controls.Add(this.btnPrint);
            this.panel3.Controls.Add(this.btnManageStudent);
            this.panel3.Location = new System.Drawing.Point(0, 287);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(318, 147);
            this.panel3.TabIndex = 49;
            // 
            // btnRegistration
            // 
            this.btnRegistration.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistration.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnRegistration.ForeColor = System.Drawing.Color.White;
            this.btnRegistration.Location = new System.Drawing.Point(65, 11);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(212, 34);
            this.btnRegistration.TabIndex = 16;
            this.btnRegistration.Text = "Registration";
            this.btnRegistration.UseVisualStyleBackColor = false;
            this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click);
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
            // btnManageStudent
            // 
            this.btnManageStudent.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnManageStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageStudent.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnManageStudent.ForeColor = System.Drawing.Color.White;
            this.btnManageStudent.Location = new System.Drawing.Point(65, 56);
            this.btnManageStudent.Name = "btnManageStudent";
            this.btnManageStudent.Size = new System.Drawing.Size(212, 34);
            this.btnManageStudent.TabIndex = 17;
            this.btnManageStudent.Text = "Manage Student";
            this.btnManageStudent.UseVisualStyleBackColor = false;
            this.btnManageStudent.Click += new System.EventHandler(this.btnManageStudent_Click);
            // 
            // lblToPrint
            // 
            this.lblToPrint.AutoSize = true;
            this.lblToPrint.Font = new System.Drawing.Font("Sylfaen", 36F, System.Drawing.FontStyle.Bold);
            this.lblToPrint.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblToPrint.Location = new System.Drawing.Point(712, 0);
            this.lblToPrint.Name = "lblToPrint";
            this.lblToPrint.Size = new System.Drawing.Size(203, 62);
            this.lblToPrint.TabIndex = 50;
            this.lblToPrint.Text = "To Print";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDNo,
            this.FirstName,
            this.LastName,
            this.Contact,
            this.BOD,
            this.Gender,
            this.Address});
            this.dataGridView1.Location = new System.Drawing.Point(14, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(988, 426);
            this.dataGridView1.TabIndex = 28;
            // 
            // IDNo
            // 
            this.IDNo.HeaderText = "IDNo";
            this.IDNo.Name = "IDNo";
            // 
            // FirstName
            // 
            this.FirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            this.LastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            // 
            // Contact
            // 
            this.Contact.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Contact.HeaderText = "Contact";
            this.Contact.Name = "Contact";
            // 
            // BOD
            // 
            this.BOD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BOD.HeaderText = "Date of Birth";
            this.BOD.Name = "BOD";
            // 
            // Gender
            // 
            this.Gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            // 
            // Address
            // 
            this.Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            // 
            // frmPrintStd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1335, 663);
            this.Controls.Add(this.lblToPrint);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnCourse);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDashBoard);
            this.Controls.Add(this.btnStudent);
            this.Controls.Add(this.lblITSchool);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.lblWelcome);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmPrintStd";
            this.Text = "Student Print Form";
            this.Load += new System.EventHandler(this.frmPrintStd_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCourse;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDashBoard;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Label lblITSchool;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton RadAll;
        private System.Windows.Forms.RadioButton RadFemale;
        private System.Windows.Forms.RadioButton RadMale;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Button btnPrin;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnRegistration;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnManageStudent;
        private System.Windows.Forms.Label lblToPrint;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn IDNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn BOD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
    }
}