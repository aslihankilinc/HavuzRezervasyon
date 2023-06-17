using HavuzRezervasyon.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HavuzRezervasyon.UI
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtKulAd.Text != String.Empty && txtSifre.Text != String.Empty)
            {

                if (DatabaseRepository.Login(new Entities.tblKullanici { KullaniciAdi = txtKulAd.Text, Sifre = txtSifre.Text }))
                {
                    this.Hide();
                    new FrmAnaSayfa().ShowDialog();
                }
                else MessageBox.Show("Kullanıcı Adı ,şifrenizi kontrol ediniz");
            }
            else MessageBox.Show("Kullanıcı Adı ,şifrenizi kontrol ediniz");
        }
    }
}

