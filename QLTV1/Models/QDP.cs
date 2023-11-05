using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV1.Models
{
    internal class QDP
    {
        public string MaQDP { get; set; }
        public string Lydo { get; set; }
        public int TienPhat { get; set; }

        public QDP(string maQDP, string lydo, int tienPhat)
        {
            MaQDP = maQDP;
            Lydo = lydo;
            TienPhat = tienPhat;
        }
    }
}
