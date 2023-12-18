namespace Week10_Day3_2
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
            lblInformationOnCourse = new Label();
            label4 = new Label();
            btShowInformationOnCourse = new Button();
            btCreateCourse = new Button();
            tbCourseName = new TextBox();
            tbCourseECs = new TextBox();
            lvCourses = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(51, 32);
            label1.Name = "label1";
            label1.Size = new Size(134, 28);
            label1.TabIndex = 0;
            label1.Text = "Course name: ";
            // 
            // lblInformationOnCourse
            // 
            lblInformationOnCourse.AutoSize = true;
            lblInformationOnCourse.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblInformationOnCourse.Location = new Point(27, 197);
            lblInformationOnCourse.Name = "lblInformationOnCourse";
            lblInformationOnCourse.Size = new Size(0, 25);
            lblInformationOnCourse.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(51, 85);
            label4.Name = "label4";
            label4.Size = new Size(211, 56);
            label4.TabIndex = 3;
            label4.Text = "Course ECs: \r\n(optional, 3 by default)";
            // 
            // btShowInformationOnCourse
            // 
            btShowInformationOnCourse.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btShowInformationOnCourse.Location = new Point(392, 256);
            btShowInformationOnCourse.Name = "btShowInformationOnCourse";
            btShowInformationOnCourse.Size = new Size(185, 30);
            btShowInformationOnCourse.TabIndex = 4;
            btShowInformationOnCourse.Text = "Show Course Information";
            btShowInformationOnCourse.UseVisualStyleBackColor = true;
            btShowInformationOnCourse.Click += btShowInformationOnCourse_Click;
            // 
            // btCreateCourse
            // 
            btCreateCourse.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btCreateCourse.Location = new Point(51, 151);
            btCreateCourse.Name = "btCreateCourse";
            btCreateCourse.Size = new Size(292, 30);
            btCreateCourse.TabIndex = 5;
            btCreateCourse.Text = "Create Course-object";
            btCreateCourse.UseVisualStyleBackColor = true;
            btCreateCourse.Click += btCreateCourse_Click;
            // 
            // tbCourseName
            // 
            tbCourseName.Location = new Point(191, 40);
            tbCourseName.Name = "tbCourseName";
            tbCourseName.Size = new Size(152, 23);
            tbCourseName.TabIndex = 6;
            // 
            // tbCourseECs
            // 
            tbCourseECs.Location = new Point(191, 93);
            tbCourseECs.Name = "tbCourseECs";
            tbCourseECs.Size = new Size(68, 23);
            tbCourseECs.TabIndex = 7;
            // 
            // lvCourses
            // 
            lvCourses.FormattingEnabled = true;
            lvCourses.ItemHeight = 15;
            lvCourses.Location = new Point(392, 32);
            lvCourses.Name = "lvCourses";
            lvCourses.Size = new Size(185, 214);
            lvCourses.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(589, 315);
            Controls.Add(lvCourses);
            Controls.Add(tbCourseECs);
            Controls.Add(tbCourseName);
            Controls.Add(btCreateCourse);
            Controls.Add(btShowInformationOnCourse);
            Controls.Add(label4);
            Controls.Add(lblInformationOnCourse);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblInformationOnCourse;
        private Label label4;
        private Button btShowInformationOnCourse;
        private Button btCreateCourse;
        private TextBox tbCourseName;
        private TextBox tbCourseECs;
        private ListBox lvCourses;
    }
}