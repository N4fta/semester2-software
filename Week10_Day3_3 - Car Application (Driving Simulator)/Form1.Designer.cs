namespace Week10_Day3_3
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
            components = new System.ComponentModel.Container();
            tbSpeedControl = new TrackBar();
            btPedalGas = new Button();
            btPedalBrake = new Button();
            lblPedalBrake = new Label();
            lblPedalGas = new Label();
            pbWindscreen = new PictureBox();
            lblDescription = new Label();
            rbFerrari = new RadioButton();
            rbFiatPanda = new RadioButton();
            lblSpeedDisplay = new Label();
            tImage = new System.Windows.Forms.Timer(components);
            tCooldown = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)tbSpeedControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbWindscreen).BeginInit();
            SuspendLayout();
            // 
            // tbSpeedControl
            // 
            tbSpeedControl.Enabled = false;
            tbSpeedControl.LargeChange = 1;
            tbSpeedControl.Location = new Point(687, 22);
            tbSpeedControl.Maximum = 5;
            tbSpeedControl.Name = "tbSpeedControl";
            tbSpeedControl.Orientation = Orientation.Vertical;
            tbSpeedControl.Size = new Size(45, 294);
            tbSpeedControl.TabIndex = 0;
            tbSpeedControl.TickStyle = TickStyle.Both;
            tbSpeedControl.Value = 1;
            // 
            // btPedalGas
            // 
            btPedalGas.Enabled = false;
            btPedalGas.Location = new Point(589, 293);
            btPedalGas.Name = "btPedalGas";
            btPedalGas.Size = new Size(72, 118);
            btPedalGas.TabIndex = 1;
            btPedalGas.Text = " |       | \r\n |       | \r\n |       | \r\n |       | \r\n |       | \r\n |       | ";
            btPedalGas.UseVisualStyleBackColor = true;
            btPedalGas.KeyDown += btPedalGas_KeyDown;
            btPedalGas.KeyUp += btPedals_KeyUp;
            btPedalGas.MouseDown += btPedalGas_MouseDown;
            btPedalGas.MouseUp += btPedals_MouseUp;
            // 
            // btPedalBrake
            // 
            btPedalBrake.Enabled = false;
            btPedalBrake.Location = new Point(487, 293);
            btPedalBrake.Name = "btPedalBrake";
            btPedalBrake.Size = new Size(72, 118);
            btPedalBrake.TabIndex = 2;
            btPedalBrake.Text = " |       | \r\n |       | \r\n |       | \r\n |       | \r\n |       | \r\n |       | ";
            btPedalBrake.UseVisualStyleBackColor = true;
            btPedalBrake.KeyDown += btPedalBrake_KeyDown;
            btPedalBrake.KeyUp += btPedals_KeyUp;
            btPedalBrake.MouseDown += btPedalBrake_MouseDown;
            btPedalBrake.MouseUp += btPedals_MouseUp;
            // 
            // lblPedalBrake
            // 
            lblPedalBrake.AutoSize = true;
            lblPedalBrake.Enabled = false;
            lblPedalBrake.Location = new Point(505, 414);
            lblPedalBrake.Name = "lblPedalBrake";
            lblPedalBrake.Size = new Size(36, 15);
            lblPedalBrake.TabIndex = 3;
            lblPedalBrake.Text = "Brake";
            // 
            // lblPedalGas
            // 
            lblPedalGas.AutoSize = true;
            lblPedalGas.Enabled = false;
            lblPedalGas.Location = new Point(613, 414);
            lblPedalGas.Name = "lblPedalGas";
            lblPedalGas.Size = new Size(26, 15);
            lblPedalGas.TabIndex = 4;
            lblPedalGas.Text = "Gas";
            // 
            // pbWindscreen
            // 
            pbWindscreen.Enabled = false;
            pbWindscreen.Location = new Point(30, 22);
            pbWindscreen.Name = "pbWindscreen";
            pbWindscreen.Size = new Size(633, 249);
            pbWindscreen.SizeMode = PictureBoxSizeMode.Zoom;
            pbWindscreen.TabIndex = 5;
            pbWindscreen.TabStop = false;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescription.Location = new Point(12, 361);
            lblDescription.MaximumSize = new Size(430, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(137, 25);
            lblDescription.TabIndex = 6;
            lblDescription.Text = "Insert Your Keys";
            // 
            // rbFerrari
            // 
            rbFerrari.AutoSize = true;
            rbFerrari.Font = new Font("Magneto", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            rbFerrari.Location = new Point(12, 419);
            rbFerrari.Name = "rbFerrari";
            rbFerrari.Size = new Size(93, 24);
            rbFerrari.TabIndex = 7;
            rbFerrari.Text = "Ferrari";
            rbFerrari.CheckedChanged += StartUpSequence;
            // 
            // rbFiatPanda
            // 
            rbFiatPanda.AutoSize = true;
            rbFiatPanda.Font = new Font("Ravie", 9.25F, FontStyle.Italic, GraphicsUnit.Point);
            rbFiatPanda.Location = new Point(111, 420);
            rbFiatPanda.Name = "rbFiatPanda";
            rbFiatPanda.Size = new Size(122, 23);
            rbFiatPanda.TabIndex = 8;
            rbFiatPanda.Text = "Fiat Panda";
            rbFiatPanda.CheckedChanged += StartUpSequence;
            // 
            // lblSpeedDisplay
            // 
            lblSpeedDisplay.AutoSize = true;
            lblSpeedDisplay.Enabled = false;
            lblSpeedDisplay.Font = new Font("Agency FB", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblSpeedDisplay.Location = new Point(30, 293);
            lblSpeedDisplay.Name = "lblSpeedDisplay";
            lblSpeedDisplay.Size = new Size(0, 58);
            lblSpeedDisplay.TabIndex = 9;
            // 
            // tImage
            // 
            tImage.Interval = 500;
            tImage.Tick += tImage_Tick;
            // 
            // tCooldown
            // 
            tCooldown.Interval = 50;
            tCooldown.Tick += tCooldown_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSpeedDisplay);
            Controls.Add(rbFiatPanda);
            Controls.Add(rbFerrari);
            Controls.Add(lblDescription);
            Controls.Add(pbWindscreen);
            Controls.Add(lblPedalGas);
            Controls.Add(lblPedalBrake);
            Controls.Add(btPedalBrake);
            Controls.Add(btPedalGas);
            Controls.Add(tbSpeedControl);
            Name = "Form1";
            Text = "Test Drive";
            ((System.ComponentModel.ISupportInitialize)tbSpeedControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbWindscreen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar tbSpeedControl;
        private Button btPedalGas;
        private Button btPedalBrake;
        private Label lblPedalBrake;
        private Label lblPedalGas;
        private PictureBox pbWindscreen;
        private Label lblDescription;
        private RadioButton rbFerrari;
        private RadioButton rbFiatPanda;
        private Label lblSpeedDisplay;
        private System.Windows.Forms.Timer tImage;
        private System.Windows.Forms.Timer tCooldown;
    }
}