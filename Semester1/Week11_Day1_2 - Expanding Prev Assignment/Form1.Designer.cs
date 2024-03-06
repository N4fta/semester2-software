namespace Week11_Day1_2
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
            gbActions = new GroupBox();
            btDeposit = new Button();
            btWithdraw = new Button();
            nupAmount = new NumericUpDown();
            rbSavings = new RadioButton();
            rbCheckings = new RadioButton();
            label2 = new Label();
            label4 = new Label();
            label1 = new Label();
            label5 = new Label();
            lblCheckingsAccount = new Label();
            lblSavingsAccount = new Label();
            gbActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nupAmount).BeginInit();
            SuspendLayout();
            // 
            // gbActions
            // 
            gbActions.Controls.Add(btDeposit);
            gbActions.Controls.Add(btWithdraw);
            gbActions.Controls.Add(nupAmount);
            gbActions.Controls.Add(rbSavings);
            gbActions.Controls.Add(rbCheckings);
            gbActions.Controls.Add(label2);
            gbActions.Controls.Add(label4);
            gbActions.Location = new Point(12, 52);
            gbActions.Name = "gbActions";
            gbActions.Size = new Size(245, 205);
            gbActions.TabIndex = 0;
            gbActions.TabStop = false;
            gbActions.Text = "Actions";
            // 
            // btDeposit
            // 
            btDeposit.Location = new Point(25, 164);
            btDeposit.Name = "btDeposit";
            btDeposit.Size = new Size(75, 23);
            btDeposit.TabIndex = 7;
            btDeposit.Text = "Deposit";
            btDeposit.UseVisualStyleBackColor = true;
            btDeposit.Click += btDeposit_Click;
            // 
            // btWithdraw
            // 
            btWithdraw.Location = new Point(116, 164);
            btWithdraw.Name = "btWithdraw";
            btWithdraw.Size = new Size(75, 23);
            btWithdraw.TabIndex = 8;
            btWithdraw.Text = "Withdraw";
            btWithdraw.UseVisualStyleBackColor = true;
            btWithdraw.Click += btWithdraw_Click;
            // 
            // nupAmount
            // 
            nupAmount.DecimalPlaces = 2;
            nupAmount.Location = new Point(125, 130);
            nupAmount.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nupAmount.Name = "nupAmount";
            nupAmount.Size = new Size(85, 23);
            nupAmount.TabIndex = 7;
            // 
            // rbSavings
            // 
            rbSavings.AutoSize = true;
            rbSavings.Location = new Point(25, 87);
            rbSavings.Name = "rbSavings";
            rbSavings.Size = new Size(113, 19);
            rbSavings.TabIndex = 6;
            rbSavings.TabStop = true;
            rbSavings.Text = "Savings Account";
            rbSavings.UseVisualStyleBackColor = true;
            // 
            // rbCheckings
            // 
            rbCheckings.AutoSize = true;
            rbCheckings.Location = new Point(25, 62);
            rbCheckings.Name = "rbCheckings";
            rbCheckings.Size = new Size(128, 19);
            rbCheckings.TabIndex = 5;
            rbCheckings.TabStop = true;
            rbCheckings.Text = "Checkings Account";
            rbCheckings.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(15, 36);
            label2.Name = "label2";
            label2.Size = new Size(163, 14);
            label2.TabIndex = 2;
            label2.Text = "Please select a bank account";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Rockwell", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(15, 133);
            label4.Name = "label4";
            label4.Size = new Size(104, 14);
            label4.TabIndex = 4;
            label4.Text = "Amount in euros: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(15, 9);
            label1.Name = "label1";
            label1.Size = new Size(175, 14);
            label1.TabIndex = 1;
            label1.Text = "Checking account balance: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(15, 34);
            label5.Name = "label5";
            label5.Size = new Size(162, 14);
            label5.TabIndex = 4;
            label5.Text = "Savings account balance: ";
            // 
            // lblCheckingsAccount
            // 
            lblCheckingsAccount.AutoSize = true;
            lblCheckingsAccount.Location = new Point(196, 9);
            lblCheckingsAccount.Name = "lblCheckingsAccount";
            lblCheckingsAccount.Size = new Size(0, 15);
            lblCheckingsAccount.TabIndex = 5;
            // 
            // lblSavingsAccount
            // 
            lblSavingsAccount.AutoSize = true;
            lblSavingsAccount.Location = new Point(196, 34);
            lblSavingsAccount.Name = "lblSavingsAccount";
            lblSavingsAccount.Size = new Size(0, 15);
            lblSavingsAccount.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(269, 269);
            Controls.Add(lblSavingsAccount);
            Controls.Add(lblCheckingsAccount);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(gbActions);
            Name = "Form1";
            Text = "Form1";
            gbActions.ResumeLayout(false);
            gbActions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nupAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbActions;
        private Label label2;
        private Label label4;
        private Label label1;
        private Label label5;
        private Label lblCheckingsAccount;
        private Label lblSavingsAccount;
        private Button btDeposit;
        private Button btWithdraw;
        private NumericUpDown nupAmount;
        private RadioButton rbSavings;
        private RadioButton rbCheckings;
    }
}