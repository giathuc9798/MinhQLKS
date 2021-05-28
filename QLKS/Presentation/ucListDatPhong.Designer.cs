namespace QLKS.Presentation
{
    partial class ucListDatPhong
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvListDatPhong = new System.Windows.Forms.DataGridView();
            this.MaDatPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChiPhiPhatSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhachHangs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phongs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListDatPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtKeyword);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(772, 68);
            this.panel1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nhập từ khóa cần tìm:";
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(159, 20);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(221, 22);
            this.txtKeyword.TabIndex = 12;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnAdd);
            this.flowLayoutPanel1.Controls.Add(this.btnEdit);
            this.flowLayoutPanel1.Controls.Add(this.btnDelete);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(522, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(250, 68);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(3, 10);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 35);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(84, 10);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 35);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(165, 10);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 35);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(386, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(96, 30);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvListDatPhong);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(772, 478);
            this.panel2.TabIndex = 11;
            // 
            // dgvListDatPhong
            // 
            this.dgvListDatPhong.AllowUserToAddRows = false;
            this.dgvListDatPhong.AllowUserToDeleteRows = false;
            this.dgvListDatPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListDatPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListDatPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDatPhong,
            this.MaKH,
            this.MaPhong,
            this.NgayDen,
            this.NgayDi,
            this.TinhTrang,
            this.ThanhToan,
            this.ChiPhiPhatSinh,
            this.KhachHangs,
            this.Phongs});
            this.dgvListDatPhong.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvListDatPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListDatPhong.Location = new System.Drawing.Point(0, 0);
            this.dgvListDatPhong.Name = "dgvListDatPhong";
            this.dgvListDatPhong.ReadOnly = true;
            this.dgvListDatPhong.RowHeadersWidth = 51;
            this.dgvListDatPhong.RowTemplate.Height = 24;
            this.dgvListDatPhong.Size = new System.Drawing.Size(772, 478);
            this.dgvListDatPhong.TabIndex = 0;
            // 
            // MaDatPhong
            // 
            this.MaDatPhong.DataPropertyName = "MaDatPhong";
            this.MaDatPhong.HeaderText = "Mã đặt phòng";
            this.MaDatPhong.MinimumWidth = 6;
            this.MaDatPhong.Name = "MaDatPhong";
            this.MaDatPhong.ReadOnly = true;
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã khách hàng";
            this.MaKH.MinimumWidth = 6;
            this.MaKH.Name = "MaKH";
            this.MaKH.ReadOnly = true;
            // 
            // MaPhong
            // 
            this.MaPhong.DataPropertyName = "MaPhong";
            this.MaPhong.HeaderText = "Mã phòng";
            this.MaPhong.MinimumWidth = 6;
            this.MaPhong.Name = "MaPhong";
            this.MaPhong.ReadOnly = true;
            // 
            // NgayDen
            // 
            this.NgayDen.DataPropertyName = "NgayDen";
            this.NgayDen.HeaderText = "Ngày đến";
            this.NgayDen.MinimumWidth = 6;
            this.NgayDen.Name = "NgayDen";
            this.NgayDen.ReadOnly = true;
            // 
            // NgayDi
            // 
            this.NgayDi.DataPropertyName = "NgayDi";
            this.NgayDi.HeaderText = "Ngày đi";
            this.NgayDi.MinimumWidth = 6;
            this.NgayDi.Name = "NgayDi";
            this.NgayDi.ReadOnly = true;
            // 
            // TinhTrang
            // 
            this.TinhTrang.DataPropertyName = "TinhTrang";
            this.TinhTrang.HeaderText = "Tình trạng";
            this.TinhTrang.MinimumWidth = 6;
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.ReadOnly = true;
            // 
            // ThanhToan
            // 
            this.ThanhToan.DataPropertyName = "ThanhToan";
            this.ThanhToan.HeaderText = "Thanh toán";
            this.ThanhToan.MinimumWidth = 6;
            this.ThanhToan.Name = "ThanhToan";
            this.ThanhToan.ReadOnly = true;
            // 
            // ChiPhiPhatSinh
            // 
            this.ChiPhiPhatSinh.DataPropertyName = "ChiPhiPhatSinh";
            this.ChiPhiPhatSinh.HeaderText = "Chi phí phát sinh";
            this.ChiPhiPhatSinh.MinimumWidth = 6;
            this.ChiPhiPhatSinh.Name = "ChiPhiPhatSinh";
            this.ChiPhiPhatSinh.ReadOnly = true;
            // 
            // KhachHangs
            // 
            this.KhachHangs.HeaderText = "Khách hàng";
            this.KhachHangs.MinimumWidth = 6;
            this.KhachHangs.Name = "KhachHangs";
            this.KhachHangs.ReadOnly = true;
            this.KhachHangs.Visible = false;
            // 
            // Phongs
            // 
            this.Phongs.HeaderText = "Phòng";
            this.Phongs.MinimumWidth = 6;
            this.Phongs.Name = "Phongs";
            this.Phongs.ReadOnly = true;
            this.Phongs.Visible = false;
            // 
            // ucListDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ucListDatPhong";
            this.Size = new System.Drawing.Size(772, 546);
            this.Load += new System.EventHandler(this.ucListDatPhong_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListDatPhong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvListDatPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDatPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChiPhiPhatSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhachHangs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phongs;
    }
}
