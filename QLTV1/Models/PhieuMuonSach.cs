using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV1.Models
{
    internal class PhieuMuonSach
    {
        public string MaPhieu { get; set; }
        public string MaDG { get; set; }

        public PhieuMuonSach(string maPhieu, string maDG)
        {
            MaPhieu = maPhieu;
            MaDG = maDG;
        }
    }
}
