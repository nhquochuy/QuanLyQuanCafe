using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    partial class fTableManager
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mntAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.userInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mntUserInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.mntLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fpnTable = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.nmrQty = new System.Windows.Forms.NumericUpDown();
            this.cboFood = new System.Windows.Forms.ComboBox();
            this.cboFoodCategory = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.livBill = new System.Windows.Forms.ListView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnMerge = new System.Windows.Forms.Button();
            this.cboChangeTable = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.nmrDiscount = new System.Windows.Forms.NumericUpDown();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.btnChangeTable = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.lblCurrentUserName = new System.Windows.Forms.Label();
            this.lblTypeAcc = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrQty)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrDiscount)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mntAdmin,
            this.userInformationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(811, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mntAdmin
            // 
            this.mntAdmin.Name = "mntAdmin";
            this.mntAdmin.Size = new System.Drawing.Size(55, 20);
            this.mntAdmin.Text = "Admin";
            this.mntAdmin.Click += new System.EventHandler(this.mntAdmin_Click);
            // 
            // userInformationToolStripMenuItem
            // 
            this.userInformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mntUserInfo,
            this.mntLogOut});
            this.userInformationToolStripMenuItem.Name = "userInformationToolStripMenuItem";
            this.userInformationToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.userInformationToolStripMenuItem.Text = "User Information";
            // 
            // mntUserInfo
            // 
            this.mntUserInfo.Name = "mntUserInfo";
            this.mntUserInfo.Size = new System.Drawing.Size(163, 22);
            this.mntUserInfo.Text = "User Information";
            this.mntUserInfo.Click += new System.EventHandler(this.mntUserInfo_Click);
            // 
            // mntLogOut
            // 
            this.mntLogOut.Name = "mntLogOut";
            this.mntLogOut.Size = new System.Drawing.Size(163, 22);
            this.mntLogOut.Text = "Log out";
            this.mntLogOut.Click += new System.EventHandler(this.mntLogOut_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.fpnTable);
            this.panel1.Location = new System.Drawing.Point(13, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 410);
            this.panel1.TabIndex = 1;
            // 
            // fpnTable
            // 
            this.fpnTable.Location = new System.Drawing.Point(4, 3);
            this.fpnTable.Name = "fpnTable";
            this.fpnTable.Size = new System.Drawing.Size(433, 404);
            this.fpnTable.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.nmrQty);
            this.panel2.Controls.Add(this.cboFood);
            this.panel2.Controls.Add(this.cboFoodCategory);
            this.panel2.Location = new System.Drawing.Point(459, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(348, 63);
            this.panel2.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd.Location = new System.Drawing.Point(266, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 54);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // nmrQty
            // 
            this.nmrQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrQty.Location = new System.Drawing.Point(213, 22);
            this.nmrQty.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            -2147483648});
            this.nmrQty.Name = "nmrQty";
            this.nmrQty.Size = new System.Drawing.Size(47, 22);
            this.nmrQty.TabIndex = 2;
            this.nmrQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cboFood
            // 
            this.cboFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFood.FormattingEnabled = true;
            this.cboFood.Location = new System.Drawing.Point(3, 33);
            this.cboFood.Name = "cboFood";
            this.cboFood.Size = new System.Drawing.Size(203, 24);
            this.cboFood.TabIndex = 1;
            // 
            // cboFoodCategory
            // 
            this.cboFoodCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFoodCategory.FormattingEnabled = true;
            this.cboFoodCategory.Location = new System.Drawing.Point(3, 3);
            this.cboFoodCategory.Name = "cboFoodCategory";
            this.cboFoodCategory.Size = new System.Drawing.Size(203, 24);
            this.cboFoodCategory.TabIndex = 0;
            this.cboFoodCategory.SelectedValueChanged += new System.EventHandler(this.CboFoodCategory_SelectedValueChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.livBill);
            this.panel3.Location = new System.Drawing.Point(459, 97);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(348, 272);
            this.panel3.TabIndex = 3;
            // 
            // livBill
            // 
            this.livBill.HideSelection = false;
            this.livBill.Location = new System.Drawing.Point(4, 4);
            this.livBill.Name = "livBill";
            this.livBill.Size = new System.Drawing.Size(341, 265);
            this.livBill.TabIndex = 0;
            this.livBill.UseCompatibleStateImageBehavior = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnMerge);
            this.panel4.Controls.Add(this.cboChangeTable);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txtTotalAmount);
            this.panel4.Controls.Add(this.nmrDiscount);
            this.panel4.Controls.Add(this.btnDiscount);
            this.panel4.Controls.Add(this.btnChangeTable);
            this.panel4.Controls.Add(this.btnPayment);
            this.panel4.Location = new System.Drawing.Point(459, 375);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(348, 63);
            this.panel4.TabIndex = 3;
            // 
            // btnMerge
            // 
            this.btnMerge.Location = new System.Drawing.Point(63, 6);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(57, 30);
            this.btnMerge.TabIndex = 10;
            this.btnMerge.Text = "Merge";
            this.btnMerge.UseVisualStyleBackColor = true;
            this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
            // 
            // cboChangeTable
            // 
            this.cboChangeTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChangeTable.FormattingEnabled = true;
            this.cboChangeTable.Location = new System.Drawing.Point(4, 36);
            this.cboChangeTable.Name = "cboChangeTable";
            this.cboChangeTable.Size = new System.Drawing.Size(116, 24);
            this.cboChangeTable.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Total Amount";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(210, 38);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(90, 20);
            this.txtTotalAmount.TabIndex = 8;
            // 
            // nmrDiscount
            // 
            this.nmrDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrDiscount.Location = new System.Drawing.Point(133, 38);
            this.nmrDiscount.Name = "nmrDiscount";
            this.nmrDiscount.Size = new System.Drawing.Size(63, 22);
            this.nmrDiscount.TabIndex = 7;
            this.nmrDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnDiscount
            // 
            this.btnDiscount.Location = new System.Drawing.Point(133, 6);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(63, 30);
            this.btnDiscount.TabIndex = 6;
            this.btnDiscount.Text = "Discount";
            this.btnDiscount.UseVisualStyleBackColor = true;
            // 
            // btnChangeTable
            // 
            this.btnChangeTable.Location = new System.Drawing.Point(3, 6);
            this.btnChangeTable.Name = "btnChangeTable";
            this.btnChangeTable.Size = new System.Drawing.Size(57, 30);
            this.btnChangeTable.TabIndex = 5;
            this.btnChangeTable.Text = "Change";
            this.btnChangeTable.UseVisualStyleBackColor = true;
            this.btnChangeTable.Click += new System.EventHandler(this.btnChangeTable_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(304, 6);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(40, 54);
            this.btnPayment.TabIndex = 4;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // lblCurrentUserName
            // 
            this.lblCurrentUserName.AutoSize = true;
            this.lblCurrentUserName.Location = new System.Drawing.Point(463, 9);
            this.lblCurrentUserName.Name = "lblCurrentUserName";
            this.lblCurrentUserName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCurrentUserName.Size = new System.Drawing.Size(35, 13);
            this.lblCurrentUserName.TabIndex = 4;
            this.lblCurrentUserName.Text = "label2";
            this.lblCurrentUserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTypeAcc
            // 
            this.lblTypeAcc.AutoSize = true;
            this.lblTypeAcc.Location = new System.Drawing.Point(623, 9);
            this.lblTypeAcc.Name = "lblTypeAcc";
            this.lblTypeAcc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTypeAcc.Size = new System.Drawing.Size(35, 13);
            this.lblTypeAcc.TabIndex = 5;
            this.lblTypeAcc.Text = "label2";
            this.lblTypeAcc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fTableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 450);
            this.Controls.Add(this.lblTypeAcc);
            this.Controls.Add(this.lblCurrentUserName);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fTableManager";
            this.Text = "Table Managerment";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmrQty)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrDiscount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip meunuStrip1;
        private MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mntAdmin;
        private System.Windows.Forms.ToolStripMenuItem userInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mntUserInfo;
        private System.Windows.Forms.ToolStripMenuItem mntLogOut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown nmrQty;
        private System.Windows.Forms.ComboBox cboFood;
        private System.Windows.Forms.ComboBox cboFoodCategory;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListView livBill;
        private System.Windows.Forms.NumericUpDown nmrDiscount;
        private System.Windows.Forms.Button btnDiscount;
        private System.Windows.Forms.Button btnChangeTable;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.FlowLayoutPanel fpnTable;
        private Label label1;
        private TextBox txtTotalAmount;
        private ComboBox cboChangeTable;
        private Button btnMerge;
        private Label lblCurrentUserName;
        private Label lblTypeAcc;
    }
}