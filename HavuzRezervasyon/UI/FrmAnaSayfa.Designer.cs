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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnIptal = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGiris = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnListele = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtGiris = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnMusteriYenile = new System.Windows.Forms.Button();
            this.cbRezHavuz = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnMusEkle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.dtRezGiris = new System.Windows.Forms.DateTimePicker();
            this.cbMusteri = new System.Windows.Forms.ComboBox();
            this.dgGunluk = new System.Windows.Forms.DataGridView();
            this.dgRezervasyon = new System.Windows.Forms.DataGridView();
            this.musteriIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.girisTarihiDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cikisTarihiDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucretDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.havuzIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adSoyadDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.havuzAdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblRezervasyonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RezerveId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CikisTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MusteriId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GirisTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HavuzId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.havuzAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgGunluk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRezervasyon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRezervasyonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgRezervasyon);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(993, 678);
            this.panel1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnIptal,
            this.btnCikis,
            this.btnGiris});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(145, 76);
            // 
            // btnIptal
            // 
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(144, 24);
            this.btnIptal.Text = "İptal Et";
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(144, 24);
            this.btnCikis.Text = "Çıkış Ver";
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnGiris
            // 
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(144, 24);
            this.btnGiris.Text = "Giriş Yaptı";
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnListele);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dtGiris);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(993, 193);
            this.panel2.TabIndex = 0;
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.Maroon;
            this.btnListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F, System.Drawing.FontStyle.Bold);
            this.btnListele.ForeColor = System.Drawing.SystemColors.Control;
            this.btnListele.Location = new System.Drawing.Point(337, 63);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(91, 40);
            this.btnListele.TabIndex = 167;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
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
            this.panel3.Controls.Add(this.btnMusteriYenile);
            this.panel3.Controls.Add(this.cbRezHavuz);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.btnMusEkle);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btnKaydet);
            this.panel3.Controls.Add(this.dtRezGiris);
            this.panel3.Controls.Add(this.cbMusteri);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(993, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(606, 193);
            this.panel3.TabIndex = 1;
            // 
            // btnMusteriYenile
            // 
            this.btnMusteriYenile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMusteriYenile.Location = new System.Drawing.Point(512, 20);
            this.btnMusteriYenile.Name = "btnMusteriYenile";
            this.btnMusteriYenile.Size = new System.Drawing.Size(30, 23);
            this.btnMusteriYenile.TabIndex = 174;
            this.btnMusteriYenile.Text = " ▷";
            this.btnMusteriYenile.UseVisualStyleBackColor = false;
            this.btnMusteriYenile.Click += new System.EventHandler(this.btnMusteriYenile_Click);
            // 
            // cbRezHavuz
            // 
            this.cbRezHavuz.FormattingEnabled = true;
            this.cbRezHavuz.Location = new System.Drawing.Point(117, 103);
            this.cbRezHavuz.Name = "cbRezHavuz";
            this.cbRezHavuz.Size = new System.Drawing.Size(352, 24);
            this.cbRezHavuz.TabIndex = 173;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(22, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 172;
            this.label5.Text = "Havuz:";
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
            this.label3.Location = new System.Drawing.Point(22, 19);
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
            this.btnKaydet.Location = new System.Drawing.Point(415, 133);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(91, 40);
            this.btnKaydet.TabIndex = 168;
            this.btnKaydet.Text = "Oluştur";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // dtRezGiris
            // 
            this.dtRezGiris.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtRezGiris.CustomFormat = "hh: mm: ss";
            this.dtRezGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.dtRezGiris.Location = new System.Drawing.Point(117, 56);
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
            // dgGunluk
            // 
            this.dgGunluk.AutoGenerateColumns = false;
            this.dgGunluk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGunluk.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.musteriIdDataGridViewTextBoxColumn1,
            this.girisTarihiDataGridViewTextBoxColumn1,
            this.cikisTarihiDataGridViewTextBoxColumn1,
            this.ucretDataGridViewTextBoxColumn1,
            this.havuzIdDataGridViewTextBoxColumn1,
            this.adSoyadDataGridViewTextBoxColumn1,
            this.havuzAdDataGridViewTextBoxColumn1});
            this.dgGunluk.DataSource = this.tblRezervasyonBindingSource;
            this.dgGunluk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgGunluk.Location = new System.Drawing.Point(993, 193);
            this.dgGunluk.Name = "dgGunluk";
            this.dgGunluk.RowHeadersWidth = 51;
            this.dgGunluk.RowTemplate.Height = 24;
            this.dgGunluk.Size = new System.Drawing.Size(606, 485);
            this.dgGunluk.TabIndex = 2;
            // 
            // dgRezervasyon
            // 
            this.dgRezervasyon.AutoGenerateColumns = false;
            this.dgRezervasyon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRezervasyon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RezerveId,
            this.CikisTarihi,
            this.MusteriId,
            this.GirisTarihi,
            this.ucretDataGridViewTextBoxColumn,
            this.adSoyadDataGridViewTextBoxColumn,
            this.HavuzId,
            this.havuzAdDataGridViewTextBoxColumn});
            this.dgRezervasyon.ContextMenuStrip = this.contextMenuStrip1;
            this.dgRezervasyon.DataSource = this.tblRezervasyonBindingSource;
            this.dgRezervasyon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgRezervasyon.Location = new System.Drawing.Point(0, 193);
            this.dgRezervasyon.Name = "dgRezervasyon";
            this.dgRezervasyon.RowHeadersWidth = 51;
            this.dgRezervasyon.RowTemplate.Height = 24;
            this.dgRezervasyon.Size = new System.Drawing.Size(993, 485);
            this.dgRezervasyon.TabIndex = 1;
            // 
            // musteriIdDataGridViewTextBoxColumn1
            // 
            this.musteriIdDataGridViewTextBoxColumn1.DataPropertyName = "MusteriId";
            this.musteriIdDataGridViewTextBoxColumn1.HeaderText = "MusteriId";
            this.musteriIdDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.musteriIdDataGridViewTextBoxColumn1.Name = "musteriIdDataGridViewTextBoxColumn1";
            this.musteriIdDataGridViewTextBoxColumn1.Visible = false;
            this.musteriIdDataGridViewTextBoxColumn1.Width = 125;
            // 
            // girisTarihiDataGridViewTextBoxColumn1
            // 
            this.girisTarihiDataGridViewTextBoxColumn1.DataPropertyName = "GirisTarihi";
            this.girisTarihiDataGridViewTextBoxColumn1.HeaderText = "GirisTarihi";
            this.girisTarihiDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.girisTarihiDataGridViewTextBoxColumn1.Name = "girisTarihiDataGridViewTextBoxColumn1";
            this.girisTarihiDataGridViewTextBoxColumn1.Width = 125;
            // 
            // cikisTarihiDataGridViewTextBoxColumn1
            // 
            this.cikisTarihiDataGridViewTextBoxColumn1.DataPropertyName = "CikisTarihi";
            this.cikisTarihiDataGridViewTextBoxColumn1.HeaderText = "CikisTarihi";
            this.cikisTarihiDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.cikisTarihiDataGridViewTextBoxColumn1.Name = "cikisTarihiDataGridViewTextBoxColumn1";
            this.cikisTarihiDataGridViewTextBoxColumn1.Visible = false;
            this.cikisTarihiDataGridViewTextBoxColumn1.Width = 125;
            // 
            // ucretDataGridViewTextBoxColumn1
            // 
            this.ucretDataGridViewTextBoxColumn1.DataPropertyName = "Ucret";
            this.ucretDataGridViewTextBoxColumn1.HeaderText = "Ucret";
            this.ucretDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.ucretDataGridViewTextBoxColumn1.Name = "ucretDataGridViewTextBoxColumn1";
            this.ucretDataGridViewTextBoxColumn1.Visible = false;
            this.ucretDataGridViewTextBoxColumn1.Width = 125;
            // 
            // havuzIdDataGridViewTextBoxColumn1
            // 
            this.havuzIdDataGridViewTextBoxColumn1.DataPropertyName = "HavuzId";
            this.havuzIdDataGridViewTextBoxColumn1.HeaderText = "HavuzId";
            this.havuzIdDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.havuzIdDataGridViewTextBoxColumn1.Name = "havuzIdDataGridViewTextBoxColumn1";
            this.havuzIdDataGridViewTextBoxColumn1.Visible = false;
            this.havuzIdDataGridViewTextBoxColumn1.Width = 125;
            // 
            // adSoyadDataGridViewTextBoxColumn1
            // 
            this.adSoyadDataGridViewTextBoxColumn1.DataPropertyName = "AdSoyad";
            this.adSoyadDataGridViewTextBoxColumn1.HeaderText = "AdSoyad";
            this.adSoyadDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.adSoyadDataGridViewTextBoxColumn1.Name = "adSoyadDataGridViewTextBoxColumn1";
            this.adSoyadDataGridViewTextBoxColumn1.Width = 125;
            // 
            // havuzAdDataGridViewTextBoxColumn1
            // 
            this.havuzAdDataGridViewTextBoxColumn1.DataPropertyName = "HavuzAd";
            this.havuzAdDataGridViewTextBoxColumn1.HeaderText = "HavuzAd";
            this.havuzAdDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.havuzAdDataGridViewTextBoxColumn1.Name = "havuzAdDataGridViewTextBoxColumn1";
            this.havuzAdDataGridViewTextBoxColumn1.Width = 125;
            // 
            // tblRezervasyonBindingSource
            // 
            this.tblRezervasyonBindingSource.DataSource = typeof(HavuzRezervasyon.Entities.tblRezervasyon);
            // 
            // RezerveId
            // 
            this.RezerveId.DataPropertyName = "RezerveId";
            this.RezerveId.HeaderText = "Id";
            this.RezerveId.MinimumWidth = 6;
            this.RezerveId.Name = "RezerveId";
            this.RezerveId.ReadOnly = true;
            this.RezerveId.Width = 125;
            // 
            // CikisTarihi
            // 
            this.CikisTarihi.DataPropertyName = "CikisTarihi";
            this.CikisTarihi.HeaderText = "CikisTarihi";
            this.CikisTarihi.MinimumWidth = 6;
            this.CikisTarihi.Name = "CikisTarihi";
            this.CikisTarihi.Width = 125;
            // 
            // MusteriId
            // 
            this.MusteriId.DataPropertyName = "MusteriId";
            this.MusteriId.HeaderText = "MusteriId";
            this.MusteriId.MinimumWidth = 6;
            this.MusteriId.Name = "MusteriId";
            this.MusteriId.ReadOnly = true;
            this.MusteriId.Width = 125;
            // 
            // GirisTarihi
            // 
            this.GirisTarihi.DataPropertyName = "GirisTarihi";
            this.GirisTarihi.HeaderText = "GirisTarihi";
            this.GirisTarihi.MinimumWidth = 6;
            this.GirisTarihi.Name = "GirisTarihi";
            this.GirisTarihi.ReadOnly = true;
            this.GirisTarihi.Width = 125;
            // 
            // ucretDataGridViewTextBoxColumn
            // 
            this.ucretDataGridViewTextBoxColumn.DataPropertyName = "Ucret";
            this.ucretDataGridViewTextBoxColumn.HeaderText = "Ucret";
            this.ucretDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ucretDataGridViewTextBoxColumn.Name = "ucretDataGridViewTextBoxColumn";
            this.ucretDataGridViewTextBoxColumn.Width = 125;
            // 
            // adSoyadDataGridViewTextBoxColumn
            // 
            this.adSoyadDataGridViewTextBoxColumn.DataPropertyName = "AdSoyad";
            this.adSoyadDataGridViewTextBoxColumn.HeaderText = "AdSoyad";
            this.adSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adSoyadDataGridViewTextBoxColumn.Name = "adSoyadDataGridViewTextBoxColumn";
            this.adSoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // HavuzId
            // 
            this.HavuzId.DataPropertyName = "HavuzId";
            this.HavuzId.HeaderText = "HavuzId";
            this.HavuzId.MinimumWidth = 6;
            this.HavuzId.Name = "HavuzId";
            this.HavuzId.ReadOnly = true;
            this.HavuzId.Visible = false;
            this.HavuzId.Width = 125;
            // 
            // havuzAdDataGridViewTextBoxColumn
            // 
            this.havuzAdDataGridViewTextBoxColumn.DataPropertyName = "HavuzAd";
            this.havuzAdDataGridViewTextBoxColumn.HeaderText = "HavuzAd";
            this.havuzAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.havuzAdDataGridViewTextBoxColumn.Name = "havuzAdDataGridViewTextBoxColumn";
            this.havuzAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // FrmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1599, 678);
            this.Controls.Add(this.dgGunluk);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "FrmAnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.FrmAnaSayfa_Load);
            this.panel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgGunluk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRezervasyon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRezervasyonBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtGiris;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgGunluk;
        private System.Windows.Forms.ComboBox cbMusteri;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DateTimePicker dtRezGiris;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMusEkle;
        private System.Windows.Forms.ComboBox cbRezHavuz;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn RezerveIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tblRezervasyonBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn RezerveIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn girisTarihiDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cikisTarihiDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ucretDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn havuzIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn adSoyadDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn havuzAdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button btnMusteriYenile;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnIptal;
        private System.Windows.Forms.ToolStripMenuItem btnCikis;
        private System.Windows.Forms.ToolStripMenuItem btnGiris;
        private System.Windows.Forms.DataGridView dgRezervasyon;
        private System.Windows.Forms.DataGridViewTextBoxColumn RezerveId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CikisTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MusteriId;
        private System.Windows.Forms.DataGridViewTextBoxColumn GirisTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ucretDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn HavuzId;
        private System.Windows.Forms.DataGridViewTextBoxColumn havuzAdDataGridViewTextBoxColumn;
    }
}