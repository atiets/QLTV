using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV1.Models
{
    internal class TheLoai
    {
        public string MaTheLoai { get; set; }
        public string TenTheLoai { get; set; }
        public int QDSoTuoi { get; set; }

        public TheLoai(string maTheLoai, string tenTheLoai, int qdSoTuoi)
        {
            MaTheLoai = maTheLoai;
            TenTheLoai = tenTheLoai;
            QDSoTuoi = qdSoTuoi;
        }

    }
}
