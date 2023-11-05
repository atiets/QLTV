using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV1.Models
{
    internal class DauSach_TacGia
    {
        public string MaDauSach { get; set; }
        public string MaTG { get; set; }

        public DauSach_TacGia(string maDauSach, string maTG)
        {
            MaDauSach = maDauSach;
            MaTG = maTG;
        }
    }
}
