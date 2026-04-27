using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giao_Dien_Toan_Cap1
{
    public class StudentResult
    {
        public string Name { get; set; }
        public int Correct { get; set; }
        public int Wrong { get; set; }
        public DateTime Date { get; set; }
        public string Rank { get; set; } // Xếp loại: Giỏi, Khá, Trung Bình...
    }
    internal class StudentData
    {
    }

    public static class GlobalData
    {
        // Danh sách tĩnh để lưu tất cả học sinh đã làm bài
        public static List<StudentResult> RankingList = new List<StudentResult>();
    }
}
