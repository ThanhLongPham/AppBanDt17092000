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
    public partial class LoiNhuan : Form
    {
        public LoiNhuan()
        {
            InitializeComponent();
        }

        private void LoiNhuan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appQLBHDataSet6.LoiNhuan' table. You can move, or remove it, as needed.
            this.loiNhuanTableAdapter.Fill(this.appQLBHDataSet6.LoiNhuan);

        }
    }
}
