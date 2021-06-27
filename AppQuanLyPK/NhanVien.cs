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
    public partial class NhanVien : Form
    {
        private static string chuc_vu = "";
        public NhanVien()
        {
            InitializeComponent();
        }
        private void LoadDataGridView()
        {
            string sql = "SELECT * from tblNhanVien";
            DataTable MyTable = ConnectData.ExcuteDateTable_SQL(sql);
            dgNhanVien.DataSource = MyTable;
            dgNhanVien.Columns[0].HeaderText = "Mã NV";
            dgNhanVien.Columns[1].HeaderText = "Họ Và Tên";
            dgNhanVien.Columns[2].HeaderText = "Giới Tính";
            dgNhanVien.Columns[3].HeaderText = "Ngày Sinh";
            dgNhanVien.Columns[4].HeaderText = "Số Điện Thoại";
            dgNhanVien.Columns[5].HeaderText = "Địa Chỉ";
            dgNhanVien.Columns[6].HeaderText = "Chức Vụ";
            dgNhanVien.Columns[7].HeaderText = "Ảnh";
            dgNhanVien.Columns[0].Width = 100;
            dgNhanVien.Columns[1].Width = 140;
            dgNhanVien.Columns[2].Width = 100;
            dgNhanVien.Columns[3].Width = 120;
            dgNhanVien.Columns[4].Width = 120;
            dgNhanVien.Columns[5].Width = 140;
            dgNhanVien.Columns[6].Width = 140;
            dgNhanVien.Columns[7].Width = 300;
            dgNhanVien.AllowUserToAddRows = false;
            dgNhanVien.EditMode = DataGridViewEditMode.EditProgrammatically;
            string ql = "Select* From tblNhanVien Where MaNhanVien Like'%" + cbManhanvien.Text + "%'";
            DataTable My_tk = ConnectData.ExcuteDateTable_SQL(ql);
            dgNhanVien.DataSource = My_tk;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = true;
            btnLuu.Enabled = true;
            btnCapnhat.Enabled = true;
            btnThem.Enabled = true;
            txtMaNhanVien.Text = Functions.CreateKey("NV");
            LoadDataGridView();
        }

        private void cbChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbChucVu.SelectedValue != null)
                chuc_vu = cbChucVu.SelectedValue.ToString();
        }
        private int getGioiTinh()
        {
            if (rdNam.Checked == true && rdNu.Checked == false)
                return 1;
            else if (rdNam.Checked == false && rdNu.Checked == true)
                return 0;
            else
                return 0;
        }
        private void SetGioitinh(int gioitinh)
        {
            if (gioitinh == 0)
            { rdNam.Checked = false; rdNu.Checked = true; }
            else
            {
                rdNam.Checked = true;
                rdNu.Checked = false;
            }
        }

        private void dgNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int _row = e.RowIndex;
            txtMaNhanVien.Text = dgNhanVien.Rows[_row].Cells[0].Value.ToString();
            txtTenNhanVien.Text = dgNhanVien.Rows[_row].Cells[1].Value.ToString();
            SetGioitinh(int.Parse(dgNhanVien.Rows[_row].Cells[2].Value.ToString()));
            dtNgaySinh.Text = dgNhanVien.Rows[_row].Cells[3].Value.ToString();
            txtSoDienThoai.Text = dgNhanVien.Rows[_row].Cells[4].Value.ToString();
            txtDiaChi.Text = dgNhanVien.Rows[_row].Cells[5].Value.ToString();
            cbChucVu.SelectedValue = dgNhanVien.Rows[_row].Cells[6].Value.ToString();
            txtAnh.Text = dgNhanVien.Rows[_row].Cells[7].Value.ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (rdNam.Checked == false && rdNu.Checked == false)
                MessageBox.Show("bạn chưa chọn giới tính!");
            else
            {
                int GioiTinh = getGioiTinh();
                string sql = "insert into tblNhanVien (MaNhanVien,TenNhanVien,GioiTinh,NgaySinh,SoDienThoai,DiaChi,ChucVu,Anh)values('" + txtMaNhanVien.Text + "',N'" + txtTenNhanVien.Text + "','" + GioiTinh + "','" + dtNgaySinh.Text + "','" + txtSoDienThoai.Text + "',N'" + txtDiaChi.Text + "',N'" + chuc_vu + "','" + txtAnh.Text + "')";
                ConnectData.ExcuteNonData(sql);
                LoadDataGridView();
                MessageBox.Show("Thêm thành công!");
            }
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            string sql = "update tblNhanVien set TenNhanVien=N'" + txtTenNhanVien.Text + "',GioiTinh='" + getGioiTinh() + "',NgaySinh='" + dtNgaySinh.Text + "',SoDienThoai='" + txtSoDienThoai.Text + "',DiaChi=N'" + txtDiaChi.Text + "',ChucVu=N'" + chuc_vu + "',Anh='" + txtAnh.Text + "' Where MaNhanVien='" + txtMaNhanVien.Text + "'";
            ConnectData.ExcuteNonData(sql);
            LoadDataGridView();
            MessageBox.Show(" cập nhật thành công!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "delete from tblNhanVien where MaNhanVien='" + txtMaNhanVien.Text + "'";
            ConnectData.ExcuteNonData(sql);
            LoadDataGridView();
            MessageBox.Show("Xóa thành công!");
        }

        private void Mo_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chọn ảnh minh hoạ cho sản phẩm";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                picAnh.Image = Image.FromFile(dlgOpen.FileName);
                txtAnh.Text = dlgOpen.FileName;
            }
        }

        private void rdNam_CheckedChanged(object sender, EventArgs e)
        {
            getGioiTinh();
        }

        private void rdNu_CheckedChanged(object sender, EventArgs e)
        {
            getGioiTinh();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (cbManhanvien.Text == "")
            {
                MessageBox.Show("Bạn phải chọn một mã hóa đơn để tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbManhanvien.Focus();
                return;
            }
            txtMaNhanVien.Text = cbManhanvien.Text;
            LoadDataGridView();
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = true;
            btnCapnhat.Enabled = true;
            cbManhanvien.SelectedIndex = -1;
        }

        private void cbManhanvien_DropDown(object sender, EventArgs e)
        {
            Functions.FillCombo("SELECT MaNhanVien FROM tblNhanVien", cbManhanvien, "MaNhanVien", "MaNhanVien");
            cbManhanvien.SelectedIndex = -1;
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Thoát_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có muốn thoát không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (h == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void TroVe_Click(object sender, EventArgs e)
        {
            HeThong fn = new HeThong();
            this.Hide();
            fn.Show();
        }

        private void btnHienthi_Click(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            // TODO: This line of code loads data into the 'appQLBHDataSet1.tblChucVu' table. You can move, or remove it, as needed.
            this.tblChucVuTableAdapter.Fill(this.appQLBHDataSet1.tblChucVu);

        }
    }
}
