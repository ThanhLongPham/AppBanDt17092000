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
    public partial class HangHoa : Form
    {
        public static string Ma_loai_hang = "";
        public HangHoa()
        {
            InitializeComponent();
        }
        private void LoadDataGridView()
        {
            string sql = "SELECT * from tblHangHoa";
            DataTable MyTable = ConnectData.ExcuteDateTable_SQL(sql);
            dgvHangHoa.DataSource = MyTable;
            dgvHangHoa.Columns[0].HeaderText = "Mã sản phẩm";
            dgvHangHoa.Columns[1].HeaderText = "Mã loại hàng";
            dgvHangHoa.Columns[2].HeaderText = "Tên sản phẩm";
            dgvHangHoa.Columns[3].HeaderText = "Số lượng";
            dgvHangHoa.Columns[4].HeaderText = "Ngày khởi tạo";
            dgvHangHoa.Columns[5].HeaderText = "Giá nhập";
            dgvHangHoa.Columns[6].HeaderText = "Giá bán";
            dgvHangHoa.Columns[7].HeaderText = "Ghi chú";
            dgvHangHoa.Columns[0].Width = 100;
            dgvHangHoa.Columns[1].Width = 80;
            dgvHangHoa.Columns[2].Width = 100;
            dgvHangHoa.Columns[3].Width = 50;
            dgvHangHoa.Columns[4].Width = 100;
            dgvHangHoa.Columns[5].Width = 100;
            dgvHangHoa.Columns[6].Width = 100;
            dgvHangHoa.Columns[7].Width = 10;
            dgvHangHoa.AllowUserToAddRows = false;
            dgvHangHoa.EditMode = DataGridViewEditMode.EditProgrammatically;
            string ql = "Select* From tblHangHoa Where MaHang Like'%" + cbMaSP.Text + "%'";
            DataTable My_tk = ConnectData.ExcuteDateTable_SQL(ql);
            dgvHangHoa.DataSource = My_tk;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = true;
            btnLuu.Enabled = true;
            btnSua.Enabled = true;
            btnThem.Enabled = true;
            txtMaSP.Text = Functions.CreateKey("HH");
            LoadDataGridView();
        }

        private void cbMaLoaiHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMaLoaiHang.SelectedValue != null)
                Ma_loai_hang = cbMaLoaiHang.SelectedValue.ToString();
        }

        private void dgvHangHoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int _row = e.RowIndex;
            txtMaSP.Text = dgvHangHoa.Rows[_row].Cells[0].Value.ToString();
            cbMaLoaiHang.SelectedValue = dgvHangHoa.Rows[_row].Cells[1].Value.ToString();
            txtTenHang.Text = dgvHangHoa.Rows[_row].Cells[2].Value.ToString();
            txtSoLuong.Text = dgvHangHoa.Rows[_row].Cells[3].Value.ToString();
            dtNgayKhoiTao.Text = dgvHangHoa.Rows[_row].Cells[4].Value.ToString();
            txtGiaNhap.Text = dgvHangHoa.Rows[_row].Cells[5].Value.ToString();
            txtGiaBan.Text = dgvHangHoa.Rows[_row].Cells[6].Value.ToString();
            txtGhichu.Text = dgvHangHoa.Rows[_row].Cells[7].Value.ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = "insert into tblHangHoa (MaHang,MaLoaiHang,TenHang,SoLuong,NgayKhoiTao,GiaNhap,GiaBan,GhiChu)values('" + txtMaSP.Text + "',N'" + Ma_loai_hang + "',N'" + txtTenHang.Text + "','" + txtSoLuong.Text + "','" + dtNgayKhoiTao.Text + "','" + txtGiaNhap.Text + "',N'" + txtGiaBan.Text + "',N'" + txtGhichu.Text + "')";
            ConnectData.ExcuteNonData(sql);
            LoadDataGridView();
            MessageBox.Show("Lưu thành công!");

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "delete from tblHangHoa where Mahang='" + txtMaSP.Text + "'";
            ConnectData.ExcuteNonData(sql);
            LoadDataGridView();
            MessageBox.Show("Xóa thành công!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = "update tblHangHoa set MaLoaihang = N'" + Ma_loai_hang + "',TenHang = N'" + txtTenHang.Text + "',SoLuong ='" + txtSoLuong.Text + "',NgayKhoiTao = '" + dtNgayKhoiTao.Text + "',GiaNhap = '" + txtGiaNhap.Text + "',GiaBan = '" + txtGiaBan.Text + "',GhiChu = N'" + txtGhichu.Text + "' Where MaHang = '" + txtMaSP.Text + "'";
            ConnectData.ExcuteNonData(sql);
            LoadDataGridView();
            MessageBox.Show(" cập nhật thành công!");
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (cbMaSP.Text == "")
            {
                MessageBox.Show("Bạn phải chọn một mã hóa đơn để tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbMaSP.Focus();
                return;
            }
            txtMaSP.Text = cbMaSP.Text;
            LoadDataGridView();
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = true;
            btnSua.Enabled = true;
            cbMaSP.SelectedIndex = -1;
        }

        private void cbMaSP_DropDown(object sender, EventArgs e)
        {

            Functions.FillCombo("SELECT MaHang FROM tblHangHoa", cbMaSP, "MaHang", "MaHang");
            cbMaSP.SelectedIndex = -1;
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

        private void HangHoa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appQLBHDataSet9.tblLoaiHang' table. You can move, or remove it, as needed.
            this.tblLoaiHangTableAdapter1.Fill(this.appQLBHDataSet9.tblLoaiHang);
            // TODO: This line of code loads data into the 'appQLBHDataSet2.tblLoaiHang' table. You can move, or remove it, as needed.
            LoadDataGridView();
        }
    }
}
