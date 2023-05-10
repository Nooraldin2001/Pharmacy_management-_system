namespace PharmacyProject
{
    partial class MEDmanForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewMan = new System.Windows.Forms.DataGridView();
            this.searchBartb = new System.Windows.Forms.TextBox();
            this.ManCounttb = new System.Windows.Forms.TextBox();
            this.ManEmailtb = new System.Windows.Forms.TextBox();
            this.ManPhonetb = new System.Windows.Forms.TextBox();
            this.ManAdresstb = new System.Windows.Forms.TextBox();
            this.ManDeibttb = new System.Windows.Forms.TextBox();
            this.ManEmptb = new System.Windows.Forms.TextBox();
            this.ManNametb = new System.Windows.Forms.TextBox();
            this.ManTypeCB = new System.Windows.Forms.ComboBox();
            this.FundFirstMonthDtp = new System.Windows.Forms.DateTimePicker();
            this.NotesRtb = new System.Windows.Forms.RichTextBox();
            this.FundFirstMonthlbl = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.insertBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.manifactureNameLBL = new System.Windows.Forms.Label();
            this.manempNameLBL = new System.Windows.Forms.Label();
            this.AddressManifactureLBL = new System.Windows.Forms.Label();
            this.manifactureMailLBL = new System.Windows.Forms.Label();
            this.manifacturePhoneLBL = new System.Windows.Forms.Label();
            this.MAnDeiptLBL = new System.Windows.Forms.Label();
            this.manifactureCountLBL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMan)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(768, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 59);
            this.label1.TabIndex = 3;
            this.label1.Text = "الموردين";
            // 
            // dataGridViewMan
            // 
            this.dataGridViewMan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMan.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewMan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMan.Location = new System.Drawing.Point(12, 131);
            this.dataGridViewMan.Name = "dataGridViewMan";
            this.dataGridViewMan.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewMan.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewMan.RowTemplate.Height = 29;
            this.dataGridViewMan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMan.Size = new System.Drawing.Size(1178, 637);
            this.dataGridViewMan.TabIndex = 4;
            this.dataGridViewMan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMan_CellClick);
            this.dataGridViewMan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMan_CellContentClick);
            // 
            // searchBartb
            // 
            this.searchBartb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBartb.BackColor = System.Drawing.Color.White;
            this.searchBartb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchBartb.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.searchBartb.Location = new System.Drawing.Point(1308, 131);
            this.searchBartb.Name = "searchBartb";
            this.searchBartb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.searchBartb.Size = new System.Drawing.Size(348, 38);
            this.searchBartb.TabIndex = 5;
            this.searchBartb.Text = " بحث بأسم المورد";
            this.searchBartb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.searchBartb.TextChanged += new System.EventHandler(this.searchBartb_TextChanged);
            // 
            // ManCounttb
            // 
            this.ManCounttb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ManCounttb.BackColor = System.Drawing.Color.White;
            this.ManCounttb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ManCounttb.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ManCounttb.Location = new System.Drawing.Point(1493, 471);
            this.ManCounttb.Name = "ManCounttb";
            this.ManCounttb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ManCounttb.Size = new System.Drawing.Size(163, 30);
            this.ManCounttb.TabIndex = 9;
            this.ManCounttb.Tag = "";
            this.ManCounttb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ManEmailtb
            // 
            this.ManEmailtb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ManEmailtb.BackColor = System.Drawing.Color.White;
            this.ManEmailtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ManEmailtb.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ManEmailtb.Location = new System.Drawing.Point(1266, 310);
            this.ManEmailtb.Name = "ManEmailtb";
            this.ManEmailtb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ManEmailtb.Size = new System.Drawing.Size(163, 30);
            this.ManEmailtb.TabIndex = 10;
            this.ManEmailtb.Tag = "";
            this.ManEmailtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ManPhonetb
            // 
            this.ManPhonetb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ManPhonetb.BackColor = System.Drawing.Color.White;
            this.ManPhonetb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ManPhonetb.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ManPhonetb.Location = new System.Drawing.Point(1493, 392);
            this.ManPhonetb.Name = "ManPhonetb";
            this.ManPhonetb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ManPhonetb.Size = new System.Drawing.Size(163, 30);
            this.ManPhonetb.TabIndex = 12;
            this.ManPhonetb.Tag = "";
            this.ManPhonetb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ManAdresstb
            // 
            this.ManAdresstb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ManAdresstb.BackColor = System.Drawing.Color.White;
            this.ManAdresstb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ManAdresstb.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ManAdresstb.Location = new System.Drawing.Point(1493, 310);
            this.ManAdresstb.Name = "ManAdresstb";
            this.ManAdresstb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ManAdresstb.Size = new System.Drawing.Size(163, 30);
            this.ManAdresstb.TabIndex = 13;
            this.ManAdresstb.Tag = "";
            this.ManAdresstb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ManDeibttb
            // 
            this.ManDeibttb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ManDeibttb.BackColor = System.Drawing.Color.White;
            this.ManDeibttb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ManDeibttb.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ManDeibttb.Location = new System.Drawing.Point(1266, 471);
            this.ManDeibttb.Name = "ManDeibttb";
            this.ManDeibttb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ManDeibttb.Size = new System.Drawing.Size(163, 30);
            this.ManDeibttb.TabIndex = 14;
            this.ManDeibttb.Tag = "";
            this.ManDeibttb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ManEmptb
            // 
            this.ManEmptb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ManEmptb.BackColor = System.Drawing.Color.White;
            this.ManEmptb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ManEmptb.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ManEmptb.Location = new System.Drawing.Point(1266, 228);
            this.ManEmptb.Name = "ManEmptb";
            this.ManEmptb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ManEmptb.Size = new System.Drawing.Size(163, 30);
            this.ManEmptb.TabIndex = 15;
            this.ManEmptb.Tag = "";
            this.ManEmptb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ManNametb
            // 
            this.ManNametb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ManNametb.BackColor = System.Drawing.Color.White;
            this.ManNametb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ManNametb.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ManNametb.Location = new System.Drawing.Point(1493, 228);
            this.ManNametb.Name = "ManNametb";
            this.ManNametb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ManNametb.Size = new System.Drawing.Size(163, 30);
            this.ManNametb.TabIndex = 16;
            this.ManNametb.Tag = "";
            this.ManNametb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ManTypeCB
            // 
            this.ManTypeCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ManTypeCB.BackColor = System.Drawing.Color.White;
            this.ManTypeCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ManTypeCB.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ManTypeCB.FormattingEnabled = true;
            this.ManTypeCB.Items.AddRange(new object[] {
            "شركة ",
            "مخزن ",
            "دكتور"});
            this.ManTypeCB.Location = new System.Drawing.Point(1266, 392);
            this.ManTypeCB.Name = "ManTypeCB";
            this.ManTypeCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ManTypeCB.Size = new System.Drawing.Size(163, 33);
            this.ManTypeCB.TabIndex = 17;
            this.ManTypeCB.Text = "نوع المورد";
            // 
            // FundFirstMonthDtp
            // 
            this.FundFirstMonthDtp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FundFirstMonthDtp.CalendarForeColor = System.Drawing.Color.SkyBlue;
            this.FundFirstMonthDtp.CalendarMonthBackground = System.Drawing.Color.White;
            this.FundFirstMonthDtp.CalendarTitleForeColor = System.Drawing.Color.PaleTurquoise;
            this.FundFirstMonthDtp.CalendarTrailingForeColor = System.Drawing.Color.LightCyan;
            this.FundFirstMonthDtp.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.FundFirstMonthDtp.Location = new System.Drawing.Point(1324, 565);
            this.FundFirstMonthDtp.Name = "FundFirstMonthDtp";
            this.FundFirstMonthDtp.Size = new System.Drawing.Size(256, 27);
            this.FundFirstMonthDtp.TabIndex = 18;
            // 
            // NotesRtb
            // 
            this.NotesRtb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NotesRtb.BackColor = System.Drawing.Color.White;
            this.NotesRtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NotesRtb.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.NotesRtb.Location = new System.Drawing.Point(1226, 596);
            this.NotesRtb.Name = "NotesRtb";
            this.NotesRtb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NotesRtb.Size = new System.Drawing.Size(430, 127);
            this.NotesRtb.TabIndex = 20;
            this.NotesRtb.Text = "ملاحظة (اذا وجد)";
            // 
            // FundFirstMonthlbl
            // 
            this.FundFirstMonthlbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FundFirstMonthlbl.AutoSize = true;
            this.FundFirstMonthlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FundFirstMonthlbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FundFirstMonthlbl.Location = new System.Drawing.Point(1393, 537);
            this.FundFirstMonthlbl.Name = "FundFirstMonthlbl";
            this.FundFirstMonthlbl.Size = new System.Drawing.Size(125, 25);
            this.FundFirstMonthlbl.TabIndex = 22;
            this.FundFirstMonthlbl.Text = "بداية الشهر المالي";
            // 
            // backBtn
            // 
            this.backBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.backBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backBtn.ForeColor = System.Drawing.Color.White;
            this.backBtn.Location = new System.Drawing.Point(1561, 53);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(95, 56);
            this.backBtn.TabIndex = 23;
            this.backBtn.Text = ">>";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.searchBtn.Location = new System.Drawing.Point(1208, 131);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(94, 41);
            this.searchBtn.TabIndex = 24;
            this.searchBtn.Text = "بحث";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.updateBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.updateBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.updateBtn.Location = new System.Drawing.Point(1408, 729);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(94, 36);
            this.updateBtn.TabIndex = 25;
            this.updateBtn.Text = "تعديل";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // insertBtn
            // 
            this.insertBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.insertBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.insertBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.insertBtn.Location = new System.Drawing.Point(1562, 729);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(94, 36);
            this.insertBtn.TabIndex = 26;
            this.insertBtn.Text = "إضافة";
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.deleteBtn.Location = new System.Drawing.Point(1226, 729);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(94, 36);
            this.deleteBtn.TabIndex = 27;
            this.deleteBtn.Text = "حذف";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1684, 125);
            this.panel1.TabIndex = 28;
            // 
            // manifactureNameLBL
            // 
            this.manifactureNameLBL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.manifactureNameLBL.BackColor = System.Drawing.Color.Transparent;
            this.manifactureNameLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.manifactureNameLBL.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.manifactureNameLBL.Location = new System.Drawing.Point(1493, 195);
            this.manifactureNameLBL.Name = "manifactureNameLBL";
            this.manifactureNameLBL.Size = new System.Drawing.Size(163, 30);
            this.manifactureNameLBL.TabIndex = 29;
            this.manifactureNameLBL.Text = "اسم المورد";
            this.manifactureNameLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // manempNameLBL
            // 
            this.manempNameLBL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.manempNameLBL.BackColor = System.Drawing.Color.Transparent;
            this.manempNameLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.manempNameLBL.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.manempNameLBL.Location = new System.Drawing.Point(1266, 195);
            this.manempNameLBL.Name = "manempNameLBL";
            this.manempNameLBL.Size = new System.Drawing.Size(163, 30);
            this.manempNameLBL.TabIndex = 30;
            this.manempNameLBL.Text = "اسم المندوب";
            this.manempNameLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddressManifactureLBL
            // 
            this.AddressManifactureLBL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressManifactureLBL.BackColor = System.Drawing.Color.Transparent;
            this.AddressManifactureLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddressManifactureLBL.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.AddressManifactureLBL.Location = new System.Drawing.Point(1493, 277);
            this.AddressManifactureLBL.Name = "AddressManifactureLBL";
            this.AddressManifactureLBL.Size = new System.Drawing.Size(163, 30);
            this.AddressManifactureLBL.TabIndex = 31;
            this.AddressManifactureLBL.Text = "العنوان";
            this.AddressManifactureLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // manifactureMailLBL
            // 
            this.manifactureMailLBL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.manifactureMailLBL.BackColor = System.Drawing.Color.Transparent;
            this.manifactureMailLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.manifactureMailLBL.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.manifactureMailLBL.Location = new System.Drawing.Point(1266, 277);
            this.manifactureMailLBL.Name = "manifactureMailLBL";
            this.manifactureMailLBL.Size = new System.Drawing.Size(163, 30);
            this.manifactureMailLBL.TabIndex = 32;
            this.manifactureMailLBL.Text = "البريد الالكتروني";
            this.manifactureMailLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // manifacturePhoneLBL
            // 
            this.manifacturePhoneLBL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.manifacturePhoneLBL.BackColor = System.Drawing.Color.Transparent;
            this.manifacturePhoneLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.manifacturePhoneLBL.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.manifacturePhoneLBL.Location = new System.Drawing.Point(1493, 359);
            this.manifacturePhoneLBL.Name = "manifacturePhoneLBL";
            this.manifacturePhoneLBL.Size = new System.Drawing.Size(163, 30);
            this.manifacturePhoneLBL.TabIndex = 33;
            this.manifacturePhoneLBL.Text = "رقم المورد";
            this.manifacturePhoneLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MAnDeiptLBL
            // 
            this.MAnDeiptLBL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MAnDeiptLBL.BackColor = System.Drawing.Color.Transparent;
            this.MAnDeiptLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MAnDeiptLBL.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.MAnDeiptLBL.Location = new System.Drawing.Point(1266, 438);
            this.MAnDeiptLBL.Name = "MAnDeiptLBL";
            this.MAnDeiptLBL.Size = new System.Drawing.Size(163, 30);
            this.MAnDeiptLBL.TabIndex = 34;
            this.MAnDeiptLBL.Text = "المبلغ المستحق";
            this.MAnDeiptLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // manifactureCountLBL
            // 
            this.manifactureCountLBL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.manifactureCountLBL.BackColor = System.Drawing.Color.Transparent;
            this.manifactureCountLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.manifactureCountLBL.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.manifactureCountLBL.Location = new System.Drawing.Point(1493, 438);
            this.manifactureCountLBL.Name = "manifactureCountLBL";
            this.manifactureCountLBL.Size = new System.Drawing.Size(163, 30);
            this.manifactureCountLBL.TabIndex = 35;
            this.manifactureCountLBL.Text = "حساب المورد";
            this.manifactureCountLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MEDmanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1684, 780);
            this.Controls.Add(this.manifactureCountLBL);
            this.Controls.Add(this.MAnDeiptLBL);
            this.Controls.Add(this.manifacturePhoneLBL);
            this.Controls.Add(this.manifactureMailLBL);
            this.Controls.Add(this.AddressManifactureLBL);
            this.Controls.Add(this.manempNameLBL);
            this.Controls.Add(this.manifactureNameLBL);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.insertBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.FundFirstMonthlbl);
            this.Controls.Add(this.NotesRtb);
            this.Controls.Add(this.FundFirstMonthDtp);
            this.Controls.Add(this.ManTypeCB);
            this.Controls.Add(this.ManNametb);
            this.Controls.Add(this.ManEmptb);
            this.Controls.Add(this.ManDeibttb);
            this.Controls.Add(this.ManAdresstb);
            this.Controls.Add(this.ManPhonetb);
            this.Controls.Add(this.ManEmailtb);
            this.Controls.Add(this.ManCounttb);
            this.Controls.Add(this.searchBartb);
            this.Controls.Add(this.dataGridViewMan);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.Name = "MEDmanForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MEDman";
            this.Load += new System.EventHandler(this.MEDmanForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMan)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView dataGridViewMan;
        private TextBox searchBartb;
        private TextBox ManCounttb;
        private TextBox ManEmailtb;
        private TextBox ManPhonetb;
        private TextBox ManAdresstb;
        private TextBox ManDeibttb;
        private TextBox ManEmptb;
        private TextBox ManNametb;
        private ComboBox ManTypeCB;
        private DateTimePicker FundFirstMonthDtp;
        private RichTextBox NotesRtb;
        private Label FundFirstMonthlbl;
        private Button backBtn;
        private Button searchBtn;
        private Button updateBtn;
        private Button insertBtn;
        private Button deleteBtn;
        private Panel panel1;
        private Label manifactureNameLBL;
        private Label manempNameLBL;
        private Label AddressManifactureLBL;
        private Label manifactureMailLBL;
        private Label manifacturePhoneLBL;
        private Label MAnDeiptLBL;
        private Label manifactureCountLBL;
    }
}