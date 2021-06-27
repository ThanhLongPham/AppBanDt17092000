using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppQuanLyPK.Class;

namespace AppQuanLyPK
{
    public partial class DoiMatKhau : Form
    {
        string txtTaiKhoan = XacNhan.to;
        public DoiMatKhau()
        {
            InitializeComponent();
        }

        private void DoiMK_Click(object sender, EventArgs e)
        {
            if (txtMatKhauMoi.Text == "" || txtNhapLaiMK.Text == "")
            {
                label.ForeColor = System.Drawing.Color.Red;
                label.Text = "Bạn không được để ô trống!";
            }
            else
            {
                if (txtMatKhauMoi.Text == txtNhapLaiMK.Text)
                {
                    string Sql = "Update NguoiDung set MatKhau ='" + txtNhapLaiMK.Text + "'where TaiKhoan='" + txtTaiKhoan + "'";
                    ConnectData.ExcuteNonData(Sql);
                    MessageBox.Show("Reset successfully!");
                }
                else
                {
                    label.ForeColor = System.Drawing.Color.Red;
                    label.Text = "Mật khẩu không trùng khớp!";
                }
            }
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

        private void TroVe_Click(object sender, EventArgs e)
        {
            From1 fn = new From1();
            this.Hide();
            fn.Show();
        }
    }
}
