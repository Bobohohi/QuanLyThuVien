using do_an_tin_hoc_6tr.Fdatabase;
using do_an_tin_hoc_6tr.List;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace do_an_tin_hoc_6tr.view
{
    public partial class fdanhsachdocgia : Form
    {
        readonly AddList<Cdocgia> sldg = new AddList<Cdocgia>();
        readonly product_docgia dg = new product_docgia();
        Cdocgia curentdg = null;
        public fdanhsachdocgia()
        {
            InitializeComponent();
        }
        public void hien()
        {
            dtvdg.DataSource = dg.getALL().ToList();
        }

        private void fdanhsachdocgia_Load(object sender, EventArgs e)
        {
            dtvdg.AutoGenerateColumns = false;
            string Filename = "dsdg.txt";
            if (File.Exists(Filename))
            {
                dg.setAll(sldg.Load(Filename));
                hien();
            }
        }

        private void btthemdg_Click(object sender, EventArgs e)
        {

        }

        private void btexit_Click(object sender, EventArgs e)
        {
            fnhanvien f = new fnhanvien();
            string Filename = "dsdg.txt";
            bool result = sldg.SaveFile(dg.getALL(), Filename);
            if (result)
            {
                Close();
                f.Show();
                Hide();
            }
        }

        private void btxoadg_Click(object sender, EventArgs e)
        {
            if (curentdg == null)
            {
                MessageBox.Show(@"Vui Lòng Chọn Đọc Giả Cần Xóa", @"Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            dg.xoa(curentdg);
            hien();
        }

        private void dtvdg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtvdg_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            curentdg = (Cdocgia)dtvdg.Rows[e.RowIndex].DataBoundItem;
            lbdocgia.Text = dtvdg.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
    }
}
