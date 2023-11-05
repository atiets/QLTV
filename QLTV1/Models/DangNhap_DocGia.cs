using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV1.Models
{
    internal class DangNhap_DocGia
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public DangNhap_DocGia(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
