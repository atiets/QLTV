using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLTV1
{
    public partial class Form1 : Form
    {

        //tao 2 bien cu bo
        string strCon = @"Data Source=DESKTOP-IDTU04D\AT;Initial Catalog=QLTV;Integrated Security=True";
        //doi tuong ket noi
        SqlConnection sqlcon = null;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void OpenConnection_Click(object sender, EventArgs e)
        {
            try
            {
                if(sqlcon == null) 
                {
                    sqlcon= new SqlConnection(strCon); //Rong -> tao moi
                }
                if(sqlcon.State == ConnectionState.Closed) 
                {
                    sqlcon.Open();
                    MessageBox.Show("Sucess Connection");
                    Home home = new Home();
                    home.Show();
                }

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CloseConnection_Click(object sender, EventArgs e)
        {
            if (sqlcon.State == ConnectionState.Open)
            {
                sqlcon.Close();
                MessageBox.Show("Sucess Connection");
            }
            else
                MessageBox.Show("Failer Connection");
        }
    }
}
