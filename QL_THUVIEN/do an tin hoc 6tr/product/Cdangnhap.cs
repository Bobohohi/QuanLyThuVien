using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace do_an_tin_hoc_6tr
{
    [Serializable]
    internal class Cdangnhap
    {
        public string Stk { get; set; }
        public string Smk { get; set; }
        public string Sma { get; internal set; }
    }
}
