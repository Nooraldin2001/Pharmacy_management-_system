namespace PharmacyProject
{
    partial class BillingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillingForm));
            this.BillGrv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backBtn = new System.Windows.Forms.Button();
            this.bilingLBL = new System.Windows.Forms.Label();
            this.BillType = new System.Windows.Forms.ComboBox();
            this.categorySafecomboBox2 = new System.Windows.Forms.ComboBox();
            this.AddToBillBTN = new System.Windows.Forms.Button();
            this.MedicinesearchTB = new System.Windows.Forms.TextBox();
            this.customerNameTB = new System.Windows.Forms.TextBox();
            this.quantityMedicineTB = new System.Windows.Forms.TextBox();
            this.UpdateBTN = new System.Windows.Forms.Button();
            this.DeleteBTN = new System.Windows.Forms.Button();
            this.SaveBTN = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.CreateCustomerBTN = new System.Windows.Forms.Button();
            this.ManfuctureNameTB = new System.Windows.Forms.TextBox();
            this.CreateManfuctureBTN = new System.Windows.Forms.Button();
            this.medViewDgv = new System.Windows.Forms.DataGridView();
            this.resetMedicineBTN = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.medSearchcCB = new System.Windows.Forms.ComboBox();
            this.cusCB = new System.Windows.Forms.ComboBox();
            this.BillDtp = new System.Windows.Forms.DateTimePicker();
            this.subtotalTb = new System.Windows.Forms.TextBox();
            this.medTaxTb = new System.Windows.Forms.TextBox();
            this.dicountMed = new System.Windows.Forms.TextBox();
            this.grdTotalTb = new System.Windows.Forms.TextBox();
            this.VATtb = new System.Windows.Forms.TextBox();
            this.dicountView = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.manIDcb = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.paymentMethodCb = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.printBtn = new System.Windows.Forms.Button();
            this.empCB = new System.Windows.Forms.ComboBox();
            this.ManifactureREfreshBTN = new System.Windows.Forms.Button();
            this.customerRefreshBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BillGrv)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medViewDgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BillGrv
            // 
            this.BillGrv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BillGrv.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.BillGrv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BillGrv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column5,
            this.Column2,
            this.Column3,
            this.Column4});
            this.BillGrv.GridColor = System.Drawing.SystemColors.ControlText;
            this.BillGrv.Location = new System.Drawing.Point(1025, 194);
            this.BillGrv.Name = "BillGrv";
            this.BillGrv.ReadOnly = true;
            this.BillGrv.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BillGrv.RowHeadersWidth = 51;
            this.BillGrv.RowTemplate.Height = 29;
            this.BillGrv.Size = new System.Drawing.Size(652, 375);
            this.BillGrv.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "كوود الدوا";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 119;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "اسم الدواء";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "عدد الوحدات";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 118;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "سعر الوحدة";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 119;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "الأجمالي الفرعي";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 118;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Controls.Add(this.bilingLBL);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1684, 125);
            this.panel1.TabIndex = 1;
            // 
            // backBtn
            // 
            this.backBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.backBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backBtn.ForeColor = System.Drawing.Color.White;
            this.backBtn.Location = new System.Drawing.Point(1577, 39);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(95, 50);
            this.backBtn.TabIndex = 42;
            this.backBtn.Text = ">>";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Visible = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // bilingLBL
            // 
            this.bilingLBL.AutoSize = true;
            this.bilingLBL.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bilingLBL.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bilingLBL.Location = new System.Drawing.Point(726, 39);
            this.bilingLBL.Name = "bilingLBL";
            this.bilingLBL.Size = new System.Drawing.Size(98, 38);
            this.bilingLBL.TabIndex = 0;
            this.bilingLBL.Text = "الفواتير";
            this.bilingLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BillType
            // 
            this.BillType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BillType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BillType.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BillType.FormattingEnabled = true;
            this.BillType.Items.AddRange(new object[] {
            "صادر",
            "وارد"});
            this.BillType.Location = new System.Drawing.Point(753, 409);
            this.BillType.Name = "BillType";
            this.BillType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BillType.Size = new System.Drawing.Size(174, 36);
            this.BillType.TabIndex = 2;
            this.BillType.Text = "صادر";
            this.BillType.SelectedIndexChanged += new System.EventHandler(this.BillType_SelectedIndexChanged);
            // 
            // categorySafecomboBox2
            // 
            this.categorySafecomboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.categorySafecomboBox2.DisplayMember = "الرئيسية";
            this.categorySafecomboBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.categorySafecomboBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.categorySafecomboBox2.FormattingEnabled = true;
            this.categorySafecomboBox2.Items.AddRange(new object[] {
            "الرئيسية ",
            "صباحى ",
            "مسائى"});
            this.categorySafecomboBox2.Location = new System.Drawing.Point(753, 451);
            this.categorySafecomboBox2.Name = "categorySafecomboBox2";
            this.categorySafecomboBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.categorySafecomboBox2.Size = new System.Drawing.Size(174, 36);
            this.categorySafecomboBox2.TabIndex = 3;
            this.categorySafecomboBox2.Text = "الخزينة";
            // 
            // AddToBillBTN
            // 
            this.AddToBillBTN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddToBillBTN.BackColor = System.Drawing.SystemColors.HotTrack;
            this.AddToBillBTN.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddToBillBTN.ForeColor = System.Drawing.Color.MintCream;
            this.AddToBillBTN.Location = new System.Drawing.Point(739, 279);
            this.AddToBillBTN.Name = "AddToBillBTN";
            this.AddToBillBTN.Size = new System.Drawing.Size(201, 55);
            this.AddToBillBTN.TabIndex = 5;
            this.AddToBillBTN.Text = "إضافة إلى الفتورة";
            this.AddToBillBTN.UseVisualStyleBackColor = false;
            this.AddToBillBTN.Click += new System.EventHandler(this.AddToBillBTN_Click);
            // 
            // MedicinesearchTB
            // 
            this.MedicinesearchTB.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.MedicinesearchTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MedicinesearchTB.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.MedicinesearchTB.Location = new System.Drawing.Point(143, 14);
            this.MedicinesearchTB.Name = "MedicinesearchTB";
            this.MedicinesearchTB.Size = new System.Drawing.Size(174, 34);
            this.MedicinesearchTB.TabIndex = 8;
            this.MedicinesearchTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MedicinesearchTB.TextChanged += new System.EventHandler(this.MedicineNameTB_TextChanged);
            //this.MedicinesearchTB.Enter += new System.EventHandler(this.MedicineNameTB_Enter);
            // 
            // customerNameTB
            // 
            this.customerNameTB.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.customerNameTB.Enabled = false;
            this.customerNameTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customerNameTB.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.customerNameTB.Location = new System.Drawing.Point(117, 66);
            this.customerNameTB.Name = "customerNameTB";
            this.customerNameTB.Size = new System.Drawing.Size(174, 34);
            this.customerNameTB.TabIndex = 9;
            this.customerNameTB.Text = "اسم العميل";
            this.customerNameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // quantityMedicineTB
            // 
            this.quantityMedicineTB.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.quantityMedicineTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.quantityMedicineTB.ForeColor = System.Drawing.Color.Firebrick;
            this.quantityMedicineTB.Location = new System.Drawing.Point(5, 26);
            this.quantityMedicineTB.Name = "quantityMedicineTB";
            this.quantityMedicineTB.Size = new System.Drawing.Size(86, 34);
            this.quantityMedicineTB.TabIndex = 11;
            this.quantityMedicineTB.Text = "الكمية";
            this.quantityMedicineTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.quantityMedicineTB.Enter += new System.EventHandler(this.quantityMedicineTB_Enter);
            this.quantityMedicineTB.Leave += new System.EventHandler(this.quantityMedicineTB_Leave);
            // 
            // UpdateBTN
            // 
            this.UpdateBTN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateBTN.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UpdateBTN.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.UpdateBTN.Location = new System.Drawing.Point(894, 152);
            this.UpdateBTN.Name = "UpdateBTN";
            this.UpdateBTN.Size = new System.Drawing.Size(94, 36);
            this.UpdateBTN.TabIndex = 14;
            this.UpdateBTN.Text = "تعديل";
            this.UpdateBTN.UseVisualStyleBackColor = true;
            this.UpdateBTN.Visible = false;
            // 
            // DeleteBTN
            // 
            this.DeleteBTN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteBTN.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteBTN.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.DeleteBTN.Location = new System.Drawing.Point(739, 152);
            this.DeleteBTN.Name = "DeleteBTN";
            this.DeleteBTN.Size = new System.Drawing.Size(94, 36);
            this.DeleteBTN.TabIndex = 15;
            this.DeleteBTN.Text = "حذف";
            this.DeleteBTN.UseVisualStyleBackColor = true;
            this.DeleteBTN.Visible = false;
            // 
            // SaveBTN
            // 
            this.SaveBTN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveBTN.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SaveBTN.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.SaveBTN.Location = new System.Drawing.Point(789, 340);
            this.SaveBTN.Name = "SaveBTN";
            this.SaveBTN.Size = new System.Drawing.Size(94, 36);
            this.SaveBTN.TabIndex = 16;
            this.SaveBTN.Text = "حفظ";
            this.SaveBTN.UseVisualStyleBackColor = true;
            this.SaveBTN.Click += new System.EventHandler(this.SaveBTN_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // CreateCustomerBTN
            // 
            this.CreateCustomerBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateCustomerBTN.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.CreateCustomerBTN.Location = new System.Drawing.Point(6, 24);
            this.CreateCustomerBTN.Name = "CreateCustomerBTN";
            this.CreateCustomerBTN.Size = new System.Drawing.Size(105, 36);
            this.CreateCustomerBTN.TabIndex = 18;
            this.CreateCustomerBTN.Text = "جديد";
            this.CreateCustomerBTN.UseVisualStyleBackColor = true;
            this.CreateCustomerBTN.Click += new System.EventHandler(this.CreateCustomerBTN_Click);
            // 
            // ManfuctureNameTB
            // 
            this.ManfuctureNameTB.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ManfuctureNameTB.Enabled = false;
            this.ManfuctureNameTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ManfuctureNameTB.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ManfuctureNameTB.Location = new System.Drawing.Point(117, 149);
            this.ManfuctureNameTB.Name = "ManfuctureNameTB";
            this.ManfuctureNameTB.Size = new System.Drawing.Size(174, 34);
            this.ManfuctureNameTB.TabIndex = 20;
            this.ManfuctureNameTB.Text = "اسم المورد";
            this.ManfuctureNameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CreateManfuctureBTN
            // 
            this.CreateManfuctureBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateManfuctureBTN.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.CreateManfuctureBTN.Location = new System.Drawing.Point(6, 106);
            this.CreateManfuctureBTN.Name = "CreateManfuctureBTN";
            this.CreateManfuctureBTN.Size = new System.Drawing.Size(105, 34);
            this.CreateManfuctureBTN.TabIndex = 21;
            this.CreateManfuctureBTN.Text = "جديد";
            this.CreateManfuctureBTN.UseVisualStyleBackColor = true;
            this.CreateManfuctureBTN.Click += new System.EventHandler(this.CreateManfuctureBTN_Click);
            // 
            // medViewDgv
            // 
            this.medViewDgv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.medViewDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.medViewDgv.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.medViewDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medViewDgv.GridColor = System.Drawing.SystemColors.ControlText;
            this.medViewDgv.Location = new System.Drawing.Point(12, 194);
            this.medViewDgv.Name = "medViewDgv";
            this.medViewDgv.ReadOnly = true;
            this.medViewDgv.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.medViewDgv.RowHeadersWidth = 51;
            this.medViewDgv.RowTemplate.Height = 29;
            this.medViewDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.medViewDgv.Size = new System.Drawing.Size(652, 574);
            this.medViewDgv.TabIndex = 22;
            this.medViewDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.medViewDgv_CellClick);
            // 
            // resetMedicineBTN
            // 
            this.resetMedicineBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resetMedicineBTN.BackgroundImage")));
            this.resetMedicineBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.resetMedicineBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetMedicineBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resetMedicineBTN.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.resetMedicineBTN.Location = new System.Drawing.Point(94, 14);
            this.resetMedicineBTN.Name = "resetMedicineBTN";
            this.resetMedicineBTN.Size = new System.Drawing.Size(43, 34);
            this.resetMedicineBTN.TabIndex = 23;
            this.resetMedicineBTN.UseVisualStyleBackColor = true;
            this.resetMedicineBTN.Click += new System.EventHandler(this.resetMedicineBTN_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.MedicinesearchTB);
            this.groupBox1.Controls.Add(this.resetMedicineBTN);
            this.groupBox1.Controls.Add(this.medSearchcCB);
            this.groupBox1.Location = new System.Drawing.Point(60, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 54);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(7, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 36);
            this.button1.TabIndex = 34;
            this.button1.Text = "إضافة";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // medSearchcCB
            // 
            this.medSearchcCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.medSearchcCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.medSearchcCB.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.medSearchcCB.FormattingEnabled = true;
            this.medSearchcCB.Items.AddRange(new object[] {
            "Barcode",
            "اسم الدواء"});
            this.medSearchcCB.Location = new System.Drawing.Point(323, 11);
            this.medSearchcCB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.medSearchcCB.Name = "medSearchcCB";
            this.medSearchcCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.medSearchcCB.Size = new System.Drawing.Size(216, 39);
            this.medSearchcCB.TabIndex = 47;
            this.medSearchcCB.Text = "طريقة البحث";
            // 
            // cusCB
            // 
            this.cusCB.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cusCB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cusCB.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cusCB.FormattingEnabled = true;
            this.cusCB.Location = new System.Drawing.Point(117, 24);
            this.cusCB.Name = "cusCB";
            this.cusCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cusCB.Size = new System.Drawing.Size(174, 36);
            this.cusCB.TabIndex = 25;
            this.cusCB.Text = "كوود العميل";
            this.cusCB.SelectionChangeCommitted += new System.EventHandler(this.cusCB_SelectionChangeCommitted);
            // 
            // BillDtp
            // 
            this.BillDtp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BillDtp.Enabled = false;
            this.BillDtp.Location = new System.Drawing.Point(1412, 143);
            this.BillDtp.Name = "BillDtp";
            this.BillDtp.Size = new System.Drawing.Size(260, 27);
            this.BillDtp.TabIndex = 26;
            this.BillDtp.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // subtotalTb
            // 
            this.subtotalTb.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.subtotalTb.Enabled = false;
            this.subtotalTb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.subtotalTb.ForeColor = System.Drawing.Color.Firebrick;
            this.subtotalTb.Location = new System.Drawing.Point(97, 26);
            this.subtotalTb.Name = "subtotalTb";
            this.subtotalTb.Size = new System.Drawing.Size(174, 34);
            this.subtotalTb.TabIndex = 27;
            this.subtotalTb.Text = "الأجمالي الفرعي";
            this.subtotalTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // medTaxTb
            // 
            this.medTaxTb.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.medTaxTb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.medTaxTb.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.medTaxTb.Location = new System.Drawing.Point(97, 66);
            this.medTaxTb.Name = "medTaxTb";
            this.medTaxTb.Size = new System.Drawing.Size(174, 34);
            this.medTaxTb.TabIndex = 28;
            this.medTaxTb.Text = "الضريبة(%)";
            this.medTaxTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.medTaxTb.Enter += new System.EventHandler(this.medTaxTb_Enter);
            this.medTaxTb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.medTaxTb_KeyUp);
            this.medTaxTb.Leave += new System.EventHandler(this.medTaxTb_Leave);
            // 
            // dicountMed
            // 
            this.dicountMed.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dicountMed.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dicountMed.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.dicountMed.Location = new System.Drawing.Point(97, 106);
            this.dicountMed.Name = "dicountMed";
            this.dicountMed.Size = new System.Drawing.Size(174, 34);
            this.dicountMed.TabIndex = 29;
            this.dicountMed.Text = "نسبة الخصم(%)";
            this.dicountMed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.dicountMed.Enter += new System.EventHandler(this.dicountMed_Enter);
            this.dicountMed.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dicountMed_KeyUp);
            this.dicountMed.Leave += new System.EventHandler(this.dicountMed_Leave);
            // 
            // grdTotalTb
            // 
            this.grdTotalTb.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.grdTotalTb.Enabled = false;
            this.grdTotalTb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grdTotalTb.ForeColor = System.Drawing.Color.Firebrick;
            this.grdTotalTb.Location = new System.Drawing.Point(5, 146);
            this.grdTotalTb.Name = "grdTotalTb";
            this.grdTotalTb.Size = new System.Drawing.Size(266, 34);
            this.grdTotalTb.TabIndex = 30;
            this.grdTotalTb.Text = "الاجمالي(بعد الضريبةو الخصم)";
            this.grdTotalTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // VATtb
            // 
            this.VATtb.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.VATtb.Enabled = false;
            this.VATtb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VATtb.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.VATtb.Location = new System.Drawing.Point(5, 66);
            this.VATtb.Name = "VATtb";
            this.VATtb.Size = new System.Drawing.Size(86, 34);
            this.VATtb.TabIndex = 31;
            this.VATtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dicountView
            // 
            this.dicountView.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dicountView.Enabled = false;
            this.dicountView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dicountView.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.dicountView.Location = new System.Drawing.Point(5, 106);
            this.dicountView.Name = "dicountView";
            this.dicountView.Size = new System.Drawing.Size(86, 34);
            this.dicountView.TabIndex = 32;
            this.dicountView.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.medTaxTb);
            this.groupBox2.Controls.Add(this.subtotalTb);
            this.groupBox2.Controls.Add(this.grdTotalTb);
            this.groupBox2.Controls.Add(this.dicountView);
            this.groupBox2.Controls.Add(this.dicountMed);
            this.groupBox2.Controls.Add(this.VATtb);
            this.groupBox2.Controls.Add(this.quantityMedicineTB);
            this.groupBox2.Location = new System.Drawing.Point(1025, 575);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 193);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            // 
            // manIDcb
            // 
            this.manIDcb.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.manIDcb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.manIDcb.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.manIDcb.FormattingEnabled = true;
            this.manIDcb.Location = new System.Drawing.Point(117, 106);
            this.manIDcb.Name = "manIDcb";
            this.manIDcb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.manIDcb.Size = new System.Drawing.Size(177, 36);
            this.manIDcb.TabIndex = 34;
            this.manIDcb.Text = "كوود المورد";
            this.manIDcb.SelectionChangeCommitted += new System.EventHandler(this.manIDcb_SelectionChangeCommitted);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.CreateCustomerBTN);
            this.groupBox3.Controls.Add(this.manIDcb);
            this.groupBox3.Controls.Add(this.cusCB);
            this.groupBox3.Controls.Add(this.customerNameTB);
            this.groupBox3.Controls.Add(this.ManfuctureNameTB);
            this.groupBox3.Controls.Add(this.CreateManfuctureBTN);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Location = new System.Drawing.Point(1375, 575);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(297, 193);
            this.groupBox3.TabIndex = 43;
            this.groupBox3.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textBox2.Location = new System.Drawing.Point(6, 149);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(105, 34);
            this.textBox2.TabIndex = 37;
            this.textBox2.Text = "حساب قديم";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox2.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textBox1.Location = new System.Drawing.Point(6, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(105, 34);
            this.textBox1.TabIndex = 36;
            this.textBox1.Text = "حساب قديم";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.Visible = false;
            // 
            // paymentMethodCb
            // 
            this.paymentMethodCb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paymentMethodCb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.paymentMethodCb.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.paymentMethodCb.FormattingEnabled = true;
            this.paymentMethodCb.Items.AddRange(new object[] {
            "نقدي",
            "فيزا",
            "أجل"});
            this.paymentMethodCb.Location = new System.Drawing.Point(753, 493);
            this.paymentMethodCb.Name = "paymentMethodCb";
            this.paymentMethodCb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.paymentMethodCb.Size = new System.Drawing.Size(174, 36);
            this.paymentMethodCb.TabIndex = 35;
            this.paymentMethodCb.Text = "طريقة الدفع";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.MintCream;
            this.button2.Location = new System.Drawing.Point(1025, 131);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(201, 55);
            this.button2.TabIndex = 44;
            this.button2.Text = "الفواتير السابقة";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // printBtn
            // 
            this.printBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.printBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.printBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.printBtn.ForeColor = System.Drawing.Color.MintCream;
            this.printBtn.Location = new System.Drawing.Point(789, 620);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(94, 55);
            this.printBtn.TabIndex = 45;
            this.printBtn.Text = "طباعة";
            this.printBtn.UseVisualStyleBackColor = false;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click_1);
            // 
            // empCB
            // 
            this.empCB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.empCB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.empCB.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.empCB.FormattingEnabled = true;
            this.empCB.Location = new System.Drawing.Point(753, 578);
            this.empCB.Name = "empCB";
            this.empCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.empCB.Size = new System.Drawing.Size(174, 36);
            this.empCB.TabIndex = 43;
            this.empCB.Text = "اسم الموظف";
            this.empCB.SelectionChangeCommitted += new System.EventHandler(this.empCB_SelectionChangeCommitted);
            // 
            // ManifactureREfreshBTN
            // 
            this.ManifactureREfreshBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ManifactureREfreshBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ManifactureREfreshBTN.BackgroundImage")));
            this.ManifactureREfreshBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ManifactureREfreshBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManifactureREfreshBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ManifactureREfreshBTN.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ManifactureREfreshBTN.Location = new System.Drawing.Point(1326, 681);
            this.ManifactureREfreshBTN.Name = "ManifactureREfreshBTN";
            this.ManifactureREfreshBTN.Size = new System.Drawing.Size(43, 34);
            this.ManifactureREfreshBTN.TabIndex = 35;
            this.ManifactureREfreshBTN.UseVisualStyleBackColor = true;
            this.ManifactureREfreshBTN.Click += new System.EventHandler(this.ManifactureREfreshBTN_Click);
            // 
            // customerRefreshBTN
            // 
            this.customerRefreshBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.customerRefreshBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("customerRefreshBTN.BackgroundImage")));
            this.customerRefreshBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.customerRefreshBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerRefreshBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customerRefreshBTN.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.customerRefreshBTN.Location = new System.Drawing.Point(1326, 600);
            this.customerRefreshBTN.Name = "customerRefreshBTN";
            this.customerRefreshBTN.Size = new System.Drawing.Size(43, 34);
            this.customerRefreshBTN.TabIndex = 46;
            this.customerRefreshBTN.UseVisualStyleBackColor = true;
            this.customerRefreshBTN.Click += new System.EventHandler(this.customerRefreshBTN_Click);
            // 
            // BillingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1684, 780);
            this.Controls.Add(this.customerRefreshBTN);
            this.Controls.Add(this.ManifactureREfreshBTN);
            this.Controls.Add(this.empCB);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.paymentMethodCb);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.medViewDgv);
            this.Controls.Add(this.SaveBTN);
            this.Controls.Add(this.DeleteBTN);
            this.Controls.Add(this.UpdateBTN);
            this.Controls.Add(this.BillDtp);
            this.Controls.Add(this.AddToBillBTN);
            this.Controls.Add(this.categorySafecomboBox2);
            this.Controls.Add(this.BillType);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BillGrv);
            this.Name = "BillingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Billing";
            this.Load += new System.EventHandler(this.Billing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BillGrv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medViewDgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView BillGrv;
        private Panel panel1;
        private ComboBox BillType;
        private Label bilingLBL;
        private ComboBox categorySafecomboBox2;
        private Button AddToBillBTN;
        private TextBox MedicinesearchTB;
        private TextBox customerNameTB;
        private TextBox quantityMedicineTB;
        private Button UpdateBTN;
        private Button DeleteBTN;
        private Button SaveBTN;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private Button backBtn;
        private Button CreateCustomerBTN;
        private TextBox ManfuctureNameTB;
        private Button CreateManfuctureBTN;
        private DataGridView medViewDgv;
        private Button resetMedicineBTN;
        private GroupBox groupBox1;
        private ComboBox cusCB;
        private DateTimePicker BillDtp;
        private TextBox subtotalTb;
        private TextBox medTaxTb;
        private TextBox dicountMed;
        private TextBox grdTotalTb;
        private TextBox VATtb;
        private TextBox dicountView;
        private GroupBox groupBox2;
        private Button button1;
        private ComboBox manIDcb;
        private GroupBox groupBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private ComboBox paymentMethodCb;
        private Button button2;
        private Button printBtn;
        private ComboBox empCB;
        private Button ManifactureREfreshBTN;
        private Button customerRefreshBTN;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private ComboBox medSearchcCB;
    }
}