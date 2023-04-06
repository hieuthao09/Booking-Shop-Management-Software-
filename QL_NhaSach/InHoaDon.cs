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
    public partial class InHoaDon : Form
    {
        public InHoaDon()
        {
            InitializeComponent();
        }
        string mahd;
        public InHoaDon(string ma)
        {
            InitializeComponent();
            mahd = ma;
        }
        private void InHoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QL_NhaSachDataSet.chitiethoadon_In' table. You can move, or remove it, as needed.
            this.chitiethoadon_InTableAdapter.Fill(this.QL_NhaSachDataSet.chitiethoadon_In, mahd);

            this.reportViewer1.RefreshReport();
        }
    }
}
