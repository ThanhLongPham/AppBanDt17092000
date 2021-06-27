using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;


namespace AppQuanLyPK
{
    public partial class XacNhan : Form
    {
        string randomCode;
        public static string to;
        public XacNhan()
        {
            InitializeComponent();
        }

        private void btGuiMa_Click(object sender, EventArgs e)
        {
            if (txtemail.Text == "")
            {
                label2.ForeColor = System.Drawing.Color.Red;
                label2.Text = "Bạn chưa nhập Email!";
            }
            else
            {
                string from, pass, messageBody;
                Random rand = new Random();
                randomCode = (rand.Next(999999)).ToString();
                MailMessage message = new MailMessage();
                to = (txtemail.Text).ToString();
                from = "Phamlong2292@gmail.com";
                pass = "wenmatroj17092000";
                messageBody = "your reset cosde is" + randomCode;
                message.To.Add(to);
                message.From = new MailAddress(from);
                message.Body = messageBody;
                message.Subject = "password reseting code";
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);
                try
                {
                    smtp.Send(message);
                    label2.ForeColor = System.Drawing.Color.Green;
                    label2.Text = "code send successfully!";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btXacNhanMa_Click(object sender, EventArgs e)
        {
            if (txtcode.Text == "")
            {
                label3.ForeColor = System.Drawing.Color.Red;
                label3.Text = "Bạn chưa nhập mã code!";
            }
            else
            {
                if (randomCode == (txtcode.Text).ToString())
                {
                    to = txtemail.Text;
                    DoiMatKhau rp = new DoiMatKhau();
                    this.Hide();
                    rp.Show();
                }
                else
                {
                    label3.ForeColor = System.Drawing.Color.Red;
                    label3.Text = " Mã code không đúng!";
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
