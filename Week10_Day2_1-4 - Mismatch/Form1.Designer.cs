namespace Day2_1
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
            button1 = new Button();
            trackBar1 = new TrackBar();
            progressBar1 = new ProgressBar();
            label1 = new Label();
            rbRed = new RadioButton();
            rbWhite = new RadioButton();
            rbCRAZY = new RadioButton();
            btnCycleBackgrounds = new Button();
            btnCalculateBMI = new Button();
            tbHeightInput = new TextBox();
            tbWeightInput = new TextBox();
            lblInputWeight = new Label();
            lblInputHeight = new Label();
            lblBMIResults = new Label();
            lblNotesBMI = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.LightSeaGreen;
            button1.Location = new Point(93, 23);
            button1.Name = "button1";
            button1.Size = new Size(161, 40);
            button1.TabIndex = 0;
            button1.Text = "Who am I??!";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // trackBar1
            // 
            trackBar1.BackColor = Color.FromArgb(0, 192, 192);
            trackBar1.Location = new Point(20, 12);
            trackBar1.Maximum = 100;
            trackBar1.Name = "trackBar1";
            trackBar1.Orientation = Orientation.Vertical;
            trackBar1.Size = new Size(45, 396);
            trackBar1.TabIndex = 1;
            trackBar1.Value = 50;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(93, 394);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(610, 33);
            progressBar1.TabIndex = 2;
            progressBar1.Value = 50;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(709, 402);
            label1.Name = "label1";
            label1.Size = new Size(32, 25);
            label1.TabIndex = 3;
            label1.Text = "50";
            // 
            // rbRed
            // 
            rbRed.AutoSize = true;
            rbRed.Location = new Point(648, 23);
            rbRed.Name = "rbRed";
            rbRed.Size = new Size(84, 19);
            rbRed.TabIndex = 4;
            rbRed.TabStop = true;
            rbRed.Text = "Make it red";
            rbRed.UseVisualStyleBackColor = true;
            rbRed.CheckedChanged += rbRed_CheckedChanged;
            // 
            // rbWhite
            // 
            rbWhite.AutoSize = true;
            rbWhite.Location = new Point(648, 48);
            rbWhite.Name = "rbWhite";
            rbWhite.Size = new Size(96, 19);
            rbWhite.TabIndex = 5;
            rbWhite.TabStop = true;
            rbWhite.Text = "Make it white";
            rbWhite.UseVisualStyleBackColor = true;
            rbWhite.CheckedChanged += rbWhite_CheckedChanged;
            // 
            // rbCRAZY
            // 
            rbCRAZY.AutoSize = true;
            rbCRAZY.Location = new Point(648, 73);
            rbCRAZY.Name = "rbCRAZY";
            rbCRAZY.Size = new Size(121, 19);
            rbCRAZY.TabIndex = 6;
            rbCRAZY.TabStop = true;
            rbCRAZY.Text = "make it go CRAZY";
            rbCRAZY.UseVisualStyleBackColor = true;
            rbCRAZY.CheckedChanged += rbCRAZY_CheckedChanged;
            // 
            // btnCycleBackgrounds
            // 
            btnCycleBackgrounds.Location = new Point(648, 114);
            btnCycleBackgrounds.Name = "btnCycleBackgrounds";
            btnCycleBackgrounds.Size = new Size(133, 32);
            btnCycleBackgrounds.TabIndex = 7;
            btnCycleBackgrounds.Text = "Red/Green/Blue";
            btnCycleBackgrounds.UseVisualStyleBackColor = true;
            btnCycleBackgrounds.Click += btnCycleBackgrounds_Click;
            // 
            // btnCalculateBMI
            // 
            btnCalculateBMI.Location = new Point(93, 212);
            btnCalculateBMI.Name = "btnCalculateBMI";
            btnCalculateBMI.Size = new Size(161, 31);
            btnCalculateBMI.TabIndex = 8;
            btnCalculateBMI.Text = "Am I Overweight??";
            btnCalculateBMI.UseVisualStyleBackColor = true;
            btnCalculateBMI.Click += btnCalculateBMI_Click;
            // 
            // tbHeightInput
            // 
            tbHeightInput.Location = new Point(169, 173);
            tbHeightInput.Name = "tbHeightInput";
            tbHeightInput.Size = new Size(80, 23);
            tbHeightInput.TabIndex = 9;
            // 
            // tbWeightInput
            // 
            tbWeightInput.Location = new Point(169, 144);
            tbWeightInput.Name = "tbWeightInput";
            tbWeightInput.Size = new Size(80, 23);
            tbWeightInput.TabIndex = 10;
            // 
            // lblInputWeight
            // 
            lblInputWeight.AutoSize = true;
            lblInputWeight.Location = new Point(93, 147);
            lblInputWeight.Name = "lblInputWeight";
            lblInputWeight.Size = new Size(70, 15);
            lblInputWeight.TabIndex = 11;
            lblInputWeight.Text = "Weight(Kg):";
            // 
            // lblInputHeight
            // 
            lblInputHeight.AutoSize = true;
            lblInputHeight.Location = new Point(93, 176);
            lblInputHeight.Name = "lblInputHeight";
            lblInputHeight.Size = new Size(68, 15);
            lblInputHeight.TabIndex = 12;
            lblInputHeight.Text = "Height (m):";
            // 
            // lblBMIResults
            // 
            lblBMIResults.AutoSize = true;
            lblBMIResults.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblBMIResults.Location = new Point(93, 270);
            lblBMIResults.Name = "lblBMIResults";
            lblBMIResults.Size = new Size(0, 20);
            lblBMIResults.TabIndex = 13;
            // 
            // lblNotesBMI
            // 
            lblNotesBMI.AutoSize = true;
            lblNotesBMI.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNotesBMI.Location = new Point(93, 327);
            lblNotesBMI.Name = "lblNotesBMI";
            lblNotesBMI.Size = new Size(0, 13);
            lblNotesBMI.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(93, 114);
            label2.Name = "label2";
            label2.Size = new Size(198, 20);
            label2.TabIndex = 15;
            label2.Text = "Body  Mass Index Calculator:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(lblNotesBMI);
            Controls.Add(lblBMIResults);
            Controls.Add(lblInputHeight);
            Controls.Add(lblInputWeight);
            Controls.Add(tbWeightInput);
            Controls.Add(tbHeightInput);
            Controls.Add(btnCalculateBMI);
            Controls.Add(btnCycleBackgrounds);
            Controls.Add(rbCRAZY);
            Controls.Add(rbWhite);
            Controls.Add(rbRed);
            Controls.Add(label1);
            Controls.Add(progressBar1);
            Controls.Add(trackBar1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "My first program";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TrackBar trackBar1;
        private ProgressBar progressBar1;
        private Label label1;
        private RadioButton rbRed;
        private RadioButton rbWhite;
        private RadioButton rbCRAZY;
        private Button btnCycleBackgrounds;
        private Button btnCalculateBMI;
        private TextBox tbHeightInput;
        private TextBox tbWeightInput;
        private Label lblInputWeight;
        private Label lblInputHeight;
        private Label lblBMIResults;
        private Label lblNotesBMI;
        private Label label2;
    }
}