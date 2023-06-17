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
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }

        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {
            YukleMusteri();
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
        }

        #endregion
    }
}
