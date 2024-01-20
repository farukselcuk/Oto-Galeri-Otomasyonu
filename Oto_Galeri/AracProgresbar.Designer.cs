namespace Oto_Galeri
{
    partial class AracProgresbar
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
            this.lblsayı = new System.Windows.Forms.Label();
            this.lblsaniye = new System.Windows.Forms.Label();
            this.lblkaydediliyor = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblsayı
            // 
            this.lblsayı.AutoSize = true;
            this.lblsayı.Enabled = false;
            this.lblsayı.Location = new System.Drawing.Point(474, 104);
            this.lblsayı.Name = "lblsayı";
            this.lblsayı.Size = new System.Drawing.Size(20, 17);
            this.lblsayı.TabIndex = 7;
            this.lblsayı.Text = "...";
            // 
            // lblsaniye
            // 
            this.lblsaniye.AutoSize = true;
            this.lblsaniye.Enabled = false;
            this.lblsaniye.Location = new System.Drawing.Point(419, 104);
            this.lblsaniye.Name = "lblsaniye";
            this.lblsaniye.Size = new System.Drawing.Size(49, 17);
            this.lblsaniye.TabIndex = 6;
            this.lblsaniye.Text = "saniye";
            // 
            // lblkaydediliyor
            // 
            this.lblkaydediliyor.AutoSize = true;
            this.lblkaydediliyor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkaydediliyor.Location = new System.Drawing.Point(179, 92);
            this.lblkaydediliyor.Name = "lblkaydediliyor";
            this.lblkaydediliyor.Size = new System.Drawing.Size(164, 29);
            this.lblkaydediliyor.TabIndex = 5;
            this.lblkaydediliyor.Text = "Kaydediliyor...";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(60, 40);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(408, 37);
            this.progressBar1.Step = 25;
            this.progressBar1.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AracProgresbar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(530, 137);
            this.Controls.Add(this.lblsayı);
            this.Controls.Add(this.lblsaniye);
            this.Controls.Add(this.lblkaydediliyor);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AracProgresbar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblsayı;
        private System.Windows.Forms.Label lblsaniye;
        private System.Windows.Forms.Label lblkaydediliyor;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
    }
}