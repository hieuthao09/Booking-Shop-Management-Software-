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
    public partial class frm_Reset_TaiKhoan : Form
    {
        public frm_Reset_TaiKhoan()
        {
            InitializeComponent();
        }

        private void frm_Reset_TaiKhoan_Load(object sender, EventArgs e)
        {

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txt_MaNhanVien.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã nhân viên");
                return;
            }
            NhanVienBLL nv = new NhanVienBLL();
            if(!nv.kiemtra_MaNV(txt_MaNhanVien.Text))
            {
                MessageBox.Show("Nhân viên không tồn tại");
                return;
            }
            nv.update_Reset_mk(txt_MaNhanVien.Text);
            MessageBox.Show("Reset thành công");
            this.Hide();
        }
    }
}
