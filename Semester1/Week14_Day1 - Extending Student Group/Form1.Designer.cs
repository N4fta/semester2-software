namespace Week14_Day1___Extending_Student_Group
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
            label1 = new Label();
            cbxProjectGroup = new ComboBox();
            lbxProjectGroup = new ListBox();
            tbxStudentName = new TextBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            nudStudentNumber = new NumericUpDown();
            btnAddMember = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudStudentNumber).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 34);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Name: ";
            // 
            // cbxProjectGroup
            // 
            cbxProjectGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxProjectGroup.FormattingEnabled = true;
            cbxProjectGroup.Location = new Point(15, 22);
            cbxProjectGroup.Name = "cbxProjectGroup";
            cbxProjectGroup.Size = new Size(121, 23);
            cbxProjectGroup.TabIndex = 1;
            cbxProjectGroup.SelectedIndexChanged += cbxProjectGroup_SelectedIndexChanged;
            // 
            // lbxProjectGroup
            // 
            lbxProjectGroup.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbxProjectGroup.FormattingEnabled = true;
            lbxProjectGroup.ItemHeight = 15;
            lbxProjectGroup.Location = new Point(6, 51);
            lbxProjectGroup.Name = "lbxProjectGroup";
            lbxProjectGroup.Size = new Size(302, 259);
            lbxProjectGroup.TabIndex = 2;
            // 
            // tbxStudentName
            // 
            tbxStudentName.Location = new Point(123, 34);
            tbxStudentName.Name = "tbxStudentName";
            tbxStudentName.Size = new Size(120, 23);
            tbxStudentName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 77);
            label2.Name = "label2";
            label2.Size = new Size(101, 30);
            label2.TabIndex = 5;
            label2.Text = "Student Number: \r\n(Optional)";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(cbxProjectGroup);
            groupBox1.Controls.Add(lbxProjectGroup);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(314, 324);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Project Group";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox2.Controls.Add(nudStudentNumber);
            groupBox2.Controls.Add(btnAddMember);
            groupBox2.Controls.Add(tbxStudentName);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(332, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(272, 324);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Members";
            // 
            // nudStudentNumber
            // 
            nudStudentNumber.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            nudStudentNumber.Location = new Point(123, 77);
            nudStudentNumber.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudStudentNumber.Minimum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudStudentNumber.Name = "nudStudentNumber";
            nudStudentNumber.Size = new Size(120, 27);
            nudStudentNumber.TabIndex = 7;
            nudStudentNumber.TextAlign = HorizontalAlignment.Center;
            nudStudentNumber.Value = new decimal(new int[] { 100000, 0, 0, 0 });
            // 
            // btnAddMember
            // 
            btnAddMember.Location = new Point(168, 134);
            btnAddMember.Name = "btnAddMember";
            btnAddMember.Size = new Size(75, 23);
            btnAddMember.TabIndex = 0;
            btnAddMember.Text = "Add";
            btnAddMember.UseVisualStyleBackColor = true;
            btnAddMember.Click += btnAddMember_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 348);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudStudentNumber).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private ComboBox cbxProjectGroup;
        private ListBox lbxProjectGroup;
        private TextBox tbxStudentName;
        private Label label2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private NumericUpDown nudStudentNumber;
        private Button btnAddMember;
    }
}