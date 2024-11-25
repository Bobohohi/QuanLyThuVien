using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace do_an_tin_hoc_6tr
{
    public partial class fmuonsach : Form
    {
        public fmuonsach()
        {
            InitializeComponent();
        }
        public fmuonsach(string madg,string tendg,string sach,string masach,string ngaymuon,string ngaytra):this()
        {
            InitializeComponent();
            labeldg.Text = tendg;
            labelmadg.Text = madg;
            labelsach.Text = sach;
            labelmasach.Text = masach;
            labelngaymuon.Text = ngaymuon;
            labelngaytra.Text = ngaytra;
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fmuonsach_Load(object sender, EventArgs e)
        {

        }
    }
}
