namespace OOD___Student_System
{
    partial class Main_Form
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
            btnPromoteTeacher = new Button();
            grpBxActionForm = new GroupBox();
            btnCelebrateBirthday = new Button();
            nudStudentECs = new NumericUpDown();
            nudPCN = new NumericUpDown();
            btnShowInfo = new Button();
            btnStartNewSchoolyear = new Button();
            btnAddECs = new Button();
            label2 = new Label();
            grpBxAddForm = new GroupBox();
            label3 = new Label();
            rdBtnAddFormTeacher = new RadioButton();
            rdBtnAddFormStudent = new RadioButton();
            nudAddFormSalary = new NumericUpDown();
            nudAddFormECs = new NumericUpDown();
            nudAddFormYearsAtSchool = new NumericUpDown();
            nudAddFormPCN = new NumericUpDown();
            nudAddFormAge = new NumericUpDown();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnNewPerson = new Button();
            txtBxAddFormName = new TextBox();
            lstBxMainDisplay = new ListBox();
            btnShowAllPesons = new Button();
            btnSearchViaPartialName = new Button();
            cmbBxShowFilter = new ComboBox();
            txtBxPartialName = new TextBox();
            grpBxActionForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudStudentECs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPCN).BeginInit();
            grpBxAddForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudAddFormSalary).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAddFormECs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAddFormYearsAtSchool).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAddFormPCN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAddFormAge).BeginInit();
            SuspendLayout();
            // 
            // btnPromoteTeacher
            // 
            btnPromoteTeacher.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnPromoteTeacher.Location = new Point(6, 190);
            btnPromoteTeacher.Name = "btnPromoteTeacher";
            btnPromoteTeacher.Size = new Size(212, 26);
            btnPromoteTeacher.TabIndex = 21;
            btnPromoteTeacher.Text = "Promote";
            btnPromoteTeacher.UseVisualStyleBackColor = true;
            btnPromoteTeacher.Click += btnPromoteTeacher_Click;
            // 
            // grpBxActionForm
            // 
            grpBxActionForm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            grpBxActionForm.Controls.Add(btnCelebrateBirthday);
            grpBxActionForm.Controls.Add(nudStudentECs);
            grpBxActionForm.Controls.Add(nudPCN);
            grpBxActionForm.Controls.Add(btnPromoteTeacher);
            grpBxActionForm.Controls.Add(btnShowInfo);
            grpBxActionForm.Controls.Add(btnStartNewSchoolyear);
            grpBxActionForm.Controls.Add(btnAddECs);
            grpBxActionForm.Controls.Add(label2);
            grpBxActionForm.Location = new Point(736, 14);
            grpBxActionForm.Name = "grpBxActionForm";
            grpBxActionForm.Size = new Size(224, 223);
            grpBxActionForm.TabIndex = 0;
            grpBxActionForm.TabStop = false;
            grpBxActionForm.Text = "Action Form";
            // 
            // btnCelebrateBirthday
            // 
            btnCelebrateBirthday.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnCelebrateBirthday.Location = new Point(6, 94);
            btnCelebrateBirthday.Name = "btnCelebrateBirthday";
            btnCelebrateBirthday.Size = new Size(212, 26);
            btnCelebrateBirthday.TabIndex = 32;
            btnCelebrateBirthday.Text = "Celebrate birthday";
            btnCelebrateBirthday.UseVisualStyleBackColor = true;
            btnCelebrateBirthday.Click += btnCelebrateBirthday_Click;
            // 
            // nudStudentECs
            // 
            nudStudentECs.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nudStudentECs.Location = new Point(6, 158);
            nudStudentECs.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            nudStudentECs.Name = "nudStudentECs";
            nudStudentECs.Size = new Size(90, 25);
            nudStudentECs.TabIndex = 31;
            nudStudentECs.TextAlign = HorizontalAlignment.Right;
            // 
            // nudPCN
            // 
            nudPCN.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nudPCN.Location = new Point(102, 31);
            nudPCN.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudPCN.Name = "nudPCN";
            nudPCN.Size = new Size(116, 25);
            nudPCN.TabIndex = 30;
            nudPCN.TextAlign = HorizontalAlignment.Right;
            // 
            // btnShowInfo
            // 
            btnShowInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnShowInfo.Location = new Point(6, 62);
            btnShowInfo.Name = "btnShowInfo";
            btnShowInfo.Size = new Size(212, 26);
            btnShowInfo.TabIndex = 28;
            btnShowInfo.Text = "Show info";
            btnShowInfo.UseVisualStyleBackColor = true;
            btnShowInfo.Click += btnShowInfo_Click;
            // 
            // btnStartNewSchoolyear
            // 
            btnStartNewSchoolyear.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnStartNewSchoolyear.Location = new Point(6, 126);
            btnStartNewSchoolyear.Name = "btnStartNewSchoolyear";
            btnStartNewSchoolyear.Size = new Size(212, 26);
            btnStartNewSchoolyear.TabIndex = 23;
            btnStartNewSchoolyear.Text = "Start new schoolyear";
            btnStartNewSchoolyear.UseVisualStyleBackColor = true;
            btnStartNewSchoolyear.Click += btnStartNewSchoolyear_Click;
            // 
            // btnAddECs
            // 
            btnAddECs.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddECs.Location = new Point(102, 158);
            btnAddECs.Name = "btnAddECs";
            btnAddECs.Size = new Size(116, 26);
            btnAddECs.TabIndex = 18;
            btnAddECs.Text = "Add ECs";
            btnAddECs.UseVisualStyleBackColor = true;
            btnAddECs.Click += btnAddECs_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 33);
            label2.Name = "label2";
            label2.Size = new Size(39, 19);
            label2.TabIndex = 10;
            label2.Text = "PCN:";
            // 
            // grpBxAddForm
            // 
            grpBxAddForm.Controls.Add(label3);
            grpBxAddForm.Controls.Add(rdBtnAddFormTeacher);
            grpBxAddForm.Controls.Add(rdBtnAddFormStudent);
            grpBxAddForm.Controls.Add(nudAddFormSalary);
            grpBxAddForm.Controls.Add(nudAddFormECs);
            grpBxAddForm.Controls.Add(nudAddFormYearsAtSchool);
            grpBxAddForm.Controls.Add(nudAddFormPCN);
            grpBxAddForm.Controls.Add(nudAddFormAge);
            grpBxAddForm.Controls.Add(label6);
            grpBxAddForm.Controls.Add(label7);
            grpBxAddForm.Controls.Add(label8);
            grpBxAddForm.Controls.Add(label9);
            grpBxAddForm.Controls.Add(label4);
            grpBxAddForm.Controls.Add(label5);
            grpBxAddForm.Controls.Add(btnNewPerson);
            grpBxAddForm.Controls.Add(txtBxAddFormName);
            grpBxAddForm.Location = new Point(12, 14);
            grpBxAddForm.Name = "grpBxAddForm";
            grpBxAddForm.Size = new Size(247, 328);
            grpBxAddForm.TabIndex = 0;
            grpBxAddForm.TabStop = false;
            grpBxAddForm.Text = "Add form";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 34);
            label3.Name = "label3";
            label3.Size = new Size(40, 19);
            label3.TabIndex = 34;
            label3.Text = "Type:";
            // 
            // rdBtnAddFormTeacher
            // 
            rdBtnAddFormTeacher.AutoSize = true;
            rdBtnAddFormTeacher.Location = new Point(114, 61);
            rdBtnAddFormTeacher.Name = "rdBtnAddFormTeacher";
            rdBtnAddFormTeacher.Size = new Size(73, 23);
            rdBtnAddFormTeacher.TabIndex = 33;
            rdBtnAddFormTeacher.TabStop = true;
            rdBtnAddFormTeacher.Text = "Teacher";
            rdBtnAddFormTeacher.UseVisualStyleBackColor = true;
            // 
            // rdBtnAddFormStudent
            // 
            rdBtnAddFormStudent.AutoSize = true;
            rdBtnAddFormStudent.Checked = true;
            rdBtnAddFormStudent.Location = new Point(114, 31);
            rdBtnAddFormStudent.Name = "rdBtnAddFormStudent";
            rdBtnAddFormStudent.Size = new Size(75, 23);
            rdBtnAddFormStudent.TabIndex = 32;
            rdBtnAddFormStudent.TabStop = true;
            rdBtnAddFormStudent.Text = "Student";
            rdBtnAddFormStudent.UseVisualStyleBackColor = true;
            rdBtnAddFormStudent.CheckedChanged += rdBtnAddFormStudent_CheckedChanged;
            // 
            // nudAddFormSalary
            // 
            nudAddFormSalary.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nudAddFormSalary.DecimalPlaces = 2;
            nudAddFormSalary.Enabled = false;
            nudAddFormSalary.Location = new Point(114, 265);
            nudAddFormSalary.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nudAddFormSalary.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            nudAddFormSalary.Name = "nudAddFormSalary";
            nudAddFormSalary.Size = new Size(127, 25);
            nudAddFormSalary.TabIndex = 31;
            nudAddFormSalary.TextAlign = HorizontalAlignment.Right;
            nudAddFormSalary.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // nudAddFormECs
            // 
            nudAddFormECs.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nudAddFormECs.Location = new Point(114, 231);
            nudAddFormECs.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            nudAddFormECs.Name = "nudAddFormECs";
            nudAddFormECs.Size = new Size(127, 25);
            nudAddFormECs.TabIndex = 30;
            nudAddFormECs.TextAlign = HorizontalAlignment.Right;
            // 
            // nudAddFormYearsAtSchool
            // 
            nudAddFormYearsAtSchool.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nudAddFormYearsAtSchool.Location = new Point(114, 194);
            nudAddFormYearsAtSchool.Name = "nudAddFormYearsAtSchool";
            nudAddFormYearsAtSchool.Size = new Size(127, 25);
            nudAddFormYearsAtSchool.TabIndex = 26;
            nudAddFormYearsAtSchool.TextAlign = HorizontalAlignment.Right;
            // 
            // nudAddFormPCN
            // 
            nudAddFormPCN.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nudAddFormPCN.Location = new Point(114, 90);
            nudAddFormPCN.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudAddFormPCN.Name = "nudAddFormPCN";
            nudAddFormPCN.Size = new Size(127, 25);
            nudAddFormPCN.TabIndex = 25;
            nudAddFormPCN.TextAlign = HorizontalAlignment.Right;
            // 
            // nudAddFormAge
            // 
            nudAddFormAge.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nudAddFormAge.Location = new Point(114, 162);
            nudAddFormAge.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            nudAddFormAge.Name = "nudAddFormAge";
            nudAddFormAge.Size = new Size(127, 25);
            nudAddFormAge.TabIndex = 22;
            nudAddFormAge.TextAlign = HorizontalAlignment.Right;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 196);
            label6.Name = "label6";
            label6.Size = new Size(103, 19);
            label6.TabIndex = 14;
            label6.Text = "Years at school:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 162);
            label7.Name = "label7";
            label7.Size = new Size(36, 19);
            label7.TabIndex = 15;
            label7.Text = "Age:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 231);
            label8.Name = "label8";
            label8.Size = new Size(37, 19);
            label8.TabIndex = 16;
            label8.Text = "EC's:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 263);
            label9.Name = "label9";
            label9.Size = new Size(52, 19);
            label9.TabIndex = 17;
            label9.Text = "Salary: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 129);
            label4.Name = "label4";
            label4.Size = new Size(48, 19);
            label4.TabIndex = 12;
            label4.Text = "Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 96);
            label5.Name = "label5";
            label5.Size = new Size(39, 19);
            label5.TabIndex = 13;
            label5.Text = "PCN:";
            // 
            // btnNewPerson
            // 
            btnNewPerson.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnNewPerson.Location = new Point(6, 296);
            btnNewPerson.Name = "btnNewPerson";
            btnNewPerson.Size = new Size(235, 26);
            btnNewPerson.TabIndex = 21;
            btnNewPerson.Text = "Add to administration";
            btnNewPerson.UseVisualStyleBackColor = true;
            btnNewPerson.Click += btnNewPerson_Click;
            // 
            // txtBxAddFormName
            // 
            txtBxAddFormName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBxAddFormName.Location = new Point(114, 126);
            txtBxAddFormName.Name = "txtBxAddFormName";
            txtBxAddFormName.Size = new Size(127, 25);
            txtBxAddFormName.TabIndex = 16;
            txtBxAddFormName.TextAlign = HorizontalAlignment.Right;
            // 
            // lstBxMainDisplay
            // 
            lstBxMainDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstBxMainDisplay.FormattingEnabled = true;
            lstBxMainDisplay.ItemHeight = 17;
            lstBxMainDisplay.Location = new Point(265, 14);
            lstBxMainDisplay.Name = "lstBxMainDisplay";
            lstBxMainDisplay.Size = new Size(465, 259);
            lstBxMainDisplay.Sorted = true;
            lstBxMainDisplay.TabIndex = 1;
            // 
            // btnShowAllPesons
            // 
            btnShowAllPesons.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnShowAllPesons.Location = new Point(442, 285);
            btnShowAllPesons.Name = "btnShowAllPesons";
            btnShowAllPesons.Size = new Size(288, 26);
            btnShowAllPesons.TabIndex = 23;
            btnShowAllPesons.Text = "Show all persons";
            btnShowAllPesons.UseVisualStyleBackColor = true;
            btnShowAllPesons.Click += btnShowAllPesons_Click;
            // 
            // btnSearchViaPartialName
            // 
            btnSearchViaPartialName.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSearchViaPartialName.Location = new Point(442, 316);
            btnSearchViaPartialName.Name = "btnSearchViaPartialName";
            btnSearchViaPartialName.Size = new Size(288, 26);
            btnSearchViaPartialName.TabIndex = 24;
            btnSearchViaPartialName.Text = "Search via partial name";
            btnSearchViaPartialName.UseVisualStyleBackColor = true;
            btnSearchViaPartialName.Click += btnSearchViaPartialName_Click;
            // 
            // cmbBxShowFilter
            // 
            cmbBxShowFilter.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cmbBxShowFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBxShowFilter.FormattingEnabled = true;
            cmbBxShowFilter.Items.AddRange(new object[] { "All", "Students", "Teachers" });
            cmbBxShowFilter.Location = new Point(265, 285);
            cmbBxShowFilter.Name = "cmbBxShowFilter";
            cmbBxShowFilter.Size = new Size(171, 25);
            cmbBxShowFilter.TabIndex = 25;
            cmbBxShowFilter.SelectedIndexChanged += cmbBxShowFilter_SelectedIndexChanged;
            // 
            // txtBxPartialName
            // 
            txtBxPartialName.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtBxPartialName.Location = new Point(265, 316);
            txtBxPartialName.Name = "txtBxPartialName";
            txtBxPartialName.Size = new Size(171, 25);
            txtBxPartialName.TabIndex = 26;
            // 
            // Main_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(972, 353);
            Controls.Add(txtBxPartialName);
            Controls.Add(cmbBxShowFilter);
            Controls.Add(btnSearchViaPartialName);
            Controls.Add(btnShowAllPesons);
            Controls.Add(grpBxActionForm);
            Controls.Add(grpBxAddForm);
            Controls.Add(lstBxMainDisplay);
            Font = new Font("Segoe UI", 10F);
            MinimumSize = new Size(988, 392);
            Name = "Main_Form";
            Text = "Form1";
            grpBxActionForm.ResumeLayout(false);
            grpBxActionForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudStudentECs).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPCN).EndInit();
            grpBxAddForm.ResumeLayout(false);
            grpBxAddForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudAddFormSalary).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAddFormECs).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAddFormYearsAtSchool).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAddFormPCN).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAddFormAge).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpBxTeacherForm;
        private GroupBox grpBxActionForm;
        private GroupBox grpBxAddForm;
        private ListBox lstBxMainDisplay;
        private TextBox txtBxAddFormName;
        private Button btnAddECs;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label label9;
        private Button btnNewPerson;
        private Button btnShowAllPesons;
        private Button btnShowInfoTeacher;
        private Button btnPromoteTeacher;
        private Button btnStartNewSchoolyearTeacher;
        private Button btnShowInfo;
        private Button btnStartNewSchoolyear;
        private NumericUpDown nudTeacherPCN;
        private NumericUpDown nudPCN;
        private NumericUpDown nudAddFormYearsAtSchool;
        private NumericUpDown nudAddFormPCN;
        private NumericUpDown nudAddFormAge;
        private NumericUpDown nudStudentECs;
        private NumericUpDown nudAddFormSalary;
        private NumericUpDown nudAddFormECs;
        private Button btnSearchViaPartialName;
        private ComboBox cmbBxShowFilter;
        private TextBox txtBxPartialName;
        private Button btnCelebrateBirthday;
        private Label label3;
        private RadioButton rdBtnAddFormTeacher;
        private RadioButton rdBtnAddFormStudent;
    }
}
