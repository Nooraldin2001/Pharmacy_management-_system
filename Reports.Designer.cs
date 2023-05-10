namespace PharmacyProject
{
    partial class Reports
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
            this.RebortsLBl = new System.Windows.Forms.Label();
            this.TypeReportscomboBox1 = new System.Windows.Forms.ComboBox();
            this.ReportsDgv = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReportsDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.backBTN);
            this.panel1.Controls.Add(this.RebortsLBl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1094, 125);
            this.panel1.TabIndex = 0;
            // 
            // backBTN
            // 
            this.backBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.backBTN.BackColor = System.Drawing.SystemColors.HotTrack;
            this.backBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backBTN.ForeColor = System.Drawing.SystemColors.Window;
            this.backBTN.Location = new System.Drawing.Point(987, 55);
            this.backBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.backBTN.Name = "backBTN";
            this.backBTN.Size = new System.Drawing.Size(95, 50);
            this.backBTN.TabIndex = 17;
            this.backBTN.Text = ">>";
            this.backBTN.UseVisualStyleBackColor = false;
            this.backBTN.Click += new System.EventHandler(this.backBTN_Click);
            // 
            // RebortsLBl
            // 
            this.RebortsLBl.AutoSize = true;
            this.RebortsLBl.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RebortsLBl.ForeColor = System.Drawing.Color.Snow;
            this.RebortsLBl.Location = new System.Drawing.Point(513, 55);
            this.RebortsLBl.Name = "RebortsLBl";
            this.RebortsLBl.Size = new System.Drawing.Size(98, 42);
            this.RebortsLBl.TabIndex = 0;
            this.RebortsLBl.Text = "تقارير";
            // 
            // TypeReportscomboBox1
            // 
            this.TypeReportscomboBox1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TypeReportscomboBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.TypeReportscomboBox1.FormattingEnabled = true;
            this.TypeReportscomboBox1.Items.AddRange(new object[] {
            "اصناف قربة على انتهاء الصلاحية ",
            "نواقص (غير موجودة)",
            "أصناف قلت عن الحد الأدنى",
            "رأس المال",
            "اجمالى ما تم صرفه",
            "اجمالى ما تم بيعه",
            "اجمالى الأرباح",
            "المدين",
            "الدائن",
            "اعلا خصم"});
            this.TypeReportscomboBox1.Location = new System.Drawing.Point(755, 131);
            this.TypeReportscomboBox1.Name = "TypeReportscomboBox1";
            this.TypeReportscomboBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TypeReportscomboBox1.Size = new System.Drawing.Size(333, 39);
            this.TypeReportscomboBox1.TabIndex = 1;
            this.TypeReportscomboBox1.Text = "نوع التقارير";
            this.TypeReportscomboBox1.SelectedIndexChanged += new System.EventHandler(this.TypeReportscomboBox1_SelectedIndexChanged);
            this.TypeReportscomboBox1.SelectionChangeCommitted += new System.EventHandler(this.TypeReportscomboBox1_SelectionChangeCommitted);
            // 
            // ReportsDgv
            // 
            this.ReportsDgv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ReportsDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReportsDgv.Location = new System.Drawing.Point(12, 185);
            this.ReportsDgv.Name = "ReportsDgv";
            this.ReportsDgv.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ReportsDgv.RowHeadersWidth = 51;
            this.ReportsDgv.RowTemplate.Height = 29;
            this.ReportsDgv.Size = new System.Drawing.Size(1076, 435);
            this.ReportsDgv.TabIndex = 3;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 641);
            this.Controls.Add(this.ReportsDgv);
            this.Controls.Add(this.TypeReportscomboBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Reports_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReportsDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label RebortsLBl;
        private ComboBox TypeReportscomboBox1;
        private DataGridView ReportsDgv;
        private Button backBTN;
    }
}