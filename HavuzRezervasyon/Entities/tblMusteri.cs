using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HavuzRezervasyon.Entities
{
    public class tblMusteri
    {
        public int MusteriId{ get; set; }
        public string AdSoyad { get; set; }
        public string DogumTarih { get;set; }
        public int UyeMi { get; set; } = 0;
    }
}
