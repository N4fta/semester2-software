namespace Week12_Day1___Planet_Information
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
            btJupiter = new Button();
            btMercury = new Button();
            btVenus = new Button();
            btEarth = new Button();
            btMars = new Button();
            btNeptune = new Button();
            btUranus = new Button();
            btSaturn = new Button();
            btSun = new Button();
            tbDiameter = new TextBox();
            tbGravity = new TextBox();
            SuspendLayout();
            // 
            // btJupiter
            // 
            btJupiter.Location = new Point(12, 187);
            btJupiter.Name = "btJupiter";
            btJupiter.Size = new Size(159, 29);
            btJupiter.TabIndex = 4;
            btJupiter.Text = "Jupiter";
            btJupiter.UseVisualStyleBackColor = true;
            btJupiter.Click += btJupiter_Click;
            // 
            // btMercury
            // 
            btMercury.Location = new Point(12, 47);
            btMercury.Name = "btMercury";
            btMercury.Size = new Size(159, 29);
            btMercury.TabIndex = 5;
            btMercury.Text = "Mercury";
            btMercury.UseVisualStyleBackColor = true;
            btMercury.Click += btMercury_Click;
            // 
            // btVenus
            // 
            btVenus.Location = new Point(12, 82);
            btVenus.Name = "btVenus";
            btVenus.Size = new Size(159, 29);
            btVenus.TabIndex = 6;
            btVenus.Text = "Venus";
            btVenus.UseVisualStyleBackColor = true;
            btVenus.Click += btVenus_Click;
            // 
            // btEarth
            // 
            btEarth.Location = new Point(12, 117);
            btEarth.Name = "btEarth";
            btEarth.Size = new Size(159, 29);
            btEarth.TabIndex = 7;
            btEarth.Text = "Earth";
            btEarth.UseVisualStyleBackColor = true;
            btEarth.Click += btEarth_Click;
            // 
            // btMars
            // 
            btMars.Location = new Point(12, 152);
            btMars.Name = "btMars";
            btMars.Size = new Size(159, 29);
            btMars.TabIndex = 8;
            btMars.Text = "Mars";
            btMars.UseVisualStyleBackColor = true;
            btMars.Click += btMars_Click;
            // 
            // btNeptune
            // 
            btNeptune.Location = new Point(12, 292);
            btNeptune.Name = "btNeptune";
            btNeptune.Size = new Size(159, 29);
            btNeptune.TabIndex = 9;
            btNeptune.Text = "Neptune";
            btNeptune.UseVisualStyleBackColor = true;
            btNeptune.Click += btNeptune_Click;
            // 
            // btUranus
            // 
            btUranus.Location = new Point(12, 257);
            btUranus.Name = "btUranus";
            btUranus.Size = new Size(159, 29);
            btUranus.TabIndex = 10;
            btUranus.Text = "Uranus";
            btUranus.UseVisualStyleBackColor = true;
            btUranus.Click += btUranus_Click;
            // 
            // btSaturn
            // 
            btSaturn.Location = new Point(12, 222);
            btSaturn.Name = "btSaturn";
            btSaturn.Size = new Size(159, 29);
            btSaturn.TabIndex = 11;
            btSaturn.Text = "Saturn";
            btSaturn.UseVisualStyleBackColor = true;
            btSaturn.Click += btSaturn_Click;
            // 
            // btSun
            // 
            btSun.Location = new Point(12, 12);
            btSun.Name = "btSun";
            btSun.Size = new Size(159, 29);
            btSun.TabIndex = 12;
            btSun.Text = "Sun";
            btSun.UseVisualStyleBackColor = true;
            btSun.Click += btSun_Click;
            // 
            // tbDiameter
            // 
            tbDiameter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbDiameter.Location = new Point(289, 162);
            tbDiameter.Name = "tbDiameter";
            tbDiameter.ReadOnly = true;
            tbDiameter.Size = new Size(283, 23);
            tbDiameter.TabIndex = 13;
            // 
            // tbGravity
            // 
            tbGravity.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbGravity.Location = new Point(289, 88);
            tbGravity.Name = "tbGravity";
            tbGravity.ReadOnly = true;
            tbGravity.Size = new Size(283, 23);
            tbGravity.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 335);
            Controls.Add(tbGravity);
            Controls.Add(tbDiameter);
            Controls.Add(btSun);
            Controls.Add(btSaturn);
            Controls.Add(btUranus);
            Controls.Add(btNeptune);
            Controls.Add(btMars);
            Controls.Add(btEarth);
            Controls.Add(btVenus);
            Controls.Add(btMercury);
            Controls.Add(btJupiter);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btJupiter;
        private Button btMercury;
        private Button btVenus;
        private Button btEarth;
        private Button btMars;
        private Button btNeptune;
        private Button btUranus;
        private Button btSaturn;
        private Button btSun;
        private TextBox tbDiameter;
        private TextBox tbGravity;
    }
}