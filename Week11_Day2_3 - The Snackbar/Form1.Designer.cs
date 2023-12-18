namespace Week11_Day2_3
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnRemoveFromClientCart = new Button();
            btnClientAddToCart = new Button();
            lblClientPrice = new Label();
            lblClientDescription = new Label();
            lblClientStock = new Label();
            lblClientName = new Label();
            lblClientTotalPrice = new Label();
            label1 = new Label();
            lbClientCart = new ListBox();
            cbClient = new ComboBox();
            btClientOrder = new Button();
            nupClient = new NumericUpDown();
            tabPage2 = new TabPage();
            lblManagementRevenue = new Label();
            gbManagementSnack = new GroupBox();
            btnManagementRemove = new Button();
            btnManagementAdd = new Button();
            label10 = new Label();
            label9 = new Label();
            rtbManagementDescription = new RichTextBox();
            tbManagementName = new TextBox();
            nupManagementPrice = new NumericUpDown();
            nupManagementStock = new NumericUpDown();
            cbManagement = new ComboBox();
            label7 = new Label();
            lbManagementInventory = new ListBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nupClient).BeginInit();
            tabPage2.SuspendLayout();
            gbManagementSnack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nupManagementPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupManagementStock).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(772, 391);
            tabControl1.TabIndex = 0;
            tabControl1.Selected += tabControl1_Selected;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnRemoveFromClientCart);
            tabPage1.Controls.Add(btnClientAddToCart);
            tabPage1.Controls.Add(lblClientPrice);
            tabPage1.Controls.Add(lblClientDescription);
            tabPage1.Controls.Add(lblClientStock);
            tabPage1.Controls.Add(lblClientName);
            tabPage1.Controls.Add(lblClientTotalPrice);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(lbClientCart);
            tabPage1.Controls.Add(cbClient);
            tabPage1.Controls.Add(btClientOrder);
            tabPage1.Controls.Add(nupClient);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(764, 363);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Client View";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnRemoveFromClientCart
            // 
            btnRemoveFromClientCart.Location = new Point(688, 301);
            btnRemoveFromClientCart.Name = "btnRemoveFromClientCart";
            btnRemoveFromClientCart.Size = new Size(70, 24);
            btnRemoveFromClientCart.TabIndex = 13;
            btnRemoveFromClientCart.Text = "Remove";
            btnRemoveFromClientCart.UseVisualStyleBackColor = true;
            btnRemoveFromClientCart.Visible = false;
            // 
            // btnClientAddToCart
            // 
            btnClientAddToCart.Location = new Point(247, 64);
            btnClientAddToCart.Name = "btnClientAddToCart";
            btnClientAddToCart.Size = new Size(75, 23);
            btnClientAddToCart.TabIndex = 12;
            btnClientAddToCart.Text = "Add";
            btnClientAddToCart.UseVisualStyleBackColor = true;
            btnClientAddToCart.Click += btnClientAddToCart_Click;
            // 
            // lblClientPrice
            // 
            lblClientPrice.AutoSize = true;
            lblClientPrice.Location = new Point(27, 107);
            lblClientPrice.Name = "lblClientPrice";
            lblClientPrice.Size = new Size(0, 15);
            lblClientPrice.TabIndex = 11;
            // 
            // lblClientDescription
            // 
            lblClientDescription.AutoSize = true;
            lblClientDescription.Location = new Point(27, 165);
            lblClientDescription.Name = "lblClientDescription";
            lblClientDescription.Size = new Size(0, 15);
            lblClientDescription.TabIndex = 10;
            // 
            // lblClientStock
            // 
            lblClientStock.AutoSize = true;
            lblClientStock.Location = new Point(27, 136);
            lblClientStock.Name = "lblClientStock";
            lblClientStock.Size = new Size(0, 15);
            lblClientStock.TabIndex = 9;
            // 
            // lblClientName
            // 
            lblClientName.AutoSize = true;
            lblClientName.Location = new Point(27, 72);
            lblClientName.Name = "lblClientName";
            lblClientName.Size = new Size(0, 15);
            lblClientName.TabIndex = 8;
            // 
            // lblClientTotalPrice
            // 
            lblClientTotalPrice.AutoSize = true;
            lblClientTotalPrice.Location = new Point(501, 298);
            lblClientTotalPrice.Name = "lblClientTotalPrice";
            lblClientTotalPrice.Size = new Size(0, 15);
            lblClientTotalPrice.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(428, 298);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 6;
            label1.Text = "Total Price: ";
            // 
            // lbClientCart
            // 
            lbClientCart.FormattingEnabled = true;
            lbClientCart.ItemHeight = 15;
            lbClientCart.Location = new Point(428, 6);
            lbClientCart.Name = "lbClientCart";
            lbClientCart.Size = new Size(330, 289);
            lbClientCart.TabIndex = 5;
            // 
            // cbClient
            // 
            cbClient.FormattingEnabled = true;
            cbClient.Location = new Point(27, 22);
            cbClient.MaxDropDownItems = 10;
            cbClient.Name = "cbClient";
            cbClient.Size = new Size(166, 23);
            cbClient.TabIndex = 4;
            cbClient.SelectedIndexChanged += cbClient_SelectedIndexChanged;
            // 
            // btClientOrder
            // 
            btClientOrder.Location = new Point(428, 325);
            btClientOrder.Name = "btClientOrder";
            btClientOrder.Size = new Size(205, 23);
            btClientOrder.TabIndex = 3;
            btClientOrder.Text = "Order";
            btClientOrder.UseVisualStyleBackColor = true;
            btClientOrder.Click += btClientOrder_Click;
            // 
            // nupClient
            // 
            nupClient.Location = new Point(242, 23);
            nupClient.Name = "nupClient";
            nupClient.Size = new Size(80, 23);
            nupClient.TabIndex = 2;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(lblManagementRevenue);
            tabPage2.Controls.Add(gbManagementSnack);
            tabPage2.Controls.Add(cbManagement);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(lbManagementInventory);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(764, 363);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Management View";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblManagementRevenue
            // 
            lblManagementRevenue.AutoSize = true;
            lblManagementRevenue.Location = new Point(540, 23);
            lblManagementRevenue.Name = "lblManagementRevenue";
            lblManagementRevenue.Size = new Size(0, 15);
            lblManagementRevenue.TabIndex = 10;
            // 
            // gbManagementSnack
            // 
            gbManagementSnack.Controls.Add(btnManagementRemove);
            gbManagementSnack.Controls.Add(btnManagementAdd);
            gbManagementSnack.Controls.Add(label10);
            gbManagementSnack.Controls.Add(label9);
            gbManagementSnack.Controls.Add(rtbManagementDescription);
            gbManagementSnack.Controls.Add(tbManagementName);
            gbManagementSnack.Controls.Add(nupManagementPrice);
            gbManagementSnack.Controls.Add(nupManagementStock);
            gbManagementSnack.Location = new Point(248, 78);
            gbManagementSnack.Name = "gbManagementSnack";
            gbManagementSnack.Size = new Size(269, 262);
            gbManagementSnack.TabIndex = 9;
            gbManagementSnack.TabStop = false;
            gbManagementSnack.Text = "Snack";
            gbManagementSnack.Visible = false;
            // 
            // btnManagementRemove
            // 
            btnManagementRemove.Location = new Point(200, 84);
            btnManagementRemove.Name = "btnManagementRemove";
            btnManagementRemove.Size = new Size(63, 23);
            btnManagementRemove.TabIndex = 12;
            btnManagementRemove.Text = "Remove";
            btnManagementRemove.UseVisualStyleBackColor = true;
            btnManagementRemove.Visible = false;
            btnManagementRemove.Click += btnManagementRemove_Click;
            // 
            // btnManagementAdd
            // 
            btnManagementAdd.Location = new Point(200, 84);
            btnManagementAdd.Name = "btnManagementAdd";
            btnManagementAdd.Size = new Size(63, 23);
            btnManagementAdd.TabIndex = 11;
            btnManagementAdd.Text = "Add";
            btnManagementAdd.UseVisualStyleBackColor = true;
            btnManagementAdd.Visible = false;
            btnManagementAdd.Click += btnManagementAdd_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(19, 52);
            label10.Name = "label10";
            label10.Size = new Size(33, 15);
            label10.TabIndex = 11;
            label10.Text = "Price";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(16, 83);
            label9.Name = "label9";
            label9.Size = new Size(36, 15);
            label9.TabIndex = 10;
            label9.Text = "Stock";
            // 
            // rtbManagementDescription
            // 
            rtbManagementDescription.Location = new Point(16, 113);
            rtbManagementDescription.MaxLength = 3200;
            rtbManagementDescription.Name = "rtbManagementDescription";
            rtbManagementDescription.Size = new Size(247, 143);
            rtbManagementDescription.TabIndex = 8;
            rtbManagementDescription.Text = "Description";
            // 
            // tbManagementName
            // 
            tbManagementName.Location = new Point(16, 23);
            tbManagementName.Name = "tbManagementName";
            tbManagementName.Size = new Size(100, 23);
            tbManagementName.TabIndex = 3;
            tbManagementName.Text = "Name";
            // 
            // nupManagementPrice
            // 
            nupManagementPrice.DecimalPlaces = 2;
            nupManagementPrice.Location = new Point(78, 52);
            nupManagementPrice.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nupManagementPrice.Name = "nupManagementPrice";
            nupManagementPrice.Size = new Size(60, 23);
            nupManagementPrice.TabIndex = 7;
            // 
            // nupManagementStock
            // 
            nupManagementStock.Location = new Point(78, 81);
            nupManagementStock.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nupManagementStock.Name = "nupManagementStock";
            nupManagementStock.Size = new Size(60, 23);
            nupManagementStock.TabIndex = 6;
            // 
            // cbManagement
            // 
            cbManagement.FormattingEnabled = true;
            cbManagement.Location = new Point(248, 23);
            cbManagement.MaxDropDownItems = 10;
            cbManagement.Name = "cbManagement";
            cbManagement.Size = new Size(121, 23);
            cbManagement.TabIndex = 2;
            cbManagement.SelectedIndexChanged += cbManagement_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 5);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 1;
            label7.Text = "Stock";
            // 
            // lbManagementInventory
            // 
            lbManagementInventory.FormattingEnabled = true;
            lbManagementInventory.ItemHeight = 15;
            lbManagementInventory.Location = new Point(6, 23);
            lbManagementInventory.Name = "lbManagementInventory";
            lbManagementInventory.Size = new Size(213, 334);
            lbManagementInventory.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(796, 415);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nupClient).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            gbManagementSnack.ResumeLayout(false);
            gbManagementSnack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nupManagementPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupManagementStock).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label1;
        private ListBox lbClientCart;
        private ComboBox cbClient;
        private Button btClientOrder;
        private NumericUpDown nupClient;
        private TabPage tabPage2;
        private Label lblClientName;
        private Label lblClientTotalPrice;
        private Label lblClientPrice;
        private Label lblClientDescription;
        private Label lblClientStock;
        private NumericUpDown nupManagementPrice;
        private NumericUpDown nupManagementStock;
        private TextBox tbManagementName;
        private ComboBox cbManagement;
        private Label label7;
        private ListBox lbManagementInventory;
        private GroupBox gbManagementSnack;
        private Label label10;
        private Label label9;
        private RichTextBox rtbManagementDescription;
        private Label lblManagementRevenue;
        private Button btnClientAddToCart;
        private Button btnRemoveFromClientCart;
        private Button btnManagementAdd;
        private Button btnManagementRemove;
    }
}