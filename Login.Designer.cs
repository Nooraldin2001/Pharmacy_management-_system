
namespace Pharmacy
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.FullNametextBox = new System.Windows.Forms.TextBox();
            this.PasswordtextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.minimizeBTN = new System.Windows.Forms.Button();
            this.cancelBTN = new System.Windows.Forms.Button();
            this.confirmBTN = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(129, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 66);
            this.label1.TabIndex = 0;
            this.label1.Text = "تسجيل الدخول";
            // 
            // FullNametextBox
            // 
            this.FullNametextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FullNametextBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FullNametextBox.Location = new System.Drawing.Point(58, 156);
            this.FullNametextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FullNametextBox.Name = "FullNametextBox";
            this.FullNametextBox.Size = new System.Drawing.Size(347, 38);
            this.FullNametextBox.TabIndex = 2;
            this.FullNametextBox.Text = "الاسم بالكامل";
            this.FullNametextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.FullNametextBox.Enter += new System.EventHandler(this.FullNametextBox_Enter);
            this.FullNametextBox.Leave += new System.EventHandler(this.FullNametextBox_Leave);
            // 
            // PasswordtextBox
            // 
            this.PasswordtextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.PasswordtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordtextBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.PasswordtextBox.Location = new System.Drawing.Point(58, 251);
            this.PasswordtextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PasswordtextBox.Name = "PasswordtextBox";
            this.PasswordtextBox.Size = new System.Drawing.Size(347, 38);
            this.PasswordtextBox.TabIndex = 3;
            this.PasswordtextBox.Text = "كلمة المرور";
            this.PasswordtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PasswordtextBox.Enter += new System.EventHandler(this.PasswordtextBox_Enter);
            this.PasswordtextBox.Leave += new System.EventHandler(this.PasswordtextBox_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.minimizeBTN);
            this.panel1.Controls.Add(this.cancelBTN);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.Location = new System.Drawing.Point(477, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 525);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(94, 156);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 133);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // minimizeBTN
            // 
            this.minimizeBTN.BackColor = System.Drawing.SystemColors.HotTrack;
            this.minimizeBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minimizeBTN.ForeColor = System.Drawing.SystemColors.Window;
            this.minimizeBTN.Location = new System.Drawing.Point(200, 15);
            this.minimizeBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.minimizeBTN.Name = "minimizeBTN";
            this.minimizeBTN.Size = new System.Drawing.Size(40, 50);
            this.minimizeBTN.TabIndex = 1;
            this.minimizeBTN.Text = "-";
            this.minimizeBTN.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.minimizeBTN.UseVisualStyleBackColor = false;
            this.minimizeBTN.Click += new System.EventHandler(this.minimizeBTN_Click);
            // 
            // cancelBTN
            // 
            this.cancelBTN.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cancelBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancelBTN.ForeColor = System.Drawing.SystemColors.Window;
            this.cancelBTN.Location = new System.Drawing.Point(246, 15);
            this.cancelBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancelBTN.Name = "cancelBTN";
            this.cancelBTN.Size = new System.Drawing.Size(40, 50);
            this.cancelBTN.TabIndex = 0;
            this.cancelBTN.Text = "X";
            this.cancelBTN.UseVisualStyleBackColor = false;
            this.cancelBTN.Click += new System.EventHandler(this.cancelBTN_Click);
            // 
            // confirmBTN
            // 
            this.confirmBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confirmBTN.Location = new System.Drawing.Point(141, 401);
            this.confirmBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.confirmBTN.Name = "confirmBTN";
            this.confirmBTN.Size = new System.Drawing.Size(230, 62);
            this.confirmBTN.TabIndex = 6;
            this.confirmBTN.Text = "تسجيل";
            this.confirmBTN.UseVisualStyleBackColor = true;
            this.confirmBTN.Click += new System.EventHandler(this.confirmBTN_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(780, 525);
            this.Controls.Add(this.confirmBTN);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PasswordtextBox);
            this.Controls.Add(this.FullNametextBox);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox FullNametextBox;
        public System.Windows.Forms.TextBox PasswordtextBox;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button confirmBTN;
        private System.Windows.Forms.Button cancelBTN;
        private System.Windows.Forms.Button minimizeBTN;
        private PictureBox pictureBox1;
    }
}