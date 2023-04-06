using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_NhaSach.DAL.ql_SachTableAdapters;
namespace QL_NhaSach.GUI
{
    public partial class frmTaoTK : Form
    {
        public frmTaoTK()
        {
            InitializeComponent();
        }
        TAIKHOANTableAdapter tk;
        private void btn_Tạo_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txt_TTK.Text) && !String.IsNullOrEmpty(txtMK.Text))
                {
                    tk.Insert(txt_TTK.Text, txtMK.Text);
                    MessageBox.Show("Bạn đã thêm thành công");
                }
                else
                    MessageBox.Show("Bạn hãy điền đầy đủ thông tin nhé");
            }
            catch
            {
                return;
            }
           
        }

        private void frmTaoTK_Load(object sender, EventArgs e)
        {
            tk = new TAIKHOANTableAdapter();
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
