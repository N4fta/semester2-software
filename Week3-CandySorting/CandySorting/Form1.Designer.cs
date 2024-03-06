
namespace CandySorting
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbCandy = new System.Windows.Forms.ListBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbCandy);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 351);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List of Candy";
            // 
            // lbCandy
            // 
            this.lbCandy.FormattingEnabled = true;
            this.lbCandy.ItemHeight = 32;
            this.lbCandy.Location = new System.Drawing.Point(12, 38);
            this.lbCandy.Name = "lbCandy";
            this.lbCandy.Size = new System.Drawing.Size(368, 292);
            this.lbCandy.TabIndex = 1;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(12, 386);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(400, 54);
            this.btnSort.TabIndex = 1;
            this.btnSort.Text = "Sort my Candy";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 466);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Candy Sorting";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbCandy;
        private System.Windows.Forms.Button btnSort;
    }
}

