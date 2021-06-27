using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace AppQuanLyPK
{
    public partial class BCDoanhThuTheoNgay : Form
    {
        public BCDoanhThuTheoNgay()
        {
            InitializeComponent();
        }

        private void BCDoanhThuTheoNgay_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'AppQLBHDataSet8.tblHDBan' table. You can move, or remove it, as needed.
            this.tblHDBanTableAdapter.Fill(this.AppQLBHDataSet8.tblHDBan);
            this.rptDoanhthutheongay.RefreshReport();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
             //Khai báo câu lệnh SQL
            String sql = "Select * from tblHDBan Where NgayBan ='" + dtNgayBan.Text+ "'";
            SqlConnection con = new SqlConnection();
            //Truyền vào chuỗi kết nối tới cơ sở dữ liệu
            //Gọi Application.StartupPath để lấy đường dẫn tới thư mục chứa file chạy chương trình 
            con.ConnectionString = "Data Source=DESKTOP-UJTJ7EB\\SQLEXPRESS;Initial Catalog=AppQLBH;Integrated Security=True";
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            adp.Fill(ds);

            //Khai báo chế độ xử lý báo cáo, trong trường hợp này lấy báo cáo ở local
            rptDoanhthutheongay.ProcessingMode = ProcessingMode.Local;
            //Đường dẫn báo cáo
            rptDoanhthutheongay.LocalReport.ReportPath = "Rptdoanhthutheongay.rdlc";
            MessageBox.Show(ds.Tables[0].Rows.Count.ToString());
            //Nếu có dữ liệu
            if (ds.Tables[0].Rows.Count > 0)
            {
                //Tạo nguồn dữ liệu cho báo cáo
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "DataSet1";
                rds.Value = ds.Tables[0];
                //Xóa dữ liệu của báo cáo cũ trong trường hợp người dùng thực hiện câu truy vấn khác
                rptDoanhthutheongay.LocalReport.DataSources.Clear();
                //Add dữ liệu vào báo cáo
                rptDoanhthutheongay.LocalReport.DataSources.Add(rds);
                //Refresh lại báo cáo
                rptDoanhthutheongay.RefreshReport();
            }
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

        private void rptDoanhthutheongay_Load(object sender, EventArgs e)
        {

        }
    }
}
