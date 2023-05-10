namespace PharmacyProject
{
    partial class Billview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Billview));
            this.BillViewDgv = new System.Windows.Forms.DataGridView();
            this.categorySafeCB = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.resetBillbtn = new System.Windows.Forms.Button();
            this.searchBillBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.BillViewDgv)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BillViewDgv
            // 
            this.BillViewDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BillViewDgv.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.BillViewDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BillViewDgv.GridColor = System.Drawing.SystemColors.ControlText;
            this.BillViewDgv.Location = new System.Drawing.Point(12, 196);
            this.BillViewDgv.Name = "BillViewDgv";
            this.BillViewDgv.ReadOnly = true;
            this.BillViewDgv.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BillViewDgv.RowHeadersWidth = 51;
            this.BillViewDgv.RowTemplate.Height = 29;
            this.BillViewDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BillViewDgv.Size = new System.Drawing.Size(780, 595);
            this.BillViewDgv.TabIndex = 23;
            // 
            // categorySafeCB
            // 
            this.categorySafeCB.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.categorySafeCB.DisplayMember = "الرئيسية";
            this.categorySafeCB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.categorySafeCB.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.categorySafeCB.FormattingEnabled = true;
            this.categorySafeCB.Items.AddRange(new object[] {
            "الرئيسية ",
            "صباحى ",
            "مسائى"});
            this.categorySafeCB.Location = new System.Drawing.Point(132, 22);
            this.categorySafeCB.Name = "categorySafeCB";
            this.categorySafeCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.categorySafeCB.Size = new System.Drawing.Size(180, 36);
            this.categorySafeCB.TabIndex = 30;
            this.categorySafeCB.Text = "فترة الخزينة";
            this.categorySafeCB.SelectionChangeCommitted += new System.EventHandler(this.categorySafeCB_SelectionChangeCommitted);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(318, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 36);
            this.button1.TabIndex = 34;
            this.button1.Text = "المبيعات الفورية";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // resetBillbtn
            // 
            this.resetBillbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resetBillbtn.BackgroundImage")));
            this.resetBillbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.resetBillbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetBillbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resetBillbtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.resetBillbtn.Location = new System.Drawing.Point(83, 23);
            this.resetBillbtn.Name = "resetBillbtn";
            this.resetBillbtn.Size = new System.Drawing.Size(43, 36);
            this.resetBillbtn.TabIndex = 23;
            this.resetBillbtn.UseVisualStyleBackColor = true;
            this.resetBillbtn.Click += new System.EventHandler(this.resetBillbtn_Click);
            // 
            // searchBillBTN
            // 
            this.searchBillBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchBillBTN.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.searchBillBTN.Location = new System.Drawing.Point(497, 21);
            this.searchBillBTN.Name = "searchBillBTN";
            this.searchBillBTN.Size = new System.Drawing.Size(62, 36);
            this.searchBillBTN.TabIndex = 19;
            this.searchBillBTN.Text = "بحث";
            this.searchBillBTN.UseVisualStyleBackColor = true;
            this.searchBillBTN.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(262, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 59);
            this.label2.TabIndex = 3;
            this.label2.Text = "ارشيف الفواتير";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 125);
            this.panel1.TabIndex = 35;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Location = new System.Drawing.Point(15, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 36);
            this.button2.TabIndex = 36;
            this.button2.Text = "حذف";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchBillBTN);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.resetBillbtn);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.categorySafeCB);
            this.groupBox1.Location = new System.Drawing.Point(122, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(565, 63);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            // 
            // Billview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 803);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BillViewDgv);
            this.Name = "Billview";
            this.Text = "Billview";
            this.Load += new System.EventHandler(this.Billview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BillViewDgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DataGridView BillViewDgv;
        private Button resetBillbtn;
        private Button button1;
        private Button searchBillBTN;
        private Label label2;
        private ComboBox categorySafeCB;
        private Panel panel1;
        private Button button2;
        private GroupBox groupBox1;
    }
}