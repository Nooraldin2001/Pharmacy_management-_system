
namespace Pharmacy
{
    partial class MedicineForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.backBTN = new System.Windows.Forms.Button();
            this.medicineLBL = new System.Windows.Forms.Label();
            this.MedGridView1 = new System.Windows.Forms.DataGridView();
            this.nameArabicTB = new System.Windows.Forms.TextBox();
            this.manifactureNameTB = new System.Windows.Forms.TextBox();
            this.nameEnglishTB = new System.Windows.Forms.TextBox();
            this.SPriceTB = new System.Windows.Forms.TextBox();
            this.companyNameTB = new System.Windows.Forms.TextBox();
            this.stockTB = new System.Windows.Forms.TextBox();
            this.BPriceTB = new System.Windows.Forms.TextBox();
            this.MaxSelllingTB = new System.Windows.Forms.TextBox();
            this.taxratioTB = new System.Windows.Forms.TextBox();
            this.MaxbuyingTB = new System.Windows.Forms.TextBox();
            this.ExpireDate = new System.Windows.Forms.DateTimePicker();
            this.medSearchcCB = new System.Windows.Forms.ComboBox();
            this.expireDateLBL = new System.Windows.Forms.Label();
            this.RemoveBTN = new System.Windows.Forms.Button();
            this.EditBTN = new System.Windows.Forms.Button();
            this.AddBTN = new System.Windows.Forms.Button();
            this.medSearchTB = new System.Windows.Forms.TextBox();
            this.BarcodeTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.الباركود = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MedGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.backBTN);
            this.panel1.Controls.Add(this.medicineLBL);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1470, 145);
            this.panel1.TabIndex = 0;
            // 
            // backBTN
            // 
            this.backBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.backBTN.BackColor = System.Drawing.SystemColors.HotTrack;
            this.backBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backBTN.ForeColor = System.Drawing.SystemColors.Window;
            this.backBTN.Location = new System.Drawing.Point(1363, 55);
            this.backBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.backBTN.Name = "backBTN";
            this.backBTN.Size = new System.Drawing.Size(95, 50);
            this.backBTN.TabIndex = 16;
            this.backBTN.Text = ">>";
            this.backBTN.UseVisualStyleBackColor = false;
            this.backBTN.Click += new System.EventHandler(this.backBTN_Click);
            // 
            // medicineLBL
            // 
            this.medicineLBL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.medicineLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.medicineLBL.ForeColor = System.Drawing.SystemColors.Window;
            this.medicineLBL.Location = new System.Drawing.Point(0, 0);
            this.medicineLBL.Name = "medicineLBL";
            this.medicineLBL.Size = new System.Drawing.Size(1470, 145);
            this.medicineLBL.TabIndex = 0;
            this.medicineLBL.Text = "الأدوية";
            this.medicineLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MedGridView1
            // 
            this.MedGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MedGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.MedGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.MedGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MedGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MedGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.MedGridView1.ColumnHeadersHeight = 35;
            this.MedGridView1.GridColor = System.Drawing.Color.Black;
            this.MedGridView1.Location = new System.Drawing.Point(12, 152);
            this.MedGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MedGridView1.Name = "MedGridView1";
            this.MedGridView1.ReadOnly = true;
            this.MedGridView1.RowHeadersWidth = 51;
            this.MedGridView1.RowTemplate.Height = 24;
            this.MedGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MedGridView1.Size = new System.Drawing.Size(1039, 635);
            this.MedGridView1.TabIndex = 1;
            this.MedGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MedGridView1_CellClick);
            // 
            // nameArabicTB
            // 
            this.nameArabicTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nameArabicTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameArabicTB.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.nameArabicTB.Location = new System.Drawing.Point(1310, 273);
            this.nameArabicTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nameArabicTB.Name = "nameArabicTB";
            this.nameArabicTB.Size = new System.Drawing.Size(133, 30);
            this.nameArabicTB.TabIndex = 4;
            this.nameArabicTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // manifactureNameTB
            // 
            this.manifactureNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.manifactureNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.manifactureNameTB.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.manifactureNameTB.Location = new System.Drawing.Point(1110, 334);
            this.manifactureNameTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.manifactureNameTB.Name = "manifactureNameTB";
            this.manifactureNameTB.Size = new System.Drawing.Size(133, 30);
            this.manifactureNameTB.TabIndex = 5;
            this.manifactureNameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nameEnglishTB
            // 
            this.nameEnglishTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nameEnglishTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameEnglishTB.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.nameEnglishTB.Location = new System.Drawing.Point(1110, 273);
            this.nameEnglishTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nameEnglishTB.Name = "nameEnglishTB";
            this.nameEnglishTB.Size = new System.Drawing.Size(133, 30);
            this.nameEnglishTB.TabIndex = 6;
            this.nameEnglishTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SPriceTB
            // 
            this.SPriceTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SPriceTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SPriceTB.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.SPriceTB.Location = new System.Drawing.Point(1110, 393);
            this.SPriceTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SPriceTB.Name = "SPriceTB";
            this.SPriceTB.Size = new System.Drawing.Size(133, 30);
            this.SPriceTB.TabIndex = 7;
            this.SPriceTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // companyNameTB
            // 
            this.companyNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.companyNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.companyNameTB.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.companyNameTB.Location = new System.Drawing.Point(1310, 334);
            this.companyNameTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.companyNameTB.Name = "companyNameTB";
            this.companyNameTB.Size = new System.Drawing.Size(133, 30);
            this.companyNameTB.TabIndex = 8;
            this.companyNameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // stockTB
            // 
            this.stockTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stockTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stockTB.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.stockTB.Location = new System.Drawing.Point(1310, 524);
            this.stockTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stockTB.Name = "stockTB";
            this.stockTB.Size = new System.Drawing.Size(133, 30);
            this.stockTB.TabIndex = 9;
            this.stockTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BPriceTB
            // 
            this.BPriceTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BPriceTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BPriceTB.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BPriceTB.Location = new System.Drawing.Point(1310, 393);
            this.BPriceTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BPriceTB.Name = "BPriceTB";
            this.BPriceTB.Size = new System.Drawing.Size(133, 30);
            this.BPriceTB.TabIndex = 11;
            this.BPriceTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MaxSelllingTB
            // 
            this.MaxSelllingTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxSelllingTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaxSelllingTB.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.MaxSelllingTB.Location = new System.Drawing.Point(1110, 524);
            this.MaxSelllingTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaxSelllingTB.Name = "MaxSelllingTB";
            this.MaxSelllingTB.Size = new System.Drawing.Size(133, 30);
            this.MaxSelllingTB.TabIndex = 12;
            this.MaxSelllingTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // taxratioTB
            // 
            this.taxratioTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.taxratioTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.taxratioTB.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.taxratioTB.Location = new System.Drawing.Point(1310, 461);
            this.taxratioTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.taxratioTB.Name = "taxratioTB";
            this.taxratioTB.Size = new System.Drawing.Size(133, 30);
            this.taxratioTB.TabIndex = 13;
            this.taxratioTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MaxbuyingTB
            // 
            this.MaxbuyingTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxbuyingTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaxbuyingTB.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.MaxbuyingTB.Location = new System.Drawing.Point(1110, 461);
            this.MaxbuyingTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaxbuyingTB.Name = "MaxbuyingTB";
            this.MaxbuyingTB.Size = new System.Drawing.Size(133, 30);
            this.MaxbuyingTB.TabIndex = 14;
            this.MaxbuyingTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ExpireDate
            // 
            this.ExpireDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExpireDate.CalendarForeColor = System.Drawing.SystemColors.HotTrack;
            this.ExpireDate.CalendarMonthBackground = System.Drawing.SystemColors.MenuHighlight;
            this.ExpireDate.CalendarTitleBackColor = System.Drawing.SystemColors.HotTrack;
            this.ExpireDate.CalendarTitleForeColor = System.Drawing.SystemColors.HotTrack;
            this.ExpireDate.CalendarTrailingForeColor = System.Drawing.SystemColors.HotTrack;
            this.ExpireDate.CustomFormat = "dd/MM/yyyy";
            this.ExpireDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExpireDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ExpireDate.Location = new System.Drawing.Point(1193, 657);
            this.ExpireDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ExpireDate.MaxDate = new System.DateTime(2050, 1, 1, 0, 0, 0, 0);
            this.ExpireDate.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.ExpireDate.Name = "ExpireDate";
            this.ExpireDate.Size = new System.Drawing.Size(173, 38);
            this.ExpireDate.TabIndex = 15;
            // 
            // medSearchcCB
            // 
            this.medSearchcCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.medSearchcCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.medSearchcCB.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.medSearchcCB.FormattingEnabled = true;
            this.medSearchcCB.Items.AddRange(new object[] {
            "الاسم بالعربي",
            "الاسم بالانجليزي",
            "اسم المورد",
            "Barcode"});
            this.medSearchcCB.Location = new System.Drawing.Point(1183, 153);
            this.medSearchcCB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.medSearchcCB.Name = "medSearchcCB";
            this.medSearchcCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.medSearchcCB.Size = new System.Drawing.Size(216, 39);
            this.medSearchcCB.TabIndex = 16;
            // 
            // expireDateLBL
            // 
            this.expireDateLBL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.expireDateLBL.BackColor = System.Drawing.Color.Transparent;
            this.expireDateLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.expireDateLBL.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.expireDateLBL.Location = new System.Drawing.Point(1193, 622);
            this.expireDateLBL.Name = "expireDateLBL";
            this.expireDateLBL.Size = new System.Drawing.Size(162, 31);
            this.expireDateLBL.TabIndex = 18;
            this.expireDateLBL.Text = "تاريخ انتهاء الصلحية";
            this.expireDateLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RemoveBTN
            // 
            this.RemoveBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveBTN.BackColor = System.Drawing.Color.Transparent;
            this.RemoveBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RemoveBTN.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.RemoveBTN.Location = new System.Drawing.Point(1110, 698);
            this.RemoveBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RemoveBTN.Name = "RemoveBTN";
            this.RemoveBTN.Size = new System.Drawing.Size(80, 50);
            this.RemoveBTN.TabIndex = 19;
            this.RemoveBTN.Text = "حذف";
            this.RemoveBTN.UseVisualStyleBackColor = false;
            this.RemoveBTN.Click += new System.EventHandler(this.RemoveBTN_Click);
            // 
            // EditBTN
            // 
            this.EditBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EditBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EditBTN.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.EditBTN.Location = new System.Drawing.Point(1237, 698);
            this.EditBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EditBTN.Name = "EditBTN";
            this.EditBTN.Size = new System.Drawing.Size(80, 50);
            this.EditBTN.TabIndex = 20;
            this.EditBTN.Text = "تعديل";
            this.EditBTN.UseVisualStyleBackColor = true;
            this.EditBTN.Click += new System.EventHandler(this.EditBTN_Click);
            // 
            // AddBTN
            // 
            this.AddBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddBTN.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.AddBTN.Location = new System.Drawing.Point(1363, 698);
            this.AddBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddBTN.Name = "AddBTN";
            this.AddBTN.Size = new System.Drawing.Size(80, 50);
            this.AddBTN.TabIndex = 21;
            this.AddBTN.Text = "اضافة";
            this.AddBTN.UseVisualStyleBackColor = true;
            this.AddBTN.Click += new System.EventHandler(this.AddBTN_Click);
            // 
            // medSearchTB
            // 
            this.medSearchTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.medSearchTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.medSearchTB.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.medSearchTB.Location = new System.Drawing.Point(1183, 200);
            this.medSearchTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.medSearchTB.Name = "medSearchTB";
            this.medSearchTB.Size = new System.Drawing.Size(216, 30);
            this.medSearchTB.TabIndex = 22;
            this.medSearchTB.Text = "بحث";
            this.medSearchTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.medSearchTB.TextChanged += new System.EventHandler(this.medSearchTB_TextChanged);
            // 
            // BarcodeTB
            // 
            this.BarcodeTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BarcodeTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BarcodeTB.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BarcodeTB.Location = new System.Drawing.Point(1213, 592);
            this.BarcodeTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BarcodeTB.Name = "BarcodeTB";
            this.BarcodeTB.Size = new System.Drawing.Size(133, 30);
            this.BarcodeTB.TabIndex = 23;
            this.BarcodeTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(1110, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 30);
            this.label1.TabIndex = 19;
            this.label1.Text = "English Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(1310, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 30);
            this.label2.TabIndex = 24;
            this.label2.Text = "اسم الدواء";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(1110, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 30);
            this.label3.TabIndex = 25;
            this.label3.Text = "اسم المورد";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(1310, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 30);
            this.label4.TabIndex = 26;
            this.label4.Text = "اسم الشركة";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(1110, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 30);
            this.label5.TabIndex = 27;
            this.label5.Text = "سعر الشراء";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(1310, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 30);
            this.label6.TabIndex = 28;
            this.label6.Text = "سعر البيع";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(1110, 490);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 30);
            this.label7.TabIndex = 29;
            this.label7.Text = "حد البيع";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(1310, 427);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 30);
            this.label8.TabIndex = 30;
            this.label8.Text = "ضريبة";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label9.Location = new System.Drawing.Point(1110, 427);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 30);
            this.label9.TabIndex = 31;
            this.label9.Text = "حد الشراء";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label10.Location = new System.Drawing.Point(1310, 495);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 30);
            this.label10.TabIndex = 32;
            this.label10.Text = "القطع المتوفرة";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // الباركود
            // 
            this.الباركود.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.الباركود.BackColor = System.Drawing.Color.Transparent;
            this.الباركود.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.الباركود.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.الباركود.Location = new System.Drawing.Point(1213, 558);
            this.الباركود.Name = "الباركود";
            this.الباركود.Size = new System.Drawing.Size(133, 30);
            this.الباركود.TabIndex = 33;
            this.الباركود.Text = "الباركود";
            this.الباركود.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MedicineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1470, 802);
            this.Controls.Add(this.الباركود);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BarcodeTB);
            this.Controls.Add(this.medSearchTB);
            this.Controls.Add(this.AddBTN);
            this.Controls.Add(this.EditBTN);
            this.Controls.Add(this.RemoveBTN);
            this.Controls.Add(this.expireDateLBL);
            this.Controls.Add(this.medSearchcCB);
            this.Controls.Add(this.ExpireDate);
            this.Controls.Add(this.MaxbuyingTB);
            this.Controls.Add(this.taxratioTB);
            this.Controls.Add(this.MaxSelllingTB);
            this.Controls.Add(this.BPriceTB);
            this.Controls.Add(this.stockTB);
            this.Controls.Add(this.companyNameTB);
            this.Controls.Add(this.SPriceTB);
            this.Controls.Add(this.nameEnglishTB);
            this.Controls.Add(this.manifactureNameTB);
            this.Controls.Add(this.nameArabicTB);
            this.Controls.Add(this.MedGridView1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MedicineForm";
            this.Text = "MedicineForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MedicineForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MedGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label medicineLBL;
        private System.Windows.Forms.DataGridView MedGridView1;
        private System.Windows.Forms.TextBox nameArabicTB;
        private System.Windows.Forms.TextBox manifactureNameTB;
        private System.Windows.Forms.TextBox nameEnglishTB;
        private System.Windows.Forms.TextBox SPriceTB;
        private System.Windows.Forms.TextBox companyNameTB;
        private System.Windows.Forms.TextBox stockTB;
        private System.Windows.Forms.TextBox BPriceTB;
        private System.Windows.Forms.TextBox MaxSelllingTB;
        private System.Windows.Forms.TextBox taxratioTB;
        private System.Windows.Forms.TextBox MaxbuyingTB;
        private System.Windows.Forms.DateTimePicker ExpireDate;
        private System.Windows.Forms.Button backBTN;
        private System.Windows.Forms.ComboBox medSearchcCB;
        private System.Windows.Forms.Label expireDateLBL;
        private System.Windows.Forms.Button RemoveBTN;
        private System.Windows.Forms.Button EditBTN;
        private System.Windows.Forms.Button AddBTN;
        private TextBox medSearchTB;
        private TextBox BarcodeTB;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label الباركود;
    }
}