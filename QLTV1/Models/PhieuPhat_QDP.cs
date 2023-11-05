using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV1.Models
{
    internal class PhieuPhat_QDP
    {
        public string MaPhieuPhat { get; set; }
        public string MaQD { get; set; }

        public PhieuPhat_QDP(string maPhieuPhat, string maQD)
        {
            MaPhieuPhat = maPhieuPhat;
            MaQD = maQD;
        }
    }
}
