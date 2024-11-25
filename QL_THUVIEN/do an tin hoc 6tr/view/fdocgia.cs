using do_an_tin_hoc_6tr.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace do_an_tin_hoc_6tr
{
    public partial class fchuongtrinh : Form
    {

        
        List<Cthuvien> dstv_listv = new List<Cthuvien>();
        public fchuongtrinh()
        {
            InitializeComponent();
        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            fdangnhap x = new fdangnhap();
            x.Show();
        }

       
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            fthongtindogia f=new fthongtindogia();
            f.Show();
            Hide();
        }
        
        private void độcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fnhanvien fnhanvien = new fnhanvien();
            fnhanvien.Show();
        }

        private void dtvsach_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            labelms.Text = dtvsach.Rows[e.RowIndex].Cells[0].Value.ToString();
            labelts.Text = dtvsach.Rows[e.RowIndex].Cells[1].Value.ToString();
            labeltg.Text = dtvsach.Rows[e.RowIndex].Cells[2].Value.ToString();
            labelnxb.Text = dtvsach.Rows[e.RowIndex].Cells[3].Value.ToString();
            labells.Text = dtvsach.Rows[e.RowIndex].Cells[4].Value.ToString();

        }
        public void hiensach()
        {

            dtvsach.DataSource = dstv_listv.ToList();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            dtvsach.AutoGenerateColumns = false;
            FileStream fs = new FileStream("dssach.txt", FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            dstv_listv = (List<Cthuvien>)bf.Deserialize(fs);
            if (dstv_listv != null)
                hiensach();
            else
            {
                dstv_listv = new List<Cthuvien>();
                hiensach();
            }
            fs.Close();
        }
        private Cthuvien timma(string ma)
        {
            foreach (Cthuvien Ma in dstv_listv)
            {
                if (Ma.Sma == ma)
                    return Ma;
            }
            return null;
        }
        private Cthuvien timten(string ten)
        {
            foreach (Cthuvien Ten in dstv_listv)
            {
                if (Ten.Sten == ten)
                    return Ten;
            }
            return null;
        }
        private void bttim_Click(object sender, EventArgs e)
        {
            Cthuvien resultma = timma(txtimkiemsach.Text);
            Cthuvien resultten = timten(txtimkiemsach.Text);
            List<Cthuvien> resultList = new List<Cthuvien>();
            if (resultma != null)
            {
                resultList.Add(resultma);
                dtvsach.DataSource = resultList;
            }
            else if(resultten != null)
            {
                resultList.Add(resultten);
                dtvsach.DataSource = resultList;
            }
            else
            {
                MessageBox.Show("Khong ton tai");
            }
        }

        private void dtvsach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}
