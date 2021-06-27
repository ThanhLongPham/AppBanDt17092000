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
    public partial class HeThong : Form
    {
        public HeThong()
        {
            InitializeComponent();
        }

        private void hóaĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HoaDonBan fn = new HoaDonBan();
            this.Hide();
            fn.Show();
        }

        private void HeThong_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KhachHang fn = new KhachHang();
            this.Hide();
            fn.Show();
        }

        private void Thoát_Click(object sender, EventArgs e)
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

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhanVien fn = new NhanVien();
            this.Hide();
            fn.Show();
        }

        private void danhSáchSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HangHoa fn = new HangHoa();
            this.Hide();
            fn.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            From1 fn = new From1();
            this.Hide();
            fn.Show();
        }

        private void báoCáoDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BCDOANHTHU bc = new BCDOANHTHU();
            this.Hide();
            bc.Show();
        }

        private void báoCáoXuấtNhậpTồnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BCDoanhThuTheoNgay fn = new BCDoanhThuTheoNgay();
            fn.Hide();
            fn.Show();
        }
    }
}
