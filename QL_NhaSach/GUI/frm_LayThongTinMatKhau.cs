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
    public partial class frm_LayThongTinMatKhau : Form
    {
        public frm_LayThongTinMatKhau()
        {
            InitializeComponent();
        }
        string code = "";
        string sdt = "";
        public frm_LayThongTinMatKhau(string macode, string t_sdt)
        {
            InitializeComponent();
            code = macode;
            sdt = t_sdt;
        }
        private void frm_LayThongTinMatKhau_Load(object sender, EventArgs e)
        {

        }
        NhanVienBLL nv;
        private void btn_doimk_Click(object sender, EventArgs e)
        {
            try
            {
                nv = new NhanVienBLL();
                if (String.Compare(txt_code.Text, code, true) != 0)
                {
                    MessageBox.Show("Bạn nhập mã code không đúng!", "Thông báo");
                    return;
                }
                if (String.IsNullOrEmpty(txt_matkhau.Text) || String.IsNullOrEmpty(txt_nhaplaimk.Text))
                {
                    MessageBox.Show("Bạn vui lòng nhập đầy đủ thông tin!", "Thông báo");
                    return;
                }
                if (String.Compare(txt_matkhau.Text, txt_nhaplaimk.Text) != 0)
                {
                    MessageBox.Show("Mật khẩu nhập lại không khớp", "Thông báo");
                    return;
                }
                if (nv.update_mk(sdt, txt_matkhau.Text))
                {
                    MessageBox.Show("Đổi mật khẩu thành công", "Thông báo");
                    
                    return;
                }
                else
                {
                    MessageBox.Show("Lỗi", "Thông báo");
                }
            }
            catch
            {
                MessageBox.Show("Hệ thống đang cập nhật", "Thông báo");
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
