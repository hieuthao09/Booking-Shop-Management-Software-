using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_NhaSach.DTO;
using QL_NhaSach.BLL;
namespace QL_NhaSach
{
    public partial class frm_ResetMatKhau : Form
    {
        
        public frm_ResetMatKhau()
        {
            InitializeComponent();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        string code;
        string random()
        {
            string ma="";
            Random autoRand = new Random();
            for (int x = 0; x < 2; x++)
            {
                ma += autoRand.Next(1, 99).ToString();
            }
            return ma;
        }
        private void btn_ChapNhap_Click(object sender, EventArgs e)
        {
            
            code = random();
            MessageBox.Show(code, "Mã code đổi mật khẩu");
            frm_LayThongTinMatKhau frm = new frm_LayThongTinMatKhau(code, txt_sdt.Text);
            this.Hide();
            frm.ShowDialog();
        }
    }
}
