using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_an_tin_hoc_6tr.product
{
    [Serializable]
    internal class Cmuonsach : Cthongtin 
    {
        public string Smadg { get; set; }
        public string Stendg { get; set; }
        public DateTime Ngaytra {  get; set; }
        public DateTime Ngaymuon {  get; set; } = DateTime.Now;

    }
}
