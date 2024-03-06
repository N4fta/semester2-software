namespace OOD___Animals___Inheritance
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
            tbName = new TextBox();
            lstBxAnimals = new ListBox();
            nudAge = new NumericUpDown();
            btnCreate = new Button();
            cmbBxClasses = new ComboBox();
            btnRemove = new Button();
            btnCelebrateBirthday = new Button();
            ((System.ComponentModel.ISupportInitialize)nudAge).BeginInit();
            SuspendLayout();
            // 
            // tbName
            // 
            tbName.Location = new Point(29, 41);
            tbName.Name = "tbName";
            tbName.Size = new Size(100, 23);
            tbName.TabIndex = 2;
            tbName.Text = "Name";
            // 
            // lstBxAnimals
            // 
            lstBxAnimals.FormattingEnabled = true;
            lstBxAnimals.ItemHeight = 15;
            lstBxAnimals.Location = new Point(12, 109);
            lstBxAnimals.Name = "lstBxAnimals";
            lstBxAnimals.Size = new Size(776, 334);
            lstBxAnimals.TabIndex = 3;
            // 
            // nudAge
            // 
            nudAge.Location = new Point(29, 70);
            nudAge.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            nudAge.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudAge.Name = "nudAge";
            nudAge.Size = new Size(68, 23);
            nudAge.TabIndex = 4;
            nudAge.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(157, 70);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 5;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // cmbBxClasses
            // 
            cmbBxClasses.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBxClasses.FormattingEnabled = true;
            cmbBxClasses.Location = new Point(29, 12);
            cmbBxClasses.Name = "cmbBxClasses";
            cmbBxClasses.Size = new Size(122, 23);
            cmbBxClasses.TabIndex = 6;
            cmbBxClasses.SelectedIndexChanged += cmbBxClasses_SelectedIndexChanged;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(713, 70);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(75, 23);
            btnRemove.TabIndex = 7;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnCelebrateBirthday
            // 
            btnCelebrateBirthday.Location = new Point(531, 70);
            btnCelebrateBirthday.Name = "btnCelebrateBirthday";
            btnCelebrateBirthday.Size = new Size(155, 23);
            btnCelebrateBirthday.TabIndex = 8;
            btnCelebrateBirthday.Text = "Celebrate Birthday";
            btnCelebrateBirthday.UseVisualStyleBackColor = true;
            btnCelebrateBirthday.Click += btnCelebrateBirthday_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCelebrateBirthday);
            Controls.Add(btnRemove);
            Controls.Add(cmbBxClasses);
            Controls.Add(btnCreate);
            Controls.Add(nudAge);
            Controls.Add(lstBxAnimals);
            Controls.Add(tbName);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudAge).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbName;
        private ListBox lstBxAnimals;
        private NumericUpDown nudAge;
        private Button btnCreate;
        private ComboBox cmbBxClasses;
        private Button btnRemove;
        private Button btnCelebrateBirthday;
    }
}
