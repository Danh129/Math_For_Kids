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

    public partial class Form2 : Form
    {
        //Goi lai form1
        Form1 form1;
        String ten;
        int capDo;
        int[] dapAn = new int[10];
        TextBox[] txt = new TextBox[10];
        Label[] lbl = new Label[10];
        Random rd = new Random();

        public Form2(String t, int c, Form1 f1)
        {
            InitializeComponent();
            ten = t;
            capDo = c;
            //Goi form1 de quay lai
            form1 = f1;

            TaoCauHoi();
        }

        void TaoCauHoi()
        {
            int soCau = 10;

            for (int i = 0; i < soCau; i++)
            {
                int a = 0, b = 0;
                int phep = rd.Next(1, 5); // 1:+ 2:- 3:* 4:/

                // thiet lap trong panel 1 lable va 1 textbox
                lbl[i] = new Label();
                lbl[i].Location = new Point(20, 20 + i * 35);
                lbl[i].AutoSize = true;

                txt[i] = new TextBox();
                txt[i].Location = new Point(350, 20 + i * 35);
                txt[i].Width = 100;

                // =========================
                // CẤP ĐỘ 1 (CƠ BẢN)
                // =========================
                if (capDo == 1)
                {
                    if (phep == 1) // cộng
                    {
                        a = rd.Next(1, 50);
                        b = rd.Next(1, 50);
                        dapAn[i] = a + b;
                        lbl[i].Text = $"{a} + {b} = ";
                    }
                    else if (phep == 2) // trừ (không âm)
                    {
                        a = rd.Next(1, 50);
                        b = rd.Next(1, a); // đảm bảo a >= b
                        dapAn[i] = a - b;
                        lbl[i].Text = $"{a} - {b} = ";
                    }
                    else if (phep == 3) // nhân cơ bản
                    {
                        a = rd.Next(1, 10);
                        b = rd.Next(1, 10);
                        dapAn[i] = a * b;
                        lbl[i].Text = $"{a} x {b} = ";
                    }
                    else // chia hết
                    {
                        b = rd.Next(1, 10);
                        int kq = rd.Next(1, 10);

                        a = b * kq; // đảm bảo chia hết

                        dapAn[i] = kq;
                        lbl[i].Text = $"{a} / {b} = ";
                    }
                }

                // =========================
                // CẤP ĐỘ 2 (50 - 100)
                // =========================
                else if (capDo == 2)
                {
                    if (phep == 1)
                    {
                        a = rd.Next(30, 51);
                        b = rd.Next(30, 51);
                        dapAn[i] = a + b;
                        lbl[i].Text = $"{a} + {b} = ";
                    }
                    else if (phep == 2)
                    {
                        a = rd.Next(30, 51);
                        b = rd.Next(1, a);
                        dapAn[i] = a - b;
                        lbl[i].Text = $"{a} - {b} = ";
                    }
                    else if (phep == 3)
                    {
                        a = rd.Next(1, 10);
                        b = rd.Next(1, 10);
                        dapAn[i] = a * b;
                        lbl[i].Text = $"{a} x {b} = ";
                    }
                    else
                    {
                        b = rd.Next(2, 20);
                        int kq = rd.Next(2, 20);

                        a = b * kq;

                        dapAn[i] = kq;
                        lbl[i].Text = $"{a} / {b} = ";
                    }
                }

                //Cap Do 3
                else if (capDo == 3)
                {
                    if (phep == 1)
                    {
                        a = rd.Next(40, 61);
                        b = rd.Next(40, 61);
                        dapAn[i] = a + b;
                        lbl[i].Text = $"{a} + {b} = ";
                    }
                    else if (phep == 2)
                    {
                        a = rd.Next(40, 61);
                        b = rd.Next(1, a);
                        dapAn[i] = a - b;
                        lbl[i].Text = $"{a} - {b} = ";
                    }
                    else if (phep == 3)
                    {
                        a = rd.Next(1, 20);
                        b = rd.Next(1, 20);
                        dapAn[i] = a * b;
                        lbl[i].Text = $"{a} x {b} = ";
                    }
                    else
                    {
                        b = rd.Next(2, 20);
                        int kq = rd.Next(2, 20);

                        a = b * kq;

                        dapAn[i] = kq;
                        lbl[i].Text = $"{a} / {b} = ";
                    }
                }

                //Cap Do 4
                else if (capDo == 4)
                {
                    if (phep == 1)
                    {
                        a = rd.Next(50, 71);
                        b = rd.Next(50, 71);
                        dapAn[i] = a + b;
                        lbl[i].Text = $"{a} + {b} = ";
                    }
                    else if (phep == 2)
                    {
                        a = rd.Next(50, 71);
                        b = rd.Next(1, a);
                        dapAn[i] = a - b;
                        lbl[i].Text = $"{a} - {b} = ";
                    }
                    else if (phep == 3)
                    {
                        a = rd.Next(1, 20);
                        b = rd.Next(1, 20);
                        dapAn[i] = a * b;
                        lbl[i].Text = $"{a} x {b} = ";
                    }
                    else
                    {
                        b = rd.Next(2, 30);
                        int kq = rd.Next(2, 30);

                        a = b * kq;

                        dapAn[i] = kq;
                        lbl[i].Text = $"{a} / {b} = ";
                    }
                }

                //Cap Do 5
                else if (capDo == 5)
                {
                    if (phep == 1)
                    {
                        a = rd.Next(50, 101);
                        b = rd.Next(50, 101);
                        dapAn[i] = a + b;
                        lbl[i].Text = $"{a} + {b} = ";
                    }
                    else if (phep == 2)
                    {
                        a = rd.Next(50, 101);
                        b = rd.Next(1, a);
                        dapAn[i] = a - b;
                        lbl[i].Text = $"{a} - {b} = ";
                    }
                    else if (phep == 3)
                    {
                        a = rd.Next(1, 30);
                        b = rd.Next(1, 30);
                        dapAn[i] = a * b;
                        lbl[i].Text = $"{a} x {b} = ";
                    }
                    else
                    {
                        b = rd.Next(2, 30);
                        int kq = rd.Next(2, 30);

                        a = b * kq;

                        dapAn[i] = kq;
                        lbl[i].Text = $"{a} / {b} = ";
                    }
                }

                panelCauHoi.Controls.Add(lbl[i]);
                panelCauHoi.Controls.Add(txt[i]);
            }
        }



        private void btKiemTra_Click(object sender, EventArgs e)
        {
            int dung = 0, sai = 0;

            for (int i = 0; i < 10; i++)
            {
                int user;
                // Xóa khoảng trắng thừa để tránh lỗi so sánh
                string input = txt[i].Text.Trim();
                bool isNumber = int.TryParse(input, out user);

                // So sánh giá trị học sinh nhập với mảng dapAn đã lưu
                if (isNumber && user == dapAn[i])
                {
                    // NẾU ĐÚNG
                    dung++;
                    txt[i].BackColor = Color.LightGreen;
                    txt[i].ForeColor = Color.Black;
                    txt[i].Font = new Font(txt[i].Font, FontStyle.Regular);
                }
                else
                {
                    // NẾU SAI (Đây là chỗ bạn đang bị lỗi)
                    sai++;
                    txt[i].BackColor = Color.Red;

                    // DÒNG QUAN TRỌNG NHẤT: Ép TextBox hiện đáp án đúng từ mảng dapAn
                    txt[i].Text = dapAn[i].ToString();

                    // Đổi màu chữ xanh và in đậm để học sinh thấy máy đã sửa bài
                    txt[i].ForeColor = Color.Blue;
                    txt[i].Font = new Font(txt[i].Font, FontStyle.Bold);
                }

                // Khóa ô lại để học sinh không sửa đè lên đáp án đúng của máy
                txt[i].ReadOnly = true;
            }          

            MessageBox.Show(
                $"Đúng: {dung}\nSai: {sai}",
                "Kết quả",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btLamLai_Click(object sender, EventArgs e)
        {
            panelCauHoi.Controls.Clear(); // Xóa toàn bộ câu hỏi
            TaoCauHoi(); // Tạo lại đề mới

        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            int dung = 0;
            int sai = 0;
            for (int i = 0; i < 10; i++)
            {
                int user;

                if (int.TryParse(txt[i].Text, out user))
                {
                    if (user == dapAn[i])
                        dung++;
                    else
                        sai++;
                }
                else
                {
                    sai++;
                }
            }
            Form3 f = new Form3(ten, dung, sai, this);
            f.Show();
            this.Hide();
        }

        //Nut nay 1 phan de quay lai trang 1 de chon cap do va lam lai
        private void btTiepTuc_Click(object sender, EventArgs e)
        {
            form1.Show();
            this.Close();
        }
    }
}
