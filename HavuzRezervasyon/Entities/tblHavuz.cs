using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HavuzRezervasyon.Entities
{
    public class tblHavuz
    {
        public int HavuzId { get; set; } 
        public string Ad { get; set; }
        public decimal SaatlikUcret { get; set; }
    }
}
