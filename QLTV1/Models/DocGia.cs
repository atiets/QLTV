using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV1.Models
{
    internal class DocGia
    {
        public string MaDocGia { get; set; }
        public string MaLoaiDG { get; set; }
        public string CCCD { get; set; }
        public string HoTen { get; set; }
        public int Tuoi { get; set; }
        public char GioiTinh { get; set; }
        public string SoDT { get; set; }

        public DocGia(string maDocGia, string maLoaiDG, string cccd, string hoTen, int tuoi, char gioiTinh, string soDT)
        {
            MaDocGia = maDocGia;
            MaLoaiDG = maLoaiDG;
            CCCD = cccd;
            HoTen = hoTen;
            Tuoi = tuoi;
            GioiTinh = gioiTinh;
            SoDT = soDT;
        }
    }
}
