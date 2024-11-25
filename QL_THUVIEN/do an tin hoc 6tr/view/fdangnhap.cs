using do_an_tin_hoc_6tr.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Xsl;

namespace do_an_tin_hoc_6tr
{
    public partial class fdangnhap : Form
    {
        
        List<Cdangnhap> dsdk_list = new List<Cdangnhap>();     
        private Cdangnhap tim(string tk)
        {           
            foreach (Cdangnhap stk in dsdk_list)
            {
                if (stk.Stk == tk)
                    return stk;
            }
            return null;
        }       
        public fdangnhap()
        {
            InitializeComponent();
        }
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            fchuongtrinh f = new fchuongtrinh();
            fnhanvien n = new fnhanvien();
            if (ktdn(txdn.Text, txmk.Text))
            {
                if (txdn.Text == "admin" && txmk.Text=="admin")
                {
                    n.Show();
                    this.Hide();
                }
                else
                {
                    f.Show();   
                    this.Hide();
                }
            }
            else
                MessageBox.Show("Tài Khoản Hoặc Mật Khẩu Của Ban Không Đúng");
        }
        bool ktdn(string tk,string mk)
        {
            FileStream fs = new FileStream("dstk.txt", FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            dsdk_list = (List<Cdangnhap>)bf.Deserialize(fs);
            fs.Close();
            for (int i = 0; i < dsdk_list.Count; i++)
            {
                if (tk == dsdk_list[i].Stk && mk == dsdk_list[i].Smk)
                {
                    return true;
                }
            }
            return false;
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            //dsdk_list.Add(new Cdangnhap("admin", "admin",""));
        }
        
        
        private void btdangki_Click(object sender, EventArgs e)
        {
            cs f= new cs();
            f.Show();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txmk.UseSystemPasswordChar = true;
            }
            else
                txmk.UseSystemPasswordChar = false;
        }

        private void txdn_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
