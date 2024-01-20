namespace Oto_Galeri
{
    partial class TaksitveBorc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaksitveBorc));
            this.lblTaksit = new System.Windows.Forms.Label();
            this.tbtaksit = new System.Windows.Forms.TextBox();
            this.tbAracTutari = new System.Windows.Forms.TextBox();
            this.lblAractutari = new System.Windows.Forms.Label();
            this.btnTaksitle = new System.Windows.Forms.Button();
            this.lblAylık = new System.Windows.Forms.Label();
            this.lblAylıktutar = new System.Windows.Forms.Label();
            this.btnOde = new System.Windows.Forms.Button();
            this.tbBorcTc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbOdenecek = new System.Windows.Forms.TextBox();
            this.tbTC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblkalanSayi = new System.Windows.Forms.Label();
            this.lblKalan = new System.Windows.Forms.Label();
            this.pbBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTaksit
            // 
            this.lblTaksit.AutoSize = true;
            this.lblTaksit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTaksit.Location = new System.Drawing.Point(35, 76);
            this.lblTaksit.Name = "lblTaksit";
            this.lblTaksit.Size = new System.Drawing.Size(121, 24);
            this.lblTaksit.TabIndex = 0;
            this.lblTaksit.Text = "Taksit Sayısı :";
            // 
            // tbtaksit
            // 
            this.tbtaksit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbtaksit.Location = new System.Drawing.Point(219, 72);
            this.tbtaksit.Name = "tbtaksit";
            this.tbtaksit.Size = new System.Drawing.Size(139, 28);
            this.tbtaksit.TabIndex = 1;
            // 
            // tbAracTutari
            // 
            this.tbAracTutari.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbAracTutari.Location = new System.Drawing.Point(219, 122);
            this.tbAracTutari.Name = "tbAracTutari";
            this.tbAracTutari.Size = new System.Drawing.Size(139, 28);
            this.tbAracTutari.TabIndex = 3;
            // 
            // lblAractutari
            // 
            this.lblAractutari.AutoSize = true;
            this.lblAractutari.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAractutari.Location = new System.Drawing.Point(45, 125);
            this.lblAractutari.Name = "lblAractutari";
            this.lblAractutari.Size = new System.Drawing.Size(111, 24);
            this.lblAractutari.TabIndex = 2;
            this.lblAractutari.Text = "Arac Tutarı :";
            // 
            // btnTaksitle
            // 
            this.btnTaksitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTaksitle.Location = new System.Drawing.Point(126, 228);
            this.btnTaksitle.Name = "btnTaksitle";
            this.btnTaksitle.Size = new System.Drawing.Size(134, 50);
            this.btnTaksitle.TabIndex = 4;
            this.btnTaksitle.Text = "Taksitle";
            this.btnTaksitle.UseVisualStyleBackColor = true;
            this.btnTaksitle.Click += new System.EventHandler(this.btnTaksitle_Click);
            // 
            // lblAylık
            // 
            this.lblAylık.AutoSize = true;
            this.lblAylık.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAylık.Location = new System.Drawing.Point(35, 172);
            this.lblAylık.Name = "lblAylık";
            this.lblAylık.Size = new System.Drawing.Size(201, 24);
            this.lblAylık.TabIndex = 5;
            this.lblAylık.Text = "Aylık Ödenecek Tutar :";
            // 
            // lblAylıktutar
            // 
            this.lblAylıktutar.AutoSize = true;
            this.lblAylıktutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAylıktutar.Location = new System.Drawing.Point(296, 172);
            this.lblAylıktutar.Name = "lblAylıktutar";
            this.lblAylıktutar.Size = new System.Drawing.Size(25, 24);
            this.lblAylıktutar.TabIndex = 6;
            this.lblAylıktutar.Text = "...";
            this.lblAylıktutar.Click += new System.EventHandler(this.lblAylıktutar_Click);
            // 
            // btnOde
            // 
            this.btnOde.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOde.Location = new System.Drawing.Point(576, 228);
            this.btnOde.Name = "btnOde";
            this.btnOde.Size = new System.Drawing.Size(134, 50);
            this.btnOde.TabIndex = 7;
            this.btnOde.Text = "Borç Öde";
            this.btnOde.UseVisualStyleBackColor = true;
            this.btnOde.Click += new System.EventHandler(this.btnOde_Click);
            // 
            // tbBorcTc
            // 
            this.tbBorcTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbBorcTc.Location = new System.Drawing.Point(648, 27);
            this.tbBorcTc.Name = "tbBorcTc";
            this.tbBorcTc.Size = new System.Drawing.Size(139, 28);
            this.tbBorcTc.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(435, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ödenecek Tutar :";
            // 
            // tbOdenecek
            // 
            this.tbOdenecek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbOdenecek.Location = new System.Drawing.Point(648, 88);
            this.tbOdenecek.Name = "tbOdenecek";
            this.tbOdenecek.Size = new System.Drawing.Size(139, 28);
            this.tbOdenecek.TabIndex = 13;
            // 
            // tbTC
            // 
            this.tbTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbTC.Location = new System.Drawing.Point(219, 28);
            this.tbTC.Name = "tbTC";
            this.tbTC.Size = new System.Drawing.Size(139, 28);
            this.tbTC.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(61, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "TC :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(547, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "TC :";
            // 
            // lblkalanSayi
            // 
            this.lblkalanSayi.AutoSize = true;
            this.lblkalanSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkalanSayi.Location = new System.Drawing.Point(635, 145);
            this.lblkalanSayi.Name = "lblkalanSayi";
            this.lblkalanSayi.Size = new System.Drawing.Size(25, 24);
            this.lblkalanSayi.TabIndex = 18;
            this.lblkalanSayi.Text = "...";
            // 
            // lblKalan
            // 
            this.lblKalan.AutoSize = true;
            this.lblKalan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKalan.Location = new System.Drawing.Point(485, 145);
            this.lblKalan.Name = "lblKalan";
            this.lblKalan.Size = new System.Drawing.Size(107, 24);
            this.lblKalan.TabIndex = 17;
            this.lblKalan.Text = "Kalan tutar :";
            // 
            // pbBack
            // 
            this.pbBack.BackColor = System.Drawing.Color.White;
            this.pbBack.Image = ((System.Drawing.Image)(resources.GetObject("pbBack.Image")));
            this.pbBack.Location = new System.Drawing.Point(3, 2);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(38, 30);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBack.TabIndex = 19;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click);
            // 
            // TaksitveBorc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(822, 303);
            this.Controls.Add(this.pbBack);
            this.Controls.Add(this.lblkalanSayi);
            this.Controls.Add(this.lblKalan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbTC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbOdenecek);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbBorcTc);
            this.Controls.Add(this.btnOde);
            this.Controls.Add(this.lblAylıktutar);
            this.Controls.Add(this.lblAylık);
            this.Controls.Add(this.btnTaksitle);
            this.Controls.Add(this.tbAracTutari);
            this.Controls.Add(this.lblAractutari);
            this.Controls.Add(this.tbtaksit);
            this.Controls.Add(this.lblTaksit);
            this.Name = "TaksitveBorc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaksitveBorc";
            this.Load += new System.EventHandler(this.TaksitveBorc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTaksit;
        private System.Windows.Forms.TextBox tbtaksit;
        private System.Windows.Forms.TextBox tbAracTutari;
        private System.Windows.Forms.Label lblAractutari;
        private System.Windows.Forms.Button btnTaksitle;
        private System.Windows.Forms.Label lblAylık;
        private System.Windows.Forms.Label lblAylıktutar;
        private System.Windows.Forms.Button btnOde;
        private System.Windows.Forms.TextBox tbBorcTc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbOdenecek;
        private System.Windows.Forms.TextBox tbTC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblkalanSayi;
        private System.Windows.Forms.Label lblKalan;
        private System.Windows.Forms.PictureBox pbBack;
    }
}