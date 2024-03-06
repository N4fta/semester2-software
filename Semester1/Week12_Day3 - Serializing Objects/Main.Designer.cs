namespace Week12_Day3___Serializing_Objects
{
    partial class Main
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
            groupBox1 = new GroupBox();
            lblSandwichData = new Label();
            btnShowTotalRevenue = new Button();
            btnSellSelectedSandwich = new Button();
            chbxIncludeVAT = new CheckBox();
            groupBox2 = new GroupBox();
            cbxBreadFilter = new ComboBox();
            lbxMenu = new ListBox();
            label1 = new Label();
            btnLoadData = new Button();
            btnSaveData = new Button();
            btnShowOfferedSandwiches = new Button();
            btnAddNewSandwich = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox1.Controls.Add(lblSandwichData);
            groupBox1.Controls.Add(btnShowTotalRevenue);
            groupBox1.Controls.Add(btnSellSelectedSandwich);
            groupBox1.Controls.Add(chbxIncludeVAT);
            groupBox1.Location = new Point(326, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(253, 273);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cart";
            // 
            // lblSandwichData
            // 
            lblSandwichData.Location = new Point(6, 19);
            lblSandwichData.Name = "lblSandwichData";
            lblSandwichData.Size = new Size(241, 193);
            lblSandwichData.TabIndex = 6;
            lblSandwichData.Text = "Sandwich Data";
            lblSandwichData.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnShowTotalRevenue
            // 
            btnShowTotalRevenue.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnShowTotalRevenue.Location = new Point(91, 244);
            btnShowTotalRevenue.Name = "btnShowTotalRevenue";
            btnShowTotalRevenue.Size = new Size(156, 23);
            btnShowTotalRevenue.TabIndex = 5;
            btnShowTotalRevenue.Text = "Show Total Revenue";
            btnShowTotalRevenue.UseVisualStyleBackColor = true;
            btnShowTotalRevenue.Click += btnShowTotalRevenue_Click;
            // 
            // btnSellSelectedSandwich
            // 
            btnSellSelectedSandwich.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSellSelectedSandwich.Location = new Point(6, 215);
            btnSellSelectedSandwich.Name = "btnSellSelectedSandwich";
            btnSellSelectedSandwich.Size = new Size(241, 23);
            btnSellSelectedSandwich.TabIndex = 4;
            btnSellSelectedSandwich.Text = "Sell selected sandwich";
            btnSellSelectedSandwich.UseVisualStyleBackColor = true;
            btnSellSelectedSandwich.Click += btnSellSelectedSandwich_Click;
            // 
            // chbxIncludeVAT
            // 
            chbxIncludeVAT.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            chbxIncludeVAT.AutoSize = true;
            chbxIncludeVAT.Location = new Point(6, 247);
            chbxIncludeVAT.Name = "chbxIncludeVAT";
            chbxIncludeVAT.Size = new Size(87, 19);
            chbxIncludeVAT.TabIndex = 5;
            chbxIncludeVAT.Text = "Include VAT";
            chbxIncludeVAT.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(cbxBreadFilter);
            groupBox2.Controls.Add(lbxMenu);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(btnLoadData);
            groupBox2.Controls.Add(btnSaveData);
            groupBox2.Controls.Add(btnShowOfferedSandwiches);
            groupBox2.Controls.Add(btnAddNewSandwich);
            groupBox2.Location = new Point(1, 13);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(316, 273);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Menu";
            // 
            // cbxBreadFilter
            // 
            cbxBreadFilter.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbxBreadFilter.FormattingEnabled = true;
            cbxBreadFilter.Location = new Point(74, 15);
            cbxBreadFilter.Name = "cbxBreadFilter";
            cbxBreadFilter.Size = new Size(236, 23);
            cbxBreadFilter.TabIndex = 7;
            // 
            // lbxMenu
            // 
            lbxMenu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbxMenu.FormattingEnabled = true;
            lbxMenu.ItemHeight = 15;
            lbxMenu.Location = new Point(6, 73);
            lbxMenu.Name = "lbxMenu";
            lbxMenu.Size = new Size(304, 139);
            lbxMenu.TabIndex = 6;
            lbxMenu.SelectedIndexChanged += lbxMenu_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 18);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 4;
            label1.Text = "Bread filter: ";
            // 
            // btnLoadData
            // 
            btnLoadData.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLoadData.Location = new Point(154, 244);
            btnLoadData.Name = "btnLoadData";
            btnLoadData.Size = new Size(156, 23);
            btnLoadData.TabIndex = 3;
            btnLoadData.Text = "Load Data";
            btnLoadData.UseVisualStyleBackColor = true;
            btnLoadData.Click += btnLoadData_Click;
            // 
            // btnSaveData
            // 
            btnSaveData.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSaveData.Location = new Point(6, 244);
            btnSaveData.Name = "btnSaveData";
            btnSaveData.Size = new Size(141, 23);
            btnSaveData.TabIndex = 2;
            btnSaveData.Text = "Save Data";
            btnSaveData.UseVisualStyleBackColor = true;
            btnSaveData.Click += btnSaveData_Click;
            // 
            // btnShowOfferedSandwiches
            // 
            btnShowOfferedSandwiches.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnShowOfferedSandwiches.Location = new Point(8, 44);
            btnShowOfferedSandwiches.Name = "btnShowOfferedSandwiches";
            btnShowOfferedSandwiches.Size = new Size(302, 23);
            btnShowOfferedSandwiches.TabIndex = 0;
            btnShowOfferedSandwiches.Text = "Show offered sandwiches";
            btnShowOfferedSandwiches.UseVisualStyleBackColor = true;
            btnShowOfferedSandwiches.Click += btnShowOfferedSandwiches_Click;
            // 
            // btnAddNewSandwich
            // 
            btnAddNewSandwich.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAddNewSandwich.Location = new Point(6, 215);
            btnAddNewSandwich.Name = "btnAddNewSandwich";
            btnAddNewSandwich.Size = new Size(304, 23);
            btnAddNewSandwich.TabIndex = 1;
            btnAddNewSandwich.Text = "Add new Sanwich";
            btnAddNewSandwich.UseVisualStyleBackColor = true;
            btnAddNewSandwich.Click += btnAddNewSandwich_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 298);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Main";
            Text = "Main";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnShowTotalRevenue;
        private Button btnSellSelectedSandwich;
        private CheckBox chbxIncludeVAT;
        private GroupBox groupBox2;
        private ComboBox cbxBreadFilter;
        private ListBox lbxMenu;
        private Label label1;
        private Button btnLoadData;
        private Button btnSaveData;
        private Button btnShowOfferedSandwiches;
        private Button btnAddNewSandwich;
        private Label lblSandwichData;
    }
}