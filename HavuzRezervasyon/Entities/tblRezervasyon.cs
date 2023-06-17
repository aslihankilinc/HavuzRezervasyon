using HavuzRezervasyon.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HavuzRezervasyon.Entities
{
    public class tblRezervasyon
    {
        public int RezervasyonId { get;set; }
        public int MusteriId { get; set; }
        public string GirisTarihi { get; set; } 
        public string CikisTarihi { get; set; }
        public string KayitTarih { get; set; } 
        public decimal Ucret { get; set; }
        public int HavuzId { get;set; }        
        public string AdSoyad { get; set; }
        public string HavuzAd { get; set; }
        public string Telefon { get; set; }
    }
}
