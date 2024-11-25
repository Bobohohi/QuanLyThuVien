using do_an_tin_hoc_6tr.Fdatabase;
using do_an_tin_hoc_6tr.List;
using do_an_tin_hoc_6tr.product;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace do_an_tin_hoc_6tr
{
   
    public partial class fthongtin : Form
    {
        readonly AddList<Cdocgia> sldg = new AddList<Cdocgia>();
        readonly product_docgia dg = new product_docgia();
        public fthongtin()
        {
            InitializeComponent();
        }
        private Cdocgia tim(string ma)
        {
            foreach (Cdocgia n in dg.getALL()) 
            {
                if (n.Sma == ma)
                    return n;
            }
            return null;
        }
        private void fthongtin_Load(object sender, EventArgs e)
        {
            string Filename = "dsdg.txt";
            if (File.Exists(Filename))
            {
                dg.setAll(sldg.Load(Filename));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cdocgia d = new Cdocgia();
            d.Sten = txten.Text;
            d.Sma = txma.Text;
            d.Sdc = txdiachi.Text;
            d.Email = txemail.Text;
            if (cbnam.Checked == true)
                d.Sgioitinh = true;
            else
                d.Sgioitinh = false;
            d.Sngaysinh = dtpnamsinh.Value.Date;
            if (txsdt.Text == "")
            {
                MessageBox.Show("Bạn Chưa Nhập SDT");
                txsdt.Focus();
            }
            else
            {
                d.Ssdt = double.Parse(txsdt.Text);
                if (tim(d.Sma) == null)
                {
                    dg.them(d);
                    string Filename = "dsdg.txt";
                    bool result = sldg.SaveFile(dg.getALL(), Filename);
                    if (result)
                        MessageBox.Show("Save succuess!");
                }
                else
                    MessageBox.Show("Trùng Mã");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            fnhanvien f= new fnhanvien();
            f.Show();
            Hide();
        }
    }
}
