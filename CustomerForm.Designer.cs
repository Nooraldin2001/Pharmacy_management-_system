namespace PharmacyProject
{
    partial class CustomerForm
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
            this.ExitCircularBtn = new PharmacyProject.CircularButton();
            this.cusDiebtTb = new System.Windows.Forms.TextBox();
            this.cusNameTb = new System.Windows.Forms.TextBox();
            this.cusPhoneTb = new System.Windows.Forms.TextBox();
            this.cusAdressTb = new System.Windows.Forms.TextBox();
            this.cusDiscountTb = new System.Windows.Forms.TextBox();
            this.FundFirstMonthlbl = new System.Windows.Forms.Label();
            this.PatientHistoryRtb = new System.Windows.Forms.RichTextBox();
            this.DispenDateDtp = new System.Windows.Forms.DateTimePicker();
            this.cusDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.insertBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backBtn = new System.Windows.Forms.Button();
            this.searchCusCB = new System.Windows.Forms.ComboBox();
            this.searchCusBtn = new System.Windows.Forms.TextBox();
            this.cusNameLBL = new System.Windows.Forms.Label();
            this.cusAddressLBL = new System.Windows.Forms.Label();
            this.CusDieptlabel = new System.Windows.Forms.Label();
            this.cusPhoneLBL = new System.Windows.Forms.Label();
            this.cusDiscountlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cusDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitCircularBtn
            // 
            this.ExitCircularBtn.BackgroundImage = global::PharmacyProject.Properties.Resources.x_2925826_640;
            this.ExitCircularBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitCircularBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitCircularBtn.ForeColor = System.Drawing.Color.White;
            this.ExitCircularBtn.Location = new System.Drawing.Point(1601, 9);
            this.ExitCircularBtn.Name = "ExitCircularBtn";
            this.ExitCircularBtn.Size = new System.Drawing.Size(53, 56);
            this.ExitCircularBtn.TabIndex = 22;
            this.ExitCircularBtn.UseVisualStyleBackColor = true;
            this.ExitCircularBtn.Click += new System.EventHandler(this.ExitCircularBtn_Click);
            // 
            // cusDiebtTb
            // 
            this.cusDiebtTb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cusDiebtTb.BackColor = System.Drawing.Color.White;
            this.cusDiebtTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cusDiebtTb.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cusDiebtTb.Location = new System.Drawing.Point(1458, 441);
            this.cusDiebtTb.Name = "cusDiebtTb";
            this.cusDiebtTb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cusDiebtTb.Size = new System.Drawing.Size(163, 30);
            this.cusDiebtTb.TabIndex = 31;
            this.cusDiebtTb.Tag = "";
            this.cusDiebtTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //this.cusDiebtTb.Enter += new System.EventHandler(this.cusDiebtTb_Enter_1);
            //this.cusDiebtTb.Leave += new System.EventHandler(this.cusDiebtTb_Leave_1);
            //// 
            // cusNameTb
            // 
            this.cusNameTb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cusNameTb.BackColor = System.Drawing.Color.White;
            this.cusNameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cusNameTb.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cusNameTb.Location = new System.Drawing.Point(1461, 287);
            this.cusNameTb.Name = "cusNameTb";
            this.cusNameTb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cusNameTb.Size = new System.Drawing.Size(163, 30);
            this.cusNameTb.TabIndex = 30;
            this.cusNameTb.Tag = "";
            this.cusNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //this.cusNameTb.Enter += new System.EventHandler(this.cusNameTb_Enter);
            //this.cusNameTb.Leave += new System.EventHandler(this.cusNameTb_Leave);
            //// 
            // cusPhoneTb
            // 
            this.cusPhoneTb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cusPhoneTb.BackColor = System.Drawing.Color.White;
            this.cusPhoneTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cusPhoneTb.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cusPhoneTb.Location = new System.Drawing.Point(1458, 364);
            this.cusPhoneTb.Name = "cusPhoneTb";
            this.cusPhoneTb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cusPhoneTb.Size = new System.Drawing.Size(163, 30);
            this.cusPhoneTb.TabIndex = 25;
            this.cusPhoneTb.Tag = "";
            this.cusPhoneTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //this.cusPhoneTb.Enter += new System.EventHandler(this.cusPhoneTb_Enter_1);
            //this.cusPhoneTb.Leave += new System.EventHandler(this.cusPhoneTb_Leave_1);
            //// 
            // cusAdressTb
            // 
            this.cusAdressTb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cusAdressTb.BackColor = System.Drawing.Color.White;
            this.cusAdressTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cusAdressTb.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cusAdressTb.Location = new System.Drawing.Point(1234, 287);
            this.cusAdressTb.Name = "cusAdressTb";
            this.cusAdressTb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cusAdressTb.Size = new System.Drawing.Size(163, 30);
            this.cusAdressTb.TabIndex = 24;
            this.cusAdressTb.Tag = "";
            this.cusAdressTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //this.cusAdressTb.Enter += new System.EventHandler(this.cusAdressTb_Enter_1);
            //this.cusAdressTb.Leave += new System.EventHandler(this.cusAdressTb_Leave_1);
            //// 
            // cusDiscountTb
            // 
            this.cusDiscountTb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cusDiscountTb.BackColor = System.Drawing.Color.White;
            this.cusDiscountTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cusDiscountTb.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cusDiscountTb.Location = new System.Drawing.Point(1234, 364);
            this.cusDiscountTb.Name = "cusDiscountTb";
            this.cusDiscountTb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cusDiscountTb.Size = new System.Drawing.Size(163, 30);
            this.cusDiscountTb.TabIndex = 23;
            this.cusDiscountTb.Tag = "";
            this.cusDiscountTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //this.cusDiscountTb.Enter += new System.EventHandler(this.cusDiscountTb_Enter_1);
            //this.cusDiscountTb.Leave += new System.EventHandler(this.cusDiscountTb_Leave_1);
            //// 
            // FundFirstMonthlbl
            // 
            this.FundFirstMonthlbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FundFirstMonthlbl.AutoSize = true;
            this.FundFirstMonthlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FundFirstMonthlbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FundFirstMonthlbl.Location = new System.Drawing.Point(1525, 624);
            this.FundFirstMonthlbl.Name = "FundFirstMonthlbl";
            this.FundFirstMonthlbl.Size = new System.Drawing.Size(104, 25);
            this.FundFirstMonthlbl.TabIndex = 35;
            this.FundFirstMonthlbl.Text = "تاريخ الصرف";
            // 
            // PatientHistoryRtb
            // 
            this.PatientHistoryRtb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PatientHistoryRtb.BackColor = System.Drawing.Color.White;
            this.PatientHistoryRtb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PatientHistoryRtb.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.PatientHistoryRtb.Location = new System.Drawing.Point(1244, 477);
            this.PatientHistoryRtb.Name = "PatientHistoryRtb";
            this.PatientHistoryRtb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PatientHistoryRtb.Size = new System.Drawing.Size(377, 120);
            this.PatientHistoryRtb.TabIndex = 34;
            this.PatientHistoryRtb.Text = "التاريخ المرضي للعميل";
            //this.PatientHistoryRtb.Enter += new System.EventHandler(this.PatientHistoryRtb_Enter_1);
            //this.PatientHistoryRtb.Leave += new System.EventHandler(this.PatientHistoryRtb_Leave_1);
            //// 
            // DispenDateDtp
            // 
            this.DispenDateDtp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DispenDateDtp.CalendarForeColor = System.Drawing.Color.SkyBlue;
            this.DispenDateDtp.CalendarMonthBackground = System.Drawing.Color.White;
            this.DispenDateDtp.CalendarTitleForeColor = System.Drawing.Color.PaleTurquoise;
            this.DispenDateDtp.CalendarTrailingForeColor = System.Drawing.Color.LightCyan;
            this.DispenDateDtp.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DispenDateDtp.Location = new System.Drawing.Point(1234, 624);
            this.DispenDateDtp.Name = "DispenDateDtp";
            this.DispenDateDtp.Size = new System.Drawing.Size(275, 27);
            this.DispenDateDtp.TabIndex = 33;
            // 
            // cusDataGridView
            // 
            this.cusDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cusDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.cusDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cusDataGridView.Location = new System.Drawing.Point(12, 151);
            this.cusDataGridView.Name = "cusDataGridView";
            this.cusDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cusDataGridView.RowHeadersWidth = 51;
            this.cusDataGridView.RowTemplate.Height = 29;
            this.cusDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cusDataGridView.Size = new System.Drawing.Size(1178, 561);
            this.cusDataGridView.TabIndex = 36;
            this.cusDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cusDataGridView_CellClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(691, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 59);
            this.label1.TabIndex = 37;
            this.label1.Text = "العملاء";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.deleteBtn.Location = new System.Drawing.Point(1244, 666);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(94, 46);
            this.deleteBtn.TabIndex = 40;
            this.deleteBtn.Text = "حذف";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // insertBtn
            // 
            this.insertBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.insertBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.insertBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.insertBtn.Location = new System.Drawing.Point(1527, 666);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(94, 46);
            this.insertBtn.TabIndex = 39;
            this.insertBtn.Text = "إدخال";
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.updateBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.updateBtn.Location = new System.Drawing.Point(1394, 666);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(94, 46);
            this.updateBtn.TabIndex = 38;
            this.updateBtn.Text = "تحديث";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Coral;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1666, 145);
            this.panel1.TabIndex = 42;
            // 
            // backBtn
            // 
            this.backBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.backBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.backBtn.Location = new System.Drawing.Point(1559, 55);
            this.backBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(95, 50);
            this.backBtn.TabIndex = 38;
            this.backBtn.Text = ">>";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // searchCusCB
            // 
            this.searchCusCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchCusCB.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchCusCB.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.searchCusCB.FormattingEnabled = true;
            this.searchCusCB.Items.AddRange(new object[] {
            "الاسم",
            "رقم التلفون"});
            this.searchCusCB.Location = new System.Drawing.Point(1358, 166);
            this.searchCusCB.Name = "searchCusCB";
            this.searchCusCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.searchCusCB.Size = new System.Drawing.Size(162, 39);
            this.searchCusCB.TabIndex = 43;
            this.searchCusCB.Text = "طريقة البحث";
            // 
            // searchCusBtn
            // 
            this.searchCusBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchCusBtn.BackColor = System.Drawing.Color.White;
            this.searchCusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchCusBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.searchCusBtn.Location = new System.Drawing.Point(1244, 211);
            this.searchCusBtn.Name = "searchCusBtn";
            this.searchCusBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.searchCusBtn.Size = new System.Drawing.Size(380, 30);
            this.searchCusBtn.TabIndex = 44;
            this.searchCusBtn.Tag = "";
            this.searchCusBtn.Text = "بحث";
            this.searchCusBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.searchCusBtn.TextChanged += new System.EventHandler(this.searchCusBtn_TextChanged);
            this.searchCusBtn.Enter += new System.EventHandler(this.searchCusBtn_Enter);
            this.searchCusBtn.Leave += new System.EventHandler(this.searchCusBtn_Leave);
            // 
            // cusNameLBL
            // 
            this.cusNameLBL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cusNameLBL.BackColor = System.Drawing.Color.Transparent;
            this.cusNameLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cusNameLBL.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cusNameLBL.Location = new System.Drawing.Point(1488, 254);
            this.cusNameLBL.Name = "cusNameLBL";
            this.cusNameLBL.Size = new System.Drawing.Size(133, 30);
            this.cusNameLBL.TabIndex = 45;
            this.cusNameLBL.Text = "اسم العميل";
            this.cusNameLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cusAddressLBL
            // 
            this.cusAddressLBL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cusAddressLBL.BackColor = System.Drawing.Color.Transparent;
            this.cusAddressLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cusAddressLBL.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cusAddressLBL.Location = new System.Drawing.Point(1264, 254);
            this.cusAddressLBL.Name = "cusAddressLBL";
            this.cusAddressLBL.Size = new System.Drawing.Size(133, 30);
            this.cusAddressLBL.TabIndex = 46;
            this.cusAddressLBL.Text = "عنوان العميل";
            this.cusAddressLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CusDieptlabel
            // 
            this.CusDieptlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CusDieptlabel.BackColor = System.Drawing.Color.Transparent;
            this.CusDieptlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CusDieptlabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.CusDieptlabel.Location = new System.Drawing.Point(1488, 408);
            this.CusDieptlabel.Name = "CusDieptlabel";
            this.CusDieptlabel.Size = new System.Drawing.Size(133, 30);
            this.CusDieptlabel.TabIndex = 47;
            this.CusDieptlabel.Text = "المبلغ المستحق ";
            this.CusDieptlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cusPhoneLBL
            // 
            this.cusPhoneLBL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cusPhoneLBL.BackColor = System.Drawing.Color.Transparent;
            this.cusPhoneLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cusPhoneLBL.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cusPhoneLBL.Location = new System.Drawing.Point(1488, 331);
            this.cusPhoneLBL.Name = "cusPhoneLBL";
            this.cusPhoneLBL.Size = new System.Drawing.Size(133, 30);
            this.cusPhoneLBL.TabIndex = 48;
            this.cusPhoneLBL.Text = "رقم تلفون العميل";
            this.cusPhoneLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cusDiscountlabel
            // 
            this.cusDiscountlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cusDiscountlabel.BackColor = System.Drawing.Color.Transparent;
            this.cusDiscountlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cusDiscountlabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cusDiscountlabel.Location = new System.Drawing.Point(1255, 331);
            this.cusDiscountlabel.Name = "cusDiscountlabel";
            this.cusDiscountlabel.Size = new System.Drawing.Size(133, 30);
            this.cusDiscountlabel.TabIndex = 49;
            this.cusDiscountlabel.Text = "نسبة الخصم";
            this.cusDiscountlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1666, 733);
            this.Controls.Add(this.cusDiscountlabel);
            this.Controls.Add(this.cusPhoneLBL);
            this.Controls.Add(this.CusDieptlabel);
            this.Controls.Add(this.cusAddressLBL);
            this.Controls.Add(this.cusNameLBL);
            this.Controls.Add(this.searchCusBtn);
            this.Controls.Add(this.searchCusCB);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.insertBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.cusDataGridView);
            this.Controls.Add(this.FundFirstMonthlbl);
            this.Controls.Add(this.PatientHistoryRtb);
            this.Controls.Add(this.DispenDateDtp);
            this.Controls.Add(this.cusDiebtTb);
            this.Controls.Add(this.cusNameTb);
            this.Controls.Add(this.cusPhoneTb);
            this.Controls.Add(this.cusAdressTb);
            this.Controls.Add(this.cusDiscountTb);
            this.Controls.Add(this.ExitCircularBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CustomerForm";
            this.Text = "العملاء";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cusDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CircularButton ExitCircularBtn;
        private TextBox cusDiebtTb;
        private TextBox cusNameTb;
        private TextBox cusPhoneTb;
        private TextBox cusAdressTb;
        private TextBox cusDiscountTb;
        private Label FundFirstMonthlbl;
        private RichTextBox PatientHistoryRtb;
        private DateTimePicker DispenDateDtp;
        private DataGridView cusDataGridView;
        private Label label1;
        private Button deleteBtn;
        private Button insertBtn;
        private Button updateBtn;
        private Panel panel1;
        private ComboBox searchCusCB;
        private TextBox searchCusBtn;
        private Button backBtn;
        private Label cusNameLBL;
        private Label cusAddressLBL;
        private Label CusDieptlabel;
        private Label cusPhoneLBL;
        private Label cusDiscountlabel;
    }
}