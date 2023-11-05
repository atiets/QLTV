using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV1.Models
{
    internal class LoaiDG
    {
        public string MaLoaiDG { get; set; }
        public string TenLoaiDG { get; set; }
        public string DoTuoi { get; set; }

        public LoaiDG(string maLoaiDG, string tenLoaiDG, string doTuoi)
        {
            MaLoaiDG = maLoaiDG;
            TenLoaiDG = tenLoaiDG;
            DoTuoi = doTuoi;
        }
    }
}
