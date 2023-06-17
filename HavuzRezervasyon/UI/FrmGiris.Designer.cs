namespace HavuzRezervasyon.UI
{
    partial class FrmGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiris));
            this.picGiris = new System.Windows.Forms.PictureBox();
            this.lblSlogan = new System.Windows.Forms.Label();
            this.giris = new System.Windows.Forms.GroupBox();
            this.txtKulAd = new System.Windows.Forms.TextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picGiris)).BeginInit();
            this.giris.SuspendLayout();
            this.SuspendLayout();
            // 
            // picGiris
            // 
            this.picGiris.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picGiris.Image = ((System.Drawing.Image)(resources.GetObject("picGiris.Image")));
            this.picGiris.Location = new System.Drawing.Point(178, 14);
            this.picGiris.Margin = new System.Windows.Forms.Padding(5);
            this.picGiris.Name = "picGiris";
            this.picGiris.Size = new System.Drawing.Size(433, 185);
            this.picGiris.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGiris.TabIndex = 12;
            this.picGiris.TabStop = false;
            // 
            // lblSlogan
            // 
            this.lblSlogan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSlogan.AutoSize = true;
            this.lblSlogan.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSlogan.Location = new System.Drawing.Point(223, 204);
            this.lblSlogan.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSlogan.Name = "lblSlogan";
            this.lblSlogan.Size = new System.Drawing.Size(356, 39);
            this.lblSlogan.TabIndex = 13;
            this.lblSlogan.Text = "Rezarvasyon Sistemi";
            // 
            // giris
            // 
            this.giris.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.giris.AutoSize = true;
            this.giris.Controls.Add(this.txtKulAd);
            this.giris.Controls.Add(this.lblSifre);
            this.giris.Controls.Add(this.lblKullaniciAdi);
            this.giris.Controls.Add(this.txtSifre);
            this.giris.Controls.Add(this.btnGiris);
            this.giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.giris.Location = new System.Drawing.Point(55, 246);
            this.giris.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.giris.Name = "giris";
            this.giris.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.giris.Size = new System.Drawing.Size(702, 181);
            this.giris.TabIndex = 135;
            this.giris.TabStop = false;
            this.giris.Text = "Giriş Yap";
            // 
            // txtKulAd
            // 
            this.txtKulAd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtKulAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKulAd.Location = new System.Drawing.Point(251, 43);
            this.txtKulAd.Margin = new System.Windows.Forms.Padding(5);
            this.txtKulAd.Name = "txtKulAd";
            this.txtKulAd.Size = new System.Drawing.Size(249, 26);
            this.txtKulAd.TabIndex = 14;
            this.txtKulAd.Text = "harun";
            // 
            // lblSifre
            // 
            this.lblSifre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.Location = new System.Drawing.Point(161, 98);
            this.lblSifre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(63, 25);
            this.lblSifre.TabIndex = 15;
            this.lblSifre.Text = "Şifre :";
            this.lblSifre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciAdi.Location = new System.Drawing.Point(94, 42);
            this.lblKullaniciAdi.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(130, 25);
            this.lblKullaniciAdi.TabIndex = 14;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı :";
            this.lblKullaniciAdi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSifre
            // 
            this.txtSifre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtSifre.Location = new System.Drawing.Point(251, 99);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(5);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '•';
            this.txtSifre.Size = new System.Drawing.Size(249, 26);
            this.txtSifre.TabIndex = 17;
            this.txtSifre.Text = "0";
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // btnGiris
            // 
            this.btnGiris.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGiris.BackColor = System.Drawing.Color.Transparent;
            this.btnGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGiris.BackgroundImage")));
            this.btnGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGiris.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGiris.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiris.ForeColor = System.Drawing.Color.Transparent;
            this.btnGiris.Location = new System.Drawing.Point(510, 88);
            this.btnGiris.Margin = new System.Windows.Forms.Padding(5);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(67, 44);
            this.btnGiris.TabIndex = 19;
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 444);
            this.Controls.Add(this.giris);
            this.Controls.Add(this.lblSlogan);
            this.Controls.Add(this.picGiris);
            this.Name = "FrmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGiris";
            ((System.ComponentModel.ISupportInitialize)(this.picGiris)).EndInit();
            this.giris.ResumeLayout(false);
            this.giris.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picGiris;
        private System.Windows.Forms.Label lblSlogan;
        private System.Windows.Forms.GroupBox giris;
        private System.Windows.Forms.TextBox txtKulAd;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnGiris;
    }
}