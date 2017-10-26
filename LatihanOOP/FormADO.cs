using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace LatihanOOP
{
    public partial class FormADO : Form
    {
        //membuat object koneksi
        private MySqlConnection conn;
        private MySqlCommand cmd;

        public FormADO()
        {
            InitializeComponent();
            string strConn = "Server=localhost;Database=posdb;Uid=root;Pwd=;";
            conn = new MySqlConnection(strConn);
        }

        private void btnKonek_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                MessageBox.Show("Koneksi berhasil dibuka !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
