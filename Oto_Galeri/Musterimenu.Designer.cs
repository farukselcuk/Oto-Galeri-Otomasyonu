namespace Oto_Galeri
{
    partial class Musterimenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Musterimenu));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.btnborc = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ımageList3 = new System.Windows.Forms.ImageList(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.btnlist = new System.Windows.Forms.Button();
            this.dgwBorc = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBorc)).BeginInit();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "back-button.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 3;
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "salary.png");
            this.ımageList2.Images.SetKeyName(1, "checklist (2).png");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(690, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Borç Görüntüle";
            // 
            // btnborc
            // 
            this.btnborc.BackColor = System.Drawing.Color.Transparent;
            this.btnborc.ForeColor = System.Drawing.Color.Snow;
            this.btnborc.ImageKey = "salary.png";
            this.btnborc.ImageList = this.ımageList2;
            this.btnborc.Location = new System.Drawing.Point(695, 12);
            this.btnborc.Name = "btnborc";
            this.btnborc.Size = new System.Drawing.Size(123, 70);
            this.btnborc.TabIndex = 11;
            this.btnborc.UseVisualStyleBackColor = false;
            this.btnborc.Click += new System.EventHandler(this.btnborc_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.ImageKey = "back-button.png";
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(21, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 39);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1030, 385);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.Visible = false;
            // 
            // ımageList3
            // 
            this.ımageList3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList3.ImageStream")));
            this.ımageList3.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList3.Images.SetKeyName(0, "BMW.jpg");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(189, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Araç Listele";
            // 
            // btnlist
            // 
            this.btnlist.BackColor = System.Drawing.Color.Transparent;
            this.btnlist.ForeColor = System.Drawing.Color.Snow;
            this.btnlist.ImageKey = "checklist (2).png";
            this.btnlist.ImageList = this.ımageList2;
            this.btnlist.Location = new System.Drawing.Point(185, 12);
            this.btnlist.Name = "btnlist";
            this.btnlist.Size = new System.Drawing.Size(130, 70);
            this.btnlist.TabIndex = 14;
            this.btnlist.UseVisualStyleBackColor = false;
            this.btnlist.Click += new System.EventHandler(this.btnlist_Click);
            // 
            // dgwBorc
            // 
            this.dgwBorc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBorc.Location = new System.Drawing.Point(30, 152);
            this.dgwBorc.Name = "dgwBorc";
            this.dgwBorc.RowTemplate.Height = 24;
            this.dgwBorc.Size = new System.Drawing.Size(1030, 385);
            this.dgwBorc.TabIndex = 16;
            this.dgwBorc.Visible = false;
            // 
            // Musterimenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1005, 549);
            this.Controls.Add(this.dgwBorc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnlist);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnborc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Musterimenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBorc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList ımageList2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnborc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ImageList ımageList3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnlist;
        private System.Windows.Forms.DataGridView dgwBorc;
    }
}