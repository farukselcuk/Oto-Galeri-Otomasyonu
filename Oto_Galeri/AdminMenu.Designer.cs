namespace Oto_Galeri
{
    partial class AdminMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMenu));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ımageList3 = new System.Windows.Forms.ImageList(this.components);
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.btnAracEkranı = new System.Windows.Forms.Button();
            this.btnMusEkran = new System.Windows.Forms.Button();
            this.pctBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctBack)).BeginInit();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "back.png");
            // 
            // ımageList3
            // 
            this.ımageList3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList3.ImageStream")));
            this.ımageList3.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList3.Images.SetKeyName(0, "sedan.png");
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "people.png");
            // 
            // btnAracEkranı
            // 
            this.btnAracEkranı.BackColor = System.Drawing.Color.White;
            this.btnAracEkranı.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAracEkranı.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAracEkranı.ImageKey = "sedan.png";
            this.btnAracEkranı.ImageList = this.ımageList3;
            this.btnAracEkranı.Location = new System.Drawing.Point(223, 87);
            this.btnAracEkranı.Name = "btnAracEkranı";
            this.btnAracEkranı.Size = new System.Drawing.Size(195, 91);
            this.btnAracEkranı.TabIndex = 7;
            this.btnAracEkranı.Text = "Araç Ekranı";
            this.btnAracEkranı.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAracEkranı.UseVisualStyleBackColor = false;
            this.btnAracEkranı.Click += new System.EventHandler(this.btnAracEkranı_Click);
            // 
            // btnMusEkran
            // 
            this.btnMusEkran.BackColor = System.Drawing.Color.White;
            this.btnMusEkran.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusEkran.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMusEkran.ImageKey = "people.png";
            this.btnMusEkran.ImageList = this.ımageList2;
            this.btnMusEkran.Location = new System.Drawing.Point(690, 87);
            this.btnMusEkran.Name = "btnMusEkran";
            this.btnMusEkran.Size = new System.Drawing.Size(195, 91);
            this.btnMusEkran.TabIndex = 8;
            this.btnMusEkran.Text = "Müşteri Ekranı";
            this.btnMusEkran.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMusEkran.UseVisualStyleBackColor = false;
            this.btnMusEkran.Click += new System.EventHandler(this.btnMusEkran_Click);
            // 
            // pctBack
            // 
            this.pctBack.BackColor = System.Drawing.Color.White;
            this.pctBack.Image = ((System.Drawing.Image)(resources.GetObject("pctBack.Image")));
            this.pctBack.Location = new System.Drawing.Point(12, 12);
            this.pctBack.Name = "pctBack";
            this.pctBack.Size = new System.Drawing.Size(50, 43);
            this.pctBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBack.TabIndex = 10;
            this.pctBack.TabStop = false;
            this.pctBack.Click += new System.EventHandler(this.pctBack_Click);
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1025, 584);
            this.Controls.Add(this.pctBack);
            this.Controls.Add(this.btnMusEkran);
            this.Controls.Add(this.btnAracEkranı);
            this.Name = "AdminMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ImageList ımageList3;
        private System.Windows.Forms.ImageList ımageList2;
        private System.Windows.Forms.Button btnAracEkranı;
        private System.Windows.Forms.Button btnMusEkran;
        private System.Windows.Forms.PictureBox pctBack;
    }
}