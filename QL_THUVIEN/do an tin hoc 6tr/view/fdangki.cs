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

namespace do_an_tin_hoc_6tr.view
{
    public partial class FDANGKIcs : Form

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
        public FDANGKIcs()
        {
            InitializeComponent();
        }

        private void FDANGKIcs_Load(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("dstk.txt", FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            dsdk_list = (List<Cdangnhap>)bf.Deserialize(fs);
            fs.Close();
        }

        private void btdangki_Click(object sender, EventArgs e)
        {
            Cdangnhap x = new Cdangnhap();
            if (txnmk.Text == txnlmk.Text)
            {
                x.Stk = txntk.Text;
                x.Smk = txnmk.Text;
            

                if (x.Smk == "")
                {
                    MessageBox.Show("Vui Lòng Nhập Mật Khẩu");
                    txnmk.Focus();
                }
                else if (tim(x.Stk) == null)
                {
                    dsdk_list.Add(x);
                    MessageBox.Show("Tài Khoản Được Đăng Kí Thành Công");
                    //luu danh sach tai hkoan
                    FileStream fs = new FileStream("dstk.txt", FileMode.Create);
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, dsdk_list);
                    fs.Close();
                }
                else
                {
                    MessageBox.Show("Tài Khoản Đã Tồn Tại");
                }
            }
            else
            {
                MessageBox.Show("Nhập lại Mặt Khẩu Không Chính Xác");
                txnlmk.Focus();
            }
        }
    }
}
