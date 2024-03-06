namespace Week11_Day1_3
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
            label2 = new Label();
            label1 = new Label();
            btnAddToLog = new Button();
            nupExpenseForm = new NumericUpDown();
            tbExpenseForm = new TextBox();
            lbLog = new ListBox();
            nupAmountFilter = new NumericUpDown();
            btShowAllExpenses = new Button();
            btLess = new Button();
            btSame = new Button();
            btMore = new Button();
            label3 = new Label();
            label4 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nupExpenseForm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupAmountFilter).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnAddToLog);
            groupBox1.Controls.Add(nupExpenseForm);
            groupBox1.Controls.Add(tbExpenseForm);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(243, 143);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Expense Form";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 56);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 12;
            label2.Text = "Amount: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 28);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 11;
            label1.Text = "Name: ";
            // 
            // btnAddToLog
            // 
            btnAddToLog.Location = new Point(81, 94);
            btnAddToLog.Name = "btnAddToLog";
            btnAddToLog.Size = new Size(129, 43);
            btnAddToLog.TabIndex = 8;
            btnAddToLog.Text = "Add expense to transaction log";
            btnAddToLog.UseVisualStyleBackColor = true;
            btnAddToLog.Click += btnAddToLog_Click;
            // 
            // nupExpenseForm
            // 
            nupExpenseForm.DecimalPlaces = 2;
            nupExpenseForm.Location = new Point(81, 54);
            nupExpenseForm.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nupExpenseForm.Name = "nupExpenseForm";
            nupExpenseForm.Size = new Size(87, 23);
            nupExpenseForm.TabIndex = 1;
            // 
            // tbExpenseForm
            // 
            tbExpenseForm.Location = new Point(81, 25);
            tbExpenseForm.Name = "tbExpenseForm";
            tbExpenseForm.Size = new Size(129, 23);
            tbExpenseForm.TabIndex = 5;
            // 
            // lbLog
            // 
            lbLog.FormattingEnabled = true;
            lbLog.ItemHeight = 15;
            lbLog.Location = new Point(261, 12);
            lbLog.Name = "lbLog";
            lbLog.Size = new Size(198, 259);
            lbLog.TabIndex = 0;
            // 
            // nupAmountFilter
            // 
            nupAmountFilter.DecimalPlaces = 2;
            nupAmountFilter.Location = new Point(81, 201);
            nupAmountFilter.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nupAmountFilter.Name = "nupAmountFilter";
            nupAmountFilter.Size = new Size(87, 23);
            nupAmountFilter.TabIndex = 2;
            // 
            // btShowAllExpenses
            // 
            btShowAllExpenses.Location = new Point(12, 161);
            btShowAllExpenses.Name = "btShowAllExpenses";
            btShowAllExpenses.Size = new Size(243, 23);
            btShowAllExpenses.TabIndex = 6;
            btShowAllExpenses.Text = "Show all expenses";
            btShowAllExpenses.UseVisualStyleBackColor = true;
            btShowAllExpenses.Click += btShowAllExpenses_Click;
            // 
            // btLess
            // 
            btLess.Location = new Point(12, 248);
            btLess.Name = "btLess";
            btLess.Size = new Size(75, 23);
            btLess.TabIndex = 7;
            btLess.Text = "Less";
            btLess.UseVisualStyleBackColor = true;
            btLess.Click += btLess_Click;
            // 
            // btSame
            // 
            btSame.Location = new Point(93, 248);
            btSame.Name = "btSame";
            btSame.Size = new Size(81, 23);
            btSame.TabIndex = 9;
            btSame.Text = "Same";
            btSame.UseVisualStyleBackColor = true;
            btSame.Click += btSame_Click;
            // 
            // btMore
            // 
            btMore.Location = new Point(180, 248);
            btMore.Name = "btMore";
            btMore.Size = new Size(75, 23);
            btMore.TabIndex = 10;
            btMore.Text = "More";
            btMore.UseVisualStyleBackColor = true;
            btMore.Click += btMore_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 203);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 13;
            label3.Text = "Amount: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 230);
            label4.Name = "label4";
            label4.Size = new Size(245, 15);
            label4.TabIndex = 14;
            label4.Text = "Based on input amount show expenses with: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 283);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lbLog);
            Controls.Add(nupAmountFilter);
            Controls.Add(btSame);
            Controls.Add(btMore);
            Controls.Add(groupBox1);
            Controls.Add(btLess);
            Controls.Add(btShowAllExpenses);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nupExpenseForm).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupAmountFilter).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnAddToLog;
        private ListBox lbLog;
        private NumericUpDown nupExpenseForm;
        private NumericUpDown nupAmountFilter;
        private TextBox tbExpenseForm;
        private Button btShowAllExpenses;
        private Button btLess;
        private Button btSame;
        private Button btMore;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
    }
}