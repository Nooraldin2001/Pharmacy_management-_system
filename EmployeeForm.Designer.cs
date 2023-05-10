
namespace Pharmacy
{
    partial class EmployeeForm
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
            this.employeeLBL = new System.Windows.Forms.Label();
            this.AddBTN = new System.Windows.Forms.Button();
            this.EditBTN = new System.Windows.Forms.Button();
            this.RemoveBTN = new System.Windows.Forms.Button();
            this.empSearchcCB = new System.Windows.Forms.ComboBox();
            this.AddressEmployeeTB = new System.Windows.Forms.TextBox();
            this.SalaryEmployeeTB = new System.Windows.Forms.TextBox();
            this.phoneEmployeeTB = new System.Windows.Forms.TextBox();
            this.PasswordEmployeeTB = new System.Windows.Forms.TextBox();
            this.nameEmpLoyeeTB = new System.Windows.Forms.TextBox();
            this.empGridView = new System.Windows.Forms.DataGridView();
            this.NationalIDTB = new System.Windows.Forms.TextBox();
            this.phIDTB = new System.Windows.Forms.TextBox();
            this.empGenderCB = new System.Windows.Forms.ComboBox();
            this.empStatusCB = new System.Windows.Forms.ComboBox();
            this.empShiftCB = new System.Windows.Forms.ComboBox();
            this.empMalitaryCB = new System.Windows.Forms.ComboBox();
            this.empPositionCB = new System.Windows.Forms.ComboBox();
            this.empSearchTB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.backBTN);
            this.panel1.Controls.Add(this.employeeLBL);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 145);
            this.panel1.TabIndex = 0;
            // 
            // backBTN
            // 
            this.backBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.backBTN.BackColor = System.Drawing.SystemColors.HotTrack;
            this.backBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backBTN.ForeColor = System.Drawing.SystemColors.Window;
            this.backBTN.Location = new System.Drawing.Point(1077, 71);
            this.backBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.backBTN.Name = "backBTN";
            this.backBTN.Size = new System.Drawing.Size(95, 50);
            this.backBTN.TabIndex = 17;
            this.backBTN.Text = ">>";
            this.backBTN.UseVisualStyleBackColor = false;
            this.backBTN.Click += new System.EventHandler(this.backBTN_Click);
            // 
            // employeeLBL
            // 
            this.employeeLBL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.employeeLBL.ForeColor = System.Drawing.SystemColors.Window;
            this.employeeLBL.Location = new System.Drawing.Point(0, 0);
            this.employeeLBL.Name = "employeeLBL";
            this.employeeLBL.Size = new System.Drawing.Size(1184, 145);
            this.employeeLBL.TabIndex = 1;
            this.employeeLBL.Text = "الموظفين";
            this.employeeLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddBTN
            // 
            this.AddBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddBTN.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.AddBTN.Location = new System.Drawing.Point(1078, 698);
            this.AddBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddBTN.Name = "AddBTN";
            this.AddBTN.Size = new System.Drawing.Size(80, 50);
            this.AddBTN.TabIndex = 38;
            this.AddBTN.Text = "اضافة";
            this.AddBTN.UseVisualStyleBackColor = true;
            this.AddBTN.Click += new System.EventHandler(this.AddBTN_Click);
            // 
            // EditBTN
            // 
            this.EditBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EditBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EditBTN.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.EditBTN.Location = new System.Drawing.Point(951, 698);
            this.EditBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EditBTN.Name = "EditBTN";
            this.EditBTN.Size = new System.Drawing.Size(80, 50);
            this.EditBTN.TabIndex = 37;
            this.EditBTN.Text = "تعديل";
            this.EditBTN.UseVisualStyleBackColor = true;
            this.EditBTN.Click += new System.EventHandler(this.EditBTN_Click);
            // 
            // RemoveBTN
            // 
            this.RemoveBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveBTN.BackColor = System.Drawing.Color.Transparent;
            this.RemoveBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RemoveBTN.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.RemoveBTN.Location = new System.Drawing.Point(824, 698);
            this.RemoveBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RemoveBTN.Name = "RemoveBTN";
            this.RemoveBTN.Size = new System.Drawing.Size(80, 50);
            this.RemoveBTN.TabIndex = 36;
            this.RemoveBTN.Text = "حذف";
            this.RemoveBTN.UseVisualStyleBackColor = false;
            this.RemoveBTN.Click += new System.EventHandler(this.RemoveBTN_Click);
            // 
            // empSearchcCB
            // 
            this.empSearchcCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.empSearchcCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.empSearchcCB.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.empSearchcCB.FormattingEnabled = true;
            this.empSearchcCB.Items.AddRange(new object[] {
            "البحث بالاسم",
            "البحث بالرقم القومي"});
            this.empSearchcCB.Location = new System.Drawing.Point(880, 175);
            this.empSearchcCB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.empSearchcCB.Name = "empSearchcCB";
            this.empSearchcCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.empSearchcCB.Size = new System.Drawing.Size(231, 39);
            this.empSearchcCB.TabIndex = 33;
            // 
            // AddressEmployeeTB
            // 
            this.AddressEmployeeTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressEmployeeTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddressEmployeeTB.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.AddressEmployeeTB.Location = new System.Drawing.Point(1026, 477);
            this.AddressEmployeeTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddressEmployeeTB.Name = "AddressEmployeeTB";
            this.AddressEmployeeTB.Size = new System.Drawing.Size(133, 30);
            this.AddressEmployeeTB.TabIndex = 30;
            this.AddressEmployeeTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //this.AddressEmployeeTB.Enter += new System.EventHandler(this.AddressEmployeeTB_Enter);
            //this.AddressEmployeeTB.Leave += new System.EventHandler(this.AddressEmployeeTB_Leave);
            // 
            // SalaryEmployeeTB
            // 
            this.SalaryEmployeeTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SalaryEmployeeTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SalaryEmployeeTB.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.SalaryEmployeeTB.Location = new System.Drawing.Point(1026, 606);
            this.SalaryEmployeeTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SalaryEmployeeTB.Name = "SalaryEmployeeTB";
            this.SalaryEmployeeTB.Size = new System.Drawing.Size(133, 30);
            this.SalaryEmployeeTB.TabIndex = 28;
            this.SalaryEmployeeTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //this.SalaryEmployeeTB.Enter += new System.EventHandler(this.SalaryEmployeeTB_Enter);
            //this.SalaryEmployeeTB.Leave += new System.EventHandler(this.SalaryEmployeeTB_Leave);
            // 
            // phoneEmployeeTB
            // 
            this.phoneEmployeeTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneEmployeeTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phoneEmployeeTB.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.phoneEmployeeTB.Location = new System.Drawing.Point(1026, 355);
            this.phoneEmployeeTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.phoneEmployeeTB.Name = "phoneEmployeeTB";
            this.phoneEmployeeTB.Size = new System.Drawing.Size(133, 30);
            this.phoneEmployeeTB.TabIndex = 26;
            this.phoneEmployeeTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //this.phoneEmployeeTB.Enter += new System.EventHandler(this.phoneEmployeeTB_Enter);
            //this.phoneEmployeeTB.Leave += new System.EventHandler(this.phoneEmployeeTB_Leave);
            // 
            // PasswordEmployeeTB
            // 
            this.PasswordEmployeeTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordEmployeeTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordEmployeeTB.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.PasswordEmployeeTB.Location = new System.Drawing.Point(826, 290);
            this.PasswordEmployeeTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PasswordEmployeeTB.Name = "PasswordEmployeeTB";
            this.PasswordEmployeeTB.Size = new System.Drawing.Size(133, 30);
            this.PasswordEmployeeTB.TabIndex = 24;
            this.PasswordEmployeeTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //this.PasswordEmployeeTB.Enter += new System.EventHandler(this.PasswordEmployeeTB_Enter);
            //this.PasswordEmployeeTB.Leave += new System.EventHandler(this.PasswordEmployeeTB_Leave);
            // 
            // nameEmpLoyeeTB
            // 
            this.nameEmpLoyeeTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nameEmpLoyeeTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameEmpLoyeeTB.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.nameEmpLoyeeTB.Location = new System.Drawing.Point(1026, 290);
            this.nameEmpLoyeeTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nameEmpLoyeeTB.Name = "nameEmpLoyeeTB";
            this.nameEmpLoyeeTB.Size = new System.Drawing.Size(133, 30);
            this.nameEmpLoyeeTB.TabIndex = 22;
            this.nameEmpLoyeeTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //this.nameEmpLoyeeTB.Enter += new System.EventHandler(this.nameEmpLoyeeTB_Enter);
            //this.nameEmpLoyeeTB.Leave += new System.EventHandler(this.nameEmpLoyeeTB_Leave);
            // 
            // empGridView
            // 
            this.empGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.empGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.empGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.empGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.empGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.empGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.empGridView.ColumnHeadersHeight = 35;
            this.empGridView.GridColor = System.Drawing.Color.Black;
            this.empGridView.Location = new System.Drawing.Point(12, 152);
            this.empGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.empGridView.Name = "empGridView";
            this.empGridView.ReadOnly = true;
            this.empGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.empGridView.RowHeadersWidth = 51;
            this.empGridView.RowTemplate.Height = 24;
            this.empGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.empGridView.Size = new System.Drawing.Size(768, 635);
            this.empGridView.TabIndex = 39;
            this.empGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // NationalIDTB
            // 
            this.NationalIDTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NationalIDTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NationalIDTB.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.NationalIDTB.Location = new System.Drawing.Point(1026, 408);
            this.NationalIDTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NationalIDTB.Name = "NationalIDTB";
            this.NationalIDTB.Size = new System.Drawing.Size(133, 30);
            this.NationalIDTB.TabIndex = 40;
            this.NationalIDTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //this.NationalIDTB.Enter += new System.EventHandler(this.NationalIDTB_Enter);
            //this.NationalIDTB.Leave += new System.EventHandler(this.NationalIDTB_Leave);
            // 
            // phIDTB
            // 
            this.phIDTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.phIDTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phIDTB.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.phIDTB.Location = new System.Drawing.Point(1026, 538);
            this.phIDTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.phIDTB.Name = "phIDTB";
            this.phIDTB.Size = new System.Drawing.Size(133, 30);
            this.phIDTB.TabIndex = 41;
            this.phIDTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //this.phIDTB.Enter += new System.EventHandler(this.phIDTB_Enter);
            //this.phIDTB.Leave += new System.EventHandler(this.phIDTB_Leave);
            // 
            // empGenderCB
            // 
            this.empGenderCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.empGenderCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.empGenderCB.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.empGenderCB.FormattingEnabled = true;
            this.empGenderCB.Items.AddRange(new object[] {
            "male ",
            "female"});
            this.empGenderCB.Location = new System.Drawing.Point(824, 408);
            this.empGenderCB.Name = "empGenderCB";
            this.empGenderCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.empGenderCB.Size = new System.Drawing.Size(155, 33);
            this.empGenderCB.TabIndex = 42;
            this.empGenderCB.Text = "النوع";
            // 
            // empStatusCB
            // 
            this.empStatusCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.empStatusCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.empStatusCB.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.empStatusCB.FormattingEnabled = true;
            this.empStatusCB.Items.AddRange(new object[] {
            "متزوج ",
            "اعزب "});
            this.empStatusCB.Location = new System.Drawing.Point(824, 474);
            this.empStatusCB.Name = "empStatusCB";
            this.empStatusCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.empStatusCB.Size = new System.Drawing.Size(155, 33);
            this.empStatusCB.TabIndex = 43;
            this.empStatusCB.Text = "الحاله الاجتماعية";
            // 
            // empShiftCB
            // 
            this.empShiftCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.empShiftCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.empShiftCB.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.empShiftCB.FormattingEnabled = true;
            this.empShiftCB.Items.AddRange(new object[] {
            "صباحي",
            "مسائي"});
            this.empShiftCB.Location = new System.Drawing.Point(824, 538);
            this.empShiftCB.Name = "empShiftCB";
            this.empShiftCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.empShiftCB.Size = new System.Drawing.Size(155, 33);
            this.empShiftCB.TabIndex = 44;
            this.empShiftCB.Text = "الوردية";
            // 
            // empMalitaryCB
            // 
            this.empMalitaryCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.empMalitaryCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.empMalitaryCB.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.empMalitaryCB.FormattingEnabled = true;
            this.empMalitaryCB.Items.AddRange(new object[] {
            "اعفاء",
            "تم فترة التجنيد",
            "مطلوب للتجنيد"});
            this.empMalitaryCB.Location = new System.Drawing.Point(824, 606);
            this.empMalitaryCB.Name = "empMalitaryCB";
            this.empMalitaryCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.empMalitaryCB.Size = new System.Drawing.Size(155, 33);
            this.empMalitaryCB.TabIndex = 45;
            this.empMalitaryCB.Text = "الموقف التجنيدي";
            // 
            // empPositionCB
            // 
            this.empPositionCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.empPositionCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.empPositionCB.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.empPositionCB.FormattingEnabled = true;
            this.empPositionCB.Items.AddRange(new object[] {
            "Admin",
            "Pharmasict"});
            this.empPositionCB.Location = new System.Drawing.Point(824, 355);
            this.empPositionCB.Name = "empPositionCB";
            this.empPositionCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.empPositionCB.Size = new System.Drawing.Size(155, 33);
            this.empPositionCB.TabIndex = 46;
            this.empPositionCB.Text = "مدير/موظف";
            // 
            // empSearchTB
            // 
            this.empSearchTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.empSearchTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.empSearchTB.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.empSearchTB.Location = new System.Drawing.Point(880, 222);
            this.empSearchTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.empSearchTB.Name = "empSearchTB";
            this.empSearchTB.Size = new System.Drawing.Size(231, 30);
            this.empSearchTB.TabIndex = 47;
            this.empSearchTB.Text = "بحث";
            this.empSearchTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.empSearchTB.TextChanged += new System.EventHandler(this.empSearchTB_TextChanged);
            this.empSearchTB.Enter += new System.EventHandler(this.empSearchTB_Enter);
            this.empSearchTB.Leave += new System.EventHandler(this.empSearchTB_Leave);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label10.Location = new System.Drawing.Point(1025, 512);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 30);
            this.label10.TabIndex = 54;
            this.label10.Text = "كوود الفرع";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(1025, 444);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 30);
            this.label8.TabIndex = 53;
            this.label8.Text = "عنوان الموظف";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(1025, 385);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 30);
            this.label6.TabIndex = 52;
            this.label6.Text = "الرقم القومي";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(1025, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 30);
            this.label4.TabIndex = 51;
            this.label4.Text = "رقم التليفون";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(1025, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 30);
            this.label2.TabIndex = 49;
            this.label2.Text = "الاسم بالكامل";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(825, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 30);
            this.label1.TabIndex = 48;
            this.label1.Text = "كلمة المرور";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(1025, 572);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 30);
            this.label5.TabIndex = 55;
            this.label5.Text = "راتب الموظف";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 802);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.empSearchTB);
            this.Controls.Add(this.empPositionCB);
            this.Controls.Add(this.empMalitaryCB);
            this.Controls.Add(this.empShiftCB);
            this.Controls.Add(this.empStatusCB);
            this.Controls.Add(this.empGenderCB);
            this.Controls.Add(this.phIDTB);
            this.Controls.Add(this.NationalIDTB);
            this.Controls.Add(this.empGridView);
            this.Controls.Add(this.AddBTN);
            this.Controls.Add(this.EditBTN);
            this.Controls.Add(this.RemoveBTN);
            this.Controls.Add(this.empSearchcCB);
            this.Controls.Add(this.AddressEmployeeTB);
            this.Controls.Add(this.SalaryEmployeeTB);
            this.Controls.Add(this.phoneEmployeeTB);
            this.Controls.Add(this.PasswordEmployeeTB);
            this.Controls.Add(this.nameEmpLoyeeTB);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.empGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label employeeLBL;
        private System.Windows.Forms.Button AddBTN;
        private System.Windows.Forms.Button EditBTN;
        private System.Windows.Forms.Button RemoveBTN;
        private System.Windows.Forms.ComboBox empSearchcCB;
        private System.Windows.Forms.TextBox AddressEmployeeTB;
        private System.Windows.Forms.TextBox SalaryEmployeeTB;
        private System.Windows.Forms.TextBox phoneEmployeeTB;
        private System.Windows.Forms.TextBox PasswordEmployeeTB;
        private System.Windows.Forms.TextBox nameEmpLoyeeTB;
        private System.Windows.Forms.DataGridView empGridView;
        private System.Windows.Forms.Button backBTN;
        private System.Windows.Forms.TextBox NationalIDTB;
        private System.Windows.Forms.TextBox phIDTB;
        private ComboBox empGenderCB;
        private ComboBox empStatusCB;
        private ComboBox empShiftCB;
        private ComboBox empMalitaryCB;
        private ComboBox empPositionCB;
        private TextBox empSearchTB;
        private Label label10;
        private Label label8;
        private Label label6;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label label5;
    }
}