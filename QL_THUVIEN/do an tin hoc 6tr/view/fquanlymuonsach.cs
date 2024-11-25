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
    public partial class fquanlymuonsach : Form
    {
        
        readonly AddList<Cmuonsach> slm = new AddList<Cmuonsach>();
        readonly product_muonsach ms = new product_muonsach();
        readonly product_muonsach ts = new product_muonsach();
        Cmuonsach currentms = null;
        
        public fquanlymuonsach()
        {
            InitializeComponent();
        }
         public void hien()
        {
            dtvmuonsach.DataSource = ms.getALL().ToList();
        }
        public void hients()
        {
            dtvtrasach.DataSource = ts.getALL().ToList();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
            dtvmuonsach.AutoGenerateColumns = false;
            string Filename = "dsmuon.txt";
            if (File.Exists(Filename))
            {
                ms.setAll(slm.Load(Filename));
                hien();
            }
            string Filenames = "dstra.txt";
            if (File.Exists(Filenames))
            {
                ts.setAll(slm.Load(Filenames));
                hients();
            }
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            fnhanvien f=new fnhanvien();
            string Filename = "dsmuon.txt";
            string Filenames = "dstra.txt";
            bool result = slm.SaveFile(ms.getALL(), Filename);
            bool results = slm.SaveFile(ts.getALL(), Filenames);
            if (result&&results)
            {
                Close();
                f.Show();
                Hide();
            }    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currentms == null)
            {
                MessageBox.Show(@"Vui Lòng Chọn Mục Cần Trả", @"Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ts.them(currentms);
            ms.xoa(currentms);
            hien();
            hients();
            currentms = null;
            
        }

        private void dtvmuonsach_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            currentms = (Cmuonsach)dtvmuonsach.Rows[e.RowIndex].DataBoundItem;
        }
    }
}
