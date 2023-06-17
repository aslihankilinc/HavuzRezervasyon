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

            if (Convert.ToDateTime(dtRezGiris.Text) >= DateTime.Now)
            {
                var musteri = (int)cbMusteri.SelectedValue;
                var havuz = (int)cbRezHavuz.SelectedValue;
                if (DatabaseRepository.RezervasyonEkle(new Entities.tblRezervasyon { HavuzId = havuz, GirisTarihi = dtRezGiris.Value.ToShortDate(), MusteriId = musteri }))
                {
                    MessageBox.Show("İşleminiz gerçekleştirildi");
                  YukleGunlukRezarvasyon();
                }
                else MessageBox.Show("Kayıt işlemi gerçekleştirilemedi");
            }
            else MessageBox.Show("Kayıt işlemi gerçekleştirilemedi");
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            YukleRezervasyon();
        }
    }
}
