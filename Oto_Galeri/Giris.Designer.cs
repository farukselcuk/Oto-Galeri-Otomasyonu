namespace Oto_Galeri
{
    partial class Giris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this.panel1 = new System.Windows.Forms.Panel();
            this.linklsifreunuttum = new System.Windows.Forms.LinkLabel();
            this.pbeye = new System.Windows.Forms.PictureBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblsifre = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblAdminAd = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnMusteri = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbeye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.linklsifreunuttum);
            this.panel1.Controls.Add(this.pbeye);
            this.panel1.Controls.Add(this.btnGiris);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.lblsifre);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.lblAdminAd);
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(97, 105);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 323);
            this.panel1.TabIndex = 23;
            // 
            // linklsifreunuttum
            // 
            this.linklsifreunuttum.AutoSize = true;
            this.linklsifreunuttum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.linklsifreunuttum.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.linklsifreunuttum.Location = new System.Drawing.Point(191, 180);
            this.linklsifreunuttum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linklsifreunuttum.Name = "linklsifreunuttum";
            this.linklsifreunuttum.Size = new System.Drawing.Size(125, 20);
            this.linklsifreunuttum.TabIndex = 30;
            this.linklsifreunuttum.TabStop = true;
            this.linklsifreunuttum.Text = "ŞifremiUnuttum";
            this.linklsifreunuttum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklsifreunuttum_LinkClicked);
            // 
            // pbeye
            // 
            this.pbeye.BackColor = System.Drawing.Color.White;
            this.pbeye.Image = ((System.Drawing.Image)(resources.GetObject("pbeye.Image")));
            this.pbeye.Location = new System.Drawing.Point(287, 122);
            this.pbeye.Name = "pbeye";
            this.pbeye.Size = new System.Drawing.Size(29, 27);
            this.pbeye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbeye.TabIndex = 29;
            this.pbeye.TabStop = false;
            this.pbeye.Click += new System.EventHandler(this.pbeye_Click);
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.White;
            this.btnGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.ForeColor = System.Drawing.Color.Black;
            this.btnGiris.Location = new System.Drawing.Point(118, 232);
            this.btnGiris.Margin = new System.Windows.Forms.Padding(2);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(134, 55);
            this.btnGiris.TabIndex = 25;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBox2.Location = new System.Drawing.Point(127, 122);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(155, 34);
            this.textBox2.TabIndex = 22;
            // 
            // lblsifre
            // 
            this.lblsifre.AutoSize = true;
            this.lblsifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsifre.Location = new System.Drawing.Point(55, 122);
            this.lblsifre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsifre.Name = "lblsifre";
            this.lblsifre.Size = new System.Drawing.Size(68, 25);
            this.lblsifre.TabIndex = 21;
            this.lblsifre.Text = "Şifre : ";
            this.lblsifre.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBox1.Location = new System.Drawing.Point(127, 84);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 34);
            this.textBox1.TabIndex = 20;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblAdminAd
            // 
            this.lblAdminAd.AutoSize = true;
            this.lblAdminAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdminAd.Location = new System.Drawing.Point(5, 90);
            this.lblAdminAd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdminAd.Name = "lblAdminAd";
            this.lblAdminAd.Size = new System.Drawing.Size(113, 25);
            this.lblAdminAd.TabIndex = 19;
            this.lblAdminAd.Text = "Admin Adı :";
            this.lblAdminAd.Click += new System.EventHandler(this.lblAdminAd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(845, 549);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.White;
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdmin.Location = new System.Drawing.Point(45, 28);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(128, 55);
            this.btnAdmin.TabIndex = 26;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnMusteri
            // 
            this.btnMusteri.BackColor = System.Drawing.Color.White;
            this.btnMusteri.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteri.Location = new System.Drawing.Point(359, 28);
            this.btnMusteri.Margin = new System.Windows.Forms.Padding(2);
            this.btnMusteri.Name = "btnMusteri";
            this.btnMusteri.Size = new System.Drawing.Size(131, 55);
            this.btnMusteri.TabIndex = 27;
            this.btnMusteri.Text = "Müşteri";
            this.btnMusteri.UseVisualStyleBackColor = false;
            this.btnMusteri.Click += new System.EventHandler(this.btnMusteri_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "eye-scanner.png");
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(845, 549);
            this.Controls.Add(this.btnMusteri);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbeye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblsifre;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblAdminAd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnMusteri;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.PictureBox pbeye;
        private System.Windows.Forms.LinkLabel linklsifreunuttum;
    }
}

