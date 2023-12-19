namespace Week11_Day3_3___Lottery
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
            groupBox1 = new GroupBox();
            nudMaxValue = new NumericUpDown();
            nudWantedNumbers = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            btAll = new Button();
            btNext = new Button();
            btCreate = new Button();
            lbDraws = new ListBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMaxValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudWantedNumbers).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(nudMaxValue);
            groupBox1.Controls.Add(nudWantedNumbers);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(16, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(314, 137);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lottery settings";
            // 
            // nudMaxValue
            // 
            nudMaxValue.Location = new Point(158, 41);
            nudMaxValue.Name = "nudMaxValue";
            nudMaxValue.Size = new Size(97, 23);
            nudMaxValue.TabIndex = 7;
            // 
            // nudWantedNumbers
            // 
            nudWantedNumbers.Location = new Point(158, 86);
            nudWantedNumbers.Name = "nudWantedNumbers";
            nudWantedNumbers.Size = new Size(97, 23);
            nudWantedNumbers.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 88);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 1;
            label2.Text = "Nr of Ball Draws: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 43);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 0;
            label1.Text = "Max Value: ";
            // 
            // btAll
            // 
            btAll.Enabled = false;
            btAll.Location = new Point(32, 228);
            btAll.Name = "btAll";
            btAll.Size = new Size(288, 23);
            btAll.TabIndex = 5;
            btAll.Text = "Draw all remaining numbers";
            btAll.UseVisualStyleBackColor = true;
            btAll.Click += btAll_Click;
            // 
            // btNext
            // 
            btNext.Enabled = false;
            btNext.Location = new Point(32, 199);
            btNext.Name = "btNext";
            btNext.Size = new Size(288, 23);
            btNext.TabIndex = 4;
            btNext.Text = "Draw next number";
            btNext.UseVisualStyleBackColor = true;
            btNext.Click += btNext_Click;
            // 
            // btCreate
            // 
            btCreate.Location = new Point(32, 170);
            btCreate.Name = "btCreate";
            btCreate.Size = new Size(288, 23);
            btCreate.TabIndex = 3;
            btCreate.Text = "Create Lottery Object";
            btCreate.UseVisualStyleBackColor = true;
            btCreate.Click += btCreate_Click;
            // 
            // lbDraws
            // 
            lbDraws.FormattingEnabled = true;
            lbDraws.ItemHeight = 15;
            lbDraws.Location = new Point(336, 16);
            lbDraws.Name = "lbDraws";
            lbDraws.Size = new Size(193, 349);
            lbDraws.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 373);
            Controls.Add(groupBox1);
            Controls.Add(lbDraws);
            Controls.Add(btAll);
            Controls.Add(btCreate);
            Controls.Add(btNext);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudMaxValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudWantedNumbers).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Button btAll;
        private Button btNext;
        private Button btCreate;
        private Label label2;
        private Label label1;
        private ListBox lbDraws;
        private NumericUpDown nudMaxValue;
        private NumericUpDown nudWantedNumbers;
    }
}