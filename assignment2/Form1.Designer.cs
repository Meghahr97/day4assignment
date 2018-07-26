namespace assignment2
{
    partial class student
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtrollno = new System.Windows.Forms.TextBox();
            this.txtnane = new System.Windows.Forms.TextBox();
            this.rbmale = new System.Windows.Forms.RadioButton();
            this.rbfemale = new System.Windows.Forms.RadioButton();
            this.cbdepartment = new System.Windows.Forms.ComboBox();
            this.cbcourse = new System.Windows.Forms.ComboBox();
            this.cbsemester = new System.Windows.Forms.ComboBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnselect = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnfind = new System.Windows.Forms.Button();
            this.dtpdate = new System.Windows.Forms.DateTimePicker();
            this.lbselect = new System.Windows.Forms.ListBox();
            this.cbroll = new System.Windows.Forms.ComboBox();
            this.studentinformationDataSet10 = new assignment2.studentinformationDataSet10();
            this.studentinformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentinformationTableAdapter = new assignment2.studentinformationDataSet10TableAdapters.studentinformationTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.studentinformationDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentinformationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "student profile";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Roll NO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date of ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Department";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Course";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Semester";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 361);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Address";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 397);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Phone No";
            // 
            // txtrollno
            // 
            this.txtrollno.Location = new System.Drawing.Point(181, 58);
            this.txtrollno.Name = "txtrollno";
            this.txtrollno.Size = new System.Drawing.Size(144, 20);
            this.txtrollno.TabIndex = 10;
            // 
            // txtnane
            // 
            this.txtnane.Location = new System.Drawing.Point(181, 105);
            this.txtnane.Name = "txtnane";
            this.txtnane.Size = new System.Drawing.Size(135, 20);
            this.txtnane.TabIndex = 11;
            // 
            // rbmale
            // 
            this.rbmale.AutoSize = true;
            this.rbmale.Location = new System.Drawing.Point(162, 180);
            this.rbmale.Name = "rbmale";
            this.rbmale.Size = new System.Drawing.Size(47, 17);
            this.rbmale.TabIndex = 13;
            this.rbmale.TabStop = true;
            this.rbmale.Text = "male";
            this.rbmale.UseVisualStyleBackColor = true;
            // 
            // rbfemale
            // 
            this.rbfemale.AutoSize = true;
            this.rbfemale.Location = new System.Drawing.Point(264, 180);
            this.rbfemale.Name = "rbfemale";
            this.rbfemale.Size = new System.Drawing.Size(56, 17);
            this.rbfemale.TabIndex = 14;
            this.rbfemale.TabStop = true;
            this.rbfemale.Text = "female";
            this.rbfemale.UseVisualStyleBackColor = true;
            // 
            // cbdepartment
            // 
            this.cbdepartment.FormattingEnabled = true;
            this.cbdepartment.Items.AddRange(new object[] {
            "maths",
            "physics",
            "computerscience"});
            this.cbdepartment.Location = new System.Drawing.Point(181, 219);
            this.cbdepartment.Name = "cbdepartment";
            this.cbdepartment.Size = new System.Drawing.Size(144, 21);
            this.cbdepartment.TabIndex = 15;
            // 
            // cbcourse
            // 
            this.cbcourse.FormattingEnabled = true;
            this.cbcourse.Items.AddRange(new object[] {
            "maths",
            "physics",
            "computerscience"});
            this.cbcourse.Location = new System.Drawing.Point(181, 267);
            this.cbcourse.Name = "cbcourse";
            this.cbcourse.Size = new System.Drawing.Size(117, 21);
            this.cbcourse.TabIndex = 16;
            // 
            // cbsemester
            // 
            this.cbsemester.FormattingEnabled = true;
            this.cbsemester.Items.AddRange(new object[] {
            "first",
            "second",
            "third",
            "fourth"});
            this.cbsemester.Location = new System.Drawing.Point(181, 312);
            this.cbsemester.Name = "cbsemester";
            this.cbsemester.Size = new System.Drawing.Size(157, 21);
            this.cbsemester.TabIndex = 17;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(181, 354);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(136, 20);
            this.txtaddress.TabIndex = 18;
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(181, 380);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(157, 20);
            this.txtphone.TabIndex = 19;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(110, 439);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 20;
            this.btnadd.Text = "Add new";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnselect
            // 
            this.btnselect.Location = new System.Drawing.Point(205, 439);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(75, 23);
            this.btnselect.TabIndex = 21;
            this.btnselect.Text = "Select";
            this.btnselect.UseVisualStyleBackColor = true;
            this.btnselect.Click += new System.EventHandler(this.btnselect_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(296, 439);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 22;
            this.btnupdate.Text = "update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(410, 439);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 23;
            this.btndelete.Text = "delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnfind
            // 
            this.btnfind.Location = new System.Drawing.Point(34, 6);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(75, 23);
            this.btnfind.TabIndex = 24;
            this.btnfind.Text = "find";
            this.btnfind.UseVisualStyleBackColor = true;
            // 
            // dtpdate
            // 
            this.dtpdate.Location = new System.Drawing.Point(181, 140);
            this.dtpdate.Name = "dtpdate";
            this.dtpdate.Size = new System.Drawing.Size(156, 20);
            this.dtpdate.TabIndex = 25;
            // 
            // lbselect
            // 
            this.lbselect.FormattingEnabled = true;
            this.lbselect.Location = new System.Drawing.Point(516, 55);
            this.lbselect.Name = "lbselect";
            this.lbselect.Size = new System.Drawing.Size(149, 82);
            this.lbselect.TabIndex = 26;
            // 
            // cbroll
            // 
            this.cbroll.DataSource = this.studentinformationBindingSource;
            this.cbroll.DisplayMember = "name";
            this.cbroll.FormattingEnabled = true;
            this.cbroll.Location = new System.Drawing.Point(121, 6);
            this.cbroll.Name = "cbroll";
            this.cbroll.Size = new System.Drawing.Size(133, 21);
            this.cbroll.TabIndex = 27;
            this.cbroll.ValueMember = "Rollno";
            // 
            // studentinformationDataSet10
            // 
            this.studentinformationDataSet10.DataSetName = "studentinformationDataSet10";
            this.studentinformationDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentinformationBindingSource
            // 
            this.studentinformationBindingSource.DataMember = "studentinformation";
            this.studentinformationBindingSource.DataSource = this.studentinformationDataSet10;
            // 
            // studentinformationTableAdapter
            // 
            this.studentinformationTableAdapter.ClearBeforeFill = true;
            // 
            // student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 464);
            this.Controls.Add(this.cbroll);
            this.Controls.Add(this.lbselect);
            this.Controls.Add(this.dtpdate);
            this.Controls.Add(this.btnfind);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnselect);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.cbsemester);
            this.Controls.Add(this.cbcourse);
            this.Controls.Add(this.cbdepartment);
            this.Controls.Add(this.rbfemale);
            this.Controls.Add(this.rbmale);
            this.Controls.Add(this.txtnane);
            this.Controls.Add(this.txtrollno);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "student";
            this.Text = "StudentInformation";
            this.Load += new System.EventHandler(this.student_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.studentinformationDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentinformationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtrollno;
        private System.Windows.Forms.TextBox txtnane;
        private System.Windows.Forms.RadioButton rbmale;
        private System.Windows.Forms.RadioButton rbfemale;
        private System.Windows.Forms.ComboBox cbdepartment;
        private System.Windows.Forms.ComboBox cbcourse;
        private System.Windows.Forms.ComboBox cbsemester;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnfind;
        private System.Windows.Forms.DateTimePicker dtpdate;
        private System.Windows.Forms.ListBox lbselect;
        private System.Windows.Forms.ComboBox cbroll;
        private studentinformationDataSet10 studentinformationDataSet10;
        private System.Windows.Forms.BindingSource studentinformationBindingSource;
        private studentinformationDataSet10TableAdapters.studentinformationTableAdapter studentinformationTableAdapter;
    }
}

