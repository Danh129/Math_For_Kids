using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace Giao_Dien_Toan_Cap1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            LoadData();

            // Đổ dữ liệu vào bảng
            var sortedList = GlobalData.RankingList.OrderByDescending(x => x.Correct).ToList();
            dgvRanking.DataSource = sortedList;

            // Bật thanh cuộn dọc nếu dữ liệu vượt quá chiều cao hiển thị
            dgvRanking.ScrollBars = ScrollBars.Both;

            // Tùy chỉnh chiều cao dòng để thanh cuộn hoạt động mượt hơn
            dgvRanking.RowTemplate.Height = 30;
        }

        // Tách ra hàm riêng để dễ quản lý
        void LoadData()
        {
            // Clear dữ liệu cũ tránh bị trùng hiển thị nếu cần
            dgvRanking.DataSource = null;

            var sortedList = GlobalData.RankingList.OrderByDescending(x => x.Correct).ToList();
            dgvRanking.DataSource = sortedList;

            // Định dạng lại cột (Code của bạn đã đúng)
            dgvRanking.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (dgvRanking.Columns["Name"] != null)
            {
                dgvRanking.Columns["Name"].HeaderText = "Tên Học Sinh";
                dgvRanking.Columns["Correct"].HeaderText = "Số Câu Đúng";
                dgvRanking.Columns["Wrong"].HeaderText = "Số Câu Sai";
                dgvRanking.Columns["Rank"].HeaderText = "Xếp Loại";
                dgvRanking.Columns["Date"].HeaderText = "Ngày Làm";
                
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (GlobalData.RankingList.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu để xuất!", "Thông báo");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV File (*.csv)|*.csv";
            sfd.FileName = "DanhSachXepHang.csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Sử dụng UTF8 với BOM để Excel nhận diện được tiếng Việt có dấu
                    using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
                    {
                        // Viết tiêu đề cột - Phải khớp với các thuộc tính trong StudentResult
                        sw.WriteLine("Tên Học Sinh,Số Câu Đúng,Số Câu Sai,Xếp Loại,Ngày Làm");

                        foreach (var item in GlobalData.RankingList)
                        {
                            // Chuyển ngày tháng sang định dạng dễ nhìn
                            string dateStr = item.Date.ToString("dd/MM/yyyy HH:mm");

                            // Ghi từng dòng dữ liệu, ngăn cách bởi dấu phẩy
                            sw.WriteLine($"{item.Name},{item.Correct},{item.Wrong},{item.Rank},{dateStr}");
                        }
                    }
                    MessageBox.Show("Xuất file thành công!", "Thông báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu file: " + ex.Message);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
