using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV1.Models
{
    internal class TheThuVien
    {
        public string MaThe { get; set; }
        public string MaDG { get; set; }
        public DateTime NgayCap { get; set; }
        public DateTime NgayHetHan { get; set; }

        public TheThuVien(string maThe, string maDG, DateTime ngayCap, DateTime ngayHetHan)
        {
            MaThe = maThe;
            MaDG = maDG;
            NgayCap = ngayCap;
            NgayHetHan = ngayHetHan;
        }
    }
}
