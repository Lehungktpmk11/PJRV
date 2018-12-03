namespace ABRV
{
    partial class Fqldangky
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.lbltimkiem = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnhuybo = new System.Windows.Forms.Button();
            this.btnxacnhan = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvdktk = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdktk)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txttimkiem);
            this.panel1.Controls.Add(this.lbltimkiem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 68);
            this.panel1.TabIndex = 0;
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(156, 21);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(177, 20);
            this.txttimkiem.TabIndex = 1;
            this.txttimkiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttimkiem_KeyPress);
            // 
            // lbltimkiem
            // 
            this.lbltimkiem.AutoSize = true;
            this.lbltimkiem.Location = new System.Drawing.Point(83, 24);
            this.lbltimkiem.Name = "lbltimkiem";
            this.lbltimkiem.Size = new System.Drawing.Size(24, 13);
            this.lbltimkiem.TabIndex = 0;
            this.lbltimkiem.Text = "Tìm";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnthoat);
            this.panel2.Controls.Add(this.btnhuybo);
            this.panel2.Controls.Add(this.btnxacnhan);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 395);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(498, 55);
            this.panel2.TabIndex = 1;
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(396, 9);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 34);
            this.btnthoat.TabIndex = 0;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnhuybo
            // 
            this.btnhuybo.Location = new System.Drawing.Point(156, 9);
            this.btnhuybo.Name = "btnhuybo";
            this.btnhuybo.Size = new System.Drawing.Size(75, 34);
            this.btnhuybo.TabIndex = 0;
            this.btnhuybo.Text = "Hủy bỏ";
            this.btnhuybo.UseVisualStyleBackColor = true;
            this.btnhuybo.Click += new System.EventHandler(this.btnhuybo_Click);
            // 
            // btnxacnhan
            // 
            this.btnxacnhan.Location = new System.Drawing.Point(43, 9);
            this.btnxacnhan.Name = "btnxacnhan";
            this.btnxacnhan.Size = new System.Drawing.Size(75, 34);
            this.btnxacnhan.TabIndex = 0;
            this.btnxacnhan.Text = "Xác nhận";
            this.btnxacnhan.UseVisualStyleBackColor = true;
            this.btnxacnhan.Click += new System.EventHandler(this.btnxacnhan_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvdktk);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(498, 327);
            this.panel3.TabIndex = 2;
            // 
            // dgvdktk
            // 
            this.dgvdktk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdktk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvdktk.Location = new System.Drawing.Point(0, 0);
            this.dgvdktk.Name = "dgvdktk";
            this.dgvdktk.Size = new System.Drawing.Size(498, 327);
            this.dgvdktk.TabIndex = 0;
            this.dgvdktk.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdktk_CellClick);
            // 
            // Fqldangky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Fqldangky";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fqldangky";
            this.Load += new System.EventHandler(this.Fqldangky_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdktk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Label lbltimkiem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvdktk;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnhuybo;
        private System.Windows.Forms.Button btnxacnhan;
    }
}