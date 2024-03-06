namespace Week12_Day2___Random_Password_Generator
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
            nudPasswordLenght = new NumericUpDown();
            nudAmountOfPasswords = new NumericUpDown();
            chbkIncludeSymbols = new CheckBox();
            btnGeneratePasswords = new Button();
            label1 = new Label();
            label2 = new Label();
            lbxPasswords = new ListBox();
            chbxUniqueCharacters = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)nudPasswordLenght).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAmountOfPasswords).BeginInit();
            SuspendLayout();
            // 
            // nudPasswordLenght
            // 
            nudPasswordLenght.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nudPasswordLenght.Location = new Point(175, 32);
            nudPasswordLenght.Maximum = new decimal(new int[] { 94, 0, 0, 0 });
            nudPasswordLenght.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudPasswordLenght.Name = "nudPasswordLenght";
            nudPasswordLenght.Size = new Size(61, 25);
            nudPasswordLenght.TabIndex = 0;
            nudPasswordLenght.TextAlign = HorizontalAlignment.Right;
            nudPasswordLenght.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nudAmountOfPasswords
            // 
            nudAmountOfPasswords.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nudAmountOfPasswords.Location = new Point(175, 76);
            nudAmountOfPasswords.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            nudAmountOfPasswords.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudAmountOfPasswords.Name = "nudAmountOfPasswords";
            nudAmountOfPasswords.Size = new Size(61, 25);
            nudAmountOfPasswords.TabIndex = 1;
            nudAmountOfPasswords.TextAlign = HorizontalAlignment.Right;
            nudAmountOfPasswords.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // chbkIncludeSymbols
            // 
            chbkIncludeSymbols.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            chbkIncludeSymbols.AutoSize = true;
            chbkIncludeSymbols.Location = new Point(12, 155);
            chbkIncludeSymbols.Name = "chbkIncludeSymbols";
            chbkIncludeSymbols.Size = new Size(224, 23);
            chbkIncludeSymbols.TabIndex = 2;
            chbkIncludeSymbols.Text = "Include Symbols (e.g. $, *, !, etc.)";
            chbkIncludeSymbols.UseVisualStyleBackColor = true;
            // 
            // btnGeneratePasswords
            // 
            btnGeneratePasswords.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnGeneratePasswords.Location = new Point(12, 184);
            btnGeneratePasswords.Name = "btnGeneratePasswords";
            btnGeneratePasswords.Size = new Size(235, 26);
            btnGeneratePasswords.TabIndex = 3;
            btnGeneratePasswords.Text = "Generate password(s)";
            btnGeneratePasswords.UseVisualStyleBackColor = true;
            btnGeneratePasswords.Click += btnGeneratePasswords_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 34);
            label1.Name = "label1";
            label1.Size = new Size(110, 19);
            label1.TabIndex = 4;
            label1.Text = "Password lenght";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 78);
            label2.Name = "label2";
            label2.Size = new Size(59, 19);
            label2.TabIndex = 5;
            label2.Text = "Amount";
            // 
            // lbxPasswords
            // 
            lbxPasswords.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbxPasswords.FormattingEnabled = true;
            lbxPasswords.ItemHeight = 17;
            lbxPasswords.Location = new Point(12, 216);
            lbxPasswords.Name = "lbxPasswords";
            lbxPasswords.Size = new Size(235, 242);
            lbxPasswords.TabIndex = 6;
            lbxPasswords.DoubleClick += lbxPasswords_DoubleClick;
            // 
            // chbxUniqueCharacters
            // 
            chbxUniqueCharacters.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            chbxUniqueCharacters.AutoSize = true;
            chbxUniqueCharacters.Location = new Point(12, 126);
            chbxUniqueCharacters.Name = "chbxUniqueCharacters";
            chbxUniqueCharacters.Size = new Size(141, 23);
            chbxUniqueCharacters.TabIndex = 7;
            chbxUniqueCharacters.Text = "Unique Characters";
            chbxUniqueCharacters.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(259, 471);
            Controls.Add(chbxUniqueCharacters);
            Controls.Add(lbxPasswords);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnGeneratePasswords);
            Controls.Add(chbkIncludeSymbols);
            Controls.Add(nudAmountOfPasswords);
            Controls.Add(nudPasswordLenght);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            MinimumSize = new Size(275, 510);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudPasswordLenght).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAmountOfPasswords).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown nudPasswordLenght;
        private NumericUpDown nudAmountOfPasswords;
        private CheckBox chbkIncludeSymbols;
        private Button btnGeneratePasswords;
        private Label label1;
        private Label label2;
        private ListBox lbxPasswords;
        private CheckBox chbxUniqueCharacters;
    }
}