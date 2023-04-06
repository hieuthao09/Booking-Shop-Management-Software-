using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_NhaSach
{
    public partial class frmNhapSoLuong : Form
    {
        public frmNhapSoLuong()
        {
            InitializeComponent();
        }
        public int soluong ()
        {
            return int.Parse(txt_Sl.Text);   
        }
        private void btn_Nhap_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txt_Sl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        
    }
}
