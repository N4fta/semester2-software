namespace Final_Indv_Assg___Work_Tasks_by_Nuno
{
    partial class Task_Form
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
            btSave = new Button();
            btCancel = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtBxTitle = new TextBox();
            label8 = new Label();
            rchTxtBxDescription = new RichTextBox();
            chkBxAll = new CheckBox();
            chkBxHumanResources = new CheckBox();
            chkBxMarketing = new CheckBox();
            chkBxSupport = new CheckBox();
            chkBxResearchAndDevelopment = new CheckBox();
            cmbBxStatus = new ComboBox();
            dtTmPckDeadline = new DateTimePicker();
            chkLstBxEmployees = new CheckedListBox();
            chkBxSales = new CheckBox();
            btRemove = new Button();
            SuspendLayout();
            // 
            // btSave
            // 
            btSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btSave.Location = new Point(446, 354);
            btSave.Name = "btSave";
            btSave.Size = new Size(154, 33);
            btSave.TabIndex = 0;
            btSave.Text = "Save";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // btCancel
            // 
            btCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btCancel.Location = new Point(606, 354);
            btCancel.Name = "btCancel";
            btCancel.Size = new Size(154, 33);
            btCancel.TabIndex = 1;
            btCancel.Text = "Cancel";
            btCancel.UseVisualStyleBackColor = true;
            btCancel.Click += btCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 48);
            label1.Name = "label1";
            label1.Size = new Size(41, 17);
            label1.TabIndex = 2;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 77);
            label2.Name = "label2";
            label2.Size = new Size(111, 17);
            label2.TabIndex = 3;
            label2.Text = "Department(s)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 139);
            label3.Name = "label3";
            label3.Size = new Size(50, 17);
            label3.TabIndex = 4;
            label3.Text = "Status";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 184);
            label4.Name = "label4";
            label4.Size = new Size(73, 17);
            label4.TabIndex = 5;
            label4.Text = "Deadline";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(520, 31);
            label5.Name = "label5";
            label5.Size = new Size(86, 17);
            label5.TabIndex = 6;
            label5.Text = "Employees";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 216);
            label6.Name = "label6";
            label6.Size = new Size(91, 17);
            label6.TabIndex = 7;
            label6.Text = "Description";
            // 
            // txtBxTitle
            // 
            txtBxTitle.Location = new Point(143, 45);
            txtBxTitle.Name = "txtBxTitle";
            txtBxTitle.Size = new Size(370, 25);
            txtBxTitle.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Rockwell", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(12, 9);
            label8.Name = "label8";
            label8.Size = new Size(71, 27);
            label8.TabIndex = 11;
            label8.Text = "Task:";
            // 
            // rchTxtBxDescription
            // 
            rchTxtBxDescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rchTxtBxDescription.Location = new Point(143, 216);
            rchTxtBxDescription.Name = "rchTxtBxDescription";
            rchTxtBxDescription.Size = new Size(617, 132);
            rchTxtBxDescription.TabIndex = 12;
            rchTxtBxDescription.Text = "";
            // 
            // chkBxAll
            // 
            chkBxAll.AutoSize = true;
            chkBxAll.Location = new Point(143, 76);
            chkBxAll.Name = "chkBxAll";
            chkBxAll.Size = new Size(47, 21);
            chkBxAll.TabIndex = 13;
            chkBxAll.Text = "All";
            chkBxAll.UseVisualStyleBackColor = true;
            chkBxAll.CheckedChanged += chkBxAll_CheckedChanged;
            // 
            // chkBxHumanResources
            // 
            chkBxHumanResources.AutoSize = true;
            chkBxHumanResources.Location = new Point(332, 103);
            chkBxHumanResources.Name = "chkBxHumanResources";
            chkBxHumanResources.Size = new Size(154, 21);
            chkBxHumanResources.TabIndex = 14;
            chkBxHumanResources.Text = "Human Resources";
            chkBxHumanResources.UseVisualStyleBackColor = true;
            chkBxHumanResources.CheckedChanged += chkBxResearchAndDevelopment_CheckedChanged;
            // 
            // chkBxMarketing
            // 
            chkBxMarketing.AutoSize = true;
            chkBxMarketing.Location = new Point(143, 103);
            chkBxMarketing.Name = "chkBxMarketing";
            chkBxMarketing.Size = new Size(100, 21);
            chkBxMarketing.TabIndex = 15;
            chkBxMarketing.Text = "Marketing";
            chkBxMarketing.UseVisualStyleBackColor = true;
            chkBxMarketing.CheckedChanged += chkBxResearchAndDevelopment_CheckedChanged;
            // 
            // chkBxSupport
            // 
            chkBxSupport.AutoSize = true;
            chkBxSupport.Location = new Point(249, 103);
            chkBxSupport.Name = "chkBxSupport";
            chkBxSupport.Size = new Size(82, 21);
            chkBxSupport.TabIndex = 16;
            chkBxSupport.Text = "Support";
            chkBxSupport.UseVisualStyleBackColor = true;
            chkBxSupport.CheckedChanged += chkBxResearchAndDevelopment_CheckedChanged;
            // 
            // chkBxResearchAndDevelopment
            // 
            chkBxResearchAndDevelopment.AutoSize = true;
            chkBxResearchAndDevelopment.Location = new Point(194, 76);
            chkBxResearchAndDevelopment.Name = "chkBxResearchAndDevelopment";
            chkBxResearchAndDevelopment.Size = new Size(222, 21);
            chkBxResearchAndDevelopment.TabIndex = 17;
            chkBxResearchAndDevelopment.Text = "Research and Development";
            chkBxResearchAndDevelopment.UseVisualStyleBackColor = true;
            chkBxResearchAndDevelopment.CheckedChanged += chkBxResearchAndDevelopment_CheckedChanged;
            // 
            // cmbBxStatus
            // 
            cmbBxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBxStatus.FormattingEnabled = true;
            cmbBxStatus.Location = new Point(143, 136);
            cmbBxStatus.Name = "cmbBxStatus";
            cmbBxStatus.Size = new Size(164, 25);
            cmbBxStatus.TabIndex = 19;
            // 
            // dtTmPckDeadline
            // 
            dtTmPckDeadline.Location = new Point(143, 178);
            dtTmPckDeadline.Name = "dtTmPckDeadline";
            dtTmPckDeadline.Size = new Size(273, 25);
            dtTmPckDeadline.TabIndex = 20;
            // 
            // chkLstBxEmployees
            // 
            chkLstBxEmployees.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            chkLstBxEmployees.FormattingEnabled = true;
            chkLstBxEmployees.Location = new Point(520, 51);
            chkLstBxEmployees.Name = "chkLstBxEmployees";
            chkLstBxEmployees.Size = new Size(240, 144);
            chkLstBxEmployees.TabIndex = 21;
            // 
            // chkBxSales
            // 
            chkBxSales.AutoSize = true;
            chkBxSales.Location = new Point(422, 76);
            chkBxSales.Name = "chkBxSales";
            chkBxSales.Size = new Size(64, 21);
            chkBxSales.TabIndex = 22;
            chkBxSales.Text = "Sales";
            chkBxSales.UseVisualStyleBackColor = true;
            chkBxSales.CheckedChanged += chkBxResearchAndDevelopment_CheckedChanged;
            // 
            // btRemove
            // 
            btRemove.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btRemove.Location = new Point(286, 354);
            btRemove.Name = "btRemove";
            btRemove.Size = new Size(154, 33);
            btRemove.TabIndex = 23;
            btRemove.Text = "Remove";
            btRemove.UseVisualStyleBackColor = true;
            btRemove.Click += btRemove_Click;
            // 
            // Task_Form
            // 
            AutoScaleDimensions = new SizeF(9F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 399);
            Controls.Add(btRemove);
            Controls.Add(chkBxSales);
            Controls.Add(chkLstBxEmployees);
            Controls.Add(dtTmPckDeadline);
            Controls.Add(cmbBxStatus);
            Controls.Add(chkBxResearchAndDevelopment);
            Controls.Add(chkBxSupport);
            Controls.Add(chkBxMarketing);
            Controls.Add(chkBxHumanResources);
            Controls.Add(chkBxAll);
            Controls.Add(rchTxtBxDescription);
            Controls.Add(label8);
            Controls.Add(txtBxTitle);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btCancel);
            Controls.Add(btSave);
            Font = new Font("Rockwell", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            MinimumSize = new Size(794, 438);
            Name = "Task_Form";
            Text = "Task_Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btSave;
        private Button btCancel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtBxTitle;
        private Label label8;
        private RichTextBox rchTxtBxDescription;
        private CheckBox chkBxAll;
        private CheckBox chkBxHumanResources;
        private CheckBox chkBxMarketing;
        private CheckBox chkBxSupport;
        private CheckBox chkBxResearchAndDevelopment;
        private ComboBox cmbBxStatus;
        private DateTimePicker dtTmPckDeadline;
        private CheckedListBox chkLstBxEmployees;
        private CheckBox chkBxSales;
        private Button btRemove;
    }
}