namespace Final_Indv_Assg___Work_Tasks_by_Nuno
{
    partial class Dashboard_Form
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtBxTitle = new TextBox();
            btLoadAll = new Button();
            btSaveAll = new Button();
            chckBxTitle = new CheckBox();
            chckBxStatus = new CheckBox();
            chckBxDepartment = new CheckBox();
            gpBxFilters = new GroupBox();
            btFilter = new Button();
            cbxDepartment = new ComboBox();
            cbxStatus = new ComboBox();
            gpBxFiles = new GroupBox();
            btImportEmployees = new Button();
            btExportEmployees = new Button();
            btCreateTask = new Button();
            TasksToolTip = new ToolTip(components);
            lstBxTasks = new ListBox();
            gpBxFilters.SuspendLayout();
            gpBxFiles.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(82, 27);
            label1.TabIndex = 0;
            label1.Text = "Tasks:";
            // 
            // txtBxTitle
            // 
            txtBxTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBxTitle.Location = new Point(87, 24);
            txtBxTitle.Name = "txtBxTitle";
            txtBxTitle.Size = new Size(312, 25);
            txtBxTitle.TabIndex = 3;
            txtBxTitle.TextChanged += btnFilter_Click;
            // 
            // btLoadAll
            // 
            btLoadAll.Location = new Point(6, 84);
            btLoadAll.Name = "btLoadAll";
            btLoadAll.Size = new Size(86, 30);
            btLoadAll.TabIndex = 6;
            btLoadAll.Text = "Load All";
            btLoadAll.UseVisualStyleBackColor = true;
            btLoadAll.Click += btLoadAll_Click;
            // 
            // btSaveAll
            // 
            btSaveAll.Location = new Point(6, 35);
            btSaveAll.Name = "btSaveAll";
            btSaveAll.Size = new Size(86, 30);
            btSaveAll.TabIndex = 7;
            btSaveAll.Text = "Save All";
            btSaveAll.UseVisualStyleBackColor = true;
            btSaveAll.Click += btSaveAll_Click;
            // 
            // chckBxTitle
            // 
            chckBxTitle.AutoSize = true;
            chckBxTitle.Checked = true;
            chckBxTitle.CheckState = CheckState.Checked;
            chckBxTitle.Location = new Point(21, 26);
            chckBxTitle.Name = "chckBxTitle";
            chckBxTitle.Size = new Size(60, 21);
            chckBxTitle.TabIndex = 10;
            chckBxTitle.Text = "Title";
            chckBxTitle.UseVisualStyleBackColor = true;
            chckBxTitle.CheckedChanged += btnFilter_Click;
            // 
            // chckBxStatus
            // 
            chckBxStatus.AutoSize = true;
            chckBxStatus.Checked = true;
            chckBxStatus.CheckState = CheckState.Checked;
            chckBxStatus.Location = new Point(21, 55);
            chckBxStatus.Name = "chckBxStatus";
            chckBxStatus.Size = new Size(69, 21);
            chckBxStatus.TabIndex = 11;
            chckBxStatus.Text = "Status";
            chckBxStatus.UseVisualStyleBackColor = true;
            chckBxStatus.CheckedChanged += btnFilter_Click;
            // 
            // chckBxDepartment
            // 
            chckBxDepartment.AutoSize = true;
            chckBxDepartment.Checked = true;
            chckBxDepartment.CheckState = CheckState.Checked;
            chckBxDepartment.Location = new Point(21, 84);
            chckBxDepartment.Name = "chckBxDepartment";
            chckBxDepartment.Size = new Size(111, 21);
            chckBxDepartment.TabIndex = 12;
            chckBxDepartment.Text = "Department";
            chckBxDepartment.UseVisualStyleBackColor = true;
            chckBxDepartment.CheckedChanged += btnFilter_Click;
            // 
            // gpBxFilters
            // 
            gpBxFilters.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            gpBxFilters.Controls.Add(btFilter);
            gpBxFilters.Controls.Add(cbxDepartment);
            gpBxFilters.Controls.Add(cbxStatus);
            gpBxFilters.Controls.Add(txtBxTitle);
            gpBxFilters.Controls.Add(chckBxDepartment);
            gpBxFilters.Controls.Add(chckBxTitle);
            gpBxFilters.Controls.Add(chckBxStatus);
            gpBxFilters.Location = new Point(12, 378);
            gpBxFilters.Name = "gpBxFilters";
            gpBxFilters.Size = new Size(419, 139);
            gpBxFilters.TabIndex = 13;
            gpBxFilters.TabStop = false;
            gpBxFilters.Text = "Filters";
            // 
            // btFilter
            // 
            btFilter.Location = new Point(189, 111);
            btFilter.Name = "btFilter";
            btFilter.Size = new Size(210, 23);
            btFilter.TabIndex = 15;
            btFilter.Text = "Refresh";
            btFilter.UseVisualStyleBackColor = true;
            btFilter.Click += btnFilter_Click;
            // 
            // cbxDepartment
            // 
            cbxDepartment.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbxDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxDepartment.FormattingEnabled = true;
            cbxDepartment.Location = new Point(138, 82);
            cbxDepartment.Name = "cbxDepartment";
            cbxDepartment.Size = new Size(261, 25);
            cbxDepartment.TabIndex = 14;
            cbxDepartment.TextChanged += btnFilter_Click;
            // 
            // cbxStatus
            // 
            cbxStatus.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxStatus.FormattingEnabled = true;
            cbxStatus.Location = new Point(96, 53);
            cbxStatus.Name = "cbxStatus";
            cbxStatus.Size = new Size(303, 25);
            cbxStatus.TabIndex = 13;
            cbxStatus.TextChanged += btnFilter_Click;
            // 
            // gpBxFiles
            // 
            gpBxFiles.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gpBxFiles.Controls.Add(btImportEmployees);
            gpBxFiles.Controls.Add(btExportEmployees);
            gpBxFiles.Controls.Add(btSaveAll);
            gpBxFiles.Controls.Add(btLoadAll);
            gpBxFiles.Location = new Point(437, 378);
            gpBxFiles.Name = "gpBxFiles";
            gpBxFiles.Size = new Size(271, 139);
            gpBxFiles.TabIndex = 14;
            gpBxFiles.TabStop = false;
            gpBxFiles.Text = "Files";
            // 
            // btImportEmployees
            // 
            btImportEmployees.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btImportEmployees.Location = new Point(106, 84);
            btImportEmployees.Name = "btImportEmployees";
            btImportEmployees.Size = new Size(159, 30);
            btImportEmployees.TabIndex = 9;
            btImportEmployees.Text = "Import Employees";
            btImportEmployees.UseVisualStyleBackColor = true;
            btImportEmployees.Click += btImportEmployees_Click;
            // 
            // btExportEmployees
            // 
            btExportEmployees.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btExportEmployees.Location = new Point(106, 35);
            btExportEmployees.Name = "btExportEmployees";
            btExportEmployees.Size = new Size(159, 30);
            btExportEmployees.TabIndex = 8;
            btExportEmployees.Text = "Export Employees";
            btExportEmployees.UseVisualStyleBackColor = true;
            btExportEmployees.Click += btExportEmployees_Click;
            // 
            // btCreateTask
            // 
            btCreateTask.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btCreateTask.Location = new Point(543, 9);
            btCreateTask.Name = "btCreateTask";
            btCreateTask.Size = new Size(165, 27);
            btCreateTask.TabIndex = 15;
            btCreateTask.Text = "Create Task";
            btCreateTask.UseVisualStyleBackColor = true;
            btCreateTask.Click += btCreateTask_Click;
            // 
            // lstBxTasks
            // 
            lstBxTasks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstBxTasks.FormattingEnabled = true;
            lstBxTasks.ItemHeight = 17;
            lstBxTasks.Location = new Point(12, 39);
            lstBxTasks.Name = "lstBxTasks";
            lstBxTasks.Size = new Size(696, 327);
            lstBxTasks.TabIndex = 0;
            TasksToolTip.SetToolTip(lstBxTasks, "Double click an item to open it");
            lstBxTasks.DoubleClick += lstBxTasks_DoubleClick;
            // 
            // Dashboard_Form
            // 
            AutoScaleDimensions = new SizeF(9F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 529);
            Controls.Add(lstBxTasks);
            Controls.Add(btCreateTask);
            Controls.Add(gpBxFiles);
            Controls.Add(gpBxFilters);
            Controls.Add(label1);
            Font = new Font("Rockwell", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            MinimumSize = new Size(736, 568);
            Name = "Dashboard_Form";
            Text = "User";
            FormClosed += Dashboard_Form_FormClosed;
            gpBxFilters.ResumeLayout(false);
            gpBxFilters.PerformLayout();
            gpBxFiles.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox txtBxTitle;
        private Button btLoadAll;
        private Button btSaveAll;
        private CheckBox chckBxTitle;
        private CheckBox chckBxStatus;
        private CheckBox chckBxDepartment;
        private GroupBox gpBxFilters;
        private ComboBox cbxDepartment;
        private ComboBox cbxStatus;
        private GroupBox gpBxFiles;
        private Button btImportEmployees;
        private Button btExportEmployees;
        private Button btCreateTask;
        private ToolTip TasksToolTip;
        private ListBox lstBxTasks;
        private Button btFilter;
    }
}
