
namespace Pharmacy
{
    partial class Form1
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
            this.Progressbar1 = new CircularProgressBar.CircularProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Progressbar1
            // 
            this.Progressbar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.Progressbar1.AnimationSpeed = 500;
            this.Progressbar1.BackColor = System.Drawing.Color.White;
            this.Progressbar1.Font = new System.Drawing.Font("Myanmar Text", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Progressbar1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Progressbar1.InnerColor = System.Drawing.Color.White;
            this.Progressbar1.InnerMargin = 2;
            this.Progressbar1.InnerWidth = -1;
            this.Progressbar1.Location = new System.Drawing.Point(62, 141);
            this.Progressbar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Progressbar1.MarqueeAnimationSpeed = 2000;
            this.Progressbar1.Name = "Progressbar1";
            this.Progressbar1.OuterColor = System.Drawing.Color.LightGray;
            this.Progressbar1.OuterMargin = -25;
            this.Progressbar1.OuterWidth = 26;
            this.Progressbar1.ProgressColor = System.Drawing.SystemColors.HotTrack;
            this.Progressbar1.ProgressWidth = 6;
            this.Progressbar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Progressbar1.Size = new System.Drawing.Size(150, 188);
            this.Progressbar1.StartAngle = 270;
            this.Progressbar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.Progressbar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.Progressbar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.Progressbar1.SubscriptText = "";
            this.Progressbar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.Progressbar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.Progressbar1.SuperscriptText = "";
            this.Progressbar1.TabIndex = 0;
            this.Progressbar1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.Progressbar1.Value = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(17, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pharmacy";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(2, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 74);
            this.label2.TabIndex = 2;
            this.label2.Text = "Copyright ©AYAT,NOOR,AZIZ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(276, 472);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Progressbar1);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CircularProgressBar.CircularProgressBar Progressbar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}

