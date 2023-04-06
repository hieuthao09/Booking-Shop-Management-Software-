using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_NhaSach.GUI
{
    public partial class frmChucVuNhanVien : Form
    {
        public frmChucVuNhanVien()
        {
            InitializeComponent();
        }

        private void frmChucVuNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ql_Sach.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.ql_Sach.NHANVIEN);
            // TODO: This line of code loads data into the 'ql_Sach.CHUCVU_NHANVIEN' table. You can move, or remove it, as needed.
            this.cHUCVU_NHANVIENTableAdapter.Fill(this.ql_Sach.CHUCVU_NHANVIEN);

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Validate())
                {
                    this.cHUCVUNHANVIENBindingSource.EndEdit();
                    this.cHUCVU_NHANVIENTableAdapter.Update(ql_Sach.CHUCVU_NHANVIEN);
                    MessageBox.Show("Lưu thành công", "Thông báo");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Ht_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
