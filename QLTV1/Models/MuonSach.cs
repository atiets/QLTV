using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV1.Models
{
    internal class MuonSach
    {
        public string MaMuon { get; set; }
        public string MaPhieu { get; set; }
        public DateTime NgayMuon { get; set; }
        public DateTime NgayTra { get; set; }

        public MuonSach(string maMuon, string maPhieu, DateTime ngayMuon, DateTime ngayTra)
        {
            MaMuon = maMuon;
            MaPhieu = maPhieu;
            NgayMuon = ngayMuon;
            NgayTra = ngayTra;
        }
    }
}
