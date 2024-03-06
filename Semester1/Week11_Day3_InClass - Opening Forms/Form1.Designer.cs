namespace Week11_Day3_InClass
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
            listBox1 = new ListBox();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "Apple", "Bananas", "Mariah Carrey", "Shadow Wizard Money Gang", "Acused of  attempted anti-terrorism", "Oh oh oh", "HoHoho", "HoeHoeHoe" });
            listBox1.Location = new Point(228, 54);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(317, 349);
            listBox1.TabIndex = 0;
            listBox1.Visible = false;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Name of Form";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private System.Windows.Forms.Timer timer1;
    }
}