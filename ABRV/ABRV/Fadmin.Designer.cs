namespace ABRV
{
    partial class Fadmin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnthoat = new System.Windows.Forms.Button();
            this.grbtk = new System.Windows.Forms.GroupBox();
            this.rdonguoidung = new System.Windows.Forms.RadioButton();
            this.rdoadmin = new System.Windows.Forms.RadioButton();
            this.lblquyen = new System.Windows.Forms.Label();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.lblmk = new System.Windows.Forms.Label();
            this.txttaikhoan = new System.Windows.Forms.TextBox();
            this.lbltk = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgvhienthitk = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbltimkiem = new System.Windows.Forms.Label();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýĐăngKýTKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.grbtk.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhienthitk)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(661, 66);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnthoat);
            this.panel2.Controls.Add(this.grbtk);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(212, 528);
            this.panel2.TabIndex = 1;
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(27, 478);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(131, 27);
            this.btnthoat.TabIndex = 5;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // grbtk
            // 
            this.grbtk.Controls.Add(this.rdonguoidung);
            this.grbtk.Controls.Add(this.rdoadmin);
            this.grbtk.Controls.Add(this.lblquyen);
            this.grbtk.Controls.Add(this.txtmatkhau);
            this.grbtk.Controls.Add(this.lblmk);
            this.grbtk.Controls.Add(this.txttaikhoan);
            this.grbtk.Controls.Add(this.lbltk);
            this.grbtk.Controls.Add(this.txtid);
            this.grbtk.Controls.Add(this.lblid);
            this.grbtk.Location = new System.Drawing.Point(9, 38);
            this.grbtk.Name = "grbtk";
            this.grbtk.Size = new System.Drawing.Size(192, 290);
            this.grbtk.TabIndex = 4;
            this.grbtk.TabStop = false;
            this.grbtk.Text = "Tài khoản";
            // 
            // rdonguoidung
            // 
            this.rdonguoidung.AutoSize = true;
            this.rdonguoidung.Location = new System.Drawing.Point(13, 257);
            this.rdonguoidung.Name = "rdonguoidung";
            this.rdonguoidung.Size = new System.Drawing.Size(80, 17);
            this.rdonguoidung.TabIndex = 3;
            this.rdonguoidung.TabStop = true;
            this.rdonguoidung.Text = "Người dùng";
            this.rdonguoidung.UseVisualStyleBackColor = true;
            // 
            // rdoadmin
            // 
            this.rdoadmin.AutoSize = true;
            this.rdoadmin.Location = new System.Drawing.Point(12, 224);
            this.rdoadmin.Name = "rdoadmin";
            this.rdoadmin.Size = new System.Drawing.Size(54, 17);
            this.rdoadmin.TabIndex = 3;
            this.rdoadmin.TabStop = true;
            this.rdoadmin.Text = "Admin";
            this.rdoadmin.UseVisualStyleBackColor = true;
            // 
            // lblquyen
            // 
            this.lblquyen.AutoSize = true;
            this.lblquyen.Location = new System.Drawing.Point(10, 190);
            this.lblquyen.Name = "lblquyen";
            this.lblquyen.Size = new System.Drawing.Size(64, 13);
            this.lblquyen.TabIndex = 2;
            this.lblquyen.Text = "Phân quyền";
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Location = new System.Drawing.Point(10, 153);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Size = new System.Drawing.Size(171, 20);
            this.txtmatkhau.TabIndex = 1;
            // 
            // lblmk
            // 
            this.lblmk.AutoSize = true;
            this.lblmk.Location = new System.Drawing.Point(7, 133);
            this.lblmk.Name = "lblmk";
            this.lblmk.Size = new System.Drawing.Size(52, 13);
            this.lblmk.TabIndex = 0;
            this.lblmk.Text = "Mật khẩu";
            // 
            // txttaikhoan
            // 
            this.txttaikhoan.Location = new System.Drawing.Point(10, 99);
            this.txttaikhoan.Name = "txttaikhoan";
            this.txttaikhoan.Size = new System.Drawing.Size(171, 20);
            this.txttaikhoan.TabIndex = 1;
            // 
            // lbltk
            // 
            this.lbltk.AutoSize = true;
            this.lbltk.Location = new System.Drawing.Point(7, 79);
            this.lbltk.Name = "lbltk";
            this.lbltk.Size = new System.Drawing.Size(55, 13);
            this.lbltk.TabIndex = 0;
            this.lbltk.Text = "Tài khoản";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(10, 43);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(171, 20);
            this.txtid.TabIndex = 1;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(7, 23);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(18, 13);
            this.lblid.TabIndex = 0;
            this.lblid.Text = "ID";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(212, 66);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(449, 528);
            this.panel3.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dgvhienthitk);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 70);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(449, 406);
            this.panel6.TabIndex = 3;
            // 
            // dgvhienthitk
            // 
            this.dgvhienthitk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhienthitk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvhienthitk.Location = new System.Drawing.Point(0, 0);
            this.dgvhienthitk.Name = "dgvhienthitk";
            this.dgvhienthitk.Size = new System.Drawing.Size(449, 406);
            this.dgvhienthitk.TabIndex = 0;
            this.dgvhienthitk.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvhienthitk_CellClick);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnxoa);
            this.panel5.Controls.Add(this.btnsua);
            this.panel5.Controls.Add(this.btnthem);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 476);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(449, 52);
            this.panel5.TabIndex = 2;
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(275, 13);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(90, 28);
            this.btnxoa.TabIndex = 0;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(162, 12);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(90, 28);
            this.btnsua.TabIndex = 0;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(49, 13);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(90, 28);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbltimkiem);
            this.panel4.Controls.Add(this.txttimkiem);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(449, 70);
            this.panel4.TabIndex = 1;
            // 
            // lbltimkiem
            // 
            this.lbltimkiem.AutoSize = true;
            this.lbltimkiem.Location = new System.Drawing.Point(20, 16);
            this.lbltimkiem.Name = "lbltimkiem";
            this.lbltimkiem.Size = new System.Drawing.Size(49, 13);
            this.lbltimkiem.TabIndex = 1;
            this.lbltimkiem.Text = "Tìm kiếm";
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(99, 13);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(201, 20);
            this.txttimkiem.TabIndex = 0;
            this.txttimkiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttimkiem_KeyPress);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhMụcToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(661, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýĐăngKýTKToolStripMenuItem});
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.danhMụcToolStripMenuItem.Text = "Danh mục";
            // 
            // quảnLýĐăngKýTKToolStripMenuItem
            // 
            this.quảnLýĐăngKýTKToolStripMenuItem.Name = "quảnLýĐăngKýTKToolStripMenuItem";
            this.quảnLýĐăngKýTKToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quảnLýĐăngKýTKToolStripMenuItem.Text = "Quản lý đăng ký TK";
            this.quảnLýĐăngKýTKToolStripMenuItem.Click += new System.EventHandler(this.quảnLýĐăngKýTKToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Fadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 594);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Fadmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fadmin";
            this.Load += new System.EventHandler(this.Fadmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.grbtk.ResumeLayout(false);
            this.grbtk.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvhienthitk)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbltimkiem;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.GroupBox grbtk;
        private System.Windows.Forms.RadioButton rdonguoidung;
        private System.Windows.Forms.RadioButton rdoadmin;
        private System.Windows.Forms.Label lblquyen;
        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.Label lblmk;
        private System.Windows.Forms.TextBox txttaikhoan;
        private System.Windows.Forms.Label lbltk;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dgvhienthitk;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýĐăngKýTKToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}