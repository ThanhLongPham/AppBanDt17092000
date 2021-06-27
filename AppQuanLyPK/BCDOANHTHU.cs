using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppQuanLyPK
{
    public partial class BCDOANHTHU : Form
    {
        public BCDOANHTHU()
        {
            InitializeComponent();
        }

        private void BCDOANHTHU_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'AppQLBHDataSet3.tblHDBan' table. You can move, or remove it, as needed.
            this.tblHDBanTableAdapter.Fill(this.AppQLBHDataSet3.tblHDBan);

            this.reportViewer1.RefreshReport();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có muốn thoát không ?", "Thông Báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (h == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void minimize_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            HeThong fn = new HeThong();
            this.Hide();
            fn.Show();
        }
    }
}
