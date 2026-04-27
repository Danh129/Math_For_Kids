using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giao_Dien_Toan_Cap1
{
    public partial class Form3 : Form
    {
        //Goi lai form2
        Form2 form2;
        public Form3(String ten, int dung, int sai, Form2 f2)
        {
            InitializeComponent();

            form2 = f2;

            lbTenHS.Text = "Học sinh: " + ten;
            lbDS.Text = $"Đúng: {dung} | Sai: {sai}";

            // 1. Xác định Xếp loại để lưu vào danh sách
            string xepLoai = "";
            if (dung >= 8) xepLoai = "Giỏi";
            else if (dung >= 6) xepLoai = "Khá";
            else xepLoai = "Trung Bình";

            // 2. TỰ ĐỘNG LƯU vào danh sách hệ thống
            GlobalData.RankingList.Add(new StudentResult
            {
                Name = ten,
                Correct = dung,
                Wrong = sai,
                Date = DateTime.Now,
                Rank = xepLoai
            });

            // Xử lý thông báo
            if (dung >= 8)
            {
                lbThongBao.Text = "🎉 Chúc mừng bạn! Bạn rất giỏi!";
                lbThongBao.ForeColor = Color.Green;
            }
            else if (dung >= 6)
            {
                lbThongBao.Text = "👍 Bạn làm tốt, nhưng cần cố gắng thêm!";
                lbThongBao.ForeColor = Color.Orange;
            }
            else
            {
                lbThongBao.Text = "❌ Bạn cần cố gắng hơn!";
                lbThongBao.ForeColor = Color.Red;
            }
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btTroVe_Click(object sender, EventArgs e)
        {
            form2.Show();   // hiện lại Form2
            this.Close();   // đóng Form3
        }

        private void btXepHang_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog(); // Mở bảng xếp hạng dưới dạng hộp thoại
        }
    }
}
