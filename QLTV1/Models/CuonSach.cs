using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV1.Models
{
    internal class CuonSach
    {
        public string MaSach { get; set; }
        public string TrangThaiSach { get; set; }
        public DateTime NgayNhap { get; set; }
        public string MaDauSach { get; set; }

        public CuonSach(string maSach, string trangThaiSach, DateTime ngayNhap, string maDauSach)
        {
            MaSach = maSach;
            TrangThaiSach = trangThaiSach;
            NgayNhap = ngayNhap;
            MaDauSach = maDauSach;
        }
    }
}
