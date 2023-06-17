namespace HavuzRezervasyon.UI
{
    partial class FrmAnaSayfa
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
            this.dgRezervasyon = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnListele = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbHavuz = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtGiris = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnMusEkle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.dtRezGiris = new System.Windows.Forms.DateTimePicker();
            this.cbMusteri = new System.Windows.Forms.ComboBox();
            this.dtGunluk = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRezervasyon)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGunluk)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgRezervasyon);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(613, 517);
            this.panel1.TabIndex = 0;
            // 
            // dgRezervasyon
            // 
            this.dgRezervasyon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRezervasyon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgRezervasyon.Location = new System.Drawing.Point(0, 133);
            this.dgRezervasyon.Name = "dgRezervasyon";
            this.dgRezervasyon.RowHeadersWidth = 51;
            this.dgRezervasyon.RowTemplate.Height = 24;
            this.dgRezervasyon.Size = new System.Drawing.Size(613, 384);
            this.dgRezervasyon.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnListele);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cbHavuz);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dtGiris);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(613, 133);
            this.panel2.TabIndex = 0;
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.Maroon;
            this.btnListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F, System.Drawing.FontStyle.Bold);
            this.btnListele.ForeColor = System.Drawing.SystemColors.Control;
            this.btnListele.Location = new System.Drawing.Point(337, 87);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(91, 40);
            this.btnListele.TabIndex = 167;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(18, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 166;
            this.label2.Text = "Havuz :";
            // 
            // cbHavuz
            // 
            this.cbHavuz.FormattingEnabled = true;
            this.cbHavuz.Location = new System.Drawing.Point(98, 57);
            this.cbHavuz.Name = "cbHavuz";
            this.cbHavuz.Size = new System.Drawing.Size(330, 24);
            this.cbHavuz.TabIndex = 165;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(27, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 164;
            this.label1.Text = "Tarih :";
            // 
            // dtGiris
            // 
            this.dtGiris.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.dtGiris.Location = new System.Drawing.Point(98, 19);
            this.dtGiris.Margin = new System.Windows.Forms.Padding(4);
            this.dtGiris.Name = "dtGiris";
            this.dtGiris.Size = new System.Drawing.Size(330, 26);
            this.dtGiris.TabIndex = 163;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnMusEkle);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btnKaydet);
            this.panel3.Controls.Add(this.dtRezGiris);
            this.panel3.Controls.Add(this.cbMusteri);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(613, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(542, 133);
            this.panel3.TabIndex = 1;
            // 
            // btnMusEkle
            // 
            this.btnMusEkle.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnMusEkle.Location = new System.Drawing.Point(476, 19);
            this.btnMusEkle.Name = "btnMusEkle";
            this.btnMusEkle.Size = new System.Drawing.Size(30, 23);
            this.btnMusEkle.TabIndex = 171;
            this.btnMusEkle.Text = "+";
            this.btnMusEkle.UseVisualStyleBackColor = false;
            this.btnMusEkle.Click += new System.EventHandler(this.btnMusEkle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(22, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 170;
            this.label4.Text = "Rez. Tarih:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(22, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 169;
            this.label3.Text = "Müşteri :";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.SystemColors.Control;
            this.btnKaydet.Location = new System.Drawing.Point(378, 90);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(91, 40);
            this.btnKaydet.TabIndex = 168;
            this.btnKaydet.Text = "Oluştur";
            this.btnKaydet.UseVisualStyleBackColor = false;
            // 
            // dtRezGiris
            // 
            this.dtRezGiris.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtRezGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.dtRezGiris.Location = new System.Drawing.Point(117, 57);
            this.dtRezGiris.Margin = new System.Windows.Forms.Padding(4);
            this.dtRezGiris.Name = "dtRezGiris";
            this.dtRezGiris.Size = new System.Drawing.Size(352, 26);
            this.dtRezGiris.TabIndex = 164;
            // 
            // cbMusteri
            // 
            this.cbMusteri.FormattingEnabled = true;
            this.cbMusteri.Location = new System.Drawing.Point(117, 19);
            this.cbMusteri.Name = "cbMusteri";
            this.cbMusteri.Size = new System.Drawing.Size(352, 24);
            this.cbMusteri.TabIndex = 0;
            // 
            // dtGunluk
            // 
            this.dtGunluk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGunluk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGunluk.Location = new System.Drawing.Point(613, 133);
            this.dtGunluk.Name = "dtGunluk";
            this.dtGunluk.RowHeadersWidth = 51;
            this.dtGunluk.RowTemplate.Height = 24;
            this.dtGunluk.Size = new System.Drawing.Size(542, 384);
            this.dtGunluk.TabIndex = 2;
            // 
            // FrmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 517);
            this.Controls.Add(this.dtGunluk);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "FrmAnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.FrmAnaSayfa_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgRezervasyon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGunluk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgRezervasyon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtGiris;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbHavuz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtGunluk;
        private System.Windows.Forms.ComboBox cbMusteri;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DateTimePicker dtRezGiris;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMusEkle;
    }
}