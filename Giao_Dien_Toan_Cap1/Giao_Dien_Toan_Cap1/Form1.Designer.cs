namespace Giao_Dien_Toan_Cap1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.rad1 = new System.Windows.Forms.RadioButton();
            this.rad2 = new System.Windows.Forms.RadioButton();
            this.rad3 = new System.Windows.Forms.RadioButton();
            this.rad4 = new System.Windows.Forms.RadioButton();
            this.rad5 = new System.Windows.Forms.RadioButton();
            this.BtBatDai = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Tên:";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(273, 93);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(288, 30);
            this.txtTen.TabIndex = 1;
            // 
            // rad1
            // 
            this.rad1.AutoSize = true;
            this.rad1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.rad1.Location = new System.Drawing.Point(37, 92);
            this.rad1.Name = "rad1";
            this.rad1.Size = new System.Drawing.Size(97, 33);
            this.rad1.TabIndex = 2;
            this.rad1.TabStop = true;
            this.rad1.Text = "Cấp 1";
            this.rad1.UseVisualStyleBackColor = false;
            // 
            // rad2
            // 
            this.rad2.AutoSize = true;
            this.rad2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.rad2.Location = new System.Drawing.Point(191, 92);
            this.rad2.Name = "rad2";
            this.rad2.Size = new System.Drawing.Size(97, 33);
            this.rad2.TabIndex = 3;
            this.rad2.TabStop = true;
            this.rad2.Text = "Cấp 2";
            this.rad2.UseVisualStyleBackColor = false;
            // 
            // rad3
            // 
            this.rad3.AutoSize = true;
            this.rad3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.rad3.Location = new System.Drawing.Point(353, 92);
            this.rad3.Name = "rad3";
            this.rad3.Size = new System.Drawing.Size(97, 33);
            this.rad3.TabIndex = 4;
            this.rad3.TabStop = true;
            this.rad3.Text = "Cấp 3";
            this.rad3.UseVisualStyleBackColor = false;
            // 
            // rad4
            // 
            this.rad4.AutoSize = true;
            this.rad4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.rad4.Location = new System.Drawing.Point(508, 92);
            this.rad4.Name = "rad4";
            this.rad4.Size = new System.Drawing.Size(97, 33);
            this.rad4.TabIndex = 5;
            this.rad4.TabStop = true;
            this.rad4.Text = "Cấp 4";
            this.rad4.UseVisualStyleBackColor = false;
            // 
            // rad5
            // 
            this.rad5.AutoSize = true;
            this.rad5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.rad5.Location = new System.Drawing.Point(657, 92);
            this.rad5.Name = "rad5";
            this.rad5.Size = new System.Drawing.Size(97, 33);
            this.rad5.TabIndex = 6;
            this.rad5.TabStop = true;
            this.rad5.Text = "Cấp 5";
            this.rad5.UseVisualStyleBackColor = false;
            // 
            // BtBatDai
            // 
            this.BtBatDai.BackColor = System.Drawing.Color.LawnGreen;
            this.BtBatDai.ForeColor = System.Drawing.Color.Black;
            this.BtBatDai.Location = new System.Drawing.Point(405, 422);
            this.BtBatDai.Name = "BtBatDai";
            this.BtBatDai.Size = new System.Drawing.Size(176, 45);
            this.BtBatDai.TabIndex = 7;
            this.BtBatDai.Text = "Bắt Đầu";
            this.BtBatDai.UseVisualStyleBackColor = false;
            this.BtBatDai.Click += new System.EventHandler(this.BtBatDai_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.rad3);
            this.groupBox1.Controls.Add(this.rad4);
            this.groupBox1.Controls.Add(this.rad1);
            this.groupBox1.Controls.Add(this.rad2);
            this.groupBox1.Controls.Add(this.rad5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(82, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(798, 206);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn cấp độ để làm bài.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightCoral;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(327, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "⭐Chúc Các Bạn Học Tốt⭐\r\n";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Giao_Dien_Toan_Cap1.Properties.Resources.tho;
            this.pictureBox2.Location = new System.Drawing.Point(784, 378);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(172, 257);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Giao_Dien_Toan_Cap1.Properties.Resources.Canh;
            this.pictureBox1.Location = new System.Drawing.Point(12, 422);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 172);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(998, 673);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtBatDai);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Toán Học";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.RadioButton rad1;
        private System.Windows.Forms.RadioButton rad2;
        private System.Windows.Forms.RadioButton rad3;
        private System.Windows.Forms.RadioButton rad4;
        private System.Windows.Forms.RadioButton rad5;
        private System.Windows.Forms.Button BtBatDai;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

