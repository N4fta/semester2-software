namespace Day2_Demo
{
    partial class Project
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
            btnSayHello = new Button();
            lblInstructions1 = new Label();
            txtTitle = new Label();
            lblMessage = new Label();
            txtbxName = new TextBox();
            SuspendLayout();
            // 
            // btnSayHello
            // 
            btnSayHello.Location = new Point(77, 184);
            btnSayHello.Name = "btnSayHello";
            btnSayHello.Size = new Size(150, 23);
            btnSayHello.TabIndex = 0;
            btnSayHello.Text = "Say Hello";
            btnSayHello.UseVisualStyleBackColor = true;
            btnSayHello.Click += btnSayHello_Click;
            // 
            // lblInstructions1
            // 
            lblInstructions1.AutoSize = true;
            lblInstructions1.Location = new Point(77, 117);
            lblInstructions1.Name = "lblInstructions1";
            lblInstructions1.Size = new Size(111, 15);
            lblInstructions1.TabIndex = 1;
            lblInstructions1.Text = "What is your name?";
            // 
            // txtTitle
            // 
            txtTitle.AutoSize = true;
            txtTitle.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            txtTitle.Location = new Point(77, 61);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(132, 45);
            txtTitle.TabIndex = 2;
            txtTitle.Text = "Demo 2";
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(77, 271);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 15);
            lblMessage.TabIndex = 3;
            // 
            // txtbxName
            // 
            txtbxName.Location = new Point(77, 145);
            txtbxName.Name = "txtbxName";
            txtbxName.Size = new Size(203, 23);
            txtbxName.TabIndex = 4;
            // 
            // Project
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtbxName);
            Controls.Add(lblMessage);
            Controls.Add(txtTitle);
            Controls.Add(lblInstructions1);
            Controls.Add(btnSayHello);
            Name = "Project";
            Text = "The Textbox";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSayHello;
        private Label lblInstructions1;
        private Label txtTitle;
        private Label lblMessage;
        private TextBox txtbxName;
    }
}