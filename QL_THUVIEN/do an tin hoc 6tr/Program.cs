using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace do_an_tin_hoc_6tr
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new fdangnhap());
            //fdangnhap dn = new fdangnhap();
            //if(dn.ShowDialog() == DialogResult.OK)
            //{
            //    Application.Run(new fnhanvien());
            //}

        }
    }
}
