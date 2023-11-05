using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV1.Models
{
    internal class BienLai
    {
        public string MaBienLai { get; set; }
        public string MaDocGia { get; set; }
        public DateTime NgayTraTT { get; set; }
        public string HinhThucThanhToan { get; set; }
        public int TienTra { get; set; }

        public BienLai(string maBienLai, string maDocGia, DateTime ngayTraTT, string hinhThucThanhToan, int tienTra)
        {
            MaBienLai = maBienLai;
            MaDocGia = maDocGia;
            NgayTraTT = ngayTraTT;
            HinhThucThanhToan = hinhThucThanhToan;
            TienTra = tienTra;
        }
    }
}
