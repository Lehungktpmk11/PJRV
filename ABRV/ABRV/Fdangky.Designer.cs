namespace ABRV
{
    partial class Fdangky
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
            this.btnhuybo = new System.Windows.Forms.Button();
            this.btnxacnhan = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rdodongy = new System.Windows.Forms.RadioButton();
            this.txtmk = new System.Windows.Forms.TextBox();
            this.lblmatkhau = new System.Windows.Forms.Label();
            this.txttk = new System.Windows.Forms.TextBox();
            this.lblsdt = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnhuybo
            // 
            this.btnhuybo.FlatAppearance.BorderSize = 0;
            this.btnhuybo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnhuybo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhuybo.Location = new System.Drawing.Point(286, 14);
            this.btnhuybo.Name = "btnhuybo";
            this.btnhuybo.Size = new System.Drawing.Size(117, 38);
            this.btnhuybo.TabIndex = 0;
            this.btnhuybo.Text = "Hủy bỏ";
            this.btnhuybo.UseVisualStyleBackColor = true;
            this.btnhuybo.Click += new System.EventHandler(this.btnhuybo_Click);
            // 
            // btnxacnhan
            // 
            this.btnxacnhan.FlatAppearance.BorderSize = 0;
            this.btnxacnhan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnxacnhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnxacnhan.Location = new System.Drawing.Point(61, 14);
            this.btnxacnhan.Name = "btnxacnhan";
            this.btnxacnhan.Size = new System.Drawing.Size(117, 38);
            this.btnxacnhan.TabIndex = 0;
            this.btnxacnhan.Text = "Xác nhận";
            this.btnxacnhan.UseVisualStyleBackColor = true;
            this.btnxacnhan.Click += new System.EventHandler(this.btnxacnhan_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnxacnhan);
            this.panel1.Controls.Add(this.btnhuybo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 288);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 64);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(476, 79);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::ABRV.Properties.Resources.abrv;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(476, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.rdodongy);
            this.panel3.Controls.Add(this.txtmk);
            this.panel3.Controls.Add(this.lblmatkhau);
            this.panel3.Controls.Add(this.txttk);
            this.panel3.Controls.Add(this.lblsdt);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 79);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(476, 209);
            this.panel3.TabIndex = 3;
            // 
            // rdodongy
            // 
            this.rdodongy.AutoSize = true;
            this.rdodongy.Location = new System.Drawing.Point(112, 150);
            this.rdodongy.Name = "rdodongy";
            this.rdodongy.Size = new System.Drawing.Size(212, 17);
            this.rdodongy.TabIndex = 2;
            this.rdodongy.TabStop = true;
            this.rdodongy.Text = "Đồng ý với điều khoản của AB Rao vặt";
            this.rdodongy.UseVisualStyleBackColor = true;
            // 
            // txtmk
            // 
            this.txtmk.Location = new System.Drawing.Point(188, 99);
            this.txtmk.Name = "txtmk";
            this.txtmk.Size = new System.Drawing.Size(178, 20);
            this.txtmk.TabIndex = 1;
            // 
            // lblmatkhau
            // 
            this.lblmatkhau.AutoSize = true;
            this.lblmatkhau.Location = new System.Drawing.Point(103, 106);
            this.lblmatkhau.Name = "lblmatkhau";
            this.lblmatkhau.Size = new System.Drawing.Size(52, 13);
            this.lblmatkhau.TabIndex = 0;
            this.lblmatkhau.Text = "Mật khẩu";
            // 
            // txttk
            // 
            this.txttk.Location = new System.Drawing.Point(188, 52);
            this.txttk.Name = "txttk";
            this.txttk.Size = new System.Drawing.Size(178, 20);
            this.txttk.TabIndex = 1;
            // 
            // lblsdt
            // 
            this.lblsdt.AutoSize = true;
            this.lblsdt.Location = new System.Drawing.Point(103, 59);
            this.lblsdt.Name = "lblsdt";
            this.lblsdt.Size = new System.Drawing.Size(70, 13);
            this.lblsdt.TabIndex = 0;
            this.lblsdt.Text = "Số điện thoại";
            // 
            // Fdangky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 352);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Fdangky";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fdangky";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnhuybo;
        private System.Windows.Forms.Button btnxacnhan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rdodongy;
        private System.Windows.Forms.TextBox txtmk;
        private System.Windows.Forms.Label lblmatkhau;
        private System.Windows.Forms.TextBox txttk;
        private System.Windows.Forms.Label lblsdt;
    }
}