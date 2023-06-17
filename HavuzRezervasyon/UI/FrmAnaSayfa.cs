using HavuzRezervasyon.Data;
using HavuzRezervasyon.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace HavuzRezervasyon.UI
{
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }

        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {
            YukleMusteri();
            YukleHavuz();
            YukleRezervasyon();
            YukleGunlukRezarvasyon();
        }

        private void btnMusEkle_Click(object sender, EventArgs e)
        {
            new FrmMusteri().ShowDialog();
        }

        #region VarsayilanYuklemeler
        public void YukleMusteri()
        {

            var musteriList = DatabaseRepository.ListMusteri(new Entities.tblMusteri());
            cbMusteri.DataSource = musteriList;
            cbMusteri.DisplayMember = "AdSoyad";
            cbMusteri.ValueMember = "MusteriId";
        }
        public void YukleRezervasyon()
        {
            var rezList = DatabaseRepository.ListRez(new Entities.tblRezervasyon() { GirisTarihi=Convert.ToDateTime(dtGiris.Value).ToShortDate()});
            dgRezervasyon.DataSource = rezList;
        }
        public void YukleHavuz()
        {
            var havuzList = DatabaseRepository.ListHavuz(new Entities.tblHavuz());
          
            cbRezHavuz.DataSource = havuzList;
            cbRezHavuz.DisplayMember = "Ad";
            cbRezHavuz.ValueMember = "HavuzId";
        }

        public void YukleGunlukRezarvasyon()
        {
            var rezList = DatabaseRepository.ListRez(new Entities.tblRezervasyon() { KayitTarih = DateTime.Now.ToShortDate() });
            dgGunluk.DataSource = rezList;
        }
        #endregion

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            
                var musteri = (int)cbMusteri.SelectedValue;
                var havuz = (int)cbRezHavuz.SelectedValue;
                if (DatabaseRepository.RezervasyonEkle(new Entities.tblRezervasyon { HavuzId = havuz, GirisTarihi = dtRezGiris.Value.ToString(), MusteriId = musteri }))
                {
                    MessageBox.Show("İşleminiz gerçekleştirildi");
                  YukleGunlukRezarvasyon();
                YukleRezervasyon();
            }
                else MessageBox.Show("Kayıt işlemi gerçekleştirilemedi");
         
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            YukleRezervasyon();
        }

        private void btnMusteriYenile_Click(object sender, EventArgs e)
        {
            YukleMusteri();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgRezervasyon.SelectedRows)
            {
               var rezerveId = row.Cells["RezerveId"].Value.ToInt32();

                if (DatabaseRepository.RezervasyonSil(new Entities.tblRezervasyon { RezerveId = rezerveId }))
                {
                    MessageBox.Show("İşleminiz gerçekleştirildi");
                    YukleRezervasyon();
                }
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgRezervasyon.SelectedRows)
            {
                var rezerveId = row.Cells["RezerveId"].Value.ToInt32();
                if (row.Cells["CikisTarihi"].Value.ToString() == "")
                {
                    var saatlikUcret = DatabaseRepository.ListHavuz(new Entities.tblHavuz() { HavuzId = row.Cells["HavuzId"].Value.ToInt32() }).FirstOrDefault().SaatlikUcret;
                    var ucret = saatlikUcret * (Convert.ToDateTime(row.Cells["GirisTarihi"].Value) - DateTime.Now).Hours;
                    if (DatabaseRepository.RezervasyonEkle(new Entities.tblRezervasyon { HavuzId = row.Cells["HavuzId"].Value.ToInt32(),GirisTarihi = row.Cells["GirisTarihi"].Value.ToString(),MusteriId= row.Cells["MusteriId"].Value.ToInt32(), RezerveId = rezerveId, Ucret = ucret, CikisTarihi = DateTime.Now.ToString() }))
                    {

                        MessageBox.Show("İşleminiz gerçekleştirildi");
                        YukleRezervasyon();
                    }
                }
                else
                {
                    MessageBox.Show("Çıkış işlemi gerçekleştirilmiş");

                }
            }

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgRezervasyon.SelectedRows)
            {
                var rezerveId = row.Cells["RezerveId"].Value.ToInt32();
                if (row.Cells["CikisTarihi"].Value.ToString() == "")
                {
                    if (DatabaseRepository.RezervasyonEkle(new Entities.tblRezervasyon { RezerveId = rezerveId, GirisTarihi = DateTime.Now.ToString() }))
                    {
                        MessageBox.Show("İşleminiz gerçekleştirildi");
                        YukleRezervasyon();
                    }
                }
                else
                {
                    MessageBox.Show("Tarihleri kontrol ediniz");
                }
            }
        }
    }
}
