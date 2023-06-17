using HavuzRezervasyon.Data;
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
        public FrmMusteri()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtAdSoyad.Text != String.Empty && dtDogum.Text != String.Empty)
            {

                if (DatabaseRepository.MusteriEkle(new Entities.tblMusteri { AdSoyad = txtAdSoyad.Text, Telefon = txtCep.Text,DogumTarih=dtDogum.Text }))
                {
                    MessageBox.Show("Müşteri Kartı Oluşturuldu");
                    this.Close();
                }
                else MessageBox.Show("Kayıt işlemi gerçekleştirilemedi");
            }
            else MessageBox.Show("Kayıt işlemi gerçekleştirilemedi");
        }
    }
}
