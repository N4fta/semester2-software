namespace Demo_Week11_day1
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
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            lblMessage = new Label();
            rbLemonade = new RadioButton();
            rbRum = new RadioButton();
            cbOver18 = new CheckBox();
            btOrder = new Button();
            rbBeer = new RadioButton();
            rbWater = new RadioButton();
            pb1 = new PictureBox();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb1).BeginInit();
            SuspendLayout();
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(1177, 500);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(8, 23);
            numericUpDown1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 24.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(202, 52);
            label1.Name = "label1";
            label1.Size = new Size(482, 45);
            label1.TabIndex = 2;
            label1.Text = "Welcome to Tony's Virtual Bar!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(87, 132);
            label2.Name = "label2";
            label2.Size = new Size(263, 25);
            label2.TabIndex = 3;
            label2.Text = "What would you like to drink?";
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(87, 301);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 15);
            lblMessage.TabIndex = 4;
            // 
            // rbLemonade
            // 
            rbLemonade.AutoSize = true;
            rbLemonade.Location = new Point(87, 182);
            rbLemonade.Name = "rbLemonade";
            rbLemonade.Size = new Size(81, 19);
            rbLemonade.TabIndex = 5;
            rbLemonade.TabStop = true;
            rbLemonade.Text = "Lemonade";
            rbLemonade.UseVisualStyleBackColor = true;
            rbLemonade.CheckedChanged += rbLemonade_CheckedChanged;
            // 
            // rbRum
            // 
            rbRum.AutoSize = true;
            rbRum.Enabled = false;
            rbRum.Location = new Point(202, 182);
            rbRum.Name = "rbRum";
            rbRum.Size = new Size(50, 19);
            rbRum.TabIndex = 6;
            rbRum.TabStop = true;
            rbRum.Text = "Rum";
            rbRum.UseVisualStyleBackColor = true;
            rbRum.Visible = false;
            rbRum.CheckedChanged += rbRum_CheckedChanged;
            // 
            // cbOver18
            // 
            cbOver18.AutoSize = true;
            cbOver18.Location = new Point(283, 183);
            cbOver18.Name = "cbOver18";
            cbOver18.Size = new Size(90, 19);
            cbOver18.TabIndex = 7;
            cbOver18.Text = "I am over 18";
            cbOver18.UseVisualStyleBackColor = true;
            cbOver18.CheckedChanged += cbOver18_CheckedChanged;
            // 
            // btOrder
            // 
            btOrder.Location = new Point(87, 251);
            btOrder.Name = "btOrder";
            btOrder.Size = new Size(75, 23);
            btOrder.TabIndex = 8;
            btOrder.Text = "Order";
            btOrder.UseVisualStyleBackColor = true;
            btOrder.Click += btOrder_Click;
            // 
            // rbBeer
            // 
            rbBeer.AutoSize = true;
            rbBeer.Enabled = false;
            rbBeer.Location = new Point(202, 207);
            rbBeer.Name = "rbBeer";
            rbBeer.Size = new Size(48, 19);
            rbBeer.TabIndex = 9;
            rbBeer.TabStop = true;
            rbBeer.Text = "Beer";
            rbBeer.UseVisualStyleBackColor = true;
            rbBeer.Visible = false;
            rbBeer.CheckedChanged += rbBeer_CheckedChanged;
            // 
            // rbWater
            // 
            rbWater.AutoSize = true;
            rbWater.Location = new Point(87, 207);
            rbWater.Name = "rbWater";
            rbWater.Size = new Size(56, 19);
            rbWater.TabIndex = 10;
            rbWater.TabStop = true;
            rbWater.Text = "Water";
            rbWater.UseVisualStyleBackColor = true;
            rbWater.CheckedChanged += rbWater_CheckedChanged;
            // 
            // pb1
            // 
            pb1.Image = Properties.Resources._default;
            pb1.Location = new Point(506, 113);
            pb1.Name = "pb1";
            pb1.Size = new Size(362, 315);
            pb1.SizeMode = PictureBoxSizeMode.Zoom;
            pb1.TabIndex = 11;
            pb1.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.ImeMode = ImeMode.NoControl;
            comboBox1.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6" });
            comboBox1.Location = new Point(283, 267);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 509);
            Controls.Add(comboBox1);
            Controls.Add(pb1);
            Controls.Add(rbWater);
            Controls.Add(rbBeer);
            Controls.Add(btOrder);
            Controls.Add(cbOver18);
            Controls.Add(rbRum);
            Controls.Add(rbLemonade);
            Controls.Add(lblMessage);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numericUpDown1);
            Name = "Form1";
            Text = "1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private NumericUpDown numericUpDown1;
        private Label label1;
        private Label label2;
        private Label lblMessage;
        private RadioButton rbLemonade;
        private RadioButton rbRum;
        private CheckBox cbOver18;
        private Button btOrder;
        private RadioButton rbBeer;
        private RadioButton rbWater;
        private PictureBox pb1;
        private ComboBox comboBox1;
    }
}