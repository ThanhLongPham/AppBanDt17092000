namespace AppQuanLyPK
{
    partial class LoiNhuan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sốLượngDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaNhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chênhLệchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lợiNhuậnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loiNhuanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appQLBHDataSet6 = new AppQuanLyPK.AppQLBHDataSet6();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.appQLBHDataSet5 = new AppQuanLyPK.AppQLBHDataSet5();
            this.appQLBHDataSet5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loiNhuanTableAdapter = new AppQuanLyPK.AppQLBHDataSet6TableAdapters.LoiNhuanTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.minimize = new System.Windows.Forms.Button();
            this.Thoát = new System.Windows.Forms.Button();
            this.TroVe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loiNhuanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appQLBHDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appQLBHDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appQLBHDataSet5BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(516, 124);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(312, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHangDataGridViewTextBoxColumn,
            this.sốLượngDataGridViewTextBoxColumn,
            this.donGiaDataGridViewTextBoxColumn,
            this.giaNhapDataGridViewTextBoxColumn,
            this.chênhLệchDataGridViewTextBoxColumn,
            this.lợiNhuậnDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.loiNhuanBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1237, 397);
            this.dataGridView1.TabIndex = 1;
            // 
            // maHangDataGridViewTextBoxColumn
            // 
            this.maHangDataGridViewTextBoxColumn.DataPropertyName = "MaHang";
            this.maHangDataGridViewTextBoxColumn.HeaderText = "MaHang";
            this.maHangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maHangDataGridViewTextBoxColumn.Name = "maHangDataGridViewTextBoxColumn";
            this.maHangDataGridViewTextBoxColumn.Width = 125;
            // 
            // sốLượngDataGridViewTextBoxColumn
            // 
            this.sốLượngDataGridViewTextBoxColumn.DataPropertyName = "SốLượng";
            this.sốLượngDataGridViewTextBoxColumn.HeaderText = "SốLượng";
            this.sốLượngDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sốLượngDataGridViewTextBoxColumn.Name = "sốLượngDataGridViewTextBoxColumn";
            this.sốLượngDataGridViewTextBoxColumn.Width = 125;
            // 
            // donGiaDataGridViewTextBoxColumn
            // 
            this.donGiaDataGridViewTextBoxColumn.DataPropertyName = "DonGia";
            this.donGiaDataGridViewTextBoxColumn.HeaderText = "DonGia";
            this.donGiaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.donGiaDataGridViewTextBoxColumn.Name = "donGiaDataGridViewTextBoxColumn";
            this.donGiaDataGridViewTextBoxColumn.Width = 125;
            // 
            // giaNhapDataGridViewTextBoxColumn
            // 
            this.giaNhapDataGridViewTextBoxColumn.DataPropertyName = "GiaNhap";
            this.giaNhapDataGridViewTextBoxColumn.HeaderText = "GiaNhap";
            this.giaNhapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.giaNhapDataGridViewTextBoxColumn.Name = "giaNhapDataGridViewTextBoxColumn";
            this.giaNhapDataGridViewTextBoxColumn.Width = 125;
            // 
            // chênhLệchDataGridViewTextBoxColumn
            // 
            this.chênhLệchDataGridViewTextBoxColumn.DataPropertyName = "Chênh Lệch";
            this.chênhLệchDataGridViewTextBoxColumn.HeaderText = "Chênh Lệch";
            this.chênhLệchDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.chênhLệchDataGridViewTextBoxColumn.Name = "chênhLệchDataGridViewTextBoxColumn";
            this.chênhLệchDataGridViewTextBoxColumn.ReadOnly = true;
            this.chênhLệchDataGridViewTextBoxColumn.Width = 125;
            // 
            // lợiNhuậnDataGridViewTextBoxColumn
            // 
            this.lợiNhuậnDataGridViewTextBoxColumn.DataPropertyName = "Lợi Nhuận";
            this.lợiNhuậnDataGridViewTextBoxColumn.HeaderText = "Lợi Nhuận";
            this.lợiNhuậnDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lợiNhuậnDataGridViewTextBoxColumn.Name = "lợiNhuậnDataGridViewTextBoxColumn";
            this.lợiNhuậnDataGridViewTextBoxColumn.ReadOnly = true;
            this.lợiNhuậnDataGridViewTextBoxColumn.Width = 125;
            // 
            // loiNhuanBindingSource
            // 
            this.loiNhuanBindingSource.DataMember = "LoiNhuan";
            this.loiNhuanBindingSource.DataSource = this.appQLBHDataSet6;
            // 
            // appQLBHDataSet6
            // 
            this.appQLBHDataSet6.DataSetName = "AppQLBHDataSet6";
            this.appQLBHDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(363, 605);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lợi nhuận:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(363, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã sản phẩm:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(500, 605);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(328, 22);
            this.textBox1.TabIndex = 4;
            // 
            // appQLBHDataSet5
            // 
            this.appQLBHDataSet5.DataSetName = "AppQLBHDataSet5";
            this.appQLBHDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appQLBHDataSet5BindingSource
            // 
            this.appQLBHDataSet5BindingSource.DataSource = this.appQLBHDataSet5;
            this.appQLBHDataSet5BindingSource.Position = 0;
            // 
            // loiNhuanTableAdapter
            // 
            this.loiNhuanTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(567, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lợi Nhuận";
            // 
            // minimize
            // 
            this.minimize.BackColor = System.Drawing.Color.Transparent;
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimize.ForeColor = System.Drawing.Color.Black;
            this.minimize.Location = new System.Drawing.Point(1211, 2);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(30, 30);
            this.minimize.TabIndex = 93;
            this.minimize.Text = "-";
            this.minimize.UseVisualStyleBackColor = false;
            // 
            // Thoát
            // 
            this.Thoát.BackColor = System.Drawing.Color.Transparent;
            this.Thoát.BackgroundImage = global::AppQuanLyPK.Properties.Resources.close;
            this.Thoát.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Thoát.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Thoát.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thoát.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Thoát.Location = new System.Drawing.Point(1247, 2);
            this.Thoát.Name = "Thoát";
            this.Thoát.Size = new System.Drawing.Size(30, 30);
            this.Thoát.TabIndex = 92;
            this.Thoát.UseVisualStyleBackColor = false;
            // 
            // TroVe
            // 
            this.TroVe.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TroVe.BackgroundImage = global::AppQuanLyPK.Properties.Resources._return;
            this.TroVe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TroVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TroVe.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TroVe.Location = new System.Drawing.Point(3, 4);
            this.TroVe.Name = "TroVe";
            this.TroVe.Size = new System.Drawing.Size(50, 30);
            this.TroVe.TabIndex = 94;
            this.TroVe.UseVisualStyleBackColor = false;
            // 
            // LoiNhuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.TroVe);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.Thoát);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoiNhuan";
            this.Text = "LoiNhuan";
            this.Load += new System.EventHandler(this.LoiNhuan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loiNhuanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appQLBHDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appQLBHDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appQLBHDataSet5BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private AppQLBHDataSet5 appQLBHDataSet5;
        private System.Windows.Forms.BindingSource appQLBHDataSet5BindingSource;
        private AppQLBHDataSet6 appQLBHDataSet6;
        private System.Windows.Forms.BindingSource loiNhuanBindingSource;
        private AppQLBHDataSet6TableAdapters.LoiNhuanTableAdapter loiNhuanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sốLượngDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaNhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chênhLệchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lợiNhuậnDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Button Thoát;
        private System.Windows.Forms.Button TroVe;
    }
}