namespace Week11_Day1_4
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
            tmrCar = new System.Windows.Forms.Timer(components);
            btnStart = new Button();
            btnStop = new Button();
            picboxCar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picboxCar).BeginInit();
            SuspendLayout();
            // 
            // tmrCar
            // 
            tmrCar.Interval = 50;
            tmrCar.Tick += tmrCar_Tick;
            // 
            // btnStart
            // 
            btnStart.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnStart.AutoSize = true;
            btnStart.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnStart.Location = new Point(12, 68);
            btnStart.MinimumSize = new Size(340, 25);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(340, 25);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnStop.AutoSize = true;
            btnStop.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnStop.Location = new Point(358, 68);
            btnStop.MinimumSize = new Size(340, 25);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(340, 25);
            btnStop.TabIndex = 1;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // picboxCar
            // 
            picboxCar.Image = Properties.Resources.Screenshot_2023_11_23_192334;
            picboxCar.Location = new Point(12, 12);
            picboxCar.Name = "picboxCar";
            picboxCar.Size = new Size(100, 50);
            picboxCar.SizeMode = PictureBoxSizeMode.Zoom;
            picboxCar.TabIndex = 2;
            picboxCar.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(717, 101);
            Controls.Add(picboxCar);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picboxCar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer tmrCar;
        private Button btnStart;
        private Button btnStop;
        private PictureBox picboxCar;
    }
}