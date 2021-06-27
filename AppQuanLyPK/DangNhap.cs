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
    public partial class From1 : Form
    {
        public From1()
        {
            InitializeComponent();
            Init_Data();
        }
        public int ktra()
        {
            string Sql = "Select* From NguoiDung Where TaiKhoan='" + txtTaiKhoan.Text + "'and MatKhau ='" + txtMatKhau.Text + "'";
            DataTable sql_1 = ConnectData.ExcuteDateTable_SQL(Sql);
            if (sql_1.Rows.Count >= 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        private void btDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "" || txtMatKhau.Text == "")
            {
                MessageBox.Show("Tài Khoản, mật khẩu không được trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int kt = ktra(); if (kt == 1)
                {
                    Save_Data();
                    MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HeThong fr = new HeThong();
                    this.Hide();
                    fr.Show();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }
        private void Init_Data()
        {
            if (Properties.Settings.Default.Users != string.Empty)
            {
                if (Properties.Settings.Default.RememberMe == "yea")
                {
                    txtTaiKhoan.Text = Properties.Settings.Default.Users;
                    txtMatKhau.Text = Properties.Settings.Default.Password;
                    ckbNhoMK.Checked = true;
                }
                else
                {
                    txtTaiKhoan.Text = Properties.Settings.Default.Users;
                }
            }
        }
        private void Save_Data()
        {
            if (ckbNhoMK.Checked)
            {
                Properties.Settings.Default.Users = txtTaiKhoan.Text;
                Properties.Settings.Default.Password = txtMatKhau.Text;
                Properties.Settings.Default.RememberMe = "yea";
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.Users = txtTaiKhoan.Text;
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.RememberMe = "No";
                Properties.Settings.Default.Save();
            }
        }

        private void ckbHienMK_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbHienMK.Checked)
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;
            }
        }

        private void lbQuenMK_Click(object sender, EventArgs e)
        {
            XacNhan fr = new XacNhan();
            this.Hide();
            fr.Show();
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
    }
}
