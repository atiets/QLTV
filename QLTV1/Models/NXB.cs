using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV1.Models
{
    internal class NXB
    {
        public string MaNXB { get; set; }
        public string TenNXB { get; set; }

        public NXB(string maNXB, string tenNXB)
        {
            MaNXB = maNXB;
            TenNXB = tenNXB;
        }
    }
}
