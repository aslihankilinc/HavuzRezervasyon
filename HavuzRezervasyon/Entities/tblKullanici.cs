using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HavuzRezervasyon.Entities
{
    public class tblKullanici
    {
        public int KullaniciId { get; set; } 
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string AdSoyad { get;set; }
    }
}
