using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV1.Models
{
    internal class DauSach
    {
        public string MaDauSach { get; set; }
        public string TenSach { get; set;}
        public string MaTheLoai { get; set;}
        public string MaNXB { get; set; }
        public int NamXuatBan { get; set; }

        public DauSach(string maDauSach, string tenSach, string maTheLoai, string maNXB, int namXuatBan) 
        {
            MaDauSach = maDauSach;
            TenSach = tenSach;
            MaTheLoai = maTheLoai;
            MaNXB = maNXB;
            NamXuatBan = namXuatBan;
        }
    }
}
