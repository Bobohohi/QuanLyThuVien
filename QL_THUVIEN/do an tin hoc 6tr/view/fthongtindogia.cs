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
using do_an_tin_hoc_6tr.Fdatabase;
using do_an_tin_hoc_6tr.List;

namespace do_an_tin_hoc_6tr.view
{
    public partial class fthongtindogia : Form
    {
        readonly product_docgia dg = new product_docgia();
        readonly AddList<Cdocgia> sldg = new AddList<Cdocgia>();
        public fthongtindogia()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private Cdocgia tim(string ma)
        {
            foreach (Cdocgia Ma in dg.getALL())
            {
                if (Ma.Sma == ma)
                    return Ma;
            }
            return null;
        }
        private void bttim_Click(object sender, EventArgs e)
        {
            Cdocgia resultma = tim(txtim.Text);
            List<Cdocgia> resultList = new List<Cdocgia>();
            if (resultma != null)
            {
                resultList.Add(resultma);
                label7.Text = resultma.Sten;
                label8.Text = resultma.Ssdt.ToString();
                label9.Text= resultma.Email;
                label10.Text = resultma.Sdc;
                label11.Text= resultma.Sngaysinh.ToString();
            }
            else
            {
                MessageBox.Show("Khong ton tai");
            }
        }

        private void fthongtindogia_Load(object sender, EventArgs e)
        {
            string Filename = "dsdg.txt";
            if (File.Exists(Filename))
            {
                dg.setAll(sldg.Load(Filename));
                
            }
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            Close();
            fchuongtrinh f = new fchuongtrinh();
            f.Show();
            Hide();
        }
    }
}
