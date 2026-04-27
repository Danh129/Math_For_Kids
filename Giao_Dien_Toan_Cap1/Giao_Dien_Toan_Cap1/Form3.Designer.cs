namespace Giao_Dien_Toan_Cap1
{
    partial class Form3
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
            this.lbTenHS = new System.Windows.Forms.Label();
            this.lbDS = new System.Windows.Forms.Label();
            this.lbThongBao = new System.Windows.Forms.Label();
            this.btDong = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btTroVe = new System.Windows.Forms.Button();
            this.btXepHang = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTenHS
            // 
            this.lbTenHS.AutoSize = true;
            this.lbTenHS.BackColor = System.Drawing.Color.White;
            this.lbTenHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenHS.Location = new System.Drawing.Point(55, 99);
            this.lbTenHS.Name = "lbTenHS";
            this.lbTenHS.Size = new System.Drawing.Size(101, 29);
            this.lbTenHS.TabIndex = 0;
            this.lbTenHS.Text = "Tên HS:";
            // 
            // lbDS
            // 
            this.lbDS.AutoSize = true;
            this.lbDS.BackColor = System.Drawing.Color.White;
            this.lbDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDS.Location = new System.Drawing.Point(55, 181);
            this.lbDS.Name = "lbDS";
            this.lbDS.Size = new System.Drawing.Size(112, 29);
            this.lbDS.TabIndex = 1;
            this.lbDS.Text = "Đúng/Sai";
            // 
            // lbThongBao
            // 
            this.lbThongBao.AutoSize = true;
            this.lbThongBao.BackColor = System.Drawing.Color.White;
            this.lbThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongBao.Location = new System.Drawing.Point(55, 258);
            this.lbThongBao.Name = "lbThongBao";
            this.lbThongBao.Size = new System.Drawing.Size(132, 29);
            this.lbThongBao.TabIndex = 2;
            this.lbThongBao.Text = "Thông Báo";
            // 
            // btDong
            // 
            this.btDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btDong.Location = new System.Drawing.Point(838, 539);
            this.btDong.Name = "btDong";
            this.btDong.Size = new System.Drawing.Size(179, 45);
            this.btDong.TabIndex = 3;
            this.btDong.Text = "Đóng";
            this.btDong.UseVisualStyleBackColor = false;
            this.btDong.Click += new System.EventHandler(this.btDong_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Giao_Dien_Toan_Cap1.Properties.Resources.TraiTim;
            this.pictureBox2.Location = new System.Drawing.Point(12, 461);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(288, 183);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Giao_Dien_Toan_Cap1.Properties.Resources.Voi;
            this.pictureBox1.Location = new System.Drawing.Point(784, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 198);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btTroVe
            // 
            this.btTroVe.BackColor = System.Drawing.Color.Goldenrod;
            this.btTroVe.Location = new System.Drawing.Point(605, 539);
            this.btTroVe.Name = "btTroVe";
            this.btTroVe.Size = new System.Drawing.Size(154, 45);
            this.btTroVe.TabIndex = 6;
            this.btTroVe.Text = "Quay Lại";
            this.btTroVe.UseVisualStyleBackColor = false;
            this.btTroVe.Click += new System.EventHandler(this.btTroVe_Click);
            // 
            // btXepHang
            // 
            this.btXepHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btXepHang.Location = new System.Drawing.Point(350, 539);
            this.btXepHang.Name = "btXepHang";
            this.btXepHang.Size = new System.Drawing.Size(137, 45);
            this.btXepHang.TabIndex = 7;
            this.btXepHang.Text = "Xếp Hạng";
            this.btXepHang.UseVisualStyleBackColor = false;
            this.btXepHang.Click += new System.EventHandler(this.btXepHang_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(559, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "CÁC BẠN ĐÃ CỐ GẮNG RẤT NHIỀU RỒI!!!";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1055, 686);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btXepHang);
            this.Controls.Add(this.btTroVe);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btDong);
            this.Controls.Add(this.lbThongBao);
            this.Controls.Add(this.lbDS);
            this.Controls.Add(this.lbTenHS);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form3";
            this.Text = "Lưu Danh Sách";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTenHS;
        private System.Windows.Forms.Label lbDS;
        private System.Windows.Forms.Label lbThongBao;
        private System.Windows.Forms.Button btDong;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btQuayLai;
        private System.Windows.Forms.Button btTroVe;
        private System.Windows.Forms.Button btXepHang;
        private System.Windows.Forms.Label label1;
    }
}