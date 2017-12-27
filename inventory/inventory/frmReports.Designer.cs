namespace inventory
{
    partial class frmReports
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReports));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Revenue Summary");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Sales Revenue");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Prepaid Rental Sales");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Revenue Overtime", 13, 13);
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Revenue Reports", 13, 13, new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Customer\'s with Credit on Account");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Customer\'s in Debt");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Customer Accounts", 16, 16, new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Today\'s Reservations", 14, 14);
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Reservations", 14, 14, new System.Windows.Forms.TreeNode[] {
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("List of Customers", 3, 3);
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Customers", 29, 29, new System.Windows.Forms.TreeNode[] {
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("List of Products/Items", 11, 11);
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Products/Items", 11, 11, new System.Windows.Forms.TreeNode[] {
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Voided Transactions", 6, 6);
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Other", 26, 26, new System.Windows.Forms.TreeNode[] {
            treeNode15});
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tV = new System.Windows.Forms.TreeView();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.ItemSize = new System.Drawing.Size(100, 40);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.ShowToolTips = true;
            this.tabControl1.Size = new System.Drawing.Size(1028, 578);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage2.Controls.Add(this.tV);
            this.tabPage2.Controls.Add(this.dateTimePicker2);
            this.tabPage2.Controls.Add(this.dateTimePicker1);
            this.tabPage2.Controls.Add(this.radioButton6);
            this.tabPage2.Controls.Add(this.radioButton5);
            this.tabPage2.Controls.Add(this.radioButton4);
            this.tabPage2.Controls.Add(this.radioButton3);
            this.tabPage2.Controls.Add(this.radioButton2);
            this.tabPage2.Controls.Add(this.radioButton1);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.ImageIndex = 7;
            this.tabPage2.Location = new System.Drawing.Point(44, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(980, 570);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "5.ico");
            this.imageList1.Images.SetKeyName(1, "CLASSLIB.ICO");
            this.imageList1.Images.SetKeyName(2, "books.ico");
            this.imageList1.Images.SetKeyName(3, "billing copy.bmp");
            this.imageList1.Images.SetKeyName(4, "Users.png");
            this.imageList1.Images.SetKeyName(5, "act-accept-32.ico");
            this.imageList1.Images.SetKeyName(6, "act-cancel-32.ico");
            this.imageList1.Images.SetKeyName(7, "act-paste2-32.ico");
            this.imageList1.Images.SetKeyName(8, "App Icon.ico");
            this.imageList1.Images.SetKeyName(9, "Audio_Cd.ico");
            this.imageList1.Images.SetKeyName(10, "BARCODE.ICO");
            this.imageList1.Images.SetKeyName(11, "box.ico");
            this.imageList1.Images.SetKeyName(12, "bulk_return.ico");
            this.imageList1.Images.SetKeyName(13, "bundle.ico");
            this.imageList1.Images.SetKeyName(14, "calendar-32.ico");
            this.imageList1.Images.SetKeyName(15, "controlpanel.png");
            this.imageList1.Images.SetKeyName(16, "Customer.png");
            this.imageList1.Images.SetKeyName(17, "email.gif");
            this.imageList1.Images.SetKeyName(18, "folder_table.gif");
            this.imageList1.Images.SetKeyName(19, "house.gif");
            this.imageList1.Images.SetKeyName(20, "media-cd2-32.ico");
            this.imageList1.Images.SetKeyName(21, "money.gif");
            this.imageList1.Images.SetKeyName(22, "MonitorNew2.ico");
            this.imageList1.Images.SetKeyName(23, "Movie.ico");
            this.imageList1.Images.SetKeyName(24, "ordini32.gif");
            this.imageList1.Images.SetKeyName(25, "package.gif");
            this.imageList1.Images.SetKeyName(26, "prodotti.gif");
            this.imageList1.Images.SetKeyName(27, "Purchases.png");
            this.imageList1.Images.SetKeyName(28, "spedizioni.gif");
            this.imageList1.Images.SetKeyName(29, "Users.ico");
            this.imageList1.Images.SetKeyName(30, "Currency.png");
            this.imageList1.Images.SetKeyName(31, "MB_0021_clock2.png");
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(18, 264);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(144, 22);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(18, 225);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(144, 22);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton6.ForeColor = System.Drawing.Color.Black;
            this.radioButton6.Location = new System.Drawing.Point(18, 199);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(77, 20);
            this.radioButton6.TabIndex = 6;
            this.radioButton6.Text = "Custom";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton5.ForeColor = System.Drawing.Color.Black;
            this.radioButton5.Location = new System.Drawing.Point(18, 121);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(100, 20);
            this.radioButton5.TabIndex = 5;
            this.radioButton5.Text = "This Week";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.ForeColor = System.Drawing.Color.Black;
            this.radioButton4.Location = new System.Drawing.Point(18, 173);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(119, 20);
            this.radioButton4.TabIndex = 4;
            this.radioButton4.Text = "Last 4 Weeks";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.ForeColor = System.Drawing.Color.Black;
            this.radioButton3.Location = new System.Drawing.Point(18, 95);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(121, 20);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.Text = "Month to Date";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.Color.Black;
            this.radioButton2.Location = new System.Drawing.Point(18, 147);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(71, 20);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.Text = "Today";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.Black;
            this.radioButton1.Location = new System.Drawing.Point(18, 69);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(113, 20);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Year to Date";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(450, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(527, 564);
            this.panel4.TabIndex = 0;
            // 
            // tV
            // 
            this.tV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tV.ImageIndex = 5;
            this.tV.ImageList = this.imageList1;
            this.tV.Location = new System.Drawing.Point(168, 3);
            this.tV.Name = "tV";
            treeNode1.ImageIndex = 30;
            treeNode1.Name = "Node2";
            treeNode1.Text = "Revenue Summary";
            treeNode2.ImageIndex = 30;
            treeNode2.Name = "Node4";
            treeNode2.Text = "Sales Revenue";
            treeNode3.ImageIndex = 30;
            treeNode3.Name = "Node5";
            treeNode3.Text = "Prepaid Rental Sales";
            treeNode4.ImageIndex = 13;
            treeNode4.Name = "Node6";
            treeNode4.SelectedImageIndex = 13;
            treeNode4.Text = "Revenue Overtime";
            treeNode5.ImageIndex = 13;
            treeNode5.Name = "Node0";
            treeNode5.SelectedImageIndex = 13;
            treeNode5.Text = "Revenue Reports";
            treeNode6.ImageIndex = 30;
            treeNode6.Name = "Node0";
            treeNode6.Text = "Customer\'s with Credit on Account";
            treeNode7.ImageIndex = 6;
            treeNode7.Name = "Node1";
            treeNode7.Text = "Customer\'s in Debt";
            treeNode8.ImageIndex = 16;
            treeNode8.Name = "Node8";
            treeNode8.SelectedImageIndex = 16;
            treeNode8.Text = "Customer Accounts";
            treeNode9.ImageIndex = 14;
            treeNode9.Name = "Node4";
            treeNode9.SelectedImageIndex = 14;
            treeNode9.Text = "Today\'s Reservations";
            treeNode10.ImageIndex = 14;
            treeNode10.Name = "Node9";
            treeNode10.SelectedImageIndex = 14;
            treeNode10.Text = "Reservations";
            treeNode11.ImageIndex = 3;
            treeNode11.Name = "Node7";
            treeNode11.SelectedImageIndex = 3;
            treeNode11.Text = "List of Customers";
            treeNode12.ImageIndex = 29;
            treeNode12.Name = "Node10";
            treeNode12.SelectedImageIndex = 29;
            treeNode12.Text = "Customers";
            treeNode13.ImageIndex = 11;
            treeNode13.Name = "Node9";
            treeNode13.SelectedImageIndex = 11;
            treeNode13.Text = "List of Products/Items";
            treeNode14.ImageIndex = 11;
            treeNode14.Name = "Node12";
            treeNode14.SelectedImageIndex = 11;
            treeNode14.Text = "Products/Items";
            treeNode15.ImageIndex = 6;
            treeNode15.Name = "Node10";
            treeNode15.SelectedImageIndex = 6;
            treeNode15.Text = "Voided Transactions";
            treeNode16.ImageIndex = 26;
            treeNode16.Name = "Node13";
            treeNode16.SelectedImageIndex = 26;
            treeNode16.Text = "Other";
            this.tV.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode8,
            treeNode10,
            treeNode12,
            treeNode14,
            treeNode16});
            this.tV.SelectedImageIndex = 5;
            this.tV.Size = new System.Drawing.Size(276, 561);
            this.tV.TabIndex = 9;
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 578);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmReports";
            this.Text = "frmReports";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TreeView tV;
    }
}