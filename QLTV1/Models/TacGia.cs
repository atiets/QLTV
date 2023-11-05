using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV1.Models
{
    internal class TacGia
    {
        public string MaTG { get; set; }
        public string TenTG { get; set; }

        public TacGia(string maTG, string tenTG)
        {
            MaTG = maTG;
            TenTG = tenTG;
        }
    }
}
