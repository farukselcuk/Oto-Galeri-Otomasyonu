namespace Oto_Galeri
{
    partial class AdminMusteriMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMusteriMenu));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
            this.btnCostAdd = new System.Windows.Forms.Button();
            this.btnCostDelete = new System.Windows.Forms.Button();
            this.btnCostList = new System.Windows.Forms.Button();
            this.btnKalanBorc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "unhappy.png");
            this.ımageList1.Images.SetKeyName(1, "checklist.png");
            this.ımageList1.Images.SetKeyName(2, "shortlist.png");
            this.ımageList1.Images.SetKeyName(3, "salary.png");
            this.ımageList1.Images.SetKeyName(4, "public-relation.png");
            this.ımageList1.Images.SetKeyName(5, "customer.png");
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "back-button.png");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(848, 549);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(33, 477);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 24);
            this.label5.TabIndex = 22;
            this.label5.Text = "Kalan Borç";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(465, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "Müşteri Silme";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(629, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = " Müşteri Listeleme";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(271, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Müşteri Ekleme";
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Transparent;
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnback.ImageKey = "back-button.png";
            this.btnback.ImageList = this.ımageList2;
            this.btnback.Location = new System.Drawing.Point(12, 12);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(42, 33);
            this.btnback.TabIndex = 16;
            this.btnback.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnCostAdd
            // 
            this.btnCostAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnCostAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCostAdd.ImageKey = "customer.png";
            this.btnCostAdd.ImageList = this.ımageList1;
            this.btnCostAdd.Location = new System.Drawing.Point(295, 12);
            this.btnCostAdd.Name = "btnCostAdd";
            this.btnCostAdd.Size = new System.Drawing.Size(102, 69);
            this.btnCostAdd.TabIndex = 23;
            this.btnCostAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCostAdd.UseVisualStyleBackColor = false;
            this.btnCostAdd.Click += new System.EventHandler(this.btnCostAdd_Click);
            // 
            // btnCostDelete
            // 
            this.btnCostDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnCostDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCostDelete.ImageKey = "unhappy.png";
            this.btnCostDelete.ImageList = this.ımageList1;
            this.btnCostDelete.Location = new System.Drawing.Point(469, 12);
            this.btnCostDelete.Name = "btnCostDelete";
            this.btnCostDelete.Size = new System.Drawing.Size(108, 69);
            this.btnCostDelete.TabIndex = 24;
            this.btnCostDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCostDelete.UseVisualStyleBackColor = false;
            this.btnCostDelete.Click += new System.EventHandler(this.btnCostDelete_Click);
            // 
            // btnCostList
            // 
            this.btnCostList.BackColor = System.Drawing.Color.Transparent;
            this.btnCostList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCostList.ImageKey = "shortlist.png";
            this.btnCostList.ImageList = this.ımageList1;
            this.btnCostList.Location = new System.Drawing.Point(655, 12);
            this.btnCostList.Name = "btnCostList";
            this.btnCostList.Size = new System.Drawing.Size(101, 69);
            this.btnCostList.TabIndex = 25;
            this.btnCostList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCostList.UseVisualStyleBackColor = false;
            this.btnCostList.Click += new System.EventHandler(this.btnCostList_Click);
            // 
            // btnKalanBorc
            // 
            this.btnKalanBorc.BackColor = System.Drawing.Color.Transparent;
            this.btnKalanBorc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKalanBorc.ImageKey = "salary.png";
            this.btnKalanBorc.ImageList = this.ımageList1;
            this.btnKalanBorc.Location = new System.Drawing.Point(31, 387);
            this.btnKalanBorc.Name = "btnKalanBorc";
            this.btnKalanBorc.Size = new System.Drawing.Size(103, 69);
            this.btnKalanBorc.TabIndex = 26;
            this.btnKalanBorc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKalanBorc.UseVisualStyleBackColor = false;
            this.btnKalanBorc.Click += new System.EventHandler(this.btnKalanBorc_Click);
            // 
            // AdminMusteriMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(845, 549);
            this.Controls.Add(this.btnKalanBorc);
            this.Controls.Add(this.btnCostList);
            this.Controls.Add(this.btnCostDelete);
            this.Controls.Add(this.btnCostAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "AdminMusteriMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Sayfası";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ImageList ımageList2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnCostAdd;
        private System.Windows.Forms.Button btnCostDelete;
        private System.Windows.Forms.Button btnCostList;
        private System.Windows.Forms.Button btnKalanBorc;
    }
}