namespace QLKS
{
    partial class frmMain
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPhong = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pnMain = new System.Windows.Forms.Panel();
            this.btnListDatPhong = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnPhong);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.btnListDatPhong);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 58);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnPhong
            // 
            this.btnPhong.Location = new System.Drawing.Point(3, 3);
            this.btnPhong.Name = "btnPhong";
            this.btnPhong.Size = new System.Drawing.Size(112, 49);
            this.btnPhong.TabIndex = 0;
            this.btnPhong.Text = "Phòng";
            this.btnPhong.UseVisualStyleBackColor = true;
            this.btnPhong.Click += new System.EventHandler(this.btnPhong_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(121, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "Khách hàng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(238, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 49);
            this.button2.TabIndex = 2;
            this.button2.Text = "Đặt phòng";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pnMain
            // 
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 58);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(800, 392);
            this.pnMain.TabIndex = 2;
            // 
            // btnListDatPhong
            // 
            this.btnListDatPhong.Location = new System.Drawing.Point(347, 3);
            this.btnListDatPhong.Name = "btnListDatPhong";
            this.btnListDatPhong.Size = new System.Drawing.Size(131, 49);
            this.btnListDatPhong.TabIndex = 3;
            this.btnListDatPhong.Text = "Danh sách đặt phòng";
            this.btnListDatPhong.UseVisualStyleBackColor = true;
            this.btnListDatPhong.Click += new System.EventHandler(this.btnListDatPhong_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "frmMain";
            this.Text = "Main";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnPhong;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnListDatPhong;
    }
}

