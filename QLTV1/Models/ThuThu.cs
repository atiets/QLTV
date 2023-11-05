using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV1.Models
{
    internal class ThuThu
    {
        public string MaThuThu { get; set; }
        public string TenThuThu { get; set; }

        public ThuThu(string maThuThu, string tenThuThu)
        {
            MaThuThu = maThuThu;
            TenThuThu = tenThuThu;
        }
    }
}
