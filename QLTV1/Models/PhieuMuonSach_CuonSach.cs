using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV1.Models
{
    internal class PhieuMuonSach_CuonSach
    {
        public string MaPhieu { get; set; }
        public string MaSach { get; set; }

        public PhieuMuonSach_CuonSach(string maPhieu, string maSach)
        {
            MaPhieu = maPhieu;
            MaSach = maSach;
        }
    }
}
