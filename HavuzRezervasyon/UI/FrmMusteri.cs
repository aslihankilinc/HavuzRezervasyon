using HavuzRezervasyon.Data;
using HavuzRezervasyon.Entities;
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
    public partial class FrmMusteri : Form
    {
        int musteriId = 0;
        public FrmMusteri()
        {
            InitializeComponent();
        }

        private void FrmMusteri_Load(object sender, EventArgs e)
        {
            YukleMusteri();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtAdSoyad.Text != String.Empty && dtDogum.Text != String.Empty)
            {

                if (DatabaseRepository.MusteriEkle(new Entities.tblMusteri { AdSoyad = txtAdSoyad.Text, Telefon = txtCep.Text, DogumTarih = dtDogum.Text, MusteriId = musteriId }))
                {
                    MessageBox.Show("İşleminiz gerçekleştirildi");
                    this.Close();
                }
                else MessageBox.Show("Kayıt işlemi gerçekleştirilemedi");
            }
            else MessageBox.Show("Kayıt işlemi gerçekleştirilemedi");
        }

        public void YukleMusteri()
        {

            var musteriList = DatabaseRepository.ListMusteri(new Entities.tblMusteri());
            dgMusteri.DataSource = musteriList;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgMusteri.SelectedRows)
            {
                var id = row.Cells["MusteriId"].Value.ToInt32();
                if (DatabaseRepository.SilMusteri(new Entities.tblMusteri() { MusteriId = id }))
                {
                    MessageBox.Show("İşleminiz gerçekleştirildi");
                    YukleMusteri();
                }
                else
                {
                    MessageBox.Show("İşleminiz gerçekleştirilemedi");
                }
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgMusteri.SelectedRows)
            {
                musteriId = row.Cells["MusteriId"].Value.ToInt32();
                txtAdSoyad.Text = row.Cells["AdSoyad"].Value.ToString();
                txtCep.Text = row.Cells["Telefon"].Value.ToString();
            }
        }
    }
}
