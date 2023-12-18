namespace Week11_Day1_1
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
            btAddToList = new Button();
            ckbUpperCase = new CheckBox();
            ckbLowerCase = new CheckBox();
            cbColors = new ComboBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            btClearListBox = new Button();
            lbColors = new ListBox();
            tbCustomInput = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // btAddToList
            // 
            btAddToList.Location = new Point(10, 105);
            btAddToList.Name = "btAddToList";
            btAddToList.Size = new Size(234, 23);
            btAddToList.TabIndex = 0;
            btAddToList.Text = "Add to ListBox";
            btAddToList.UseVisualStyleBackColor = true;
            btAddToList.Click += btAddToList_Click;
            // 
            // ckbUpperCase
            // 
            ckbUpperCase.AutoSize = true;
            ckbUpperCase.Location = new Point(140, 70);
            ckbUpperCase.Name = "ckbUpperCase";
            ckbUpperCase.Size = new Size(104, 19);
            ckbUpperCase.TabIndex = 1;
            ckbUpperCase.Text = "To UPPERCASE";
            ckbUpperCase.UseVisualStyleBackColor = true;
            // 
            // ckbLowerCase
            // 
            ckbLowerCase.AutoSize = true;
            ckbLowerCase.Location = new Point(18, 70);
            ckbLowerCase.Name = "ckbLowerCase";
            ckbLowerCase.Size = new Size(93, 19);
            ckbLowerCase.TabIndex = 2;
            ckbLowerCase.Text = "To lowercase";
            ckbLowerCase.UseVisualStyleBackColor = true;
            // 
            // cbColors
            // 
            cbColors.FormattingEnabled = true;
            cbColors.Items.AddRange(new object[] { "Green", "RED", "blUE", "GrAy", "TurQUOISE", "EMEraLd", "greenbutitslowercase", "Custom" });
            cbColors.Location = new Point(111, 35);
            cbColors.Name = "cbColors";
            cbColors.Size = new Size(133, 23);
            cbColors.TabIndex = 3;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(17, 293);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(61, 19);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "Apples";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(117, 293);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(69, 19);
            radioButton2.TabIndex = 5;
            radioButton2.TabStop = true;
            radioButton2.Text = "Bananas";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(219, 293);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(67, 19);
            radioButton3.TabIndex = 6;
            radioButton3.TabStop = true;
            radioButton3.Text = "Custom";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 260);
            label1.Name = "label1";
            label1.Size = new Size(216, 15);
            label1.TabIndex = 7;
            label1.Text = "Select a fruit to be added to the ListBox:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 38);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 8;
            label2.Text = "Choose a color: ";
            // 
            // btClearListBox
            // 
            btClearListBox.Location = new Point(364, 299);
            btClearListBox.Name = "btClearListBox";
            btClearListBox.Size = new Size(252, 29);
            btClearListBox.TabIndex = 9;
            btClearListBox.Text = "Clear ListBox";
            btClearListBox.UseVisualStyleBackColor = true;
            btClearListBox.Click += btClearListBox_Click;
            // 
            // lbColors
            // 
            lbColors.FormattingEnabled = true;
            lbColors.ItemHeight = 15;
            lbColors.Location = new Point(364, 12);
            lbColors.Name = "lbColors";
            lbColors.Size = new Size(252, 274);
            lbColors.TabIndex = 10;
            // 
            // tbCustomInput
            // 
            tbCustomInput.Location = new Point(86, 189);
            tbCustomInput.MaxLength = 20;
            tbCustomInput.Name = "tbCustomInput";
            tbCustomInput.Size = new Size(112, 23);
            tbCustomInput.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 192);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 12;
            label3.Text = "Custom: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 340);
            Controls.Add(label3);
            Controls.Add(tbCustomInput);
            Controls.Add(lbColors);
            Controls.Add(btClearListBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(cbColors);
            Controls.Add(ckbLowerCase);
            Controls.Add(ckbUpperCase);
            Controls.Add(btAddToList);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btAddToList;
        private CheckBox ckbUpperCase;
        private CheckBox ckbLowerCase;
        private ComboBox cbColors;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Label label1;
        private Label label2;
        private Button btClearListBox;
        private ListBox lbColors;
        private TextBox tbCustomInput;
        private Label label3;
    }
}