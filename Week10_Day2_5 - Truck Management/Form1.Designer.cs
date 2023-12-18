namespace Day2_5
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
            gbInfoTrucks = new GroupBox();
            gbTruckB = new GroupBox();
            lblBoxesTruckB = new Label();
            lblPalletsTruckB = new Label();
            nudPalletsTruckB = new NumericUpDown();
            nudBoxesTruckB = new NumericUpDown();
            gbTruckA = new GroupBox();
            lblBoxesTruckA = new Label();
            lblPalletsTruckA = new Label();
            nudBoxesTruckA = new NumericUpDown();
            nudPalletsTruckA = new NumericUpDown();
            gbTruckC = new GroupBox();
            lblBoxesTruckC = new Label();
            lblPalletsTruckC = new Label();
            nudPalletsTruckC = new NumericUpDown();
            nudBoxesTruckC = new NumericUpDown();
            gbInfoOrders = new GroupBox();
            lblResults = new Label();
            lblTruckType = new Label();
            lblBoxesOrder = new Label();
            nudBoxesOrder = new NumericUpDown();
            rbTruckB = new RadioButton();
            rbTruckC = new RadioButton();
            rbTruckA = new RadioButton();
            gbInfoTrucks.SuspendLayout();
            gbTruckB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPalletsTruckB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudBoxesTruckB).BeginInit();
            gbTruckA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudBoxesTruckA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPalletsTruckA).BeginInit();
            gbTruckC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPalletsTruckC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudBoxesTruckC).BeginInit();
            gbInfoOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudBoxesOrder).BeginInit();
            SuspendLayout();
            // 
            // gbInfoTrucks
            // 
            gbInfoTrucks.Controls.Add(gbTruckB);
            gbInfoTrucks.Controls.Add(gbTruckA);
            gbInfoTrucks.Controls.Add(gbTruckC);
            gbInfoTrucks.Location = new Point(12, 12);
            gbInfoTrucks.Name = "gbInfoTrucks";
            gbInfoTrucks.Size = new Size(404, 442);
            gbInfoTrucks.TabIndex = 0;
            gbInfoTrucks.TabStop = false;
            gbInfoTrucks.Text = "Trucks";
            // 
            // gbTruckB
            // 
            gbTruckB.Controls.Add(lblBoxesTruckB);
            gbTruckB.Controls.Add(lblPalletsTruckB);
            gbTruckB.Controls.Add(nudPalletsTruckB);
            gbTruckB.Controls.Add(nudBoxesTruckB);
            gbTruckB.Location = new Point(15, 169);
            gbTruckB.Name = "gbTruckB";
            gbTruckB.Size = new Size(371, 122);
            gbTruckB.TabIndex = 3;
            gbTruckB.TabStop = false;
            gbTruckB.Text = "Info Truck type B";
            // 
            // lblBoxesTruckB
            // 
            lblBoxesTruckB.AutoSize = true;
            lblBoxesTruckB.Location = new Point(12, 53);
            lblBoxesTruckB.Name = "lblBoxesTruckB";
            lblBoxesTruckB.Size = new Size(184, 15);
            lblBoxesTruckB.TabIndex = 9;
            lblBoxesTruckB.Text = "Max. number of boxes per pallet: ";
            // 
            // lblPalletsTruckB
            // 
            lblPalletsTruckB.AutoSize = true;
            lblPalletsTruckB.Location = new Point(12, 24);
            lblPalletsTruckB.Name = "lblPalletsTruckB";
            lblPalletsTruckB.Size = new Size(185, 15);
            lblPalletsTruckB.TabIndex = 7;
            lblPalletsTruckB.Text = "Max. number of pallets per truck: ";
            // 
            // nudPalletsTruckB
            // 
            nudPalletsTruckB.Location = new Point(203, 22);
            nudPalletsTruckB.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            nudPalletsTruckB.Name = "nudPalletsTruckB";
            nudPalletsTruckB.Size = new Size(61, 23);
            nudPalletsTruckB.TabIndex = 4;
            nudPalletsTruckB.ValueChanged += change_In_Input;
            // 
            // nudBoxesTruckB
            // 
            nudBoxesTruckB.Location = new Point(203, 51);
            nudBoxesTruckB.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            nudBoxesTruckB.Name = "nudBoxesTruckB";
            nudBoxesTruckB.Size = new Size(61, 23);
            nudBoxesTruckB.TabIndex = 3;
            nudBoxesTruckB.ValueChanged += change_In_Input;
            // 
            // gbTruckA
            // 
            gbTruckA.Controls.Add(lblBoxesTruckA);
            gbTruckA.Controls.Add(lblPalletsTruckA);
            gbTruckA.Controls.Add(nudBoxesTruckA);
            gbTruckA.Controls.Add(nudPalletsTruckA);
            gbTruckA.Location = new Point(15, 31);
            gbTruckA.Name = "gbTruckA";
            gbTruckA.Size = new Size(371, 122);
            gbTruckA.TabIndex = 3;
            gbTruckA.TabStop = false;
            gbTruckA.Text = "Info Truck type A";
            // 
            // lblBoxesTruckA
            // 
            lblBoxesTruckA.AutoSize = true;
            lblBoxesTruckA.Location = new Point(12, 54);
            lblBoxesTruckA.Name = "lblBoxesTruckA";
            lblBoxesTruckA.Size = new Size(184, 15);
            lblBoxesTruckA.TabIndex = 7;
            lblBoxesTruckA.Text = "Max. number of boxes per pallet: ";
            // 
            // lblPalletsTruckA
            // 
            lblPalletsTruckA.AutoSize = true;
            lblPalletsTruckA.Location = new Point(12, 24);
            lblPalletsTruckA.Name = "lblPalletsTruckA";
            lblPalletsTruckA.Size = new Size(185, 15);
            lblPalletsTruckA.TabIndex = 6;
            lblPalletsTruckA.Text = "Max. number of pallets per truck: ";
            // 
            // nudBoxesTruckA
            // 
            nudBoxesTruckA.Location = new Point(203, 52);
            nudBoxesTruckA.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            nudBoxesTruckA.Name = "nudBoxesTruckA";
            nudBoxesTruckA.Size = new Size(61, 23);
            nudBoxesTruckA.TabIndex = 5;
            nudBoxesTruckA.ValueChanged += change_In_Input;
            // 
            // nudPalletsTruckA
            // 
            nudPalletsTruckA.Location = new Point(203, 22);
            nudPalletsTruckA.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            nudPalletsTruckA.Name = "nudPalletsTruckA";
            nudPalletsTruckA.Size = new Size(61, 23);
            nudPalletsTruckA.TabIndex = 0;
            nudPalletsTruckA.ValueChanged += change_In_Input;
            // 
            // gbTruckC
            // 
            gbTruckC.Controls.Add(lblBoxesTruckC);
            gbTruckC.Controls.Add(lblPalletsTruckC);
            gbTruckC.Controls.Add(nudPalletsTruckC);
            gbTruckC.Controls.Add(nudBoxesTruckC);
            gbTruckC.Location = new Point(15, 308);
            gbTruckC.Name = "gbTruckC";
            gbTruckC.Size = new Size(371, 122);
            gbTruckC.TabIndex = 2;
            gbTruckC.TabStop = false;
            gbTruckC.Text = "Info Truck type C";
            // 
            // lblBoxesTruckC
            // 
            lblBoxesTruckC.AutoSize = true;
            lblBoxesTruckC.Location = new Point(12, 53);
            lblBoxesTruckC.Name = "lblBoxesTruckC";
            lblBoxesTruckC.Size = new Size(184, 15);
            lblBoxesTruckC.TabIndex = 8;
            lblBoxesTruckC.Text = "Max. number of boxes per pallet: ";
            // 
            // lblPalletsTruckC
            // 
            lblPalletsTruckC.AutoSize = true;
            lblPalletsTruckC.Location = new Point(12, 24);
            lblPalletsTruckC.Name = "lblPalletsTruckC";
            lblPalletsTruckC.Size = new Size(185, 15);
            lblPalletsTruckC.TabIndex = 8;
            lblPalletsTruckC.Text = "Max. number of pallets per truck: ";
            // 
            // nudPalletsTruckC
            // 
            nudPalletsTruckC.Location = new Point(203, 22);
            nudPalletsTruckC.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            nudPalletsTruckC.Name = "nudPalletsTruckC";
            nudPalletsTruckC.Size = new Size(61, 23);
            nudPalletsTruckC.TabIndex = 2;
            nudPalletsTruckC.ValueChanged += change_In_Input;
            // 
            // nudBoxesTruckC
            // 
            nudBoxesTruckC.Location = new Point(203, 51);
            nudBoxesTruckC.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            nudBoxesTruckC.Name = "nudBoxesTruckC";
            nudBoxesTruckC.Size = new Size(61, 23);
            nudBoxesTruckC.TabIndex = 1;
            nudBoxesTruckC.ValueChanged += change_In_Input;
            // 
            // gbInfoOrders
            // 
            gbInfoOrders.Controls.Add(lblResults);
            gbInfoOrders.Controls.Add(lblTruckType);
            gbInfoOrders.Controls.Add(lblBoxesOrder);
            gbInfoOrders.Controls.Add(nudBoxesOrder);
            gbInfoOrders.Controls.Add(rbTruckB);
            gbInfoOrders.Controls.Add(rbTruckC);
            gbInfoOrders.Controls.Add(rbTruckA);
            gbInfoOrders.Location = new Point(422, 14);
            gbInfoOrders.Name = "gbInfoOrders";
            gbInfoOrders.Size = new Size(294, 442);
            gbInfoOrders.TabIndex = 1;
            gbInfoOrders.TabStop = false;
            gbInfoOrders.Text = "Order";
            // 
            // lblResults
            // 
            lblResults.AutoSize = true;
            lblResults.Location = new Point(6, 167);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(0, 15);
            lblResults.TabIndex = 10;
            // 
            // lblTruckType
            // 
            lblTruckType.AutoSize = true;
            lblTruckType.Location = new Point(36, 70);
            lblTruckType.Name = "lblTruckType";
            lblTruckType.Size = new Size(125, 15);
            lblTruckType.TabIndex = 9;
            lblTruckType.Text = "Truck type to be used: ";
            // 
            // lblBoxesOrder
            // 
            lblBoxesOrder.AutoSize = true;
            lblBoxesOrder.Location = new Point(6, 31);
            lblBoxesOrder.Name = "lblBoxesOrder";
            lblBoxesOrder.Size = new Size(155, 15);
            lblBoxesOrder.TabIndex = 8;
            lblBoxesOrder.Text = "No. of boxes to be shipped: ";
            // 
            // nudBoxesOrder
            // 
            nudBoxesOrder.Location = new Point(167, 29);
            nudBoxesOrder.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudBoxesOrder.Name = "nudBoxesOrder";
            nudBoxesOrder.Size = new Size(72, 23);
            nudBoxesOrder.TabIndex = 8;
            nudBoxesOrder.ValueChanged += change_In_Input;
            // 
            // rbTruckB
            // 
            rbTruckB.AutoSize = true;
            rbTruckB.Location = new Point(167, 93);
            rbTruckB.Name = "rbTruckB";
            rbTruckB.Size = new Size(59, 19);
            rbTruckB.TabIndex = 2;
            rbTruckB.TabStop = true;
            rbTruckB.Text = "Type B";
            rbTruckB.UseVisualStyleBackColor = true;
            rbTruckB.CheckedChanged += change_In_Input;
            // 
            // rbTruckC
            // 
            rbTruckC.AutoSize = true;
            rbTruckC.Location = new Point(167, 118);
            rbTruckC.Name = "rbTruckC";
            rbTruckC.Size = new Size(60, 19);
            rbTruckC.TabIndex = 1;
            rbTruckC.TabStop = true;
            rbTruckC.Text = "Type C";
            rbTruckC.UseVisualStyleBackColor = true;
            rbTruckC.CheckedChanged += change_In_Input;
            // 
            // rbTruckA
            // 
            rbTruckA.AutoSize = true;
            rbTruckA.Location = new Point(167, 68);
            rbTruckA.Name = "rbTruckA";
            rbTruckA.Size = new Size(60, 19);
            rbTruckA.TabIndex = 0;
            rbTruckA.TabStop = true;
            rbTruckA.Text = "Type A";
            rbTruckA.UseVisualStyleBackColor = true;
            rbTruckA.CheckedChanged += change_In_Input;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(728, 468);
            Controls.Add(gbInfoOrders);
            Controls.Add(gbInfoTrucks);
            Name = "Form1";
            Text = "Form1";
            gbInfoTrucks.ResumeLayout(false);
            gbTruckB.ResumeLayout(false);
            gbTruckB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPalletsTruckB).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudBoxesTruckB).EndInit();
            gbTruckA.ResumeLayout(false);
            gbTruckA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudBoxesTruckA).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPalletsTruckA).EndInit();
            gbTruckC.ResumeLayout(false);
            gbTruckC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPalletsTruckC).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudBoxesTruckC).EndInit();
            gbInfoOrders.ResumeLayout(false);
            gbInfoOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudBoxesOrder).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbInfoTrucks;
        private GroupBox gbInfoOrders;
        private GroupBox gbTruckB;
        private GroupBox gbTruckA;
        private GroupBox gbTruckC;
        private NumericUpDown nudPalletsTruckA;
        private RadioButton rbTruckB;
        private RadioButton rbTruckC;
        private RadioButton rbTruckA;
        private NumericUpDown nudPalletsTruckB;
        private NumericUpDown nudBoxesTruckB;
        private Label lblPalletsTruckA;
        private NumericUpDown nudBoxesTruckA;
        private NumericUpDown nudPalletsTruckC;
        private NumericUpDown nudBoxesTruckC;
        private Label lblPalletsTruckB;
        private Label lblPalletsTruckC;
        private Label lblBoxesTruckA;
        private Label lblBoxesTruckB;
        private Label lblBoxesTruckC;
        private Label lblBoxesOrder;
        private NumericUpDown nudBoxesOrder;
        private Label lblTruckType;
        private Label lblResults;
    }
}