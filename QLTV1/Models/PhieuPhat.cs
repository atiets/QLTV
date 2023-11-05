using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV1.Models
{
    internal class PhieuPhat
    {
        public string MaPhieuPhat { get; set; }
        public string MaDG { get; set; }

        public PhieuPhat(string maPhieuPhat, string maDG)
        {
            MaPhieuPhat = maPhieuPhat;
            MaDG = maDG;
        }

    }
}
