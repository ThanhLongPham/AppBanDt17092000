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
    public partial class KhachHang : Form
    {
        private static string Loai_KH = "";
        public KhachHang()
        {
            InitializeComponent();
        }
        private void LoadDataGridView()
        {
            string sql = "SELECT * from tblKhachHang";
            DataTable MyTable = ConnectData.ExcuteDateTable_SQL(sql);
            dgKhachHang.DataSource = MyTable;
            dgKhachHang.Columns[0].HeaderText = "Mã Khách Hàng";
            dgKhachHang.Columns[1].HeaderText = "Tên Khách Hàng";
            dgKhachHang.Columns[2].HeaderText = "Số Điện Thoại";
            dgKhachHang.Columns[3].HeaderText = "Địa Chỉ";
            dgKhachHang.Columns[4].HeaderText = "Loại Khách Hàng";
            dgKhachHang.Columns[0].Width = 120;
            dgKhachHang.Columns[1].Width = 200;
            dgKhachHang.Columns[2].Width = 120;
            dgKhachHang.Columns[3].Width = 190;
            dgKhachHang.Columns[4].Width = 150;
            dgKhachHang.AllowUserToAddRows = false;
            dgKhachHang.EditMode = DataGridViewEditMode.EditProgrammatically;
            string ql = "Select* From tblKhachHang Where MaKhachHang Like'%" + cbMaKhachHang.Text + "%'";
            DataTable My_tk = ConnectData.ExcuteDateTable_SQL(ql);
            dgKhachHang.DataSource = My_tk;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnHuy.Enabled = true;
            btnCapnhat.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = true;
            txtMaKhachHang.Text = Functions.CreateKey("KH");
            LoadDataGridView();
        }

        private void cbLoaiKhacHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLoaiKhacHang.SelectedValue != null)
                Loai_KH = cbLoaiKhacHang.SelectedValue.ToString();
        }

        private void dgKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int _row = e.RowIndex;
            txtMaKhachHang.Text = dgKhachHang.Rows[_row].Cells[0].Value.ToString();
            txtTenKhachHang.Text = dgKhachHang.Rows[_row].Cells[1].Value.ToString();
            txtSoDienThoai.Text = dgKhachHang.Rows[_row].Cells[2].Value.ToString();
            txtDiaChi.Text = dgKhachHang.Rows[_row].Cells[3].Value.ToString();
            cbLoaiKhacHang.SelectedValue = dgKhachHang.Rows[_row].Cells[4].Value.ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = "insert into tblKhachHang (MaKhachHang,TenKhachHang,SoDienThoai,DiaChi,LoaiKhachHang)values('" + txtMaKhachHang.Text + "',N'" + txtTenKhachHang.Text + "','" + txtSoDienThoai.Text + "',N'" + txtDiaChi.Text + "',N'" + Loai_KH + "')";
            ConnectData.ExcuteNonData(sql);
            LoadDataGridView();
            MessageBox.Show("Thêm thành công!");
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            string sql = "update tblKhachHang set TenKhachHang= N'" + txtTenKhachHang.Text + "',SoDienThoai='" + txtSoDienThoai.Text + "',DiaChi=N'" + txtDiaChi.Text + "',LoaiKhachHang=N'" + Loai_KH + "' Where MaKhachHang='" + txtMaKhachHang.Text + "'";
            ConnectData.ExcuteNonData(sql);
            LoadDataGridView();
            MessageBox.Show(" cập nhật thành công!");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

            string sql = "delete from tblKhachHang where MaKhachHang='" + txtMaKhachHang.Text + "'";
            ConnectData.ExcuteNonData(sql);
            LoadDataGridView();
            MessageBox.Show("Xóa thành công!");
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (cbMaKhachHang.Text == "")
            {
                MessageBox.Show("Bạn phải chọn một mã hóa đơn để tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbMaKhachHang.Focus();
                return;
            }
            txtMaKhachHang.Text = cbMaKhachHang.Text;
            LoadDataGridView();
            btnThem.Enabled = true;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnCapnhat.Enabled = true;
            cbMaKhachHang.SelectedIndex = -1;
        }

        private void cbMaKhachHang_DropDown(object sender, EventArgs e)
        {
            Functions.FillCombo("SELECT MaKhachHang FROM tblKhachHang", cbMaKhachHang, "MaKhachHang", "MaKhachHang");
            cbMaKhachHang.SelectedIndex = -1;
        }

        private void btnHienthi_Click(object sender, EventArgs e)
        {
            LoadDataGridView();
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

        private void KhachHang_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            // TODO: This line of code loads data into the 'appQLBHDataSet.tblLoaiKhachHang' table. You can move, or remove it, as needed.
            this.tblLoaiKhachHangTableAdapter.Fill(this.appQLBHDataSet.tblLoaiKhachHang);

        }
    }
}
