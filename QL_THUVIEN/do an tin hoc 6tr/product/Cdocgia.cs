using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_an_tin_hoc_6tr
{
    [Serializable]
    internal class Cdocgia : Cthongtin
    {
        public string Sdc {  get; set; }
        public string Email {  get; set; }
        public double Ssdt {get;set;}
        public DateTime Sngaysinh { get; set; }
        public bool Sgioitinh {  get; set; } = false;       
    }
}
