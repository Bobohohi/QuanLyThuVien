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
using System.Diagnostics.Eventing.Reader;
using do_an_tin_hoc_6tr.List;
using do_an_tin_hoc_6tr.product;
using System.Xml.Linq;
using do_an_tin_hoc_6tr.Properties;
using do_an_tin_hoc_6tr.Fdatabase;
using do_an_tin_hoc_6tr.view;

namespace do_an_tin_hoc_6tr
{
    [Serializable]
    public partial class fnhanvien : Form
    {
        readonly AddList<Cthuvien> sl = new AddList<Cthuvien>();
        readonly AddList<Cdocgia> sldg = new AddList<Cdocgia>();
        readonly AddList<Cmuonsach> slm = new AddList<Cmuonsach>();
        readonly product_docgia dg=new product_docgia();
        readonly product_admin ad = new product_admin();
        readonly product_muonsach ms = new product_muonsach();
        Cthuvien currenttv = null;
        Boolean ischange = false;
        public fnhanvien()
        {
            InitializeComponent();
        }
        private Cthuvien tim(string ma)
        {
            foreach (Cthuvien Ma in ad.getALL())
            {
                if (Ma.Sma == ma)
                    return Ma;
            }
            return null;
        }
        private Cdocgia timma(string ma)
        {
            foreach (Cdocgia Ma in dg.getALL())
            {
                if (Ma.Sma == ma)
                    return Ma;
            }
            return null;
        }
        public void hien()
        {
            dtvsach.DataSource = ad.getALL().ToList();
        }

        private void xóaSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currenttv == null)
            {
                MessageBox.Show(@"Vui Lòng Chọn Sách Cần Xóa", @"Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ad.xoa(currenttv);
            hien();
            currenttv = null;
            clear();
        }


        private void dtvsach_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txmasach.Text = dtvsach.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtensach.Text = dtvsach.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtacgia.Text = dtvsach.Rows[e.RowIndex].Cells[2].Value.ToString();
            txnxb.Text = dtvsach.Rows[e.RowIndex].Cells[3].Value.ToString();
            txloaisach.Text = dtvsach.Rows[e.RowIndex].Cells[4].Value.ToString();
            currenttv = (Cthuvien)dtvsach.Rows[e.RowIndex].DataBoundItem;
        }
        public void clear()
        {
            txloaisach.Clear();
            txmasach.Clear();
            txnxb.Clear();
            txtensach.Clear();
            txtacgia.Clear();
        }
        private void tToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cthuvien x = new Cthuvien();
            x.Sma = txmasach.Text;
            x.Sten = txtensach.Text;
            x.Stacgia = txtacgia.Text;
            x.Snxb = txnxb.Text;
            x.Sloaisach = txloaisach.Text;
            if (tim(x.Sma) == null)
            {
                ad.them(x);
                hien();
                clear();
            }
            else
                MessageBox.Show("trung ma");
        }



        private void lưuThôngTinSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Filename ="dssach.txt";
            bool result = sl.SaveFile(ad.getALL(), Filename);
            if (result)
                MessageBox.Show("Save succuess!");

        }
        private void luumuon()
        {
            string Filename = "dsmuon.txt";
            bool result = slm.SaveFile(ms.getALL(), Filename);
            if (result)
                MessageBox.Show("Save succuess!");

        }

        private void phiểuMượnSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string dg = txtendg.Text;
            string madg = txmadg.Text;
            string sach = txtensach.Text;
            string masach = txmasach.Text;
            string ngaymuon = dateTimePicker1.Value.Date.ToString();
            string ngaytra = dateTimePicker2.Value.ToString();
            fmuonsach f = new fmuonsach(dg, madg, sach, masach, ngaymuon, ngaytra);
            f.Show();

            Cmuonsach x = new Cmuonsach();
            x.Sma = txmasach.Text;
            x.Sten = txtensach.Text;
            x.Stendg = txtendg.Text;
            x.Smadg= txmadg.Text;
            x.Ngaymuon = dateTimePicker1.Value.Date;
            x.Ngaytra = dateTimePicker2.Value;
            ms.them(x);
            luumuon();
        }

        private void sửaThôngTinSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currenttv == null)
            {
                MessageBox.Show(@"Please choose a product", @"Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            currenttv.Sma = txmasach.Text;
            currenttv.Sten = txtensach.Text;
            currenttv.Stacgia=txtacgia.Text;
            currenttv.Snxb = txnxb.Text;
            currenttv.Sloaisach=txloaisach.Text;
            hien();
            currenttv = null;
            MessageBox.Show("Sửa Thành Công");
        }

        private void fnhanvien_Load(object sender, EventArgs e)
        {
            
            dtvsach.AutoGenerateColumns = false;
            string Filenamesach = "dssach.txt";
            if (File.Exists(Filenamesach))
            {
                ad.setAll(sl.Load(Filenamesach));
                hien();
            }
            string Filenamemuon = "dsmuon.txt";
            if (File.Exists(Filenamemuon))
            {
                ms.setAll(slm.Load(Filenamemuon));
            }
            string Filenamedg = "dsdg.txt";
            if (File.Exists(Filenamedg))
            {
                dg.setAll(sldg.Load(Filenamedg));
         
            }
            clear();
        }
        private void thayĐổiThôngTinToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            fdanhsachdocgia f = new fdanhsachdocgia();
            f.Show();
            Hide();
        }

        private void quảnLýĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fquanlymuonsach f = new fquanlymuonsach();
            f.Show();
            Hide();
        }

        private void thêmĐọcGiảMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fthongtin fthongtin = new fthongtin();
            fthongtin.Show();
            Hide();
        }

        private void dtvsach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int Demsach()
        {
            int dem = 0;
            for(int i = 0; i < ad.getALL().Count; i++)
            {
                dem++;
            }
            return dem;
        }
        int demdg()
        {
            int dem = 0;
            for (int i = 0;i < dg.getALL().Count; i++)
            {
                dem++;
            }
            return dem;
        }
        int demms()
        {
            int dem = 0;
            for (int i = 0; i < ms.getALL().Count; i++)
            {
                dem++;
            }
            return dem;
        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hiện Đang có trong Thư Viện Là " + Demsach());
        }

        private void sốLượngĐọcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Số lượng Thành Viên Thư Viện Là " + demdg()+" Đọc Giả");
        }

        private void sốLượngMượnSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Số lượng Sách Đã Được Mượn Là " + demms());
        }

        private void bttim_Click(object sender, EventArgs e)
        {
            Cdocgia resultma = timma(txmadg.Text);
            List<Cdocgia> resultList = new List<Cdocgia>();
            if (resultma != null)
            {
                resultList.Add(resultma);
                txtendg.Text = resultma.Sten ;
            }
            else
            {
                MessageBox.Show("Khong ton tai");
            }
        }

        private void bttimsach_Click(object sender, EventArgs e)
        {
            Cthuvien resultma = tim(txmasach.Text);
            List<Cthuvien> resultList = new List<Cthuvien>();
            if (resultma != null)
            {
                resultList.Add(resultma);
                txtensach.Text = resultma.Sten ;
                txtacgia.Text = resultma.Stacgia ;
                txnxb.Text = resultma.Snxb ;
                txloaisach.Text = resultma.Sloaisach ;
            }
            else
            {
                MessageBox.Show("Khong ton tai");
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            fdangnhap x = new fdangnhap();
            x.Show();
        }
    }
}
