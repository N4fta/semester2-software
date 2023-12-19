namespace Week12_Day1_1___Pizza_Toppings
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
            cbPizzaToppings = new ComboBox();
            btAddTopping = new Button();
            btRemoveTopping = new Button();
            lblPizzaPrice = new Label();
            lblPizzaDescription = new Label();
            SuspendLayout();
            // 
            // cbPizzaToppings
            // 
            cbPizzaToppings.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPizzaToppings.FormattingEnabled = true;
            cbPizzaToppings.Location = new Point(37, 33);
            cbPizzaToppings.Name = "cbPizzaToppings";
            cbPizzaToppings.Size = new Size(121, 23);
            cbPizzaToppings.TabIndex = 0;
            // 
            // btAddTopping
            // 
            btAddTopping.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btAddTopping.Location = new Point(251, 26);
            btAddTopping.Name = "btAddTopping";
            btAddTopping.Size = new Size(128, 35);
            btAddTopping.TabIndex = 1;
            btAddTopping.Text = "Add Topping";
            btAddTopping.UseVisualStyleBackColor = true;
            btAddTopping.Click += btAddTopping_Click;
            // 
            // btRemoveTopping
            // 
            btRemoveTopping.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btRemoveTopping.Location = new Point(251, 67);
            btRemoveTopping.Name = "btRemoveTopping";
            btRemoveTopping.Size = new Size(128, 35);
            btRemoveTopping.TabIndex = 2;
            btRemoveTopping.Text = "Remove Topping";
            btRemoveTopping.UseVisualStyleBackColor = true;
            btRemoveTopping.Click += btRemoveTopping_Click;
            // 
            // lblPizzaPrice
            // 
            lblPizzaPrice.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblPizzaPrice.AutoSize = true;
            lblPizzaPrice.Location = new Point(36, 138);
            lblPizzaPrice.Name = "lblPizzaPrice";
            lblPizzaPrice.Size = new Size(72, 15);
            lblPizzaPrice.TabIndex = 3;
            lblPizzaPrice.Text = "Price: 5 euro";
            // 
            // lblPizzaDescription
            // 
            lblPizzaDescription.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblPizzaDescription.AutoSize = true;
            lblPizzaDescription.Location = new Point(37, 114);
            lblPizzaDescription.Name = "lblPizzaDescription";
            lblPizzaDescription.Size = new Size(65, 15);
            lblPizzaDescription.TabIndex = 4;
            lblPizzaDescription.Text = "Pizza with: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 172);
            Controls.Add(lblPizzaDescription);
            Controls.Add(lblPizzaPrice);
            Controls.Add(btRemoveTopping);
            Controls.Add(btAddTopping);
            Controls.Add(cbPizzaToppings);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbPizzaToppings;
        private Button btAddTopping;
        private Button btRemoveTopping;
        private Label lblPizzaPrice;
        private Label lblPizzaDescription;
    }
}