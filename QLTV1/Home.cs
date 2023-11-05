using QLTV1.Models;
using QLTV1.UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV1
{
    public partial class Home : Form
    {
        private Button curbtn;
        private TheLoaiUC theloaiuc = new TheLoaiUC();
        public Home()
        {
            InitializeComponent();
        }

        private void btn_TheLoai_Click(object sender, EventArgs e)
        {
            if(curbtn != null)
            {
                curbtn = btn_TheLoai;
            }
            if (!splitContainer1.Panel2.Controls.Contains(theloaiuc))
            {
                splitContainer1.Panel2.Controls.Clear();
                theloaiuc.Dock = DockStyle.Fill;
                splitContainer1.Panel2.Controls.Add(theloaiuc);
            }
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (curbtn != null)
                {
                    curbtn = btn_TheLoai;
                }
                if (!splitContainer1.Panel2.Controls.Contains(theloaiuc))
                {
                    splitContainer1.Panel2.Controls.Clear();
                    theloaiuc.Dock = DockStyle.Fill;
                    splitContainer1.Panel2.Controls.Add(theloaiuc);
                }
            }
        }

        private void btn_TacGia_Click(object sender, EventArgs e)
        {

        }
    }
}
