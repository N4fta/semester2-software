namespace Week12_Day3___Serializing_Objects
{
    partial class Add_New_Sandwich
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbxNewSandwichName = new TextBox();
            btnAddSandwich = new Button();
            cbxNewSandwichBread = new ComboBox();
            chlbxIngredients = new CheckedListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 11);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Name: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 41);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "Bread: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 74);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 2;
            label3.Text = "Ingredients: ";
            // 
            // tbxNewSandwichName
            // 
            tbxNewSandwichName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbxNewSandwichName.Location = new Point(87, 12);
            tbxNewSandwichName.Name = "tbxNewSandwichName";
            tbxNewSandwichName.Size = new Size(352, 23);
            tbxNewSandwichName.TabIndex = 3;
            // 
            // btnAddSandwich
            // 
            btnAddSandwich.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAddSandwich.Location = new Point(12, 193);
            btnAddSandwich.Name = "btnAddSandwich";
            btnAddSandwich.Size = new Size(427, 23);
            btnAddSandwich.TabIndex = 5;
            btnAddSandwich.Text = "Add Sandwich";
            btnAddSandwich.UseVisualStyleBackColor = true;
            btnAddSandwich.Click += btnAddSandwich_Click;
            // 
            // cbxNewSandwichBread
            // 
            cbxNewSandwichBread.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbxNewSandwichBread.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxNewSandwichBread.FormattingEnabled = true;
            cbxNewSandwichBread.Location = new Point(87, 41);
            cbxNewSandwichBread.Name = "cbxNewSandwichBread";
            cbxNewSandwichBread.Size = new Size(352, 23);
            cbxNewSandwichBread.TabIndex = 6;
            // 
            // chlbxIngredients
            // 
            chlbxIngredients.FormattingEnabled = true;
            chlbxIngredients.Location = new Point(87, 74);
            chlbxIngredients.Name = "chlbxIngredients";
            chlbxIngredients.Size = new Size(352, 112);
            chlbxIngredients.TabIndex = 7;
            // 
            // Add_New_Sandwich
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 218);
            Controls.Add(chlbxIngredients);
            Controls.Add(cbxNewSandwichBread);
            Controls.Add(btnAddSandwich);
            Controls.Add(tbxNewSandwichName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Add_New_Sandwich";
            Text = "Add New  Sandwich";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbxNewSandwichName;
        private Button btnAddSandwich;
        private ComboBox cbxNewSandwichBread;
        private CheckedListBox chlbxIngredients;
    }
}